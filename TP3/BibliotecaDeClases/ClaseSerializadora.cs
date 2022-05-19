using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

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
                string objetoJson = JsonSerializer.Serialize(datos);

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
                        string archivoJson = File.ReadAllText(completa);
                        datos = JsonSerializer.Deserialize<T>(archivoJson);
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
