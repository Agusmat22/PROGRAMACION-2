using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Entidades.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTesting
{
    [TestClass]
    
    public class PaquetePesadoTest
    {
        [TestMethod]
        public void AplicarImpuesto_DeberiaRetornarCostoDeEnvioMasImpuestosAfipYAduana()
        {
            decimal valorEsperado = 160;
            PaquetePesado paquete = new PaquetePesado("25641", 100, "Brasil", "Argentina", 30);

            Assert.AreEqual(valorEsperado, paquete.AplicarImpuestos());


        }

        [TestMethod]
        public void Impuestos_DeberiaRetornarValorImpuestoDel25PorcientoSobreCostoEnvio_CuandoEsImplementacionExplicitaAfip()
        {
            PaquetePesado paquete = new PaquetePesado("25641", 100, "Brasil", "Argentina", 30);

            Assert.AreEqual(25, ((IAfip)paquete).Impuestos);
        }

        [TestMethod]
        public void Impuestos_DeberiaRetornarValorImpuestoDel35PorcientoSobreCostoEnvio_CuandoEsImplementacionImplicita()
        {
            PaquetePesado paquete = new PaquetePesado("25641", 100, "Brasil", "Argentina", 30);

            Assert.AreEqual(35, paquete.Impuestos);
        }

        [TestMethod]
        [DataRow(false)]
        public void TienePrioridad_DeberiaRetornarFalse(bool valorEsperado)
        {
            PaquetePesado paquete = new PaquetePesado("25641", 1400, "Brasil", "Argentina", 30);

            Assert.AreEqual(valorEsperado, paquete.TienePrioridad);
        }
    }
}
