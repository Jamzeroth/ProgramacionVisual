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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void personaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Persona1 P1 = new Persona1();
                P1.Show();
        }

        private void estudianteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Estudiante1 E1 = new Estudiante1();
            E1.Show();
        }

        private void profesorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Profesor1 P1 = new Profesor1();
            P1.Show();
        }
    }
}
