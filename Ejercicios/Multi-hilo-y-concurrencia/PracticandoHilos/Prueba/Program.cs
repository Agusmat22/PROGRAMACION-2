using Entidades;
using System.Collections.Concurrent;
using System.Text.RegularExpressions;

namespace Prueba
{
    internal class Program
    {
        public delegate void CamarerosAtienden(string nombre, List<int> mesas, int demoraEnAtender);

        public delegate void ActualizarPacientes(Queue<Persona> listaPersonas);

        static void Main(string[] args)
        {
            #region Primera prueba
            /*
            //tengo como parametro un referente de metodos (delegados)
            CamarerosAtienden camarerosAtiende = MozoAtender;
            List<int> mesas1 = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18 };
            List<int> mesas2 = new List<int>() { 12, 13, 14, 15, 16, 17, 18, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18 };

            Task mozo1 = Task.Run(() => camarerosAtiende("agustin",mesas1,1000));
            Task mozo2 = Task.Run(() => camarerosAtiende("sofia",mesas2,2000));

            Console.ReadKey();
        

            static string AtenderMesa(string nombre, int mesa)
            {
                return $"{nombre} atendio la mesa {mesa}.";

            }

            static void MozoAtender(string nombre, List<int> mesas, int demoraEnAtender)
            {

                foreach (int item in mesas)
                {

                    Console.WriteLine($"{AtenderMesa(nombre, item)}\n");
                    Thread.Sleep(demoraEnAtender);
                }
            }*/
            #endregion

            #region Segundo prueba
            ActualizarPacientes actualizarPacientes = MostrarListaPersonas;
            ActualizarPacientes actualizarPacientes2 = MostrarListaPersonas;


            Persona per1 = new Persona("Agustin","Ramon",20);
            Persona per2 = new Persona("Lucas","GImenez",33);
            Persona per3 = new Persona("Sofia","Isunza",10);
            Persona per4 = new Persona("Marcelo","Garcia",22);
            Persona per5 = new Persona("Vanesa","Pinto",80);
            Persona per6 = new Persona("Lucia","Irine",44);
            Persona per7 = new Persona("Romina","Lida",94);
            Persona per8 = new Persona("Juli","Prime",11);


            Queue<Persona> cola1 = new Queue<Persona>();

            cola1.Enqueue(per1);
            cola1.Enqueue(per2);
            cola1.Enqueue(per3);
            cola1.Enqueue(per4);
            

            Queue<Persona> cola2 = new Queue<Persona>();

            cola2.Enqueue(per5);
            cola2.Enqueue(per6);
            cola2.Enqueue(per7);
            cola2.Enqueue(per8);

            Task tarea1 = Task.Run(() => actualizarPacientes(cola1));
            Task tarea2 = Task.Run(() => actualizarPacientes(cola2));

            #endregion

            Task tarea = Task.Run(() => ActualizarHora());

            Console.ReadKey();

        }

        public static void MostrarListaPersonas(Queue<Persona> listaPersona)
        {

            foreach (Persona item in listaPersona)
            {
                Console.WriteLine(item);
                Thread.Sleep(1000);
            }

        }

        public static void ActualizarHora()
        {
            while (true)
            {
                string hora = DateTime.Now.ToString("HH/mm/ss");

                //hora = Regex.Replace(hora,"/", "-");

                string[] horaPartida = hora.Split("/");
                hora = $"Hora: {horaPartida[0]} | Minuto: {horaPartida[1]} | Segundo: {horaPartida[2]}";

                
                Console.WriteLine(hora);
                Thread.Sleep(1000);

            }
        }
    }
            
}

        
        
