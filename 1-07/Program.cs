using System;

namespace _1_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cantidadEmpleados;
            Console.WriteLine("Ingrese la cantidad de empleados: ");
            cantidadEmpleados = int.Parse(Console.ReadLine());

            float[] valorHora = new float[cantidadEmpleados];
            string[] nombre = new string[cantidadEmpleados];
            int[] añosTrabajados = new int[cantidadEmpleados];
            int[] horasTrabajadas = new int[cantidadEmpleados];
            double[] total = new double[cantidadEmpleados];

         

            for(int i = 0; i < cantidadEmpleados; i++)
            {
                Console.WriteLine("Ingrese el valor hora del empleado {0}: ", i);
                valorHora[i] = float.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese el nombre del empleado {0}", i);
                nombre[i] = Console.ReadLine();

                Console.WriteLine("Ingrese los años trabajados por el empleado {0}", nombre[i]);
                añosTrabajados[i] = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese las horas trabajadas por mes del empleado {0}", nombre[i]);
                horasTrabajadas[i] = int.Parse(Console.ReadLine());

                total[i] = (valorHora[i] * horasTrabajadas[i] + añosTrabajados[i] * 150) * 0.87;
            }


            for(int i = 0; i < cantidadEmpleados; i++)
            {
                Console.WriteLine("El empleado {0} cuenta con una antigüedad de {1} años, un valor hora de {2} y su total a cobrar es del mismo es de {3}", nombre[i], añosTrabajados[i], valorHora[i], total[i]);
            }

        }
    }
}
