using System;
using System.Linq.Expressions;

namespace _2_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string hola = Conversor.ConvertirDecimalABinario(300);

            Console.WriteLine(hola);

            int numero = Conversor.ConvertirBinarioADecimal(1100);

            Console.WriteLine(numero);

            //soy god no?
        }
    }
}
