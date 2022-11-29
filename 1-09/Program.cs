using System;

namespace _1_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 10; i += 2)
            {   
                for(int l = 2; l < 10 - i; l+= 2)
                {
                    Console.Write(" ");
                }

                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }
    }
}
