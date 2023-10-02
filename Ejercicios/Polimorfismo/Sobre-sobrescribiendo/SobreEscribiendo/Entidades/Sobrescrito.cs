namespace Entidades
{
    public abstract class Sobrescrito
    {
        protected string miAtributo;


        public Sobrescrito() 
        {
            this.miAtributo = "Probar abstractos";
        }


        //PROPERTY
        protected abstract string MiPropiedad { get; }
        

        
        public override string ToString()
        {
            return "Este es mi metodo ToString sobrescrito";
        }

        public override bool Equals(object? obj)
        {
            bool valor = false;
          
            if(obj is Sobrescrito s)
            {
                valor =  this.GetType() == s.GetType();   
            }

            return valor;
        }

        public override int GetHashCode()
        {
            return 1142510181;
        }


        public abstract string MiMetodo();
    }
}