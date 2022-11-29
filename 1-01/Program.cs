using System;

namespace _1_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variable escalar != variable atomica

            int[] numero = new int[5];

            int minimo = 0;
            int maximo = 0;
            int total = 0;
            float promedio;

            //int.TryParse

            //int.TryParse(Console.ReadLine(), numero); //devuelve un boolean

            for (int i = 0; i < numero.Length; i++)
            {
                Console.WriteLine("Ingrese un numero: ({0})", i);
                numero[i] = int.Parse(Console.ReadLine());

                total += numero[i];

                if (numero[i] < minimo || i == 0)
                {
                    minimo = numero[i];
                }

                if (numero[i] > maximo || i == 0)
                {
                    maximo = numero[i];
                }
            }

            promedio = (float) total / numero.Length;

            Console.WriteLine("\nEl maximo es {0}, el minimo es {1} y el promedio es {2}", maximo, minimo, promedio);

        }
    }
}
