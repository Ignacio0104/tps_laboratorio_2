using Microsoft.VisualStudio.TestTools.UnitTesting;
using BibliotecaDeClases;

namespace TestUnitarios
{
    [TestClass]
    public class TestValidacionMail
    {
        [TestMethod]
        public void ValidarEmail_SinIngresoTodosNumeros_DebeDevolverFalse()
        {
            bool expected = false;

            string cadena = "1233663";

            bool actual = Logica.VerificarEmail(cadena);

            Assert.AreEqual(expected, actual);


        }
    }
}
