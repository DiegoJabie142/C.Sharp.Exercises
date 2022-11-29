using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Dolar
    {
        private double cantidad;
        private static double cotzRespectoDolar;

        #region CONSTRUCTORES

        static Dolar()
        {
            cotzRespectoDolar = 1;
        }

        public Dolar(double cantidad)
        {
            this.cantidad = cantidad;
        }
        #endregion

        #region OPERADORES EURO & PESO
        public static explicit operator Euro(Dolar d)
        {
            return new Euro(d.Cantidad / Euro.CotzRespectoDolar);
        }

        public static explicit operator Peso(Dolar d)
        {
            return new Peso(d.Cantidad / Peso.CotzRespectoDolar);
        }

        #endregion

        #region GETTERS & SETTERS
        public double Cantidad
        {
            get { return this.cantidad; }
        }

        public double Cotizacion
        {
            get { return Dolar.cotzRespectoDolar; }
        }
        #endregion  

        #region OPERADOR IMPLICITO

        public static implicit operator Dolar(double d)
        {
            return new Dolar(d);
        }

        #endregion

        #region OPERADORES !=

        public static bool operator !=(Dolar d, Euro e)
        {
            return !d.Cantidad.Equals(e.Cantidad);
        }

        public static bool operator !=(Dolar d, Peso p)
        {
            return !d.Cantidad.Equals(p.Cantidad);
        }

        public static bool operator !=(Dolar d1, Dolar d2)
        {
            return !d1.cantidad.Equals(d2.cantidad);
        }

        #endregion

        #region OPERADORES ==
        public static bool operator ==(Dolar d, Euro e)
        {
            return d.Cantidad.Equals(e.Cantidad);
        }

        public static bool operator ==(Dolar d, Peso p)
        {
            return d.Cantidad.Equals(p.Cantidad);
        }

        public static bool operator ==(Dolar d1, Dolar d2)
        {
            return !d1.cantidad.Equals(d2.cantidad);
        }

        #endregion

        #region OPERADORES -

        public static Dolar operator -(Dolar d, Euro e)
        {
            return new Dolar(d.Cantidad - ((Dolar)e).Cantidad);
        }

        public static Dolar operator -(Dolar d, Peso p)
        {
            return new Dolar(d.Cantidad - ((Dolar)p).Cantidad);
        }

        public static Dolar operator -(Dolar d1, Dolar d2)
        {
            return new Dolar(d1.Cantidad - d2.Cantidad);
        }

        #endregion

        #region OPERADORES +
        public static Dolar operator +(Dolar d, Euro e)
        {
            return new Dolar(d.Cantidad + ((Dolar)e).Cantidad);
        }
        public static Dolar operator +(Dolar d, Peso p)
        {
            return new Dolar(d.Cantidad + ((Dolar)p).Cantidad);
        }
        public static Dolar operator +(Dolar d1, Dolar d2)
        {
            return new Dolar(d1.Cantidad + d2.Cantidad);
        }

        #endregion

    }
}
