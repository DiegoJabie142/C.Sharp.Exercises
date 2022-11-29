using System;
using System.Threading;
using Billetes;

namespace _02___Cotizador___Ejecutable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dolar d1 = new Dolar(100);
            Euro e1 = new Euro(100 /Euro.CotzRespectoDolar);
            Peso p1 = new Peso(100 / Peso.CotzRespectoDolar);

            Dolar d2 = new Dolar(50);
            Euro e2 = new Euro(50 / Euro.CotzRespectoDolar);
            Peso p2 = new Peso(50 / Peso.CotzRespectoDolar);

            Console.WriteLine($"User 1 tiene: {d1.Cantidad} de dolares, {e1.Cantidad} de euros, {p1.Cantidad} de pesos");
            Console.WriteLine($"User 2 tiene: {d2.Cantidad} de dolares, {e2.Cantidad} de Euros, {p2.Cantidad} de pesos");
            Console.WriteLine("Resto al User 1, User 2, para obtener user 3.");    

            Dolar d3 = d1 - e2;
            Console.WriteLine($"Luego de restar los dolares del User 1 con los euros del user 2 el User 3 tiene: {d3.Cantidad} dolares");

            Euro e3 = e1 - d2;
            Console.WriteLine($"Luego de restar los euros del User 1 con los dolares del user 2 el User 3 tiene: {e3.Cantidad} euros");

            Peso p3 = p1 - d2;
            Console.WriteLine($"Luego de restar los pesos del User 1 con los dolares del user 2 el User 3 tiene: {p3.Cantidad} pesos");


        }
    }
}
