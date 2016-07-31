using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaCSharp
{
    public class Persona
    {
        private String Nombre;
        private String Telefono;

        public void setNombre(String val)
        {
            Nombre = val;
        }

        public String getNombre()
        {
            return Nombre;
        }

        public void setTelefono(String val)
        {
            Telefono = val;
        }

        public String getTelefono()
        {
            return Telefono;
        }
    }
}
