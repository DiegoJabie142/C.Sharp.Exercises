using System;

namespace TryParse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese su número: ");
            string strNumber = Console.ReadLine();

            int number; 

            if (!NumeroEntero.TryParse(strNumber, out number)){
                Console.WriteLine($"No se pudo hacer el parseo de {strNumber}.");
            }
            else
            {
                Console.WriteLine($"Se pudo realizar el parseo: {number}");
            }

        }
    }
    public class NumeroEntero
    {
        public static bool TryParse(string strNumber, out int  number) // tiene que indicar si pudo o no pudo
        {
            bool rtn = true;

            try
            {
                number = int.Parse(strNumber);
            }
            catch(Exception e)
            {
                rtn = false;
                number = 0;
            }

            return rtn;
        }
    }
}
