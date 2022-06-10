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
    public class TestBuscarIndiceProducto
    {
        [TestMethod]
        public void BuscarIndiceProducto_SiIngresoUnProductoValido_DebeDevolverUnIndice()
        {
            string path = AppDomain.CurrentDomain.BaseDirectory;

            string ruta = path + @"RecursosDePrueba";

            List<Producto> datos = default;
            string archivo = string.Empty;
            string completa = ruta + @"\" + "baseDatosProductos" + ".json";
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

            int expected = 5;

            Producto producto = Blockbuster.ListaDeProductos[5];

            int actual = Blockbuster.BuscarIndiceProducto(producto);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void BuscarIndiceProducto_SiIngresoUnProductoInvalido_DebeDevolverUnMenosUno()
        {
            string path = AppDomain.CurrentDomain.BaseDirectory;

            string ruta = path + @"RecursosDePrueba";

            List<Producto> datos = default;
            string archivo = string.Empty;
            string completa = ruta + @"\" + "baseDatosProductos" + ".json";
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

            int expected = -1;

            Producto producto = new Producto("prueba", 24, 10);

            int actual = Blockbuster.BuscarIndiceProducto(producto);

            Assert.AreEqual(expected, actual);
        }
    }
}
