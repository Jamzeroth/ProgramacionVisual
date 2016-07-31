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
    public partial class Casual1 : Form
    {
        Casual C1 = new Casual();
        public Casual1()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            C1.setMarca(txtMarca.Text);
            C1.setTalla(Int32.Parse(txtTalla.Text));
            C1.setEvento(txtEvento.Text);
            txtMarca.Text = "";
            txtTalla.Text = "";
            txtEvento.Text = "";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            txtMarca.Text = C1.getMarca();
            txtTalla.Text = C1.getTalla().ToString();
            txtEvento.Text = C1.getEvento();
        }
    }
}
