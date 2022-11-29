using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_03
{
    public static class Conversor
    {
        public static string ConvertirDecimalABinario(int numeroEntero)
        {
            string auxBinary = "";

            while(numeroEntero > 0)
            {
                if(numeroEntero %2 == 0)
                {
                    auxBinary += "0";
                }
                else
                {
                    auxBinary += "1";   
                }

                numeroEntero /= 2;
            }

            string finalBinaryString = "";

            int large = auxBinary.Length;

            for (int i = large - 1; i >= 0; i--)
            {
                finalBinaryString += auxBinary[i];
            }

            return finalBinaryString;
        }

        public static int ConvertirBinarioADecimal(int numeroEntero)
        {
            string auxNumero = numeroEntero.ToString();

            int numeroDecimal = 0;

            int largo = auxNumero.Length;

            for(int i = 0; i < largo; i++)
            {
                int auxInt = auxNumero[i] - '0';

                numeroDecimal += auxInt * (int)Math.Pow(2, largo-i-1);
            }

            return numeroDecimal;
        }

    }
}
