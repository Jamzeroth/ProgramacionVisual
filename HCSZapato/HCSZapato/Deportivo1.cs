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
    public partial class Deportivo1 : Form
    {
        Deportivo D1 = new Deportivo();
        public Deportivo1()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            D1.setMarca(txtMarca.Text);
            D1.setTalla(Int32.Parse(txtTalla.Text));
            D1.setDeporte(txtDeporte.Text);
            txtMarca.Text = "";
            txtTalla.Text = "";
            txtDeporte.Text = "";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            txtMarca.Text = D1.getMarca();
            txtTalla.Text = D1.getTalla().ToString();
            txtDeporte.Text = D1.getDeporte();
        }
    }
}
