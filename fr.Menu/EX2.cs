using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fr.Menu
{
    public partial class EX2 : Form
    {
        //const string rs = "R$:";
        public EX2()
        {
            InitializeComponent();
            SoundPlayer player = new SoundPlayer(Properties.Resources.Bling);
            player.Play();
        }

        private void Calcular_Click(object sender, EventArgs e)
        {
            try
            {
                decimal P = Convert.ToDecimal(txtB1.Text);
                decimal Q = Convert.ToDecimal(txtB2.Text);

                //Calculo
                decimal total = P * Q;

                //Aparece o total no 3 textbox
                txtB3.Text = total.ToString("C2");

                Limpar.Focus();
            }
            catch (Exception) { MessageBox.Show(">:( número inválido", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Limpar.PerformClick();
                txtB1.Focus();
            }
        }

        private void Limpar_Click(object sender, EventArgs e)
        {
            foreach (Control X in this.Controls)
            {
                if (X is System.Windows.Forms.TextBox txt)
                {
                    txt.Clear();
                }
            }

            txtB1.Focus();
        }

        private void txtB2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.OemPeriod || e.KeyCode == Keys.Decimal)
            {
                e.SuppressKeyPress = true;
            }

            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                Limpar.Focus();
                Calcular.PerformClick();
            }
        }

        private void txtB1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.OemPeriod || e.KeyCode == Keys.Decimal)
            {
                e.SuppressKeyPress = true;
            }

            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                txtB2.Focus();
            }
        }
    }
}
