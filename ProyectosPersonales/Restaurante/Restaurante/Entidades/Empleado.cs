namespace Entidades
{
    public class Empleado
    {
        public enum ETurno
        {
            mañana,
            tarde,
            noche
        }

        public enum EPuesto
        {
            mozo,
            cocina, 
            cajero
        }


        private string usuario;
        private string password;
        private string nombre;
        private string apellido;
        private short dni;
        private ETurno turno;
        private EPuesto puesto;

        public Empleado(string usuario, string password, string nombre, 
            string apellido, short dni, ETurno turno, EPuesto puesto)
        {
            this.usuario = usuario;
            this.password = password;
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.turno = turno;
            this.puesto = puesto;
        }

        public string Nombre
        {
            get { return this.nombre + " "+ this.apellido; }
        }

        public ETurno Turno
        {
            get { return this.turno; }
        }

        public EPuesto Puesto
        {
            get { return this.puesto; }
        }

        public bool ValidarCuenta(string usuario,string password)
        {
            return this.usuario == usuario && this.password == password;
        }

        public static bool operator ==(Empleado e1, Empleado e2)
        {
            return e1.dni == e2.dni;
        }

        public static bool operator !=(Empleado e1, Empleado e2)
        {
            return !(e1 == e2);
        }
    }
}