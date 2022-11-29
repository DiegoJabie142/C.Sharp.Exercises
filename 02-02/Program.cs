using System;

namespace _02_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int contador = 0;
            int total = 0;
            string respuesta = "";

            Console.WriteLine("¿Desea ingresar un número? (S): ");
            respuesta = Console.ReadLine();
            
            while(Validador.ValidarRespuesta("S", respuesta))
            {
                Console.WriteLine("Ingrese un número: ");
                while(!int.TryParse(Console.ReadLine(), out numero)){
                    Console.WriteLine("Error. Reingrese el número: ");
                }

                contador++;
                total += numero;
                
                Console.WriteLine("¿Desea ingresar otro número? (S): ");
                respuesta = Console.ReadLine();
            }

            Console.WriteLine("Se han ingresado {0} número/s y el total es: {1}", contador, total);
        }
    }
}
