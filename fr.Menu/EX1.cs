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
    public partial class EX1 : Form
    {
        public EX1()
        {
            InitializeComponent();
            txtBnum1.Focus();
            SoundPlayer player = new SoundPlayer(Properties.Resources.Bling);
            player.Play();
        }

        private void bttCalcular_Click(object sender, EventArgs e)
        {
            Calcular(); 
        }

        private void txtBnum3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.OemPeriod || e.KeyCode == Keys.Decimal)
            {
                e.SuppressKeyPress = true;
            }

            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                Calcular();
            }
        }

        private void bttLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
            txtBnum1.Focus();
        }

        private void Calcular()
        {
            try
            {
                lblRes.Text = "A média é: " + ((Convert.ToDecimal(txtBnum1.Text) + Convert.ToDecimal(txtBnum2.Text) + Convert.ToDecimal(txtBnum3.Text)) / 3).ToString("F2");
                bttLimpar.Focus();
            }
            catch (Exception)
            {
                MessageBox.Show("Digite um número válido!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Limpar();
                txtBnum1.Focus();
            }
        }

        private void Limpar()
        {
            txtBnum1.Clear();
            txtBnum2.Clear();
            txtBnum3.Clear();
            lblRes.Text = "A média é:";
        }

        private void txtBnum2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.OemPeriod || e.KeyCode == Keys.Decimal)
            {
                e.SuppressKeyPress=true;
            }
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                txtBnum3.Focus();
            }
        }

        private void txtBnum1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.OemPeriod || e.KeyCode == Keys.Decimal)
            {
                e.SuppressKeyPress = true;
            }

            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                txtBnum2.Focus();
            }
        }
    }
}
