namespace Entidades
{
    public class Libro
    {
        private List<string> paginas;


        public Libro()
        {
            paginas = new List<string>();
        }

        public string this[int indexador]
        {
            get 
            {
                if (indexador >= 0 && indexador < paginas.Count)
                {
                    return paginas[indexador];
                }
                else
                {
                    return string.Empty;
                }
            }

            set
            {
                if (indexador >= 0 && indexador < paginas.Count)
                {
                    paginas[indexador] = value;
                }
                else
                {
                    paginas.Add(value);
                }
            }

        }
    }
}