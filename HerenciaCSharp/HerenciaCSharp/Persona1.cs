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
    public partial class Persona1 : Form
    {
        Persona P1 = new Persona();

        public Persona1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            P1.setNombre(txtNombre.Text);
            P1.setTelefono(txtTelefono.Text);
            txtNombre.Text = "";
            txtTelefono.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtNombre.Text = P1.getNombre();
            txtTelefono.Text = P1.getTelefono();
        }
    }
}
