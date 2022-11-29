using System;

namespace Excepciones_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {

            }
            catch
            {

            }
        }

        public class MyException : Exception
        {

            public MyException(string message) : base(message)
            {

            }
            public MyException(string message, Exception inner) : base(inner.Message + "\n" + message, inner)
            {

            }
            public void CrearExcepcion()
            {
                try
                {

                }
                catch(MyException e)
                {

                }
            }
        }
    }
}
