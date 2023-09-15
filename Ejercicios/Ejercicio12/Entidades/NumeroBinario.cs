using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class NumeroBinario
    {
        private string numero;

        private NumeroBinario(string numero)
        {
            this.numero = numero;
        }

        public string GetNumero()
        { return this.numero; }

        //Genero una conversion implicita para instanciar mi objeto que dicho constructor es privado
        public static implicit operator NumeroBinario (string numero)
        {
            return new NumeroBinario (numero);
        }

        public static implicit operator string(NumeroBinario numero)
        {
            return numero.GetNumero();
        }

        public static explicit operator NumeroDecimal(NumeroBinario numeroBinario)
        {
            return (NumeroDecimal)numeroBinario;
        }

        public static string operator +(NumeroBinario numBinario,NumeroDecimal numDecimal)
        {
            int numeroCasteado = Conversor.ConvertirBinarioADecimal(numBinario);

            int resultado = numeroCasteado + numDecimal.GetNumero();

            return Conversor.ConversorDecimalABinario(resultado);
        }

        public static string operator -(NumeroBinario numBinario, NumeroDecimal numDecimal)
        {
            int numeroCasteado = Conversor.ConvertirBinarioADecimal(numBinario);

            int resultado = numeroCasteado - numDecimal.GetNumero();

            return Conversor.ConversorDecimalABinario(resultado);
        }

        public static bool operator ==(NumeroBinario numBinario, NumeroDecimal numDecimal)
        {
            int numeroCasteado = Conversor.ConvertirBinarioADecimal(numBinario);

            return numeroCasteado == numDecimal.GetNumero();
        }

        public static bool operator !=(NumeroBinario numBinario, NumeroDecimal numDecimal)
        {

            return !(numBinario == numDecimal);
        }
    }
}
