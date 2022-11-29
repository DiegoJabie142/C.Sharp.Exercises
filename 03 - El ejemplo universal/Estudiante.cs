using System;
using System.Text;

namespace _03___El_ejemplo_universal
{
    public class Estudiante
    {
        private string apellido;
        private string legajo;
        private string nombre;
        private int notaPrimerParcial;
        private int notaSegundoParcial;
        private static Random random;

        static Estudiante()
        {
            Estudiante.random = new Random();
        }

        public Estudiante(string nombre, string apellido, string legajo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.legajo = legajo;
        }


        /*public string Apellido {
            get { return apellido; }
            set { apellido = value; }
        }*/

        public void SetNotaPrimerParcial(int notaPrimerParcial)
        {
            this.notaPrimerParcial = notaPrimerParcial;
        }

        public void SetNotaSegundoParcial(int notaSegundoParcial)
        {
            this.notaSegundoParcial = notaSegundoParcial;
        }

        private double CalcularPromedio()
        {
            return (notaPrimerParcial + notaSegundoParcial) / 2;
        }

        public int CalcularNotaFinal()
        {
            int nota = -1;

            if (this.notaPrimerParcial > 3 && this.notaSegundoParcial > 3)
            {
                nota = Estudiante.random.Next(6, 11);
            }

            return nota;
        }
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            string stringMostrar;

            sb.AppendLine(this.nombre + ", " + this.apellido + " legajo: " + this.legajo);
            sb.AppendLine("Nota primer parcial: " + notaPrimerParcial.ToString());
            sb.AppendLine("Nota segundo parcial: " + notaSegundoParcial.ToString());
            sb.AppendLine("Promedio: " + CalcularPromedio().ToString());

            int notaFinal = CalcularNotaFinal();
            if (notaFinal != -1)
            {
                sb.AppendLine("Nota final: " + notaFinal.ToString());
            }
            else
            {
                sb.AppendLine("Alumno desaprobado.");
            }

            stringMostrar = sb.ToString();

            return stringMostrar;
        }

    }
}
