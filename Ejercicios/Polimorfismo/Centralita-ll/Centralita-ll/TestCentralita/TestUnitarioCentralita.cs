using Centralita;
namespace TestCentralita
{
    [TestClass]
    public  class TestUnitarioCentralita
    {
        [TestMethod]
        public void ValidaraQueLaListaDeLLamadasDeLaCentralitaEsteInstanciadaAlCrearUnObjeto_DeberaDevolverTrue()
        {
            //ARRANGE
            Centralitaa centralitaa = new Centralitaa();

            //ASSERT
            Assert.IsNotNull(centralitaa.Llamadas);
           
        }

        [TestMethod]
        [ExpectedException(typeof(CentralitaException))]
        public void AlInvocarLaSobrecargarElOperadorMas_EnLaClaseCentralitaa_IntetaraCargarUnaSegundaLlamada_Local_ConLosMismosDatosYDeberaDevolverUnaExcepcion()
        {
            //ARRANGE
            Centralitaa centralitaa = new Centralitaa();
            //DOS LLAMADAS LOCALES CON EL MISMO NUMERO DE ORIGEN
            Local llamada1 = new Local("1163223", 1.20F, "987",20F);
            Local llamada2 = new Local("1163223", 1.5F, "987",30F);

            //ASSERT 
            //se espera que largue Una Excepcion ya que dos llamadas iguales no se pueden agregar
            bool valor =  centralitaa + llamada1;
            bool valor2 = centralitaa + llamada2;


        }

        [TestMethod]
        [ExpectedException(typeof(CentralitaException))]
        public void AlInvocarLaSobrecargarElOperadorMas_EnLaClaseCentralitaa_IntetaraCargarUnaSegundaLlamada_Provincial_ConLosMismosDatosYDeberaDevolverUnaExcepcion()
        {
            //ARRANGE
            Centralitaa centralitaa = new Centralitaa();
            //DOS LLAMADAS PROVINCIALES CON EL MISMO NUMERO DE ORIGEN
            Provincial llamada1 = new Provincial("1163223", Provincial.Franja.Franja_1,1.20F ,"987");
            Provincial llamada2 = new Provincial("1163223", Provincial.Franja.Franja_1, 1.5F, "987");

            //ASSERT 
            //se espera que largue Una Excepcion ya que dos llamadas iguales no se pueden agregar
            bool valor = centralitaa + llamada1;
            bool valor2 = centralitaa + llamada2;


        }

        [TestMethod]
        public void ElmetodoComparaCuatroObjetosConLosMismoDatosDosLlamadasLocalesYProvincialesEntreSi_DebiendoSerIgualesSoloEntreSiDelMismoTipo()
        {
            List<Llamada> llamadasValidarEntreSi = new List<Llamada>();
            //ARRANGE
            Centralitaa centralitaa = new Centralitaa();
            //DOS LLAMADAS PROVINCIALES CON EL MISMO NUMERO DE ORIGEN
            Provincial llamada1 = new Provincial("1163223", Provincial.Franja.Franja_1, 1.20F, "987");
            Provincial llamada2 = new Provincial("1163223", Provincial.Franja.Franja_1, 1.5F, "987");

            Local llamada3 = new Local("1163223", 1.20F, "987", 20F);
            Local llamada4 = new Local("1163223", 1.5F, "987", 30F);

            //ASSERT 

            //indico que no deben ser iguales
            Assert.IsFalse(llamada1 == llamada3);
            Assert.IsFalse(llamada1 == llamada4);
            Assert.IsFalse(llamada2 == llamada3);
            Assert.IsFalse(llamada2 == llamada4);

            //indico que deben ser iguales
            Assert.IsTrue(llamada1 == llamada2);
            Assert.IsTrue(llamada3 == llamada4);



        }
    }
}