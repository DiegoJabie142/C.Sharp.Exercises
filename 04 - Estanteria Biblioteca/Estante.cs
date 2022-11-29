using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04___Estanteria_Biblioteca
{
    public class Estante
    {
        private Producto[] productos;
        private int ubicacionEstante;

        #region CONSTRUCTORES
        private Estante(int capacidad)
        {
            this.productos = new Producto[capacidad];
        }

        public Estante(int capacidad, int ubicacion) : this(capacidad)
        {
            this.ubicacionEstante = ubicacion;
        }

        #endregion

        #region GETTERS & SETTERS
        public Producto[] GetProductos()
        {
            return this.productos;
        }

        #endregion GETTERS & SETTERS

        #region MOSTRAR ESTANTE
        public static string MostrarEstante(Estante e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Estante ubicacion: {e.ubicacionEstante}\n");

            foreach (Producto producto in e.GetProductos())
            {
                if (!Object.ReferenceEquals(producto, null))
                {
                    sb.AppendLine(Producto.MostrarProducto(producto));
                    sb.AppendLine("----------------------");
                }
            }

            return sb.ToString();
        }
        #endregion

        #region OPERADORES ==

        public static bool operator ==(Estante e, Producto p)
        {
            int large = e.productos.Length;

            bool rtn = false;

            for (int i = 0; i < large; i++)
            {
                if (e.productos[i] == p)
                {
                    rtn = true;
                    break;
                }
            }

            return rtn;
        }

        #endregion

        #region OPERADORES !=

        public static bool operator !=(Estante e, Producto p)
        {
            return !(e == p);
        }

        #endregion

        #region OPERADORES +

        public static bool operator +(Estante e, Producto p)
        {

            bool rtn = false;

            if (e != p)
            {
                for (int i = 0; i < e.productos.Length; i++)
                {
                    if (e.productos[i] is null)
                    {
                        e.productos[i] = p;
                        rtn = true;
                        break;
                    }
                }
            }

            return rtn;
        }

        #endregion

        #region OPERADORES -
        public static Estante operator -(Estante e, Producto p)
        {

            for (int i = 0; i < e.productos.Length; i++)
            {
                if (e.productos[i] == p)
                {
                    e.productos[i] = null;
                    break;
                }
            }
            return e;
        }

        #endregion

    }

}
