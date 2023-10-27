using Entidades.Interfaces;

namespace Entidades
{
    public class Boligrafo : IAcciones
    {
        private ConsoleColor colorTinta;
        private float tinta;

        public Boligrafo(float tinta, ConsoleColor colorTinta)
        {
            this.colorTinta = colorTinta;
            this.tinta = tinta;
        }

        public ConsoleColor ColorTinta { get => colorTinta; set => colorTinta = value; }
        public float Tinta { get => tinta; set => tinta = value; }

        //CUMPLO EL CONTRATO CON LA INTERFACE
        public ConsoleColor Color
        {
            get
            {
                return this.colorTinta;
            }
            set 
            { 
                this.colorTinta = value;
            }
        }

        public float UnidadesDeEscritura
        {
            get
            {
                return (int)this.tinta;
            }
            set
            {
                this.tinta = value;
            }
        }


        /// <summary>
        /// Reducira la tinta en 0.3 por cada caracter escrito
        /// </summary>
        /// <param name="text"></param>
        /// <returns>La escritura con el color y texto</returns>
        public EscrituraWrapper Escribir(string text)
        {
            int cantidadDeCaracteres = text.Length;

            tinta -= cantidadDeCaracteres * 0.3F;

            return new EscrituraWrapper(this.colorTinta, text);
        }

        /// <summary>
        /// Incrementara la tinta segun la cantidad de unidades
        /// </summary>
        /// <param name="unidades"></param>
        /// <returns></returns>
        public bool Recargar(int unidades)
        {
            if (unidades > 0)
            {
                this.tinta += unidades;
                return true;
            }

            return false;
        }


        public override string ToString()
        {
            return $"Boligrafo con color de tinta {this.colorTinta} y su nivel de tinta es {this.tinta}";
        }
    }
}