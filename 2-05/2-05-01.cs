using System;
using System.Text;

namespace _2_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            StringBuilder sb = new StringBuilder(); 
            for(int i = 1; i <= 11; i++)
            {
                sb = Tablas.devolverTabla(i);
                Console.WriteLine(sb);
            }
        }
    }
}
