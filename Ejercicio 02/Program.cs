using System;
using Ejercicio01;

namespace Ejercicio_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tempera t1 = new Tempera(ConsoleColor.Red, "Alba", 50);
            Tempera t2 = new Tempera(ConsoleColor.Blue, "Alba", 50);
            Tempera t3 = new Tempera(ConsoleColor.Red, "Alba", 25);
            Tempera t4 = new Tempera(ConsoleColor.Black, "Pinturita", 50);
            Tempera t5 = new Tempera(ConsoleColor.Green, "Temperita", 50);

            //Comparo temperas

            Console.WriteLine("t1 == t2: {0}", (t1 == t2));
            Console.WriteLine("t1 == t3: {0}", (t1 == t3));
            Console.WriteLine("t1 == t4: {0}", (t1 == t4));
            Console.WriteLine("t1 == null: {0}", (t1 == null));
            Console.WriteLine("null == t1: {0}", (null == t1));

            Tempera t6 = t1 + t2;
            Console.WriteLine(Tempera.Mostrar(t6));

            Tempera t7 = t1 + t3;
            Console.WriteLine(Tempera.Mostrar(t7));

            Tempera t8 = t1 + t4;
            Console.WriteLine(Tempera.Mostrar(t8));

            Tempera t9 = t1 + null;
            Console.WriteLine(Tempera.Mostrar(t9));

            Tempera t10 = t1 + 20;
            Console.WriteLine(Tempera.Mostrar(t10));

            Tempera t11 = t2 + 30;
            Console.WriteLine(Tempera.Mostrar(t11));

            Paleta p


        }
    }
}
