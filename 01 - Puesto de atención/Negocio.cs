using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01___Puesto_de_atención
{
    public class Negocio
    {
        private  PuestoAtencion caja;
        private Queue<Cliente> clientes;
        private string nombre;

        public Cliente Cliente{
            get { return clientes.Dequeue(); }
            set {
                _ = this + value; ;
            }
        }

        public int ClientesPendientes {
            get { return clientes.Count; }
        }

        private Negocio()
        {  
            this.clientes = new Queue<Cliente>();
            this.caja = new PuestoAtencion(Puesto.Caja1);
        }

        public Negocio(string nombre):this ()
        {
            this.nombre = nombre;
        }

        public static bool operator ==(Negocio n, Cliente c)
        {
            bool rtn = false;

            if(n.clientes is not null)
            {
                foreach (Cliente c1 in n.clientes)
                {
                    if (c1 == c)
                    {
                        rtn = true;
                        break;
                    }
                }
            }

            return rtn;
        }

        public static bool operator !=(Negocio n, Cliente c)
        {
            bool rtn = true;

            if (n.clientes is not null)
            {
                foreach (Cliente c1 in n.clientes)
                {
                    if (c1 == c)
                    {
                        rtn = false;
                        break;
                    }
                }
            }

            return rtn;
        }

        public static bool operator ~(Negocio n)
        {
            bool rtn = false;
            
            if(n.ClientesPendientes > 0)
            {
                rtn = n.caja.Atender(n.Cliente);
            }

            return rtn;
        }

        public static bool operator +(Negocio n, Cliente c)
        {
            bool rtn = false;

            if(n != c)
            {
                n.clientes.Enqueue(c);
                rtn = true;
            }

            return rtn;
        }

    }
}
