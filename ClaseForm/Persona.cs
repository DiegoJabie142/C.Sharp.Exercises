using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseForm
{
    public class Persona
    {

        public string nombre;
        public string apellido;

        public Persona(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }

        public string MostrarInfo()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(nombre);
            sb.AppendLine($", {apellido}");

            return sb.ToString();
        }
    }
}
