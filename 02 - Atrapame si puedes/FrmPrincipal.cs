using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02___Atrapame_si_puedes
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void richTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                if(txBxLitros.Text.Length <= 0 || txtBxKilometros.Text.Length <= 0)
                {
                    throw new ParametrosVaciosException();
                }

                int n = int.Parse(txtBxKilometros.Text);
                int n2 = int.Parse(txBxLitros.Text);

                int r = Calculador.Calcular(n, n2);

                rchTxBxResultados.Text += $"La gasolina rinde {r} litros por kilometro.";
            }
            catch (ParametrosVaciosException exc)
            {
                MessageBox.Show(exc.Message);
            }
            catch (DivideByZeroException exc)
            {
                MessageBox.Show(exc.Message);
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
    }

    public class ParametrosVaciosException : Exception
    {
        public ParametrosVaciosException() : base("Excepción provocada, existe algún campo vacío.")
        {

        }
    }

    public static class Calculador
    {
        public static int Calcular(int n, int n2)
        {
            int k = n / n2;

            return k;
        }
    }
}
