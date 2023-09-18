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

        public Numeracion Operar(char tipoOperacion)
        {
            Numeracion resultado;
            switch (tipoOperacion)
            {

                case '+':
                    resultado = primerOperando + segundoOperando;
                    break;

                case '-':
                    resultado = primerOperando - segundoOperando;
                    break;

                case '*':
                    resultado = primerOperando * segundoOperando;
                    break;

                default:  
                    resultado = primerOperando / segundoOperando;     
                    
                    break;

            }

            return resultado;
        }


    }
}