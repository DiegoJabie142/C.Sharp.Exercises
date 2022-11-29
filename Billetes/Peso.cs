using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{

    public class Peso
    {
        private double cantidad;
        private static double cotzRespectoDolar;

        #region CONSTRUCTORES
        static Peso()
        {
            cotzRespectoDolar = 0.00974184120798830979055041402825;
        }

        public Peso(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Peso(double cantidad, double cotizacion) : this(cantidad)
        {
            Peso.cotzRespectoDolar = cotizacion;
        }

        #endregion

        #region GETTERS & SETTERS
        public double Cantidad
        {
            get { return this.cantidad; }
        }

        public static double CotzRespectoDolar
        {
            get { return Peso.cotzRespectoDolar; }
        }

        #endregion

        #region OPERADORES DOLAR & EURO

        public static explicit operator Dolar(Peso p)
        {
            return new Dolar(p.cantidad * Peso.CotzRespectoDolar);
        }

        public static explicit operator Euro(Peso p)
        {
            return new Euro(p.Cantidad / Peso.cotzRespectoDolar / Euro.CotzRespectoDolar);
        }

        #endregion

        #region OPERADORES !=

        public static bool operator !=(Peso p, Dolar d)
        {
            return !p.cantidad.Equals(d.Cantidad);
        }
        public static bool operator !=(Peso p, Euro e)
        {
            return !p.cantidad.Equals(e.Cantidad);
        }

        public static bool operator !=(Peso p1, Peso p2)
        {
            return !p1.cantidad.Equals(p2.cantidad);
        }

        #endregion

        #region OPERADORES ==
        public static bool operator ==(Peso p, Dolar d)
        {
            return p.cantidad.Equals(d.Cantidad);
        }
        public static bool operator ==(Peso p, Euro e)
        {
            return p.cantidad.Equals(e.Cantidad);
        }
        public static bool operator ==(Peso p1, Peso p2)
        {
            return p1.cantidad.Equals(p2.cantidad);
        }

        #endregion

        #region OPERADORES -
        public static Peso operator -(Peso p, Dolar d)
        {
            return new Peso(p.Cantidad - ((Peso)d).Cantidad);
        }

        public static Peso operator -(Peso p, Euro e)
        {
            return new Peso(p.Cantidad - ((Peso)e).Cantidad);
        }

        public static Peso operator -(Peso p1, Peso p2)
        {
            return new Peso(p1.Cantidad - p2.Cantidad);
        }

        #endregion

        #region OPERADORES +

        public static Peso operator +(Peso p, Dolar d)
        {
            return new Peso(p.Cantidad + ((Peso)d).Cantidad);
        }

        public static Peso operator +(Peso p, Euro e)
        {
            return new Peso(p.Cantidad + ((Peso)e).Cantidad);
        }

        public static Peso operator +(Peso p1, Peso p2)
        {
            return new Peso(p1.Cantidad + p2.Cantidad);
        }

        #endregion

    }
}
