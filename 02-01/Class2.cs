using System;

namespace Validador
{
    public static class Validador
    {
        public static bool Validar(int valor, int min, int max)
        {
            return valor <= max && valor >= min ? true : false;
        }
    }
}

