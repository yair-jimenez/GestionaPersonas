using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesParaManejarLaConsola
{
    public class ManejadorDePreguntas
    {
        public static bool PreguntaSiNo(string pregunta)
        {
            string preguntaPorSiONo = pregunta + " presiona 1 para aceptar, 0 para cancelar";
            int respuestaNum = PedirRespuestaNumericaHastaQueEstaNoSeaVacia(preguntaPorSiONo);
            if (respuestaNum != 0 && respuestaNum != 1)
                PreguntaSiNo(pregunta);
            bool respuesta = respuestaNum == 1;
            return respuesta;
        }
        public static string PedirRespuestaHastaQueEstaNoSeaVacia(string pregunta)
        {
            string respuestaAsolicitud = RepetirPreguntaHastaQueSeEspecifiqueUnValor(pregunta);
            return respuestaAsolicitud;
        }
        public static int PedirRespuestaNumericaHastaQueEstaNoSeaVacia(string pregunta)
        {
            int respuestaAsolicitud = RepetirPreguntaHastaQueSeEspecifiqueUnValorNumerico(pregunta);
            return respuestaAsolicitud;
        }
        private static string RepetirPreguntaHastaQueSeEspecifiqueUnValor(string peticion)
        {
            Console.WriteLine(peticion);
            string respuestaDelUsuarioDesdeConsola = Console.ReadLine();
            if (respuestaDelUsuarioDesdeConsola.Trim().Length == 0)
            {
                RepetirPreguntaHastaQueSeEspecifiqueUnValor(peticion);
            }
            return respuestaDelUsuarioDesdeConsola;
        }
        private static int RepetirPreguntaHastaQueSeEspecifiqueUnValorNumerico(string peticion)
        {
            int respuestaNumerica = -1;
            Console.WriteLine(peticion);
            string respuestaDelUsuarioDesdeConsola = Console.ReadLine();
            if (respuestaDelUsuarioDesdeConsola.Trim().Length == 0)
            {
                RepetirPreguntaHastaQueSeEspecifiqueUnValorNumerico(peticion);
            }
            else
            {

                if (int.TryParse(respuestaDelUsuarioDesdeConsola, out respuestaNumerica) == false)
                {
                    RepetirPreguntaHastaQueSeEspecifiqueUnValorNumerico(peticion);
                }
            }
            return respuestaNumerica;
        }
    }
}
