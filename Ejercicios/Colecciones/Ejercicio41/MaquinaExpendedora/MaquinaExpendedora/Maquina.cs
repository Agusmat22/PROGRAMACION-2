using Entidades;
using System.Diagnostics;

namespace MaquinaExpendedora
{
    public partial class Maquina : Form
    {
        private Dictionary<int, Stack<Producto>> maquinaExpendedora;
        private Producto producto;
        private int numeroIngresado;

        public Maquina()
        {
            InitializeComponent();

            // Asigna el mismo manejador de eventos a todos los botones dentro del GroupBox
            foreach (Button button in grpTablero.Controls.OfType<Button>())
            {
                button.Click += BotonPresionadoTablero; // Usamos el mismo manejador para todos los botones
            }
        }

        private void Maquina_Load(object sender, EventArgs e)
        {
            maquinaExpendedora = new Dictionary<int, Stack<Producto>>();

            Producto producto1 = new Producto("Lays", 100, "a15");
            Producto producto2 = new Producto("Coca", 1020, "bn2");
            Producto producto3 = new Producto("Agua", 500, "cqp");
            Producto producto5 = new Producto("Pringles", 10, "pq10");
            Producto producto4 = new Producto("Rocklets", 120, "98ca");
            Producto producto6 = new Producto("Chocolate", 120, "98a");


            Stack<Producto> papasFritas = new Stack<Producto>();
            Stack<Producto> bebidas = new Stack<Producto>();
            Stack<Producto> dulces = new Stack<Producto>();

            //GUARDO LAS PAPAS FRITAS EN EL STACK
            papasFritas.Push(producto1);
            papasFritas.Push(producto5);

            //GUARDO LAS BEBIDAS EN EL STACK
            bebidas.Push(producto2);
            bebidas.Push(producto3);

            //GUARDO LOS DULCES EN EL STACK
            dulces.Push(producto4);
            dulces.Push(producto6);

            maquinaExpendedora.Add(0, papasFritas);
            maquinaExpendedora.Add(1, bebidas);
            maquinaExpendedora.Add(2, dulces);


        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            /*
            while (!int.TryParse(this.txtSeleccion.Text, out numeroIngresado))
            {
                this.txtSeleccion.Text = "";
                this.txtMensaje.Text = "Error, el producto no existe";
            }

            switch (numeroIngresado)
            {
                //PAPAS FRITAS
                case 1:

                    if (maquinaExpendedora[numeroIngresado].Count > 0)
                    {
                        this.txtMensaje.Text = $"Se eligio el producto {maquinaExpendedora[numeroIngresado].Peek}";
                    }
                    break;
            }
            */
        }

        private void BotonPresionadoTablero(object sender, EventArgs e)
        {
            string numero = "";

            foreach (Control item in grpTablero.Controls)
            {
                if (item is Button boton)
                {
                    if (boton == this.btn0)
                    {
                        numero = "0";
                    }
                    else if (boton == this.btnUno)
                    {
                        numero = "1";
                    }
                    else if (boton == this.btn2)
                    {
                        numero = "2";
                    }
                    else if (boton == this.btn3)
                    {
                        numero = "3";
                    }
                    else if (boton == this.btn4)
                    {
                        numero = "4";
                    }
                    else if (boton == this.btn5)
                    {
                        numero = "5";
                    }
                    else if (boton == this.btn6)
                    {
                        numero = "6";
                    }
                    else if (boton == this.btn7)
                    {
                        numero = "7";
                    }
                    else if (boton == this.btn8)
                    {
                        numero = "8";
                    }
                    else if (boton == this.btn9)
                    {
                        numero = "9";
                    }
                    else if (boton == this.btnIngresar)
                    {
                        MessageBox.Show("Hola");
                    }

                    break;
                }

            }
            this.txtSeleccion.Text += numero;


        }


    }
}