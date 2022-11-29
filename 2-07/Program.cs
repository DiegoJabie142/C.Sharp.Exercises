using System;

namespace _2_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la base en cm: ");
            double baseTriangulo = double.Parse(Console.ReadLine());
            
            Console.WriteLine("Ingrese la altura en cm: ");
            double altura = double.Parse(Console.ReadLine());

            double hipotenusa = Pitagoras.CalcularHipotenusa(baseTriangulo, altura);
            Console.WriteLine("La hipotenusa es: {0}cm", hipotenusa);
        }
    }
}
