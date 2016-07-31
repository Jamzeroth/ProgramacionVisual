using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolimorfismoAbstraccionCsharp
{
    class Boxer : Perro
    {
        public override String ladrar()
        {
            return "boxer ladrando";
        }

        public override String Dormir()
        {
            return "boxer durmiendo";
        }
    }
}
