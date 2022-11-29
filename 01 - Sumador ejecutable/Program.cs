using System;
using _01___Sumador;

namespace _01___Sumador_ejecutable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sumador sum = new Sumador();

            Sumador sum2 = new Sumador();

            Console.WriteLine($"suma de objetos {sum + sum2}");
            Console.WriteLine($"Suma de long : {sum2.Sumar(100, 687)} Sumador {sum2.Cantidad()}");
            Console.WriteLine($"suma de objetos {sum + sum2}");
            Console.WriteLine($"Suma de long : {sum.Sumar("HOla ", "Munjjjjjdo")} Sumador {sum.Cantidad()}");
            if (sum | sum2)
            {
                Console.WriteLine("ES true");
            }
            Console.WriteLine($"suma de objetos {sum + sum2}");
        }
    }
}
