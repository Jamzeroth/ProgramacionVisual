using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolimorfismoInterfacesCsharp
{
    class Bulldog : iPerro
    {
        public string ladrar()
        {
            return "bulldog ladrando";
        }

        public string dormir()
        {
            return "bulldod durmiendo";
        }
    }
}
