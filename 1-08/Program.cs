﻿using System;

namespace _1_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for(int i = 1; i < 10; i+=2)
            {
                for(int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
