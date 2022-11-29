using System;
using System.Linq;
using System.Text;

namespace _04___Estanteria_Biblioteca
{
    public class Producto
    {
        private string codigoDeBarra;
        private string marca;
        private float precio;

        #region CONSTRUCTORES

        public Producto(string marca, string codigo, float precio)
        {
            this.marca = marca;
            this.codigoDeBarra = codigo;
            this.precio = precio;
        }

        #endregion

        #region GETTERS & SETTERS
        public string Marca {
            get { return this.marca; }
        }

        public float Precio
        {
            get { return this.precio; }
        }
        #endregion

        #region MOSTRAR
        public static string MostrarProducto(Producto p)
        {
            string rtn = "Marca: " + p.Marca + "\nPrecio: " + (p.precio.ToString());

            return rtn;
        }

        #endregion

        #region OPERADORES !=
        public static bool operator !=(Producto p, string marca)
        {
            return marca.Equals(p.Marca) ? false : true;

        }

        public static bool operator !=(Producto p1, Producto p2)
        {
            return p1.Marca.Equals(p2.Marca) && p1.codigoDeBarra.Equals(p2.codigoDeBarra) ? false : true;
        }

        #endregion

        #region OPERADORES ==
        public static bool operator ==(Producto p, string marca)
        {
            return marca.Equals(p.Marca) ? true : false;
        }

        public static bool operator ==(Producto p1, Producto p2)
        {

            bool rtn = false;

            if (!(p1 is null || p2 is null))
            {
                rtn = (p1.marca == p2.marca && p1.codigoDeBarra == p2.codigoDeBarra);
            }

            return rtn;
        }

        #endregion

        #region OPERADOR EXPLICIT

        public static explicit operator string(Producto p)
        {
            return p.codigoDeBarra;
        }

        #endregion
    }

}
