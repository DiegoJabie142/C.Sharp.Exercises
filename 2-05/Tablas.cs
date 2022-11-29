using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_05
{
    internal class Tablas
    {
        public static StringBuilder devolverTabla(int numero){

            StringBuilder sb = new StringBuilder();
            
            String aux = "La tabla de multiplicar del número " + numero.ToString() + ":\n";
            
            sb.Append(aux);

            for(int i = 1; i <= 9; i++)
            {
                int resultado = numero * i;
                aux = numero.ToString() + " x " + i.ToString() + " = " + resultado.ToString() + "\n";
                sb.Append(aux);
            }

            return sb;
        }
    }
}
