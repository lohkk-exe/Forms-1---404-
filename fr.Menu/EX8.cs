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
    public partial class EX8 : Form
    {
        int atual = 1;
        int ant = 0;
        int c = 1;
        int max;
        public EX8()
        {
            InitializeComponent();
            helpProvider1.SetShowHelp(this, true);
            helpProvider1.SetHelpString(this, "A sequência de fibonacci é uma série numérica onde cada número é composto pela soma dos dois anteriores, começando de 0 e 1.");

            //errorProvider1.Icon = SystemIcons.Information;
            //errorProvider1.SetError(label1, "A sequência de fibonacci é uma série numérica\n onde cada número é composto pela soma dos\n dois anteriores, começando de 0 e 1.");
            //errorProvider1.BlinkStyle = ErrorBlinkStyle.NeverBlink;

            toolTip1.SetToolTip(label1, "A sequência de fibonacci é uma série numérica\nonde cada número é composto pela soma dos\ndois anteriores, começando de 0 e 1.");

            lRes.MaximumSize = new Size(510, 305);

            SoundPlayer player = new SoundPlayer(Properties.Resources.Bling);
            player.Play();
        }

        private void bCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                max = Convert.ToInt32(numSeq.Text);

                if (max < 1)
                {
                    MessageBox.Show("Digite um número válido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    bLimpar.PerformClick();
                }
                else
                {

                    if (c == 1)
                    {
                        if (max == 1)
                        {
                            lRes.Text = "O primeiro número da sequência de fibonacci é:\n " + ant;
                            lRes.Visible = true;
                        }
                        else 
                        { 
                            lRes.Text = "Os primeiros " + max + " números da sequência de fibonacci são:\n " + ant + ", " + atual;
                            lRes.Visible = true;
                            c++;
                        }
                    }
                    while (c < max)
                    {
                        atual = ant + atual; ant = atual - ant;
                        lRes.Text += ", " + atual;
                        c++;
                    }

                    bCalcular.Enabled = false;
                    bLimpar.Focus();
                }
            }
            catch 
            {
                MessageBox.Show("Digite um número válido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                bLimpar.PerformClick();
                numSeq.Focus();
            }
        }

        private void bLimpar_Click(object sender, EventArgs e)
        {
            atual = 1;
            ant = 0;
            c = 1;
            lRes.Text = "";
            numSeq.Clear();
            numSeq.Focus();
            lRes.Visible= false;

            bCalcular.Enabled = true;

        }
        private void EX8_MouseMove(object sender, MouseEventArgs e)
        {
            if (bCalcular.Bounds.Contains(e.Location)) //se o buttton.enalbed-true, qm recebe o evento é o botão, ent n ativa o evento do form
            {
                Cursor = Cursors.No;
            }
            else
            {
                Cursor = Cursors.Default;
            }

            //.bounds == área do botão
            //e.location == posição do mouse
            //contains == se está
            //se o a posição do mouse está na área do botão :3
        }

        private void numSeq_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bCalcular.PerformClick();
                e.SuppressKeyPress = true;
            }
        }
    }
}
