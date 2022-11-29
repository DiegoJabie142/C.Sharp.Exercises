using System;
using System.Collections.Generic;

namespace PARCIAL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Persona> lista = new List<Persona>();
            lista.Add(new Persona("Tito"));
            lista.Add(new Persona("Pepe"));
            lista.Add(new Persona("Roberto"));
            lista.Add(new Persona("Julia"));
            lista.Add(new Persona("Susana"));

            foreach(Persona item in lista){
                if(item.nombre == "Tito")
                {
                    lista.Remove(item);
                }
            }
        }
    }

    public class Persona
    {
        public string nombre;

        public Persona(string nombre) {
            this.nombre = nombre;
        }

        public virtual string MiMetodo()
        {
            return "hola";
        }
    }

    public class Persona2 : Persona
    {
        public Persona2(string nombre) : base(nombre) { }

        public override string MiMetodo()
        {
            return "hola2";
        }
    }

}
