using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Futbolista : Persona
    {
        private Eposicion posicion;

        public Futbolista(string nombre, Eposicion posicion) : base(nombre)
        {
            this.posicion = posicion;
        }

        public Eposicion Eposicion { 
            get => this.posicion; 
            set { this.posicion = value; } 
        }

        public override string Entrenar()
        {
            var sb = new StringBuilder();
            sb.Append(ToString());
            sb.Append(" y estoy entrenando.");

            return sb.ToString();

        }


    }
}
