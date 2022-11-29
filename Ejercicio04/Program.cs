using System;

namespace Ejercicio04
{
    using Tempera;
    using Paleta;
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
            Console.WriteLine("t1 + t2 = " + Tempera.Mostrar(t6));

            Tempera t7 = t1 + t3;
            Console.WriteLine("t1 + t3 = " + Tempera.Mostrar(t7));

            Tempera t8 = t1 + t4;
            Console.WriteLine("t1 + t4 = " + Tempera.Mostrar(t8));

            Tempera t9 = t1 + null;
            Console.WriteLine("t1 + null = " + Tempera.Mostrar(t9));

            Tempera t10 = t1 + 20;
            Console.WriteLine("t1 + 20 = " + Tempera.Mostrar(t10));

            Tempera t11 = t2 + 30;
            Console.WriteLine("t1 + 30 = " + Tempera.Mostrar(t11));


            Paleta p = 3;
            Console.WriteLine("p == t1 ? : {0}", p == t1);
            
            Console.WriteLine("p += t1");
            p += t1; 
            Console.WriteLine((string)p);
           
            Console.WriteLine("p += t2");
            p += t2;
            Console.WriteLine((string)p);

            Console.WriteLine("p += t3");
            p += t3;
            Console.WriteLine((string)p);

            Console.WriteLine("p += t4");
            p += t4;   
            Console.WriteLine((string)p);
            
            Console.WriteLine("p += t5");
            p += t5;
            Console.WriteLine((string)p);

            Console.WriteLine("p -= t1");
            p -= t1;
            Console.WriteLine((string)p);

            Console.WriteLine("p -= t2");
            p -= t2;
            Console.WriteLine((string)p);

            Console.WriteLine("p -= t5");
            p -= t5;
            Console.WriteLine((string)p);

            
            Paleta p2 = 2;

            Console.WriteLine("p2 += t5");
            p2 += t5;
            Console.WriteLine((string)p2);

            Console.WriteLine("p2 += t4");
            p2 += t4;
            Console.WriteLine((string)p2);

            Console.WriteLine("p2 += t3");
            p2 += t3;
            Console.WriteLine((string)p2);

            Console.WriteLine("p2 += t2");
            p2 += t5;
            Console.WriteLine((string)p2);

            Console.WriteLine("p3= p + p2");
            Paleta p3 = p + p2;
            Console.WriteLine((string)p3);

        }
    }
}
