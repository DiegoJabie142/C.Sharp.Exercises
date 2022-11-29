using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2_03;

namespace _03___Conversor_Binario_Recargado
{
    public class NumeroDecimal
    {
        public double numero;

        private NumeroDecimal(double numero)
        {
            this.numero = numero;
        }

        public static double operator +(NumeroDecimal nd, NumeroBinario nb)
        {
            int integerAux = Conversor.ConvertirBinarioADecimal(int.Parse(nb.numero)) + (int)nd.numero;

            return integerAux;
        }

        public static double operator -(NumeroDecimal nd, NumeroBinario nb)
        {
            int integerAux = Conversor.ConvertirBinarioADecimal(int.Parse(nb.numero))- (int)nd.numero;

            return integerAux;
        }

        public static bool operator ==(NumeroDecimal nd, NumeroBinario nb)
        {
            int integerAux = Conversor.ConvertirBinarioADecimal(int.Parse(nb.numero));

            return integerAux.Equals(nd.numero) ? true : false;
        }

        public static bool operator !=(NumeroDecimal nd, NumeroBinario nb)
        {
            int integerAux = Conversor.ConvertirBinarioADecimal(int.Parse(nb.numero));

            return integerAux.Equals(nd.numero) ? false : true;
        }
    }
}
