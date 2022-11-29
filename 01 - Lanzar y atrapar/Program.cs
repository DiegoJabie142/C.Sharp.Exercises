using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;

namespace _01___Lanzar_y_atrapar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MiClase miClase = new MiClase();
        }
    }

    internal class UnaExcepcion : Exception
    {

    }

    public class MiExcepcion : Exception
    {

    }

    public class MiClase
    {
        public static void DividirPorZero()
        {
            int numero = 10;
            numero /= 0;
            
        }

        public MiClase()
        {
            try
            {
                MiClase.DividirPorZero();
            }
            catch (DivideByZeroException e)
            {
                throw new DivideByZeroException();
            }
        }

        public MiClase(DivideByZeroException inner)
        {
            
        }
    }
}
