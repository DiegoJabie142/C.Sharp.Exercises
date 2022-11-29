using System;

namespace _1_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberMax = int.Parse(Console.ReadLine());

            for (int k = 1; k < numberMax; k++)
            {
                for (int i = 1; i < k; i++)
                {
                    int suma = 0;
                    for (int j = i; j <= k; j++)
                    {
                        suma += j;
                    }

                    int suma2 = 0;
                    for (int j = i; j > 0; j--)
                    {
                        suma2 += j;
                    }

                    if (suma == suma2)
                    {
                        Console.WriteLine("El numero {0} es centro de {1}", i, k);
                    }
                }
            }
        }
    }
}
