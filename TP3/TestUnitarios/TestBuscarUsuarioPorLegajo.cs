using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using BibliotecaDeClases;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestUnitarios
{
    [TestClass]
    public class TestBuscarUsuarioPorLegajo
    {
        [TestMethod]
        public void BuscarUsuario_SiIngresoUnLegajoValido_DebeDevolverUnUsuario()
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

            int legajo = 49;

            Usuario actual = Blockbuster.BuscarUsuario(legajo);

            Assert.AreEqual(expected, actual);
        }
        
        [TestMethod]
        public void BuscarUsuario_SiIngresoUnLegajoInvalido_DebeDevolverNull()
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

            int legajo = 1000;

            Usuario actual = Blockbuster.BuscarUsuario(legajo);

            Assert.AreEqual(expected, actual);
        }
       
    }
}
