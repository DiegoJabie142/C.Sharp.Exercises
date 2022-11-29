using System;
using System.Collections.Generic;

namespace _01___Torneo
{
    public abstract class A
    {
        public abstract string Metodo();

        public virtual string Metodo2()
        {
            return "hola";
        }
    }

    public class B : A
    {
        public override string Metodo()
        {
            return "hola";
        }
    }

    public class C
    {
        public B objeto = new B();

        public string hola;

        public string Hola()
        {
            this.hola = objeto.Metodo();

            return hola;
        }
    }
    


}
