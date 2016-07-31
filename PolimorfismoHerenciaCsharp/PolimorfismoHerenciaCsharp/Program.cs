using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolimorfismoHerenciaCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Bulldog P1 = new Bulldog();
            Bulldog P2 = new Bulldog();
            Boxer P3 = new Boxer();
            Boxer P4 = new Boxer();
            Perro[] P = { P1, P2, P3, P4 };
            foreach (Perro item in P)
            {
                Console.WriteLine(item.ladrar());
                Console.ReadKey();
            }
        }
    }
}