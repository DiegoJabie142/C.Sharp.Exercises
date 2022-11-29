using System;
 public static class Validador
    {
        public static bool Validar(int valor, int min, int max)
        {
            return valor <= max && valor >= min ? true : false;
        }
    public static bool ValidarRespuesta(string respuesta, string entrada)
    {
        bool rtn = false;

        if (respuesta == entrada || respuesta == entrada.ToLower())
        {
            rtn = true;
        }

        return rtn;
    }
}

