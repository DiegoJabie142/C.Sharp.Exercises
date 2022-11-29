using System;

namespace _02_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int minimo = 0;
            int maximo = 0;
            int total = 0;
            bool esNumero = true;

            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("Ingrese un numero entre -100 y 100: ");
                esNumero = int.TryParse(Console.ReadLine(), out numero);
                while(!(Validador.Validar(numero, -100, 100)) || esNumero == false){
                    Console.WriteLine("Error. Reingrese un numero entre -100 y 100: ");
                    esNumero = int.TryParse(Console.ReadLine(), out numero);
                }

                if(numero < minimo || i == 0)
                {
                    minimo = numero;
                }

                if (numero > maximo || i == 0)
                {
                    maximo = numero;
                }

                total += numero;
            }

            float promedio = (float)total / 10;

            Console.WriteLine("El valor minimo ingresado es {0}, el maximo es {1}, y el promedio es {2}", minimo, maximo, promedio);
        }
    }
}
