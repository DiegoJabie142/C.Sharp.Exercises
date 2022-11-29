using System;
public static class Validador
{
    public static bool Validar(int valor, int min, int max)
    {
        return valor <= max && valor >= min ? true : false;
    }

    public static bool ValidarRespuesta(string respuesta, string entrada)
    {
        return respuesta == entrada ? true : false;
    }
}

