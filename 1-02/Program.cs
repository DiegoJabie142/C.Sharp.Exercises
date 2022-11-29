using System;

namespace _1_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            double cuadrado;
            double cubo;

            Console.WriteLine("Ingrese un número mayor que 0: ");

            while (!(int.TryParse(Console.ReadLine(), out numero)) || numero < 0)
            {
                Console.WriteLine("ERROR. Reingrese el número: ");
            };

            cuadrado = Math.Pow(numero, 2);
            cubo = Math.Pow(numero, 3);

            Console.WriteLine("El cuadrado de {0} es {1} y el cubo es {2}.", numero, cuadrado, cubo);
        }
    }
}
