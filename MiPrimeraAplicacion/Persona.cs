using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class Persona
    {
        public string Nombre;
        public string ApellidoMaterno;
        public string ApellidoPaterno;
        public int Edad;
        private string _NombreCompleto;
        public string NombreCompleto { get { return _NombreCompleto; }  }
        Persona padre;
        public Persona(string Nombre, string ApellidoMaterno,string ApellidoPaterno, int Edad) 
        {
            this.Nombre = Nombre;
            this.ApellidoMaterno = ApellidoMaterno;
            this.ApellidoPaterno = ApellidoPaterno;
            this.Edad = Edad;
            AsignaNombreCompletoALaVariable();
        }
        private void AsignaNombreCompletoALaVariable()
        {
            _NombreCompleto = Nombre + " " + ApellidoMaterno + " " + ApellidoPaterno;
        }
        private string ObtenerIdentificadorPropioParaEstaPersona() 
        {
            return Nombre + ApellidoMaterno  + ApellidoPaterno + Edad.ToString();
        }
        
       
    }
}
   
