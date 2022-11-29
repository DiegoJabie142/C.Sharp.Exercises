using System;

namespace _1_06
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int inicio;
            int fin;

            Console.WriteLine("Coloque año de inicio: ");
            inicio = int.Parse(Console.ReadLine());
            Console.WriteLine("Coloque año de fin: ");
            fin = int.Parse(Console.ReadLine());

            for(int i = inicio; i < fin; i++)
            {
                if((i % 4 == 0 && i % 100 != 0) || (i % 100 == 0 && i % 400 == 0 ))
                {
                    Console.WriteLine("El año {0} es bisiesto.", i);
                }
            }

        }
    }
}
