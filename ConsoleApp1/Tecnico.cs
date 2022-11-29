using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Tecnico : Persona
    {
        public Tecnico(string nombre) : base(nombre)
        {

        }

        public override string Entrenar()
        {
            var sb = new StringBuilder();
            sb.Append(ToString());
            sb.Append(" y estoy dirigiendo.");

            return sb.ToString();
        }
    }
}
