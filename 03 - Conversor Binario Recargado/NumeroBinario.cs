using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2_03;

namespace _03___Conversor_Binario_Recargado
{
    public class NumeroBinario
    {
        public string numero;

        private NumeroBinario(string numero)
        {
            this.numero = numero;
        }
        
        public static string operator +(NumeroBinario nb, NumeroDecimal nd)
        {
            int ndAux = Conversor.ConvertirBinarioADecimal(int.Parse(nb.numero));

            ndAux += (int)nd.numero;

            return Conversor.ConvertirDecimalABinario(ndAux);
        }

        public static string operator -(NumeroBinario nb, NumeroDecimal nd)
        {
            int ndAux = Conversor.ConvertirBinarioADecimal(int.Parse(nb.numero));

            ndAux -= (int)nd.numero;

            return Conversor.ConvertirDecimalABinario(ndAux);
        }

        public static bool operator ==(NumeroBinario nb, NumeroDecimal nd)
        {
            string aux = Conversor.ConvertirDecimalABinario((int)nd.numero);

            return nd.Equals(aux) ? true : false;
        }

        public static bool operator !=(NumeroBinario nb, NumeroDecimal nd)
        {
            string aux = Conversor.ConvertirDecimalABinario((int)nd.numero);

            return nd.Equals(aux) ? false : true;
        }
    }
}
