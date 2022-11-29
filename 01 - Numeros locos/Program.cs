using System;

namespace _01___Numeros_locos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vector = new int[20];

            Random rnd = new Random();

            for(int i = 0; i < 20; i++)
            {
                vector[i] = rnd.Next()/1000000;
            }

            for(int i = 0; i < 19; i++)
            {
                for(int j = i+1; j < 20; j++)
                {
                    if(vector[i] < vector[j])
                    {
                        int aux = vector[i];
                        vector[i] = vector[j];
                        vector[j] = aux;
                    }
                }
            }

            for(int i = 0; i < 20; i++)
            {
                Console.WriteLine($"Numero {i + 1}: {vector[i]}");
            }


            for (int i = 0; i < 19; i++)
            {
                for (int j = i + 1; j < 20; j++)
                {
                    if (vector[i] > vector[j])
                    {
                        int aux = vector[i];
                        vector[i] = vector[j];
                        vector[j] = aux;
                    }
                }
            }

            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine($"Numero {i + 1}: {vector[i]}");
            }
        }
    }
}
