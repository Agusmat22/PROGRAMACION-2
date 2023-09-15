using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class NumeroDecimal
    {
        private int numero;

        private NumeroDecimal(int numero)
        {
            this.numero = numero;
        }

        public int GetNumero()
        { return this.numero; }

        //Genero una conversion implicita para instanciar mi objeto que dicho constructor es privado
        public static implicit operator NumeroDecimal(int numero)
        {
            return new NumeroDecimal(numero);
        }

        public static implicit operator int(NumeroDecimal numero)
        {
            return numero.GetNumero();
        }

        public static explicit operator NumeroBinario(NumeroDecimal numeroDecimal)
        {
            return Conversor.ConversorDecimalABinario(numeroDecimal);
        }

        public static int operator +(NumeroDecimal numDecimal ,NumeroBinario numBinario)
        {
            int resultado = (NumeroDecimal)numBinario + numDecimal.GetNumero();

            return resultado;
        }

        public static int operator -(NumeroDecimal numDecimal, NumeroBinario numBinario)
        {

            int resultado = (NumeroDecimal)numBinario - numDecimal.GetNumero();

            return resultado;
        }

        public static bool operator ==(NumeroDecimal numDecimal, NumeroBinario numBinario)
        {
            int numeroCasteado = Conversor.ConvertirBinarioADecimal(numBinario);

            return numeroCasteado == numDecimal.GetNumero();
        }

        public static bool operator !=(NumeroDecimal numDecimal, NumeroBinario numBinario)
        {

            return !(numDecimal == numBinario);
        }
    }
}
