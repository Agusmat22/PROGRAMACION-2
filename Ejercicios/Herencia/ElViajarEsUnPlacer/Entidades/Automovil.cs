namespace Entidades
{
    public class Automovil : VehiculoTerrestre
    {
        private int cantidadPasajeros;

        public Automovil(short cantidadRuedas,short cantidadPuertas,EColores color,short cantidadMarchas,int cantidadPasajeros)
            :base(cantidadRuedas,cantidadPuertas,color,cantidadMarchas)
        {
            this.cantidadPasajeros = cantidadPasajeros;
        }
    }
}