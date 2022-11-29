using System;

namespace Calculadora_de_formas
{
    public abstract class Figura
    {
        public abstract double CalcularSuperficie();

        public abstract double CalcularPerimetro();


        public virtual string Dibujar()
        {
            return "Dibujando forma...";
        }
    }

}
