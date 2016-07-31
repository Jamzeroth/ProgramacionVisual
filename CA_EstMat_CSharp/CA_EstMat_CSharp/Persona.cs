using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_EstMat_CSharp
{
    class Persona
    {
        private string nombre;

        public Persona()
        {
            nombre = "sin nombre";
        }

        public void setPersona(string nombre1)
        {
            nombre = nombre1;
        }

        public string getNombre()
        {
            return nombre;
        }
    }
}
