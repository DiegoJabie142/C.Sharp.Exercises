using System;
using _03___El_ejemplo_universal;

namespace _03___El_ejemplo_universal_ejecutable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Estudiante e1 = new Estudiante("Diego", "Rodríguez", "108346");
            Estudiante e2 = new Estudiante("Rodrigo", "Rodríguez", "109345");
            Estudiante e3 = new Estudiante("Pedro", "Gomez", "103467");

            e1.SetNotaPrimerParcial(8);
            e1.SetNotaSegundoParcial(8);

            e2.SetNotaPrimerParcial(5);
            e2.SetNotaSegundoParcial(3);

            e3.SetNotaPrimerParcial(7);
            e3.SetNotaSegundoParcial(9);

            Console.WriteLine(e1.Mostrar());
            Console.WriteLine(e2.Mostrar());
            Console.WriteLine(e3.Mostrar());
        }
    }
}
