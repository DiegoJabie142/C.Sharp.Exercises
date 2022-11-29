using System;

namespace EjercicioClase___Producto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Producto p1 = new Producto(1, "Alfajor", 130, 30);

            int id = (int)p1; // explicita
            string name = p1; // implicita

            Console.WriteLine(id);
            Console.WriteLine(name);
        }
    }
}
