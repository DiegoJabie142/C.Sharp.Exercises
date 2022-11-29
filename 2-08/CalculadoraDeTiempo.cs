using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_08
{
    internal class CalculadoraDeTiempo
    {
        public static int CalcularDias(int anio, int mes, int dia)
        {

            DateTime t = DateTime.Now;

            DateTime t1 = new DateTime(anio, mes, dia);

            TimeSpan t2 = new TimeSpan();

            t2 = t - t1;

            return t2.Days;
        }
    }
}
