using frmsMenu;
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
    public partial class EX10 : Form
    {
        int num;
        string[] arrayxd = { "infantil", "juvenil", "júnior", "profissional" };
        decimal x;
        int f = 0;
        public EX10()
        {
            InitializeComponent();
            errorProvider1.SetError(label2, "Só são permitidas idades entre 05 e 25 anos XD");
            errorProvider1.SetIconAlignment(label2, ErrorIconAlignment.MiddleLeft);
            errorProvider1.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider1.Icon = SystemIcons.Information;
            SoundPlayer player = new SoundPlayer(Properties.Resources.Bling);
            player.Play();
        }

        private void bCalcular_Click(object sender, EventArgs e)
        {
            try
            {

                if (tNum.Text == "05 a 10")
                {
                    x = 0;
                    MessageBox.Show("A categoria do jogador é: " + arrayxd[(int)x], "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    errorProvider1.BlinkStyle = ErrorBlinkStyle.NeverBlink;
                    errorProvider1.Icon = SystemIcons.Information;
                }
                else if (tNum.Text == "11 a 15")
                {
                    x = 1;
                    MessageBox.Show("A categoria do jogador é: " + arrayxd[(int)x], "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    errorProvider1.BlinkStyle = ErrorBlinkStyle.NeverBlink;
                    errorProvider1.Icon = SystemIcons.Information;
                }
                else if (tNum.Text == "16 a 20")
                {
                    x = 2;
                    MessageBox.Show("A categoria do jogador é: " + arrayxd[(int)x], "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    errorProvider1.BlinkStyle = ErrorBlinkStyle.NeverBlink;
                    errorProvider1.Icon = SystemIcons.Information;
                }
                else if (tNum.Text == "21 a 25")
                {
                    x = 3;
                    MessageBox.Show("A categoria do jogador é: " + arrayxd[(int)x], "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    errorProvider1.BlinkStyle = ErrorBlinkStyle.NeverBlink;
                    errorProvider1.Icon = SystemIcons.Information;
                }
                else
                {
                    num = Convert.ToInt32(tNum.Text);
                    if (num < 5)
                    {
                        MessageBox.Show("Digite um número válido", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        errorProvider1.Icon = SystemIcons.Error;
                        errorProvider1.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;

                    }
                    else
                    {
                        x = (num / 5.0m) - 1;

                        if (num != 5 && x % 1 == 0)
                        {
                            x = x - 1;
                        }



                        MessageBox.Show("A categoria do jogador é: " + arrayxd[(int)x], "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // se converter apeans, sem usar Math.Round, o valor será truncado, não arredondado.
                        errorProvider1.BlinkStyle = ErrorBlinkStyle.NeverBlink;
                        errorProvider1.Icon = SystemIcons.Information;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Digite um número válido", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorProvider1.Icon = SystemIcons.Error;
                errorProvider1.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
            }

            tNum.Text = "";
            tNum.Focus();
        }

        private void tNum_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                bCalcular.PerformClick();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (f == 0)
            {
                ex_11xd ex_11xd = new ex_11xd();
                ex_11xd.Show();
                f++;
            }
        }
    }
}
