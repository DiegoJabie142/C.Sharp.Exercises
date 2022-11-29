using System;

namespace _1_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            int option;
            string entrada;

            Console.WriteLine("Ingrese un número entero positivo o \"salir\" para salir: ");
            entrada = Console.ReadLine();

            while (entrada != "salir" && !(int.TryParse(entrada, out number)))
            {
                Console.WriteLine("Error. Reingrese un número entero positivo o \"salir\" para salir: ");
                entrada = Console.ReadLine();
            }

            for(int i = 1; i <= number; i++)
            {
                int counter = 0;

                for(int j = 1; j <= i; j++)
                {
                    if(i % j == 0)
                    {
                        counter++;
                    }
                }

                if(counter <= 2)
                {
                    Console.WriteLine(i);
                }
            }

            Console.WriteLine("¿Quiere volver a iterar?\n1. Sí\n2. No");
            while(!(int.TryParse(Console.ReadLine(), out option)) || (option != 1 && option != 2))
            {
                Console.WriteLine("Opcion incorrecta. ¿Quiere volver a iterar?\n1. Sí\n2.No");
            }

            if(option == 1)
            {
                Main(args);
            }

        }
    }
}
