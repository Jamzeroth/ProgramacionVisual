using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolimorfismoInterfacesCsharp
{
    class Akita : iPerro
    {
        public string ladrar()
        {
            return "Akita ladrando";
        }

        public string dormir()
        {
            return "Akita durmiendo";
        }
    }
}
