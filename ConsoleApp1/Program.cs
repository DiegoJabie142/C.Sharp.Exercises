using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List <PreparadorFisico> preparadores = new List<PreparadorFisico>();
            preparadores.Add(new PreparadorFisico("Juan Perez"));

            List<Tecnico> tecnicos = new List<Tecnico>();
            tecnicos.Add(new Tecnico("Coco Basile"));

            List<Futbolista> jugadores = new List<Futbolista>();
            jugadores.Add(new Futbolista("Marcos", Eposicion.Arquero));
            jugadores.Add(new Futbolista("Marcos", Eposicion.Defensor));
            jugadores.Add(new Futbolista("Marcos", Eposicion.Delantero));

            List<Persona> lista = new List<Persona>();
            lista.AddRange(tecnicos); // add range agrega todos los objetos de la lista
            lista.AddRange(preparadores);
            lista.AddRange(jugadores);

            Persona.EntrenarPlantel(lista);

        }
    }
}
