using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_09
{
    internal class Factorial
    {
        public static int Factorializar(int number)
        {
            int factorial = 1;

            for(int i = 1; i <= number; i++)
            {
                factorial *= i;
            }

            return factorial;
        }
    }
}
