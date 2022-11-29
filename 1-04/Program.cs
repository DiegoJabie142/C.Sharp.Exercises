using System;

namespace _1_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Los primeros 4 números perfectos son: ");

            int counter = 0;

            int i = 5;

            while (counter != 4)
            {
                int checker = 0;

                for(int j = 1; j < i; j++)
                {
                    if( i % j == 0)
                    {
                        checker += j;
                    }
                }

                if(i == checker)
                {
                    Console.WriteLine(i);
                    counter++;
                }

                i++;
            }
        }
    }
}
