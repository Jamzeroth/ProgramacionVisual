using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCSZapato
{
    public class Casual:Zapato
    {
        private string evento;

        public void setEvento(string e)
        {
            evento = e;
        }

        public string getEvento()
        {
            return evento;
        }
    }
}
