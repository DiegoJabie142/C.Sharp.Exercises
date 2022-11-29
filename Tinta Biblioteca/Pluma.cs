using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tinta_Biblioteca
{
    public class Pluma
    {

        private string marca;
        private Tinta tinta;
        private int cantidad;

        #region CONSTRUCTORES
        public Pluma()
        {
            this.marca = "Sin marca";
            this.tinta = null;
            this.cantidad = 1;
        }

        public Pluma(string marca) : this()
        {
            this.marca = marca;
        }

        public Pluma(string marca, Tinta t) : this(marca)
        {
            this.tinta = t;
        }

        public Pluma(string marca, Tinta tinta, int cantidad) : this(marca, tinta)
        {
            this.cantidad = cantidad;
        }

        #endregion

        #region MOSTRAR
        private string Mostrar()
        {
            string s = this;
            return s;
        }

        #endregion

        #region OPERADORES ==
        public static bool operator ==(Pluma p, Tinta t)
        {
            return p.tinta == t;
        }

        #endregion

        #region OPERADORES !=
        public static bool operator !=(Pluma p, Tinta t)
        {
            return !(p.tinta == t);
        }

        #endregion

        #region OPERADORES +

        public static Pluma operator +(Pluma p, Tinta t)
        {
            return p == t ? new Pluma(p.marca, p.tinta, ++p.cantidad) : p;
        }

        #endregion

        #region OPERADORES -
        public static Pluma operator -(Pluma p, Tinta t)
        {
            return p == t ? new Pluma(p.marca, p.tinta, --p.cantidad) : p;
        }

        #endregion

        #region OPERADORES IMPLICITOS

        public static implicit operator string(Pluma p)
        {
            string s = "La marca es " + p.marca + "su tinta es: \n" + (string)p.tinta + "\nY tiene una cantidad de " + p.cantidad.ToString();
            
            return s;
        }

        #endregion

    }
}
