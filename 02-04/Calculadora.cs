using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_04
{
    internal class Calculadora
    {
        public static double Calcular(int number, int number2, string operation)
        {
            double rtn = 0;

            switch(operation){
                
                case "+":
                    rtn = Plus(number, number2);
                    break;

                case "-":
                    rtn = Subtraction(number, number2);
                    break;

                case "*":
                    rtn = Multiplication(number,number2);
                    break;

                case "/":
                    if (Validar(number2))
                    {
                        rtn = Division(number, number2);
                    }
                    break;

                default:
                  break;
            }

            return rtn;
        }

        private static bool Validar(int number)
        {
            bool rtn = true;

            if(number != 0)
            {
                rtn = false;
            }

            return rtn;
        }

        private static int Plus(int number1, int number2)
        {
            return number1 + number2;
        }

        private static int Subtraction(int number1, int number2)
        {
            return number1 - number2;
        }

        private static int Multiplication(int number1, int number2)
        {
            return number1 * number2;
        }

        private static double Division(int number1, int number2)
        {
            return (double) number1 / number2;
        }
    }
}
