using System;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace BibliotecaDeClases
{
    public static class ClaseSerializadora<T>
    {
        static string ruta;
        static ClaseSerializadora()
        {
            ruta = ".\\Recursos";//Conseguir la ruta desde cualquier PC
        }

        public static void Escribir(T datos)
        {
            string completa = ruta + @"/baseDatosPeliculas.json";

            try
            {
                if (!Directory.Exists(ruta))//Esto significa que la carpeta NO EXISTE
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


        public static T Leer()
        {
            string archivo = string.Empty;
            T datos = default;
            string completa = ruta + @"\baseDatosPeliculas.json";

            try
            {
                if (Directory.Exists(ruta))//Esto significa que la carpeta NO EXISTE
                {
                    if (completa != null)
                    {
                        JsonSerializerOptions options = new JsonSerializerOptions
                        {
                            Converters ={new JsonStringEnumConverter( JsonNamingPolicy.CamelCase)},

                        };
                        string archivoJson = File.ReadAllText(completa);
                        datos = JsonSerializer.Deserialize<T>(archivoJson,options);
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
