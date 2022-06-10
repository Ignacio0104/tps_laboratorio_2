using BibliotecaDeClases;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace TestUnitarios
{
    [TestClass]
    public class TestCheckLogIn
    {
        [TestMethod]
        public void ValidarCheckIn_SiIngresoDatosCorrectos_DebeDevolverUnUsuario()
        {
            string path = AppDomain.CurrentDomain.BaseDirectory;

            string ruta = path + @"RecursosDePrueba";

            List<Usuario> datos = default;
            string archivo = string.Empty;
            string completa = ruta + @"\" + "baseDatosEmpleados" + ".json";
            try
            {
                if (Directory.Exists(ruta))//Validamos que la carpeta exista
                {
                    string[] archivos = Directory.GetFiles(ruta); //Trae todas las rutas de los archivos

                    foreach (string item in archivos)
                    {
                        if (item.Contains("baseDatosEmpleados")) //Buscamos el archivo por nombre
                        {
                            archivo = item;
                            break;
                        }
                    }
                    if (archivo != null)
                    {
                        JsonSerializerOptions options = new JsonSerializerOptions
                        {
                            Converters = { new JsonStringEnumConverter(JsonNamingPolicy.CamelCase) },

                        };
                        string archivoJson = File.ReadAllText(archivo);
                        datos = JsonSerializer.Deserialize<List<Usuario>>(archivoJson, options);
                    }
                }
                Blockbuster.ListaDeEmpleados = datos;
            }
            catch (Exception e)
            {
                throw new Exception($"Error en el archivo {completa}");
            }

            Usuario expected = Blockbuster.ListaDeEmpleados[48];

            string usuario = "nacho2022";
            string clave = "1234";

            Usuario actual = Blockbuster.CheckLogIn(usuario, clave);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidarCheckIn_SiIngresoDatosIncorrectos_DebeDevolverNull()
        {
            string path = AppDomain.CurrentDomain.BaseDirectory;

            string ruta = path + @"RecursosDePrueba";

            List<Usuario> datos = default;
            string archivo = string.Empty;
            string completa = ruta + @"\" + "baseDatosEmpleados" + ".json";
            try
            {
                if (Directory.Exists(ruta))//Validamos que la carpeta exista
                {
                    string[] archivos = Directory.GetFiles(ruta); //Trae todas las rutas de los archivos

                    foreach (string item in archivos)
                    {
                        if (item.Contains("baseDatosEmpleados")) //Buscamos el archivo por nombre
                        {
                            archivo = item;
                            break;
                        }
                    }
                    if (archivo != null)
                    {
                        JsonSerializerOptions options = new JsonSerializerOptions
                        {
                            Converters = { new JsonStringEnumConverter(JsonNamingPolicy.CamelCase) },

                        };
                        string archivoJson = File.ReadAllText(archivo);
                        datos = JsonSerializer.Deserialize<List<Usuario>>(archivoJson, options);
                    }
                }
                Blockbuster.ListaDeEmpleados = datos;
            }
            catch (Exception e)
            {
                throw new Exception($"Error en el archivo {completa}");
            }

            Usuario expected = null;

            string usuario = "nacho20222";
            string clave = "12345";

            Usuario actual = Blockbuster.CheckLogIn(usuario, clave);

            Assert.AreEqual(expected, actual);
        }
    }
}
