namespace Entidades
{
    public class Operacion
    {
        //atributos del tipo Numeracion
        private Numeracion primerOperando;
        private Numeracion segundoOperando;

        //Inicializo los atributos
        public Operacion(Numeracion primerOperando, Numeracion segundoOperando)
        {
            this.primerOperando = primerOperando;
            this.segundoOperando = segundoOperando;
        }


    }
}