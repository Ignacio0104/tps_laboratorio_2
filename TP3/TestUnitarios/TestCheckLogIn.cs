using Microsoft.VisualStudio.TestTools.UnitTesting;
using BibliotecaDeClases;
using System.Collections.Generic;
using System;
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
            List<Usuario> listaDeUsuariosAux = new List<Usuario>();
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
                listaDeUsuariosAux = datos;
                Blockbuster.ListaDeEmpleados = datos;
            }
            catch (Exception e)
            {
                throw new Exception($"Error en el archivo {completa}");
            }
            
            Usuario expected = listaDeUsuariosAux[48];

            string usuario = "nacho2022";
            string clave = "1234";

            Usuario actual = Blockbuster.CheckLogIn(usuario, clave);

            Assert.AreEqual(expected, actual);
        }
/*
        [TestMethod]
        public void ValidarEmail_SiIngresoUnMailCorrecto_DebeDevolverTrue()
        {
            bool expected = true;

            string cadena = "ignacio@gmail.com";

            bool actual = Logica.VerificarEmail(cadena);

            Assert.AreEqual(expected, actual);


        }

        [TestMethod]
        public void ValidarEmail_SiIngresoUnMailSinArroba_DebeDevolverFalse()
        {
            bool expected = false;

            string cadena = "ignaciogmail.com";

            bool actual = Logica.VerificarEmail(cadena);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidarEmail_SiIngresoUnMailMasDeUnArroba_DebeDevolverFalse()
        {
            bool expected = false;

            string cadena = "ig@nacio@gmail.com";

            bool actual = Logica.VerificarEmail(cadena);

            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void ValidarEmail_SiIngresoNumerosDespuesDelArroba_DebeDevolverFalse()
        {
            bool expected = false;

            string cadena = "ignacio@gma23il.com";

            bool actual = Logica.VerificarEmail(cadena);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidarEmail_SiIngresoUnaCadenaVacia_DebeDevolverFalse()
        {
            bool expected = false;

            string cadena = "";

            bool actual = Logica.VerificarEmail(cadena);

            Assert.AreEqual(expected, actual);

        }*/
    }
}
