using Entidades;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTesting
{
    [TestClass]
    public class UnitTestingMetodoExtension
    {
        [TestMethod]
        [DataRow(10,2)]
        public void AlInvocar_ElMetodoContarCantidadDeDigitos_DeberaRetornarUnStringConLaCantidadTotal(Int64 numero, int valorEsperado)
        {
            //ARREGE
            int cantidadDeDigitos = numero.ContarCantidadDeDigitos();

            //ASSERT
            Assert.AreEqual(valorEsperado, cantidadDeDigitos);

        }
    }
}