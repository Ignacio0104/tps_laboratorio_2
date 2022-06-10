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
    public class TestValidacionTelefono
    {
        [TestMethod]
        public void ValidarTelefono_SiIngresoUnaLetra_DebeDevolverFalse()
        {
            bool expected = false;

            string cadena = "123366h3";

            bool actual = Logica.VerificarTelefonoArgentina(cadena);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidarTelefono_SiIngresoUnTelefonoCorrecto_DebeDevolverTrue()
        {
            bool expected = true;

            string cadena = "54678902";

            bool actual = Logica.VerificarTelefonoArgentina(cadena);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidarTelefono_SiIngresoUnTelefonoMuyCorto_DebeDevolverFalse()
        {
            bool expected = false;

            string cadena = "5462";

            bool actual = Logica.VerificarTelefonoArgentina(cadena);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidarTelefono_SiIngresoUnTelefonoMuyLargo_DebeDevolverFalse()
        {
            bool expected = false;

            string cadena = "15678912345";

            bool actual = Logica.VerificarTelefonoArgentina(cadena);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ValidarTelefono_SiIngresoUnaCadenaVacia_DebeDevolverFalse()
        {
            bool expected = false;

            string cadena = "";

            bool actual = Logica.VerificarEmail(cadena);

            Assert.AreEqual(expected, actual);

        }

    }
}
