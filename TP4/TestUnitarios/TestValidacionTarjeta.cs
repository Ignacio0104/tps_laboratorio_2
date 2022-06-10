using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaDeClases;

namespace TestUnitarios
{
    [TestClass]
    public class TestValidacionTarjeta
    {
        [TestMethod]
        public void ValidarTarjeta_SiNoComienzaCon45o3_DebeDevolverFalse()
        {
            bool expected = false;

            string cadena = "1234567890231234";

            bool actual = Logica.VerificarTarjetaCredito(cadena);

            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void ValidarTarjeta_SiComienza45o3_DebeDevolverTrue()
        {
            bool expected = true;

            string cadena = "4234567890231234";

            bool actual = Logica.VerificarTarjetaCredito(cadena);

            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void ValidarTarjeta_SiIngresoUnaTarjetaLarga_DebeDevolverFalse()
        {
            bool expected = false;

            string cadena = "423456789023123424141";

            bool actual = Logica.VerificarTarjetaCredito(cadena);

            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void ValidarTarjeta_SiIngresoUnaTarjetaCorta_DebeDevolverFalse()
        {
            bool expected = false;

            string cadena = "42569093123490";

            bool actual = Logica.VerificarTarjetaCredito(cadena);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidarTarjeta_SiIngresoLetras_DebeDevolverFalse()
        {
            bool expected = false;

            string cadena = "456789023456111s";

            bool actual = Logica.VerificarTarjetaCredito(cadena);

            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void ValidarTarjeta_SiIngresoUnaCadenaVacia_DebeDevolverFalse()
        {
            bool expected = false;

            string cadena = "";

            bool actual = Logica.VerificarEmail(cadena);

            Assert.AreEqual(expected, actual);

        }
    }
}
