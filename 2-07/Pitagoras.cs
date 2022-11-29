using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_07
{
    internal class Pitagoras
    {
        public static double CalcularHipotenusa(double baseTriangulo, double alturaTriangulo)
        {
            return Math.Sqrt(Math.Pow(baseTriangulo, 2) + Math.Pow(alturaTriangulo, 2));
        }
    }
}
