using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Runtime.CompilerServices;

namespace _01___Puesto_de_atención
{

    public class PuestoAtencion
    {
        static private int numeroActual;
        private Puesto puesto;

        public static int NumeroActual {
            get { return ++PuestoAtencion.numeroActual; }
        }

        public bool Atender(Cliente c)
        {
            Console.WriteLine($"\nSe está atendiendo al cliente número {PuestoAtencion.NumeroActual}");
            Thread.Sleep(2000);
            Console.WriteLine("\nSe ha terminado de atender al cliente.\n");
           
            return true;
        }
        static PuestoAtencion()
        {
            numeroActual = 0;
        }

        public PuestoAtencion(Puesto puesto)
        {
            this.puesto = puesto;
        }
    }
}
