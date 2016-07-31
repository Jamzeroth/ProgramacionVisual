using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolimorfismoAbstraccionCsharp
{
    class Bulldog : Perro
    {
        public override String ladrar()
        {
            return "bulldod ladrando";
        }

        public override String Dormir()
        {
            return "bulldog durmiendo";
        }
    }
}
