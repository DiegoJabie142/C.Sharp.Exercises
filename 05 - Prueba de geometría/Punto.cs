using System;

namespace _05___Prueba_de_geometría
{
    public class Punto
    {
        private int x;
        private int y;

        public int GetX
        {
            get { return x; }
        }

        public int GetY
        {
            get { return y; }
        }

        public Punto(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
}
