using Entidades;
namespace UnitTest
{
    [TestClass]
    public class TestUnitarios
    {
        [TestMethod]
        [DataRow("3",3)]
        public void AlInvocar_ElMetodoDeInstanciaDeCalculadora_Add_SumareUnStringConUnSoloNumero_DeberaDevolverElResultado(string valor, int valorEsperado)
        {
            //ARRANGE: INICIALIZAR LAS VARIABLES
            Calculadora calculadora = new Calculadora();

            //ACT : LLAMAR LOS METODOS A TESTEAR
            int resultado = calculadora.Add(valor);

            Assert.AreEqual(valorEsperado, resultado);

        }

        [TestMethod]
        [DataRow("1,2", 3)]
        public void AlInvocar_ElMetodoDeInstanciaDeCalculadoraAdd_SumaraUnStringConDosNumerosDividosPorUnaComa_DevolveraElResultado(string valor, int valorEsperado)
        {
            //ARRANGE: INICIALIZAR LAS VARIABLES
            Calculadora calculadora = new Calculadora();

            //ACT : LLAMAR LOS METODOS A TESTEAR
            int resultado = calculadora.Add(valor);

            Assert.AreEqual(valorEsperado, resultado);
        }

        [TestMethod]
        [DataRow("", 0)]
        public void AlInvocar_ElMetodoDeInstanciaDeCalculadoraAdd_SumaraUnStringVacio_DevolveraElResultado(string valor, int valorEsperado)
        {
            //ARRANGE: INICIALIZAR LAS VARIABLES
            Calculadora calculadora = new Calculadora();

            //ACT : LLAMAR LOS METODOS A TESTEAR
            int resultado = calculadora.Add(valor);

            Assert.AreEqual(valorEsperado, resultado);
        }

        [TestMethod]
        [DataRow("1,5,6,10", 22)]
        public void AlInvocar_ElMetodoDeInstanciaDeCalculadoraAdd_SumaraUnStringQueContendraNumerosInfinitosDivididosPorUnaComa_DevolveraElResultado(string valor, int valorEsperado)
        {
            //ARRANGE: INICIALIZAR LAS VARIABLES
            Calculadora calculadora = new Calculadora();

            //ACT : LLAMAR LOS METODOS A TESTEAR
            int resultado = calculadora.Add(valor);

            Assert.AreEqual(valorEsperado, resultado);
        }

        [TestMethod]
        [DataRow("1\n2,3", 6)]
        public void AlInvocar_ElMetodoDeInstanciaDeCalculadoraAdd_SumaraUnStringQueContendraSaltosDeLineaParaSepararLosNumeros_DevolveraElResultado(string valor, int valorEsperado)
        {
            //ARRANGE: INICIALIZAR LAS VARIABLES
            Calculadora calculadora = new Calculadora();

            //ACT : LLAMAR LOS METODOS A TESTEAR
            int resultado = calculadora.Add(valor);

            Assert.AreEqual(valorEsperado, resultado);
        }

        [TestMethod]
        [DataRow("-50")]
        [ExpectedException(typeof(ExcepcionNegativoNoPermitido))]
        public void AlInvocar_ElMetodoDeInstanciaDeCalculadoraAdd_IntentaraSumarUnNumeroNegativo_DevolveraUnaExcepcion(string valor)
        {
            //ARRANGE: INICIALIZAR LAS VARIABLES
            Calculadora calculadora = new Calculadora();

            //ACT : LLAMAR LOS METODOS A TESTEAR
            int resultado = calculadora.Add(valor);

            //Assert.AreEqual(valorEsperado, resultado);
        }




    }
}