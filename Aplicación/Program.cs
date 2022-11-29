using System;
using System.Data.Common;

namespace Aplicación
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona persona = new Persona();

            Console.WriteLine(persona.Mostrar2());
        }

        public partial class Persona
        {
            public string nombre;

            public virtual string Mostrar()
            {
                return this.nombre;
            }
        }

        public partial class Persona
        {

            string nombre2;

            public virtual string Mostrar2()
            {
                return this.nombre2;
            }
        }

        public abstract class Estudiante : Persona
        {
            
            public static bool operator |(Estudiante e, Persona p)
            {
                return true;
            }
        }
    }
}
