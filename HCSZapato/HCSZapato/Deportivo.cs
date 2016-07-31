using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCSZapato
{
    public class Deportivo:Zapato
    {
        private string deporte;

        public void setDeporte(string d)
        {
            deporte = d;
        }

        public string getDeporte()
        {
            return deporte;
        }
    }
}
