using System;

namespace Ejercicio_01
{
    public static class CalculadoraDeString
    {
        public static int Add(string numeros)
        {
            string[] auxNums = numeros.Split(",");

            int numero = 0;

            foreach (var strNumero in auxNums)
            {
                numero += int.Parse(strNumero);
            }

            return numero;
        }
    }
}
