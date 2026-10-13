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
    public partial class EX5 : Form
    {
        double N;
        int c = 0;
        public EX5()
        {
            InitializeComponent();
            SoundPlayer player = new SoundPlayer(Properties.Resources.Bling);
            player.Play();
        }

        private void calculo()
        { 
            // Verificação 
            if (N > 0)
            {
                txtB2.Text = "Positivo(+)!";
                txtB2.ForeColor = Color.White;
                txtB2.BackColor = Color.Green;

            }
            else if (N < 0)
            {
                txtB2.Text = "Negativo(-)!";
                txtB2.ForeColor = Color.White;
                txtB2.BackColor = Color.Red;
            }
            else
            {
                MessageBox.Show("Coloque um número difenrente de 0!!", "Erro de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void limpar()
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is System.Windows.Forms.TextBox txt)
                {
                    txt.Clear();
                }
            }
            c = 0;
            txtB1.Focus();
            txtB2.BackColor = Color.White;
        }

        private void Verificação_Click(object sender, EventArgs e)
        {
            try
            {
                N = Convert.ToDouble(txtB1.Text);
                if (N == 0)
                {
                    //MessageBox.Show("Coloque um número difenrente de 0!!", "Erro de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    errorProvider1.SetError(txtB1, "O número deve ser diferente de 0! >:("); //:3
                    txtB1.Clear();
                    txtB1.Focus();
                }
                else if (c == 0)
                {
                    calculo();
                    c++;
                    Verificação.Text = "Limpar";
                    txtB1.ReadOnly = true;
                    errorProvider1.SetError(txtB1, "");
                }
                else
                {
                    Verificação.Text = "Verificação";
                    limpar();
                    txtB1.ReadOnly = false;
                }
            }
            catch (Exception)
            {
                MessageBox.Show(" ⚠️  Por favor, coloque números!", "Erro de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtB1.Clear();
                txtB1.Focus();
                errorProvider1.SetError(txtB1, "");
            }
        }

        private void txtB1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Verificação.PerformClick();
            }
        }
    }
    
}
