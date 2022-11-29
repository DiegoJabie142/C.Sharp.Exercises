using System;

namespace _2_02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string goOn = "";
            int number;
            int result = 0;
            int counter = 0;
           
            do
            {
                Console.WriteLine("Ingrese un número entero: ");
                while(!int.TryParse(Console.ReadLine(), out number))
                {
                    Console.WriteLine("Error. Reingrese un número entero: ");
                }
                counter++;

                result += number;

                Console.WriteLine("¿Desea continuar? (S)");
                goOn = Console.ReadLine();
            } while (Validador.ValidarRespuesta("S", goOn));

            Console.WriteLine("Se han ingresado {0} números enteros y el total es {1}", counter, result);
        }
    }
}
