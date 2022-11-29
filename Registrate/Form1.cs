using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registrate
{
    using Ingresante;
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listCountrys.Text = "Argentina";
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string nombre = txtName.Text;
            string direccion = txtAdress.Text;
            int edad = (int)numericAges.Value;
            string pais = listCountrys.Text;
            string genero;
            string[] cursos = new string[3];

            #region IFS PARA GENERO

            if (rdBtnMasculino.Checked == true)
            {
                genero = rdBtnMasculino.Text;
            }
            else if (rdBtnFemenino.Checked == true)
            {
                genero = rdBtnFemenino.Text;
            }
            else
            {
                genero = rdBtnNoBinario.Text;
            }
            #endregion

            #region IFS PARA CURSOS

            int j = 0;

            if (chBxCSharp.Checked == true)
            {
                cursos[j] = chBxCSharp.Text;
                j++;
            }
            if (chBxCPlusPlus.Checked == true)
            {
                cursos[j] = chBxCPlusPlus.Text;
                j++;
            }
            if (chBxJavaScript.Checked == true)
            {
                cursos[j] = chBxJavaScript.Text;
            }

            #endregion

            // EN ESTA LINEA YA ESTA CARGADO EL GENERO Y LOS CURSOS
            Ingresante ingresante = new Ingresante(nombre, direccion, genero, pais, cursos, edad);

            MessageBox.Show(ingresante.Mostrar());
        }
    }
}
