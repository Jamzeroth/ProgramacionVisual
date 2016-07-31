using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolimorfismoAbstraccionCsharp
{
    abstract class Perro
    {
        public virtual String ladrar()
        {
            return "Perro ladrando";
        }

        public abstract String Dormir();
    }
}
