using Entidades;
namespace UnitTesting
{
    [TestClass]
    public class PaqueteFragilTest
    {
        [TestMethod]
        public void AplicarImpuestos_DeberiaRetornarCostoDeEnvioMasImpuestoAduana()
        {

        }

        [TestMethod]

        public void Impuestos_DeberiaRetornarValorImpuestoDel35PorcientoSobreCostoEnvio()
        {
            PaqueteFragil paquete = new PaqueteFragil("25641", 100, "Brasil", "Argentina", 30);

            Assert.AreEqual(35,paquete.Impuestos);

        }

        [TestMethod]
        [DataRow(true)]
        public void TienePrioridad_DeberiaRetornarTrue(bool valorEsperado)
        {
            PaqueteFragil paquete = new PaqueteFragil("25641", 1400, "Brasil", "Argentina", 30);

            Assert.AreEqual(valorEsperado, paquete.TienePrioridad);
        }
    }
}