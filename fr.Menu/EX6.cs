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
    public partial class EX6 : Form
    {

        long n;
        long a;
        long f;
        public EX6()
        {
            InitializeComponent(); 
            mtNum.Focus();

            toolTip1.SetToolTip(label1, "Fatorial é o produto de determiando número com\ntodos os números naturais menores que ele");

            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            SoundPlayer player = new SoundPlayer(Properties.Resources.Bling);
            player.Play();
        }
        
        private void bCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                n = Convert.ToInt64(mtNum.Text);
                if (n < 0)
                {
                    MessageBox.Show("Número negativos não possuem fatorial!", "Ops!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (n <= 1)
                {
                    f = 1;
                    MessageBox.Show("O fatorial de " + n + " é " + f, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    a = n - 1;
                    f = n * a;
                    a--;
                    while (a > 1)
                    {
                        f = f * a;
                        a--;
                    }
                    //DialogResult x =
                    MessageBox.Show("O fatorial de " + n + " é " + f, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    mtNum.Clear();
                    mtNum.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Digite um número válido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bLimpar_Click(object sender, EventArgs e)
        {
            mtNum.Clear();
            mtNum.Focus();
        }

        private void EX6_HelpButtonClicked(object sender, CancelEventArgs e)
        {
            MessageBox.Show("O fatorial de um número é o produto dele com todos os números naturais menores", "O que é fatorial?", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void mtNum_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                bCalcular.PerformClick();
            }
        }
    }
}
