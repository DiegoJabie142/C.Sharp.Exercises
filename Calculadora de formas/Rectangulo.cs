using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_de_formas
{
    public class Rectangulo : Figura
    {
        protected double ladoX;
        protected double ladoY;

        public Rectangulo(double ladoX, double ladoY)
        {
            this.ladoX = ladoX;
            this.ladoY = ladoY;
        }

        public override string Dibujar()
        {
            return "Dibujando Rectángulo...";
        }

        public override double CalcularSuperficie()
        {
            return Math.Round((ladoX * ladoY), 2);
        }

        public override double CalcularPerimetro()
        {
            return Math.Round((2 * ladoX + 2 * ladoY), 2);
        }

    }
}
