using Entidades;

namespace ElViajarEsUnPlacer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<VehiculoTerrestre> vehiculos = new List<VehiculoTerrestre>();

            Automovil auto = new Automovil(4,5,VehiculoTerrestre.EColores.Blanco,5,4);
            Camion camion = new Camion(8,2,VehiculoTerrestre.EColores.Rojo,3,500);
            Moto moto = new Moto(2,0,VehiculoTerrestre.EColores.Gris,1);

            vehiculos.Add(camion);
            vehiculos.Add(auto);
            vehiculos.Add(moto);

            foreach (VehiculoTerrestre vehiculo in vehiculos)
            {
                Console.WriteLine(vehiculo.Mostrar());
            }
        }
    }
}