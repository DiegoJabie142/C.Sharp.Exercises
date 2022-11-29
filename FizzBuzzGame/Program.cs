using System;
using System.Text;

namespace FizzBuzzGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 3251590;
        }
    }

    public static class Int32FizzBuzz { 
        

        static string FizzBuzz(this Int32 entero)
        {
            string enteroStr = entero.ToString();

            StringBuilder sb = new StringBuilder();

            foreach(var c in enteroStr)
            {
                Int32 aux = Int32.Parse(c.ToString());

                if(aux % 3 == 0 && aux % 5 == 0)
                {
                    sb.Append("Fizz Buzz");
                }
                else if(aux % 5 == 0)
                {
                    sb.Append("Buzz");
                }
                else if(aux % 3 == 0)
                {
                    sb.Append("Fizz");
                }
                else
                {
                    sb.Append(" "+c.ToString()+" ");
                }

            }

            return sb.ToString();
        }

    
    }
        
}
