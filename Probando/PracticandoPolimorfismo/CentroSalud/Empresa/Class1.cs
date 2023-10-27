using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa
{
    public class Class1 : IProbandoInterfaz, SegIntefaz<string>
    {
        public string Nombre { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        int IProbandoInterfaz.SumarNumeros(int num1, int num2)
        {
            return num1 + num2;
        }

        public int SumarNumeros(int num1, int num2)
        {
            return num1 + num2;
        }

        public bool prueba(IProbandoInterfaz ip)
        {
            return true;
        }
    }
}
