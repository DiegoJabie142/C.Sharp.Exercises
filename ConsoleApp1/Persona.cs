using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public  abstract class Persona
    {
        private string _nombre;

        public string Nombre { get => Nombre; set { _nombre = value; } }
        
        public Persona(string nombre)
        {
            _nombre = nombre;
        }

        public abstract string Entrenar();

        public override string ToString()
        {
            return "Hola soy " + _nombre;
        }

        public virtual string Saludar()
        {
            return ToString();
        }

        public static void EntrenarPlantel(List<Persona> personas)
        {
            foreach(Persona persona in personas)
            {
                Console.WriteLine(persona.Entrenar());
            }
        }

    }
}
