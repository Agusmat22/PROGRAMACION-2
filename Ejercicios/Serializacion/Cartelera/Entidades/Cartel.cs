namespace Entidades
{
    public class Cartel
    {
        private int colorARGB;
        private Texto titulo;
        private Texto mensaje;

        public Cartel(int colorARGB, Texto titulo, Texto mensaje)
        {
            ColorARGB = colorARGB;
            Titulo = titulo;
            Mensaje = mensaje;
        }

        public int ColorARGB
        {
            get { return colorARGB; }
            set { colorARGB = value; }
        }


        public Texto Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }


        public Texto Mensaje
        {
            get { return mensaje; }
            set { mensaje = value; }
        }

        

    }
}