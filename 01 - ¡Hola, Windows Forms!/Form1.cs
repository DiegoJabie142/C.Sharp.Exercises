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
    public partial class Form1 : System.Windows.Forms.Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSaludar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string materia = comboMaterias.Text;

            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(apellido))
            {
                if(string.IsNullOrEmpty(nombre) && string.IsNullOrEmpty(apellido))
                {
                    MessageBox.Show("Se deben completar los siguientes campos:\nNombre\nApellido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);

                }else if (string.IsNullOrEmpty(apellido))
                {
                    MessageBox.Show("Se deben completar los siguientes campos:\nApellido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);

                }
                else
                {
                    MessageBox.Show("Se deben completar los siguientes campos:\nNombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);

                }
            }
            else
            {
                Form2 form2 = new Form2();
                form2.LblSaludar(nombre, apellido, materia);
                form2.ShowDialog();
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboMaterias.Text = "Programación II";
            comboMaterias.Items.Add("Laboratorio de Computación II");
            comboMaterias.Items.Add("Matemática I");
            comboMaterias.Items.Add("Programación I");
            comboMaterias.Items.Add("Laboratorio de Computación I"); 
            comboMaterias.Items.Add("Sistemas de Procesamiento de Datos");
            comboMaterias.Items.Add("Metodología de la Investigación");
            comboMaterias.Items.Add("Inglés II");
            comboMaterias.Items.Add("Inglés I");
            comboMaterias.Items.Add("Estadística");
            comboMaterias.Items.Add("Arquitectura y Sistemas Operativos");
        }
    }
}
