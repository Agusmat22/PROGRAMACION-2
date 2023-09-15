/*
Crear una aplicación de consola.
Modelar y declarar las clases necesarias para resolver la necesidad del cliente. 
Hacerlo en un proyecto de biblioteca de clases.
Las clases deberán tener los métodos necesarios, incluyendo uno que devuelva toda la información del objeto 
en formato string.
Instanciar los siguientes objetos:
Un cliente con un perro sin vacunar.
Un cliente con un gato con la vacuna "Triple Felina".
Un cliente con un gato sin vacunas y un perro con la vacuna contra la rabia.
Mostrar por consola todos los datos de los clientes instanciados y sus mascotas.

*/

using Entidades;

namespace LaVeterinaria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Veterinaria veterinaria = new Veterinaria();

            DateTime fechaNacimiento = new DateTime(2023, 02, 24);

            //MASCOTAS 

            Mascota mascota1 = new Mascota("Perro", "Nina", fechaNacimiento);

            Mascota mascota2 = new Mascota("Gato", "Mishi", fechaNacimiento, "Triple Felina");

            Mascota mascota3 = new Mascota("Gato", "Mishi", fechaNacimiento);

            Mascota mascota4 = new Mascota("Perro", "Mishi", fechaNacimiento, "Rabia");

            //CLIENTES

            Cliente cliente1 = new Cliente("Agustin","Garcia","Av.Caseros",1156988623);
            Cliente cliente2 = new Cliente("Sofia","Rubiales","Av.Libertador",1191479623);
            Cliente cliente3 = new Cliente("Roberto","Alvarez","Av.Santa Fe",1157113623);


            cliente1.AgregarMascota(mascota1);
            cliente2.AgregarMascota(mascota2);
            cliente3.AgregarMascota(mascota3);
            cliente3.AgregarMascota(mascota4);


            veterinaria.RegistrarCliente(cliente1);
            veterinaria.RegistrarCliente(cliente2);
            veterinaria.RegistrarCliente(cliente3);

            Console.WriteLine(veterinaria.Mostrar());


            

        }
    }
}