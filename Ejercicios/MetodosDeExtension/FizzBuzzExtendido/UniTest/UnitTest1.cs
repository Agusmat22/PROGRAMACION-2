using Entidades;
using System.Drawing;

namespace UniTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [DataRow(3,"Fizz")]
        [DataRow(6,"Fizz")]
        [DataRow(9,"Fizz")]
        [DataRow(12,"Fizz")]
        public void Al_InvocarElMetodoDeInstanciaDeInt_SiEsDivisiblePorTres_DeboObtenerFizz(int valor, string valorEsperado)
        {
            //arrange (preparacion)
            string resultado;

            //act (invocacion de metodos a probar)
            resultado = valor.FizzBuzz();

            //ASSERT
            Assert.AreEqual(valorEsperado, resultado);




        }

        [TestMethod]
        [DataRow(5, "Buzz")]
        [DataRow(10, "Buzz")]
        [DataRow(20, "Buzz")]
        public void Al_InvocarElMetodoDeInstanciaDeInt_SiEsDivisiblePorCinco_DeboObtenerBuzz(int valor, string valorEsperado)
        {
            //arrange (preparacion)
            string resultado;

            //act (invocacion de metodos a probar)
            resultado = valor.FizzBuzz();

            //ASSERT
            Assert.AreEqual(valorEsperado, resultado);

        }

        [TestMethod]
        [DataRow(15, "FizzBuzz")]
        [DataRow(30, "FizzBuzz")]
        [DataRow(45, "FizzBuzz")]
        public void Al_InvocarElMetodoDeInstanciaDeInt_SiEsDivisiblePorCincoYTres_DeboObtenerFizzBuzz(int valor, string valorEsperado)
        {
            //arrange (preparacion)
            string resultado;

            //act (invocacion de metodos a probar)
            resultado = valor.FizzBuzz();

            //ASSERT
            Assert.AreEqual(valorEsperado, resultado);
        }

        [TestMethod]
        [DataRow(17, "17")]
        [DataRow(13, "13")]
        public void Al_InvocarElMetodoDeInstanciaDeInt_SiNoEsDivisiblePorCincoYTres_DeboObtenerElValorEnString(int valor, string valorEsperado)
        {
            //arrange (preparacion)
            string resultado;

            //act (invocacion de metodos a probar)
            resultado = valor.FizzBuzz();

            //ASSERT
            Assert.AreEqual(valorEsperado, resultado);
        }
    }
}