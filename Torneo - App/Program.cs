using System;
using Torneo;

namespace Torneo___App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Torneo<EquipoBasquet> torneoBasquet = new Torneo<EquipoBasquet>("Mega torneo basquet");

            EquipoBasquet e = new EquipoBasquet("e", DateTime.Now);
            EquipoBasquet e2 = new EquipoBasquet("e2", DateTime.Now);

            _ = torneoBasquet + e;
            _ = torneoBasquet + e2;

            Console.WriteLine(torneoBasquet.Mostrar());

            Console.WriteLine(torneoBasquet.JugarPartido);

        }
    }
}
