using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculate
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void txtCCNum1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtCCNum2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string n1 = this.txtCCNum1.Text;
            string n2 = this.txtCCNum2.Text;

            if (cmbOperacion.SelectedItem != null)
            {
                string cmbo = cmbOperacion.SelectedItem.ToString();
                txtResultado.Text = Operaciones.Calculo(n1, n2, cmbo);
            }
            else
            {
                txtResultado.Text = "SELECCIONAR OPERACION";
            }
        }

        private void cmbConvertir_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private void cmbConvertir_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnCalConvertir_Click(object sender, EventArgs e)
        {
            string v1 = this.txtVConvertir.Text;
            if (v1 != "")
            {
                //Int64 n1 = Convert.ToInt64(v1);
                if (cmbConvertir.SelectedItem != null)
                {
                    string cmbo = cmbConvertir.SelectedItem.ToString();
                    txtResult.Text = Conversion.Calculo(v1, cmbo);
                }
                else
                {
                    txtResult.Text = "SELECCIONAR TIPO DE CONVERSIÓN";
                }
            }
            else
            {
                txtResult.Text = "INGRESE UN VALOR";
            }
        }
    }
}
