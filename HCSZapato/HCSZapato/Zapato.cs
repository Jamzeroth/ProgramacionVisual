using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCSZapato
{
    public class Zapato
    {
        private string marca;
        private int talla;

        public void setMarca(string m)
        {
            marca = m;
        }
        public string getMarca()
        {
            return marca;
        }
        public void setTalla(int t)
        {
            talla = t;
        }
        public int getTalla()
        {
            return talla;
        }
    }
}
