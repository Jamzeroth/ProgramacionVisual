using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_persona_CSharp
{
    class Materia
    {
        private string codigo;
        private string nombre;
        private int creditos;

        public Materia() { }

        public Materia(string codigo1, string nombre1, int creditos1)
        {
            codigo = codigo1;
            nombre = nombre1;
            creditos = creditos1;
        }

        public void setCodigo(string codigo1)
        {
            codigo = codigo1;
        }

        public void setNombre(string nombre1)
        {
            nombre = nombre1;
        }

        public void setCreditos(int creditos1)
        {
            creditos = creditos1;
        }

        public string getCodigo()
        {
            return codigo;
        }

        public string getNombre()
        {
            return nombre;
        }

        public int getCreditos()
        {
            return creditos;
        }
    }
}
