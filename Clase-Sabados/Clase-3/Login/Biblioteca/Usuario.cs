namespace Biblioteca
{
    public enum Colores
    {
        rojo,
        azul,
        verde,
        violeta
    }
    public class Usuario
    {
        private string nombre;
        private string correo;
        private string password;
        private DateTime fechaNacimiento;
        private int codSeguridad;
        private Colores color;
        private string sexo;
        private bool estudia;
        private bool trabaja;
        private bool mayorDeEdad;

        public Usuario()
        {

        }

        public Usuario(string nombre, string correo, string password, 
            DateTime fechaNacimiento, int codSeguridad, Colores color, string sexo)
        {
            this.nombre = nombre;
            this.correo = correo;
            this.password = password;
            this.fechaNacimiento = fechaNacimiento;
            this.codSeguridad = codSeguridad;
            this.color = color;
            this.sexo = sexo;
        }


        public void SetTrabajar(bool valor)
        {
            this.trabaja = valor;
        }

        public void SetEstudiar(bool valor)
        {
            this.estudia = valor;
        }

        public void SetMayorDeEdad(bool valor)
        {
            this.mayorDeEdad = valor;
        }

        public static bool operator ==(Usuario a, Usuario b)
        {
            return a.correo == b.correo && a.password == b.password;
        }

        public static bool operator !=(Usuario a, Usuario b)
        {
            return !(a.correo == b.correo);
        }

        public static bool operator +(List<Usuario> listUsuarios,Usuario usuarioNuevo)
        {
            bool valor = true;

            foreach(Usuario user in listUsuarios)
            {
                if(user == usuarioNuevo)
                {
                    valor = false;
                }
            }

            listUsuarios.Add(usuarioNuevo);

            return valor;

        }


        public bool ValidarPassword(string password)
        {
            return this.password == password;
        }

        public bool ValidarCorreo(string correo)
        {
            return this.correo == correo;
        }

    }
}