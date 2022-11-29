using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmAltaModificacion
{
    public partial class FrmAltaModificacion : Form
    {
        public string Objeto;
        public FrmAltaModificacion(/*string titulo, string txtObjeto, string txtBtnConfirmar*/)
        {
            InitializeComponent();

            /*this.Text = titulo;
            this.txtObjeto.Text = txtObjeto;
            this.btnConfirmar.Text = txtBtnConfirmar;*/
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (txtObjeto.Text.Length > 0)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {

            }
                
        }

        private void txtObjeto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                this.btnConfirmar_Click(sender, e);
            }
        }
    }
}
