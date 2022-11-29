using System;

namespace Tempera
{
    public class Tempera
    {
        private ConsoleColor color;
        private string marca;
        private Int32 cantidad;

        #region CONSTRUCTORES
        public Tempera(ConsoleColor color, string marca, Int32 cantidad)
        {
            this.color = color;
            this.marca = marca;
            this.cantidad = cantidad;
        }

        #endregion

        #region GETTERS & SETTERS

        public ConsoleColor Color {
            get { return color; }
        }

        public string Marca
        {
            get { return marca; }
        }

        #endregion


        #region MOSTRAR
        private string Mostrar()
        {
            return "Color: " + this.color.ToString() + ", marca: " + this.marca + ", cantidad: " + this.cantidad.ToString(); 
        }

        public static string Mostrar(Tempera p)
        {
            return p.Mostrar();
        }

        #endregion

        #region SOBRECARGA OPERADORES

        public static bool operator ==(Tempera p1, Tempera p2)
        {
            bool rtn = false;

            if(p1 is not null && p2 is not null)
            {
                rtn = p1.marca == p2.marca && p1.color == p2.color ? true : false;
            }
            else if(p1 is null && p2 is null)
            {
                rtn = true;
            }

            return rtn;

        }
        public static bool operator !=(Tempera p1, Tempera p2)
        {
            bool rtn = false;

            if(p1 is not null && p2 is not null)
            {
                rtn = p1.marca == p2.marca && p1.color == p2.color ? false : true;

            }

            return rtn;
        }

        public static implicit operator int(Tempera p)
        {
            return p.cantidad;
        }

        public static Tempera operator +(Tempera p1, Tempera p2)
        {
            Tempera t = p1;

            if(p1 is not null && p2 is not null)
            {
                return p1 == p2 ? new Tempera(p1.color, p1.marca, p1.cantidad + p2.cantidad) : t;
            }

            return t;
        }

        public static Tempera operator +(Tempera p1, int cant)
        {
            Tempera t = p1;

            if (p1 is not null)
            {
                return new Tempera(p1.color, p1.marca, p1.cantidad + cant);
            }

            return t;
        }



        #endregion
    }
}
