using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_CSharp
{
    class Persona
    {
        private string nombre;
        private string apellido;
        private int edad;
        private string telefono;

        public Persona()
        {
            nombre = "";
            apellido = "";
            edad = 0;
            telefono = "";
        }

        public void setNombre(string val)
        {
            nombre = val;
        }

        public string getNombre()
        {
            return nombre;
        }
        public void setApellido(string val)
        {
            apellido = val;
        }

        public string getApellido()
        {
            return apellido;
        }
        public void setTelefono(string val)
        {
            telefono = val;
        }

        public string getTelefono()
        {
            return telefono;
        }
        public void setEdad(int val)
        {
            edad = val;
        }

        public int getEdad()
        {
            return edad;
        }
    }
}
