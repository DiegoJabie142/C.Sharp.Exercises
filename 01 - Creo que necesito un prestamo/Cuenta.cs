using System;

namespace _01___Creo_que_necesito_un_prestamo
{
    public class Cuenta
    {
        public string titular;
        public double cantidad;

        public Cuenta(string titular, double cantidad)
        {
            this.titular = titular;
            this.cantidad = cantidad;
        }

        public string GetTitular()
        {
            return this.titular;
        }

        public double GetCantidad()
        {
            return this.cantidad;
        }

        public string Mostrar()
        {
            string datos = "El titular " + titular + " posee una cantidad de " + cantidad.ToString() + " en su cuenta actualmente.";

            return datos;
        }

        public void Ingresar(double cantidad)
        {
            if(cantidad < 0)
            {
                this.cantidad += cantidad;
            }
        }

        public void Retirar(double cantidad)
        {
            if(cantidad < 0)
            {
                this.cantidad -= cantidad;
            }
        }
    }
}
