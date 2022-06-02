using System;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace BibliotecaDeClases
{
    public static class ClaseSerializadora<T>
    {
        static string ruta;
        static ClaseSerializadora()
        {
            ruta = ".\\Recursos";//El . me indica que la ruta es relativa al lugar donde se encuentre el usuario ejecutando el programa
        }

        public static void EscribirJson(T datos,string archivo)
        {
            string completa = ruta + @"\" + archivo + ".json";

            try
            {
                if (!Directory.Exists(ruta))//Esto valida que si la carpeta no existe, se cree en el paso siguiente
                {
                    Directory.CreateDirectory(ruta); //Aca la creamos
                }
                JsonSerializerOptions options = new JsonSerializerOptions
                {
                    Converters ={new JsonStringEnumConverter()}
                };
                string objetoJson = JsonSerializer.Serialize(datos,options);

                File.WriteAllText(completa, objetoJson);

            }
            catch (Exception e)
            {
                throw new Exception($"Error en el archivo {completa}");
            }
        }

        public static T LeerJson(string nombreArchivo)
        {
            T datos = default;
            string archivo = string.Empty;
            string completa = ruta + @"\" + nombreArchivo + ".json";
            try
            {
                if (Directory.Exists(ruta))//Validamos que la carpeta exista
                {
                    string[] archivos = Directory.GetFiles(ruta); //Trae todas las rutas de los archivos

                    foreach (string item in archivos)
                    {
                        if (item.Contains(nombreArchivo)) //Buscamos el archivo por nombre
                        {
                            archivo = item;
                            break;
                        }
                    }
                    if (archivo != null)
                    {
                        JsonSerializerOptions options = new JsonSerializerOptions
                        {
                            Converters ={new JsonStringEnumConverter( JsonNamingPolicy.CamelCase)},

                        };
                        string archivoJson = File.ReadAllText(archivo);
                        datos = JsonSerializer.Deserialize<T>(archivoJson,options);
                    }
                }
                return datos;
            }
            catch (Exception e)
            {
                throw;
            }
        }


        public static void EscribirXml(T datos, string nombreArchivo)
        {
            string completa = ruta + @"\" + nombreArchivo + ".xml";

            try
            {
                if (!Directory.Exists(ruta))
                {
                    Directory.CreateDirectory(ruta); 
                }

                using (StreamWriter sw = new StreamWriter(completa))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
                    xmlSerializer.Serialize(sw, datos);
                }


            }
            catch (Exception e)
            {
               
            }
        }

        public static T LeerXml(string nombreArchivo)
        {
            string archivo = string.Empty;
            T datos = default;
            string completa = ruta + @"\" + nombreArchivo + ".xml";

            try
            {
                if (Directory.Exists(ruta))
                {
                    string[] archivos = Directory.GetFiles(ruta); 

                    foreach (string item in archivos)
                    {
                        if (item.Contains(nombreArchivo))
                        {
                            archivo = item;
                            break;
                        }
                    }
                    if (archivo != null)
                    {
                        using (StreamReader sr = new StreamReader(completa))
                        {
                            XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
                            datos = (T)xmlSerializer.Deserialize(sr);
                        }
                    }
                }
                return datos;
            }
            catch (Exception e)
            {
                throw new Exception($"Error en el archivo {completa}");
            }
        }
    }
}
