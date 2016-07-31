using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaCSharp
{
    public class Profesor: Persona  
    {
        private String Especialidad;

        public void setEspecialidad(String val)
        {
            Especialidad = val;
        }

        public String getEspecialidad()
        {
            return Especialidad;
        }
    }
}
