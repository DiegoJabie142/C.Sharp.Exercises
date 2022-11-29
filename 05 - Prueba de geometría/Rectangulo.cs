using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05___Prueba_de_geometría
{
    public class Rectangulo
    {
        private float area;
        private float perimetro;
        private Punto vertice1;
        private Punto vertice2;
        private Punto vertice3;
        private Punto vertice4;

        public float Area
        {
            get { return area; }
        }

        public float Perimetro
        {
            get { return perimetro; }
        }

        public Rectangulo(Punto vertice1, Punto vertice3)
        {
            Punto vertice2 = new Punto(vertice3.GetX, vertice1.GetY);
            Punto vertice4 = new Punto(vertice1.GetX, vertice3.GetY);

            this.vertice1 = vertice1;
            this.vertice2 = vertice2;
            this.vertice3 = vertice3;
            this.vertice4 = vertice4;

            float baseRectangulo = Math.Abs(vertice1.GetX - vertice2.GetX);
            float alturaRectangulo = Math.Abs(vertice1.GetY - vertice4.GetY);

            this.area = baseRectangulo * alturaRectangulo;
            this.perimetro = baseRectangulo * 2 + alturaRectangulo * 2;
        }
    }
}
