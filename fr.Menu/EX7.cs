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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace fr.Menu
{
    public partial class EX7 : Form
    {
        long[] arrayxd = new long[20];
        int c = 0;

        public EX7()
        {
            InitializeComponent();
            txtNum.Focus();

            label1.MaximumSize = new Size(600, 0);
            SoundPlayer player = new SoundPlayer(Properties.Resources.Bling);
            player.Play();
        }

        private void bttEnviar_Click(object sender, EventArgs e)
        {
            try
            {
                arrayxd[c] = Convert.ToInt64(txtNum.Text);
                c++;
                label1.Text = "Números digitados:\n" + string.Join(", ", arrayxd.Take(c));

                progressBar1.Value += 5;

                if (c == 20)
                {
                    MessageBox.Show("O maior número é: " + arrayxd.Max() + "\nO menor número é: " + arrayxd.Min(), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    bttApagar.Enabled = false;
                    bttEnviar.Enabled = false;
                    txtNum.Enabled = false;
                }
                else
                    label2.Text = "Digite o " + (c + 1) + "º número:";


            }
            catch (Exception)
            {
                if (decimal.TryParse(txtNum.Text, out _))
                {
                    MessageBox.Show("Digite um número inteiro!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }else
                    MessageBox.Show("Digite números!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            txtNum.Clear();
        }

        private void txtNum_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.OemPeriod || e.KeyCode == Keys.Decimal)
            {
                e.SuppressKeyPress = true;
            }

            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                bttEnviar.PerformClick();
            }
        }

        private void bttLimpar_Click(object sender, EventArgs e)
        {
            c = 0;

            Array.Clear(arrayxd, 0, arrayxd.Length);
            bttApagar.Enabled = true;
            bttEnviar.Enabled = true;
            txtNum.Enabled = true;
            label2.Text = "Digite o " + (c + 1) + "º número:";
            //label1.Text = "";
            label1.Text = "";

            txtNum.Focus();

            progressBar1.Value = 0;
        }

        private void bttApagar_Click(object sender, EventArgs e)
        {
            arrayxd[c] = 0;
            c--;
            label1.Text = "Números digitados:\n" + string.Join(", ", arrayxd.Take(c));
            label2.Text = "Digite o " + (c + 1) + "º número:";
            progressBar1.Value -= 5;

            txtNum.Clear();
            txtNum.Focus();
        }
    }
}
