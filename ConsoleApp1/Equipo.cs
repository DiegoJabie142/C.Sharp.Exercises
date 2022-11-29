using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Equipo
    {
        private string nombre;
        private List<Persona> integrantes;

        private Equipo()
        {
            integrantes = new List<Persona>();
        }

        public Equipo(string nombre) : this()
        {
            this.nombre = nombre;
        }



    }
}
