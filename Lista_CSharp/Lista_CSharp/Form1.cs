using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lista_CSharp
{
    public partial class Form1 : Form
    {
        int c = 0;
        Persona P1 = new Persona();
        String[,] mat = new String[5, 4];
        List<Persona> ListP= new List<Persona>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            mat[c, 0] = txtNombre.Text;
            mat[c, 1] = txtApe.Text;
            mat[c, 2] = txtEdad.Text;
            mat[c, 3] = txtTlf.Text;
            c++;
            txtNombre.Text = "";
            txtApe.Text = "";
            txtEdad.Text = "";
            txtTlf.Text = "";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Lista.Items.Clear();
            for (int i = 0; i < c; i++)
            {
                P1.setNombre(mat[i, 0]);
                P1.setApellido(mat[i, 1]);
                P1.setEdad(Int32.Parse(mat[i, 2]));
                P1.setTelefono(mat[i, 3]);
                ListP.Add(P1);
                Lista.Items.Add(ListP.ElementAt(i).getNombre()+" "+ListP.ElementAt(i).getApellido()+" "+ListP.ElementAt(i).getEdad().ToString()+" "+ListP.ElementAt(i).getTelefono());
            }
        }
    }
}
