using Microsoft.VisualStudio.TestTools.UnitTesting;
using BibliotecaDeClases;

namespace TestUnitarios
{
    [TestClass]
    public class TestValidacionMail
    {
        [TestMethod]
        public void ValidarEmail_SiIngresoTodosNumeros_DebeDevolverFalse()
        {
            bool expected = false;

            string cadena = "1233663";

            bool actual = Logica.VerificarEmail(cadena);

            Assert.AreEqual(expected, actual);

        }

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
    }
}
