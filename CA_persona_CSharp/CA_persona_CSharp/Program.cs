using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_persona_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona persona1 = new Persona();
            Console.WriteLine("Persona: " + persona1.getNombre());

            Persona persona2 = new Persona("Juan Cajas");
            Console.WriteLine(persona2.getNombre());

            Console.WriteLine();
            Materia materia1 = new Materia();
            materia1.setNombre("Calculo 1");
            materia1.setCodigo("1");
            materia1.setCreditos(6);
            Console.WriteLine("Materia Nombre: " + materia1.getNombre());
            Console.WriteLine("Materia Codigo: " + materia1.getCodigo());
            Console.WriteLine("Materia Creditos: " + materia1.getCreditos());
            Console.ReadKey();
        }
    }
}
