using System;

namespace _02___Vos_cuántas_primaveras_tenés
{
    public class Persona
    {
        public string nombre;
        public string fechaDeNacimiento;
        public int dni;

        public Persona(string nombre, string fechaDeNacimiento, int dni)
        {
            this.nombre = nombre;
            this.fechaDeNacimiento = fechaDeNacimiento;
            this.dni = dni;
        }

        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public void SetFechaDeNacimiento(string fechaDeNacimiento)
        {
            this.fechaDeNacimiento = fechaDeNacimiento;
        }

        public void SetDni(int dni)
        {
            this.dni = dni;
        }

        public int CalcularEdad()
        {
            int anio;
            int mes;
            int dia;

            string[] fecha = new string[3]; 
            
            fecha =  fechaDeNacimiento.Split('/'); // el formato debe ser aaaa/mm/dd

            anio = int.Parse(fecha[0]);
            mes = int.Parse(fecha[1]);
            dia = int.Parse(fecha[2]);

            DateTime nacimiento = new DateTime(anio, mes, dia);
            int edad = DateTime.Today.AddTicks(-nacimiento.Ticks).Year - 1;

            return edad;
        }

        public string Mostrar()
        {
            string stringPersona = nombre + " tiene " + CalcularEdad() + " años, su DNI es " + dni + " y su fecha de nacimiento es " + fechaDeNacimiento;

            return stringPersona;
        }

        public string EsMayorDeEdad()
        {
            string esMayorDeEdad = "Es menor de edad";
           
            if(CalcularEdad() >= 18)
            {
                esMayorDeEdad = "Es mayor de edad";
            }

            return esMayorDeEdad;
        }

    }
}
