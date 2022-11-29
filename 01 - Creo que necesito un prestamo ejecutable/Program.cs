using System;
using _01___Creo_que_necesito_un_prestamo;

namespace _01___Creo_que_necesito_un_prestamo_ejecutable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string titular;
            double cantidad;

            Console.WriteLine("Ingrese el nombre del titular: ");
            titular = Console.ReadLine();

            Console.WriteLine("Ingrese la cantidad que posee en la cuenta: ");
            cantidad = double.Parse(Console.ReadLine());

            Cuenta primerCliente = new Cuenta(titular, cantidad);

            string estadoCuenta = primerCliente.Mostrar();

            Console.WriteLine(estadoCuenta);
        }
    }
}
