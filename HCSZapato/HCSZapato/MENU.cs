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
    public partial class MENU : Form
    {
        public MENU()
        {
            InitializeComponent();
        }

        private void zapatoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Zapato1 Z1 = new Zapato1();
            Z1.Show();
        }

        private void deportivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Deportivo1 D1 = new Deportivo1();
            D1.Show();
        }

        private void casualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Casual1 C1 = new Casual1();
            C1.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dispose();
        }

    }
}
