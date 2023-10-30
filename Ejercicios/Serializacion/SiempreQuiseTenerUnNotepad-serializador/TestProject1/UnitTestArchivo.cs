using IO;
using IO.Excepciones;
using IO.Interfaz;
namespace TestProject1
{
    [TestClass]
    public class UnitTestArchivo
    {
        [TestMethod]
        [DataRow(".json",true)]
        public void AlInvocarElMetodo_ValidarExtensionEnLaClase_PuntoJson_DeberaRetornarTrueSiCoincideYDeLoContrario_LanzaraUnaExcepcion(string extension,bool valorEsperado)
        {
            PuntoJson<string> puntoJson = new PuntoJson<string>();

            Assert.AreEqual(valorEsperado, puntoJson.ValidarExtension(extension));
           
        }

        [TestMethod]
        [DataRow(".xml", true)]
        public void AlInvocarElMetodo_ValidarExtensionEnLaClase_PuntoXml_DeberaRetornarTrueSiCoincideYDeLoContrario_LanzaraUnaExcepcion(string extension, bool valorEsperado)
        {
            PuntoXml<string> puntoXml = new PuntoXml<string>();

            Assert.AreEqual(valorEsperado, puntoXml.ValidarExtension(extension));

        }

        [TestMethod]
        [DataRow(".txt", true)]
        public void AlInvocarElMetodo_ValidarExtensionEnLaClase_PuntoTxt_DeberaRetornarTrueSiCoincideYDeLoContrario_LanzaraUnaExcepcion(string extension, bool valorEsperado)
        {
            PuntoTxt puntoTxt = new PuntoTxt();

            Assert.AreEqual(valorEsperado, puntoTxt.ValidarExtension(extension));

        }
    }
}