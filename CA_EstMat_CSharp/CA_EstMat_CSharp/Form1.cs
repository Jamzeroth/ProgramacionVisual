using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CA_EstMat_CSharp
{
    public partial class Form1 : Form
    {
        Persona p1 = new Persona();
        Materia m1 = new Materia();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            p1.setPersona(txtNombreEst.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            m1.setNombre(txtNombreMat.Text);
            m1.setCodigo(txtCod.Text);
            m1.setCreditos(Int32.Parse(txtCre.Text));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lblNombrest.Text = p1.getNombre();
            lblNombremat.Text = m1.getNombre();
            lblCod.Text = m1.getCodigo();
            lblCred.Text = m1.getCreditos().ToString();
        }
    }
}
