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
    public partial class EX9 : Form
    {

        string[] arrayxd = { "janeiro", "janeiro", "fevereiro", "março", "abril", "maio", "junho", "julho", "agosto", "setembro", "outubro", "novembro", "dezembro" };
        int num;
        public EX9()
        {
            InitializeComponent();
            tNum.Focus();
            SoundPlayer player = new SoundPlayer(Properties.Resources.Bling);
            player.Play();
        }

        private void bConverter_Click(object sender, EventArgs e)
        {
            try
            {
                num = Convert.ToInt32(tNum.Text);
                if (num < 1 || num > 12)
                {
                    MessageBox.Show("O número deve estar entre 1 e 12 ;)", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("O mês equivalente ao número " + num + " é: " + arrayxd[num--], "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch
            {
                MessageBox.Show("Digite um número válido", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            tNum.Clear();
            tNum.Focus();
        }

        private void tNum_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                bConverter.PerformClick();
            }
        }

        private void Apagar_Click(object sender, EventArgs e)
        {
            tNum.Clear();
            tNum.Focus();
        }
    }
}
