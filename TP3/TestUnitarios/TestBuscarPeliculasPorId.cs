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
    public class TestBuscarPeliculasPorId
    {
        [TestMethod]
        public void BuscarPeliculas_SiIngresoUnIdValido_DebeDevolverUnaPelicula()
        {
            string path = AppDomain.CurrentDomain.BaseDirectory;

            string ruta = path + @"RecursosDePrueba";

            List<Pelicula> datos = default;
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
                        datos = JsonSerializer.Deserialize<List<Pelicula>>(archivoJson, options);
                    }
                }
                Blockbuster.ListaDePeliculas = datos;
            }
            catch (Exception e)
            {
                throw new Exception($"Error en el archivo {completa}");
            }

            Pelicula expected = Blockbuster.ListaDePeliculas[48];

            int id = 49;

            Pelicula actual = Blockbuster.BuscarPelicula(id);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void BuscarPeliculas_SiIngresoUnIdInalido_DebeDevolverUnaNull()
        {;
            string path = AppDomain.CurrentDomain.BaseDirectory;

            string ruta = path + @"RecursosDePrueba";

            List<Pelicula> datos = default;
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
                        datos = JsonSerializer.Deserialize<List<Pelicula>>(archivoJson, options);
                    }
                }
                Blockbuster.ListaDePeliculas = datos;
            }
            catch (Exception e)
            {
                throw new Exception($"Error en el archivo {completa}");
            }

            Pelicula expected = null;

            int id = -2;

            Pelicula actual = Blockbuster.BuscarPelicula(id);

            Assert.AreEqual(expected, actual);
        }
    }
}
