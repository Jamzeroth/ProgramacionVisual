using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaCSharp
{
    public class Estudiante : Persona
    {
        private String Carrera;

        public void setCarrera(String val)
        {
            Carrera = val;
        }
        public String getCarrera()
        {
            return Carrera;
        }
    }
}
