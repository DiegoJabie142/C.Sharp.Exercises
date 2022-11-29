using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClaseForm
{
    public partial class Form1 : Form
    {
        private Persona[] personas;
        private int cantidad;
        public Form1()
        {
            InitializeComponent();
            personas = new Persona[10];
            cantidad = 0;
        }

        private void btnform2_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            DialogResult result = form.ShowDialog();

            if (result == DialogResult.OK)
            {
                personas[cantidad] = form.persona;
                cantidad++;
                
            }
            else
            {
                MessageBox.Show("Cancelado.");
            }
        }

        private void btnVer_Click(object sender, EventArgs e)
        {

            this.rTxtVerPersonas.Visible = true;

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < cantidad; i++)
            {
                sb.AppendLine(personas[i].MostrarInfo());
            }

            rTxtVerPersonas.Text = sb.ToString();

        }
    }
}
