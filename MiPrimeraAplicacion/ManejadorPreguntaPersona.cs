
using ClasesParaManejarLaConsola;
using Modelos;

namespace Preguntas
{
    public class ManejadorPreguntaPersona
    {
        public static bool FinalizarCaptura() 
        {
            return ManejadorDePreguntas.PreguntaSiNo("Deseas Finalizar la captura?");
        }
        public static Persona PresentaPreguntas() 
        {
            Persona persona = null;
            string textoParaPreguntarNombreDeLaPersona = "Cual es el nombre de la persona";
            string nombreUsuario = ManejadorDePreguntas.PedirRespuestaHastaQueEstaNoSeaVacia(textoParaPreguntarNombreDeLaPersona);

            string textoParaPreguntarApellidoPDeLaPersona = "Cual es el apellido paterno de la persona";
            string apellidoPaterno = ManejadorDePreguntas.PedirRespuestaHastaQueEstaNoSeaVacia(textoParaPreguntarApellidoPDeLaPersona);

            string textoParaPreguntarApellidoMDeLaPersona = "Cual es el apellido materno de la persona";
            string apellidoMaterno = ManejadorDePreguntas.PedirRespuestaHastaQueEstaNoSeaVacia(textoParaPreguntarApellidoMDeLaPersona);

            string textoParaPreguntarEdad = "Cual es la edad  de la persona";
            int edad = ManejadorDePreguntas.PedirRespuestaNumericaHastaQueEstaNoSeaVacia(textoParaPreguntarEdad);

            string textoParaPreguntarGuardar = "Deseas guardar temporalmente la información hasta que se cierre la aplicación?";

            if (ManejadorDePreguntas.PreguntaSiNo(textoParaPreguntarGuardar))
            {
                persona = new Persona(nombreUsuario, apellidoMaterno, apellidoPaterno, edad);
            }
            return persona;
        }  
    }
}
