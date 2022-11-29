using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Paleta
{
    using Tempera;
    public class Paleta
    {
        private List<Tempera> temperas;
        private int cantidadMaximaColores;

        private Paleta()
        {
            temperas = new List<Tempera>();
        }

        private Paleta(int cantidadMaximaColores) : this()
        {
            this.cantidadMaximaColores = cantidadMaximaColores;
        }

        public static implicit operator Paleta(int cantidadMaximaColores)
        {
            return new Paleta(cantidadMaximaColores);
        }

        public int CantidadTemperas
        {
            get { return temperas.Count; }
        }

        private string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("=== PALETA ===");
            sb.AppendLine($"Cantidad maxima: {this.cantidadMaximaColores}");

            foreach (Tempera t in this.temperas)
            {
                sb.AppendLine(Tempera.Mostrar(t));
            }

            return sb.ToString();
        }

        public int ObtenerIndice(Tempera p)
        {
            int rtn = -1;

            if (p is not null)
            {
                int i = 0;

                foreach (Tempera t in this.temperas)
                {
                    if (p == t)
                    {
                        rtn = i;
                    }
                    i++;
                }
            }
            return rtn;
        }

        public static explicit operator string(Paleta p)
        {
            return p.Mostrar();
        }

        public static bool operator ==(Paleta p, Tempera t)
        {
            bool rtn = false;

            if (p.ObtenerIndice(t) != -1)
            {
                rtn = true;
            }

            return rtn;
        }

        public static bool operator !=(Paleta p, Tempera t)
        {
            bool rtn = true;

            if (p.ObtenerIndice(t) != -1)
            {
                rtn = false;
            }

            return rtn;
        }

        public static Paleta operator +(Paleta p, Tempera t)
        {
            if (p is not null && t is not null)
            {
                if (p == t)
                {
                    p.temperas[p.ObtenerIndice(t)] += t;

                }
                else if (p.temperas.Count < p.cantidadMaximaColores)
                {
                    p.temperas.Add(t);
                }
                else
                {
                    Console.WriteLine("No hay más espacio en la paleta.");
                }
            }
            else
            {
                Console.WriteLine("HAY ALGO NULO? Q HACESSSSS!!!");
            }

            return p;
        }

        public static Paleta operator -(Paleta p, Tempera t)
        {
            if (p == t)
            {   
                p.temperas[p.ObtenerIndice(t)] += (int)t * -1;

                if ((int)p.temperas[p.ObtenerIndice(t)] <= 0)
                {
                    p.temperas.RemoveAt(p.ObtenerIndice(t));
                }
            }

            return p;
        }

        public static Paleta operator +(Paleta p1, Paleta p2)
        {
            Paleta p3 = new Paleta();

            if (p1 is not null && p2 is not null)
            {
                p3 = new Paleta(p1.cantidadMaximaColores + p2.cantidadMaximaColores);

                foreach (Tempera t in p1.temperas)
                {
                    p3 = p3 + t;
                }

                foreach (Tempera t in p2.temperas)
                {
                    p3 = p3 + t;
                }
            }

            return p3;
        }

        public Tempera this[int index]
        {
            get { 
                if (index >= 0 && index < this.CantidadTemperas)
                    {
                        return  this.temperas[index];
                    }
                return null;
                }
            set
            {
                this.temperas[index] = value;
            }
        }
    }
}


