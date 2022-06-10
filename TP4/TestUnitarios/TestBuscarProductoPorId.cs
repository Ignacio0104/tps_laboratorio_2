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
    public class TestBuscarProductoPorId
    {
        [TestMethod]
        public void BuscarProducto_SiIngresoUnIdValido_DebeDevolverUnProducto()
        {
            string path = AppDomain.CurrentDomain.BaseDirectory;

            string ruta = path + @"RecursosDePrueba";

            List<Producto> datos = default;
            string archivo = string.Empty;
            string completa = ruta + @"\" + "baseDatosPeliculas" + ".json";
            try
            {
                if (Directory.Exists(ruta))//Validamos que la carpeta exista
                {
                    string[] archivos = Directory.GetFiles(ruta); //Trae todas las rutas de los archivos

                    foreach (string item in archivos)
                    {
                        if (item.Contains("baseDatosProductos")) //Buscamos el archivo por nombre
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
                        datos = JsonSerializer.Deserialize<List<Producto>>(archivoJson, options);
                    }
                }
                Blockbuster.ListaDeProductos = datos;
            }
            catch (Exception e)
            {
                throw new Exception($"Error en el archivo {completa}");
            }

            Producto expected = Blockbuster.ListaDeProductos[9];

            int id = 1000;

            Producto actual = Blockbuster.BuscarProducto(id);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void BuscarProducto_SiIngresoUnIdInvalido_DebeDevolverNull()
        {
            string path = AppDomain.CurrentDomain.BaseDirectory;

            string ruta = path + @"RecursosDePrueba";

            List<Producto> datos = default;
            string archivo = string.Empty;
            string completa = ruta + @"\" + "baseDatosPeliculas" + ".json";
            try
            {
                if (Directory.Exists(ruta))//Validamos que la carpeta exista
                {
                    string[] archivos = Directory.GetFiles(ruta); //Trae todas las rutas de los archivos

                    foreach (string item in archivos)
                    {
                        if (item.Contains("baseDatosPeliculas")) //Buscamos el archivo por nombre
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
                        datos = JsonSerializer.Deserialize<List<Producto>>(archivoJson, options);
                    }
                }
                Blockbuster.ListaDeProductos = datos;
            }
            catch (Exception e)
            {
                throw new Exception($"Error en el archivo {completa}");
            }

            Producto expected = null;

            int id = 8000;

            Producto actual = Blockbuster.BuscarProducto(id);

            Assert.AreEqual(expected, actual);
        }
    }
}
