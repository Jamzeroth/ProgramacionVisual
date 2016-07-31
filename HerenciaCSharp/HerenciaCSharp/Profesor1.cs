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
    public partial class Profesor1 : Form
    {
        Profesor P1 = new Profesor();
        public Profesor1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            P1.setNombre(txtNombre.Text);
            P1.setTelefono(txtTelefono.Text);
            P1.setEspecialidad(txtEspecialidad.Text);
            txtNombre.Text = "";
            txtTelefono.Text = "";
            txtEspecialidad.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtNombre.Text = P1.getNombre();
            txtTelefono.Text = P1.getTelefono();
            txtEspecialidad.Text = P1.getEspecialidad();
        }

    }
}
