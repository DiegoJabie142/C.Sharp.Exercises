using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Torneo
{
    public class Torneo<T> where T : Equipo
    {
        private List<T> equipos;
        private String nombre;

        private Torneo()
        {
            equipos = new List<T>();
        }

        public Torneo(string nombre) : this()
        {
            this.nombre = nombre;
        }



        public static bool operator ==(Torneo<T> t, T e)
        {
            bool rtn = false;

            foreach(T item in t.equipos)
            {
                if(item == e)
                {
                    rtn = true;
                    break;
                }
            }

            return rtn;
        }

        public static bool operator !=(Torneo<T> t, T e)
        {
            return !(t == e);
        }

        public static bool operator +(Torneo<T> t, T e)
        {
            bool rtn = false;

            if (t is not null && t != e)
            {
                t.equipos.Add(e);
                rtn = true;
            }

            return rtn;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre del torneo: {this.nombre}");
            foreach(T item in this.equipos)
            {
                sb.AppendLine(item.Ficha());
            }

            return sb.ToString();
        }

        private string CalcularPartido(T e1, T e2)
        {
            Random r = new Random();
            return $"{e1.Nombre} {r.Next(0, 10)} - {r.Next(0, 10)} {e2.Nombre}";
        }

        public string JugarPartido
        {
            get
            {
                Random r = new Random();
                T e;
                T e2;
                string rtn = "No hay suficientes equipos.";

                if(this.equipos.Count > 1)
                {
                    do
                    {
                        e = this.equipos.ElementAt(r.Next(0, this.equipos.Count));
                        e2 = this.equipos.ElementAt(r.Next(0, this.equipos.Count));
                    } while (e == e2);

                    rtn = CalcularPartido(e, e2);
                }

                return rtn;
            }
        }
    }

    public abstract class Equipo
    {
        private string nombre;
        private DateTime fechaCreacion;

        public string Nombre { 
            get { return this.nombre; }
            set { this.nombre = value; }
        }
        public Equipo(string nombre, DateTime fechaCreacion)
        {
            this.nombre = nombre;
            this.fechaCreacion = fechaCreacion;
        }

        public static bool operator ==(Equipo e, Equipo e2)
        {
            return e.nombre == e2.nombre && e.fechaCreacion == e2.fechaCreacion;
        }

        public static bool operator !=(Equipo e, Equipo e2)
        {
            return !(e == e2);
        }

        public string Ficha()
        {
            return $"{this.nombre} fundado el {fechaCreacion.ToString("dd/mm/yyyy")}";
        }
    }

    public class EquipoBasquet : Equipo
    {
        public EquipoBasquet(string nombre, DateTime fechaCreacion) : base(nombre, fechaCreacion)
        {

        }
    }
}
