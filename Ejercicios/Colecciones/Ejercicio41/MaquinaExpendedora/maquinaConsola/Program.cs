using Entidades;

namespace maquinaConsola
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*Console.WriteLine("BIENVENIDOS A CANDY BAR");
            int ubicacion;
            while (true)
            {
                foreach (KeyValuePair<int, Producto> item in maquinaExpendedora)
                {
                    Console.WriteLine($"Ubicacion: {item.Key}  --> Producto: {item.Value.Nombre}");
                }
                Console.WriteLine("Seleccione un producto por ubicacion: \n20)SALIR");

                while (!int.TryParse(Console.ReadLine(),out ubicacion))
                {
                    Console.WriteLine("ERROR, Seleccione un producto por ubicacion: ");

                }

                if (ubicacion == 20 )
                {
                    Console.WriteLine("Salio de la maquina expendedora, mucha suerte");
                    break;

                }
                else if (ubicacion > -1 && ubicacion < 5)
                {
                    Console.WriteLine("Usted recibiio el producto: " + maquinaExpendedora[ubicacion].Nombre);
                    maquinaExpendedora.Remove(ubicacion);
                }
                else
                {
                    Console.WriteLine("No existe ese producto");
                }
                */


            //------------------------------ PARTE 2 ------------------------------------------------------------------//
            /*
            Dictionary<int, Stack<Producto>> maquinaExpendedora = new Dictionary<int, Stack<Producto>>();

            Producto producto1 = new Producto("Lays", 100, "A-15");
            Producto producto3 = new Producto("Lays2", 100, "A-15");
            Producto producto2 = new Producto("Coca", 1020, "bn2");
            Producto producto5 = new Producto("Pringles", 10, "pq10");


            //CREO 3 STACK

            Stack<Producto> papasFritas = new Stack<Producto>();
            Stack<Producto> coca = new Stack<Producto>();
            Stack<Producto> pringles = new Stack<Producto>();

            //GUARDO LAS PAPAS FRITAS EN EL STACK
            papasFritas.Push(producto1);
            papasFritas.Push(producto5);
            papasFritas.Push(producto3);

            //GUARDO LAS BEBIDAS EN EL STACK
            coca.Push(producto2);

            //GUARDO LOS DULCES EN EL STACK
            pringles.Push(producto1);




            maquinaExpendedora.Add(0, papasFritas);
            maquinaExpendedora.Add(1, coca);
            maquinaExpendedora.Add(2, pringles);

            int ubicacion;
            int cantidadStock;
            while (true)
            {
                Console.WriteLine("Posicion      Producto      Precio      Stock");
                Console.WriteLine("----------------------------------------------");

                foreach (KeyValuePair<int, Stack<Producto>> item in maquinaExpendedora)
                {
                    
                    cantidadStock = item.Value.Count; // CANTIDAD  DE STOCK DEL STACK 

                    if (item.Value.Count > 0)
                    {
                        Console.WriteLine($"{item.Key,+5} {item.Value.Peek().Nombre, +15} {item.Value.Peek().Precio,+10}$ {cantidadStock,+10}");
                    }
                    else
                    {
                        Console.WriteLine($"Sin stock");
                    }

                }
                Console.WriteLine("Seleccione un producto por ubicacion: \n20)SALIR");

                while (!int.TryParse(Console.ReadLine(), out ubicacion))
                {
                    Console.WriteLine("ERROR, Seleccione un producto por ubicacion: ");

                }

                if (ubicacion > -1 && ubicacion < 4) 
                {
                    maquinaExpendedora[ubicacion].Pop();
                
                }
                else
                {
                    break;
                }

            }
            */
            //---------------------------------- PARTE 3 -------------------------------------//
            CandyBar maquinaExpendedora = new CandyBar(); //INSTACION MI CANDYBAR DE PRODUCTOS
            int numeroElegido;
            Producto producto1 = new Producto("Lays", 100, "A-15");
            Producto producto2 = new Producto("Lays2", 100, "A-11");
            Producto producto3 = new Producto("Coca", 1020, "bn2");
            Producto producto4 = new Producto("Pringles", 10, "pq10");

            //AGREGO LOS PRODUCTOS  
            maquinaExpendedora[0] = producto1; 
            maquinaExpendedora[1] = producto2;
            maquinaExpendedora[2] = producto3;
            maquinaExpendedora[3] = producto4;

            

            Queue<string> filaClientes = new Queue<string>();

            filaClientes.Enqueue("Agustin");
            filaClientes.Enqueue("Sofia");
            filaClientes.Enqueue("Roberto");
            filaClientes.Enqueue("Lucia");
            
            Console.WriteLine("Bienvenido a la maquina Candy Bar");
            while (true)
            {
                Console.WriteLine($"Buenos dias! {filaClientes.Peek()} Perdon por la demora. Seleccione un producto\n{maquinaExpendedora.MostrarMenu()}");
                int cant = maquinaExpendedora.CantidadProductos();
                while(!(int.TryParse(Console.ReadLine(), out numeroElegido) && numeroElegido >= 0 && numeroElegido < cant))
                {
                    Console.WriteLine($"ERROR, El producto no existe. Seleccione un producto\n{maquinaExpendedora.MostrarMenu()}");

                }
               

                Console.WriteLine($"Llevara es: {maquinaExpendedora[numeroElegido].Mostrar()}");

                filaClientes.Dequeue(); //ELIMINO AL CLIENTE DE LA COLA

                if (filaClientes.Count == 0)
                {
                    Console.WriteLine($"Desea agregar mas clientes? (S/N)");
                    if (Console.ReadLine() == "S")
                    {
                        Console.WriteLine("Perfecto pero tengo pereza de agregarlos asi que sera la proxima brodeer");
                    }
                    else
                    {
                        Console.WriteLine("Gracias por comprar nuestro productos, muchas suerte!");
                        break;
                    }
                }
                else
                {
                    Console.WriteLine($"Quedan {filaClientes.Count} clientes");
                }
            }

        }

    }
}