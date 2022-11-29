using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FrmAltaModificacion;

namespace frmNotePad
{
    using FrmAltaModificacion;
    public partial class frmNotePad : Form
    {
        public frmNotePad()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmAltaModificacion frm = new FrmAltaModificacion();

            frm.ShowDialog();
        }
    }
}
