using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Tinta_Biblioteca
{
    public class Tinta
    {
        private ConsoleColor color;
        private ETipoTinta tinta;

        #region CONSTRUCTORES
        public Tinta()
        {
            this.color = ConsoleColor.Black;
            this.tinta = ETipoTinta.Comun;
        }

        public Tinta(ConsoleColor color)
        {
            this.color = color;
        }

        public Tinta(ConsoleColor color, ETipoTinta tinta) : this(color)
        {
            this.tinta = tinta;
        }

        #endregion

        #region MOSTRAR
        private string Mostrar()
        {
            return (string)this;
        }

        public static string Mostrar(Tinta t)
        {
            return t.Mostrar();
        }

        #endregion

        #region OPERADORES ==

        public static bool operator ==(Tinta t1, Tinta t2)
        {
            return t1.color == t2.color && t1.tinta == t2.tinta ? true : false;
        }

        #endregion

        #region OPERADORES !=
        public static bool operator !=(Tinta t1, Tinta t2)
        {
            return t1.color == t2.color && t1.tinta == t2.tinta ? false : true;
        }

        #endregion

        #region OPERADORES EXPLICITOS

        public static explicit operator string(Tinta t1)
        {
            return "El tipo de tinta es " + t1.tinta.ToString() + " y el color es " + t1.color.ToString();
        }

        #endregion
    }
}
