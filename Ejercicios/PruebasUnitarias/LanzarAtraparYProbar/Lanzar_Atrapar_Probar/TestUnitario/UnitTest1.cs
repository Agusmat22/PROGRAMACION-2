using Entidades;
using Entidades.Excepciones;

namespace TestUnitario
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [ExpectedException(typeof(MiExcepcion))]
        public void AlInstanciar_LaClase_OtraClase_DebeLanzarUnaException()
        {
            OtraClase miClase = new OtraClase();
        }


        [TestMethod]
        [ExpectedException(typeof(UnaExcepcion))]
        public void AlInstanciar_LaClase_MiClase_DebeLanzarUnaException()
        {
            MiClase miClase = new MiClase();
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void AlInstanciar_LaClase_MiClaseSobrecargadaPasandoUnAtributoConElValorCero_DebeLanzarUnaException()
        {
            MiClase miClase = new MiClase(0);
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void AlInvocar_ElMetodo_MetodoEstatico_DeLaClaseMiClase_DebeLanzarUnaExceptionDivideByZero()
        {
            MiClase.MetodoEstatico();
        }





    }
}