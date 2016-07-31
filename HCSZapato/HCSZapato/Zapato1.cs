using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HCSZapato
{
    public partial class Zapato1 : Form
    {
        Zapato Z1 = new Zapato();

        public Zapato1()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Z1.setMarca(txtMarca.Text);
            Z1.setTalla(Int32.Parse(txtTalla.Text));
            txtMarca.Text = "";
            txtTalla.Text = "";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            txtMarca.Text = Z1.getMarca();
            txtTalla.Text = Z1.getTalla().ToString();
        }
    }
}
