using System;
using System.Text;

namespace Ingresante
{
    public class Ingresante
    {
        private string[] cursos;
        private string direccion;
        private int edad;
        private string genero;
        private string nombre;
        private string pais;

        public Ingresante(string nombre, string direccion, string genero, string pais, string[] cursos, int edad)
        {
            this.cursos = cursos;
            this.direccion = direccion;
            this.edad = edad;
            this.genero = genero;
            this.nombre = nombre;
            this.pais = pais;
        }
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            
            sb.AppendLine("Nombre: " + this.nombre);
            sb.AppendLine("Dirección: " + this.direccion);
            sb.AppendLine("Edad: " + this.edad);
            sb.AppendLine("Género: " + this.genero);
            sb.AppendLine("País: " + this.pais);
            sb.AppendLine("Curso/s: ");
           
            foreach (string curso in this.cursos)
            {
                if (!string.IsNullOrEmpty(curso))
                {

                    sb.AppendLine(curso);
                }
            }

            return sb.ToString();
        }
    }
}
