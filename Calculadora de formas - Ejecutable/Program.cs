using System;
using System.Collections.Generic;
using Calculadora_de_formas;

namespace Calculadora_de_formas___Ejecutable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Figura> lista = new List<Figura>();

            lista.Add(new Circulo(1));
            lista.Add(new Cuadrado(3));
            lista.Add(new Rectangulo(3.4, 2));

            int i = 1;
            foreach (Figura figura in lista)
            {
                Console.WriteLine($"=============== FIGURA {i} ==================");
                Console.WriteLine($"Tipo: {figura.GetType()}");
                Console.WriteLine(figura.Dibujar());
                Console.WriteLine($"Área = {figura.CalcularSuperficie()}");
                Console.WriteLine($"Perímetro = {figura.CalcularPerimetro()}");
                Console.WriteLine("============================================\n\n");
                i++;
            }
        }
    }
}
