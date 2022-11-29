using System;
using _02___Vos_cuántas_primaveras_tenés;


namespace _02___Vos_cuantas_primaveras_tenes_ejecutable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona p1 = new Persona("Diego", "2000/11/01", 42598324);

            Persona p2 = new Persona("Sol", "2004/2/11", 53234901);

            Persona p3 = new Persona("Daniel", "1970/12/19", 29581043);

            Console.WriteLine(p1.Mostrar(), " y es " , p1.EsMayorDeEdad());
            Console.WriteLine(p2.Mostrar(), " y es ", p2.EsMayorDeEdad());
            Console.WriteLine(p3.Mostrar(), " y es ", p3.EsMayorDeEdad());
        }
    }
}
