using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolimorfismoInterfacesCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Akita P1 = new Akita();
            Akita P2 = new Akita();
            Bulldog P3 = new Bulldog();
            Bulldog P4 = new Bulldog();
            iPerro[] P = { P1, P2, P3, P4 };
            foreach(iPerro item in P)
            {
                Console.WriteLine(item.ladrar());
                Console.WriteLine(item.dormir());
                Console.ReadKey();
            }
        }
    }
}
