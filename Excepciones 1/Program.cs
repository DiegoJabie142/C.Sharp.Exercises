using System;
using System.Data;

namespace Excepciones_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                CreadorDeExcepciones.Metodo1();
            }
            catch(MyException e)
            {
                Console.WriteLine(e.Mensaje);
            }

        }
    }

    public class MyException : Exception
    {
        public MyException(string message) : base(message)
        {
            
        }

        public MyException(string message, Exception e) : base(e.Message + "\n" + message)
        {
            
        }

        public string Mensaje
        {
            get { return this.Message; }
        }

    }

    public class CreadorDeExcepciones
    {
        public static void Metodo1()
        {
            try
            {
                CreadorDeExcepciones.Metodo2();
            }
            catch(MyException e)
            {
                throw new MyException("Método 1", e);
            }
        }

        public static void Metodo2()
        {
            try
            {
                CreadorDeExcepciones.Metodo3();
            }
            catch (MyException e)
            {
                try
                {
                    throw new MyException("Método 2", e);

                }
                catch(MyException e2)
                {
                    throw new MyException("Método 2 exception 2", e2);
                }
            }
        }

        public static void Metodo3()
        {

            throw new MyException("Método 3");

            /*try
            {
                throw new MyException("Método 3");
            }
            catch(MyException e){ // corto el ciclo con catch
                Console.WriteLine("El ciclo se cortó"); 
            }*/
        }
    }
}
