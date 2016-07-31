using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HerenciaCSharp
{
    public partial class Estudiante1 : Form
    {
        Estudiante E1 = new Estudiante();
        public Estudiante1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            E1.setNombre(txtNombre.Text);
            E1.setTelefono(txtTelefono.Text);
            E1.setCarrera(txtCarrera.Text);
            txtNombre.Text = "";
            txtTelefono.Text = "";
            txtCarrera.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtNombre.Text = E1.getNombre();
            txtTelefono.Text = E1.getTelefono();
            txtCarrera.Text = E1.getCarrera();
        }
    }
}
