using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_de_formas
{
    public sealed class Circulo : Figura
    {
        private double radio;

        public Circulo(double radio)
        {
            this.radio = radio;
        }

        public override string Dibujar()
        {
            return "Dibujando Círculo...";
        }

        public override double CalcularSuperficie()
        {
            return Math.Round((radio * radio * Math.PI), 2);
        }

        public override double CalcularPerimetro()
        {
            return Math.Round((2 * radio * Math.PI), 2);
        }
    }
}
