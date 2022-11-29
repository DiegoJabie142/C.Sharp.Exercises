using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClase___Producto
{
    internal class Producto
    {
        private int id;
        private string nombre;
        private int precio;
        private int stock;

        #region CONSTRUCTORES
        public Producto(int id)
        {
            this.id = id;
            this.nombre = "";
            this.precio = 0;
            this.stock = 0;
        }

        public Producto(int id, string nombre) : this(id)
        {
            this.nombre = nombre;
        }

        public Producto(int id, string nombre, int precio) : this(id, nombre)
        {
            this.precio = precio;
        }

        public Producto(int id, string nombre, int precio, int stock) : this(id, nombre, precio)
        {
            this.stock = stock;
        }

        #endregion

        #region PROPIEDADES
        public int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        public string Nombre
        {
            get {   return this.nombre; }
            set {   this.Nombre = value; }
        }

        public int Precio
        {
            get { return this.precio; }
            set { this.precio = value; }
        }

        public int Stock {
            get {return this.stock; }
            set { this.Stock = value; } 
        }

        #endregion

        #region METODOS

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("El producto " + this.nombre + "tiene un precio de " + precio.ToString() + " y hay un stock de " + this.stock + " productos");

            string rtn = sb.ToString();

            return rtn;
        }

        #endregion

        #region SOBRECARGAS
        public static int operator +(Producto p1, Producto p2)
        {
            return p1.stock * p1.precio + p2.stock * p2.precio;
        }

        public static int operator +(Producto p1, int number)
        {
            return p1.stock + number;
        }

        public static int operator -(Producto p1, int number)
        {
            return p1.stock - number;
        }

        public static int operator -(int number, Producto p1)
        {
            return number - p1.stock ;
        }

        public static bool operator ==(Producto p1, int id)
        {
            return p1.id == id;
        }

        public static bool operator !=(Producto p1, int id)
        {
            return !(p1.id == id);
        }

        public static implicit operator string(Producto p1)
        {
            return p1.nombre;
        }

        public static explicit operator int(Producto p1)
        {
            return p1.precio;
        }

        #endregion
    }
}
