using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Euro
    {
        private double cantidad;
        private static double cotzRespectoDolar;

        #region CONSTRUCTORES
        static Euro()
        {
            cotzRespectoDolar = 1.17;
        }
        public Euro(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Euro(double cantidad, double cotizacion) : this(cantidad)
        {
            Euro.cotzRespectoDolar = cotizacion;
        }
        #endregion

        #region GETTERS & SETTERS
        public static double CotzRespectoDolar
        {
            get { return Euro.cotzRespectoDolar; }
        }

        public double Cantidad
        {
            get { return this.cantidad; }
        }

        #endregion

        #region OPERADORES DOLAR & PESO

        public static explicit operator Dolar(Euro e)
        {
            return new Dolar(e.cantidad * Euro.CotzRespectoDolar);
        }

        public static explicit operator Peso(Euro e)
        {
            return new Peso(e.cantidad / Euro.cotzRespectoDolar / Peso.CotzRespectoDolar);
        }

        #endregion

        #region OPERADORES !=

        public static bool operator !=(Euro e, Dolar d)
        {
            return !e.Cantidad.Equals(d.Cantidad);
        }
        public static bool operator !=(Euro e, Peso p)
        {
            return !e.cantidad.Equals(p.Cantidad);
        }
        public static bool operator !=(Euro e1, Euro e2)
        {
            return !e1.Cantidad.Equals(e2.cantidad);
        }

        #endregion

        #region OPERADORES ==

        public static bool operator ==(Euro e, Dolar d)
        {
            return e.Cantidad.Equals(d.Cantidad);
        }
        public static bool operator ==(Euro e, Peso p)
        {
            return !e.cantidad.Equals(p.Cantidad);
        }
        public static bool operator ==(Euro e1, Euro e2)
        {
            return !e1.Cantidad.Equals(e2.cantidad);
        }

        #endregion

        #region OPERADORES -

        public static Euro operator -(Euro e, Dolar d)
        {
            return new Euro(e.Cantidad - ((Euro)d).Cantidad);
        }

        public static Euro operator -(Euro e, Peso p)
        {
            return new Euro(e.Cantidad - ((Euro)p).Cantidad);
        }

        public static Euro operator -(Euro e1, Euro e2)
        {
            return new Euro(e1.Cantidad - e2.Cantidad);
        }

        #endregion

        #region OPERADORES +

        public static Euro operator +(Euro e, Dolar d)
        {
            return new Euro(e.Cantidad + ((Euro)d).Cantidad);
        }

        public static Euro operator +(Euro e, Peso p)
        {
            return new Euro(e.Cantidad + ((Euro)p).Cantidad);
        }

        public static Euro operator +(Euro e1, Euro e2)
        {
            return new Euro(e1.Cantidad + e2.Cantidad);
        }

        #endregion

    }
}
