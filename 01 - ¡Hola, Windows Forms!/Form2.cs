using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01____Hola__Windows_Forms_
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public void LblSaludar(string nombre, string apellido, string materia)
        {
            lblSaludo.Text = $"Soy {nombre} {apellido} y mi materia favorita es {materia}";
        }

    }
}
