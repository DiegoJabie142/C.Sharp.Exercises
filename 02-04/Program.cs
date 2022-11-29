using System;

namespace _02_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string goOn = "";
            int number = 0;
            int number2 = 0;
            string operation;
            bool isNumber = false;
            double result = 0;

            do
            {
                Console.WriteLine("Ingrese el primer número: ");
                isNumber = int.TryParse(Console.ReadLine(), out number);
                while (isNumber == false)
                {
                    Console.WriteLine("Error. Reingrese el primer número: ");
                    isNumber = int.TryParse(Console.ReadLine(), out number);
                }

                Console.WriteLine("Ingrese el segundo número: ");
                isNumber = int.TryParse(Console.ReadLine(), out number2);
                while(isNumber == false)
                {
                    Console.WriteLine("Error. Reingrese el segundo número: ");
                    isNumber = int.TryParse(Console.ReadLine(), out number2);
                }

                Console.WriteLine("Ingrese la operación ('+', '-', '*', '/'): ");
                operation = Console.ReadLine();
                while (operation != "+" && operation != "-" && operation != "*" && operation != "/")
                {
                    Console.WriteLine("Error. Reingrese la operación ('+', '-', '*', '/'): ");
                    operation = Console.ReadLine();
                }

                result = Calculadora.Calcular(number, number2, operation);
                Console.WriteLine("Resultado de {0} {1} {2} = {3}", number, operation, number2, result);

                Console.WriteLine("¿Desea continuar? (S ó N)");
                goOn = Console.ReadLine();
                while(goOn != "S" && goOn != "N")
                {
                    Console.WriteLine("¿Error. Desea continuar? (S ó N)");
                    goOn = Console.ReadLine();
                }

            }while(goOn != "N");
        }
    }
}
