using Modelos;
using Preguntas;
using System;
using System.Collections.Generic;


namespace MiPrimeraAplicacion
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Persona> personas = new List<Persona>();
            bool finalizarCaptura = false;
            while (!finalizarCaptura)
            {
                Persona nuevaPersona = ManejadorPreguntaPersona.PresentaPreguntas();
                if (nuevaPersona != null)
                {
                    personas.Add(nuevaPersona);
                }
                finalizarCaptura = ManejadorPreguntaPersona.FinalizarCaptura();
            }
            if (personas.Count == 0) 
            {
                Console.WriteLine("No se registró alguna persona");
            }
            for (int i = 0; i < personas.Count; i++) 
            {
                Persona persona = personas[i];
                string textoAMostrar = (i + 1).ToString() + "-" + persona.NombreCompleto;
                Console.WriteLine(textoAMostrar);
            }
            Console.WriteLine("Toda la información guardada dejará de existir cuando se cierre la aplicación");
            Console.ReadLine();
        }
        
    }
}
