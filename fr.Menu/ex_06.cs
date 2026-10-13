using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmsMenu
{
    public partial class ex_06 : Form
    {
        BigInteger n;
        BigInteger a;
        BigInteger f;
        int c =0;
        public ex_06()
        {
            InitializeComponent();
            //SoundPlayer player = new SoundPlayer(Properties.Resources.Bling);
            //player.Play();

            toolTip1.SetToolTip(label1, "Fatorial é o produto de determiando\nnúmero com todos os números\nnaturais menores que ele");

            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }


        private void ex_06_Shown(object sender, EventArgs e)
        {
            bttCalcular.Focus();
        }


        private void bttCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                if (c == 0)
                {
                    n = Convert.ToInt64(lblRes.Text);
                    if (n < 0)
                    {
                        MessageBox.Show("Número negativos não possuem fatorial!", "Ops!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (n <= 1)
                    {
                        f = 1;
                        lblRes.Text = "" + f;
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

                        if (f.ToString().Length > 11)
                        lblRes.Text = f.ToString("E");
                        else {
                            lblRes.Text = f.ToString();
                        }
                    }

                    c++;
                    bttLimpar.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Digite um número válido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ex_06_HelpButtonClicked(object sender, CancelEventArgs e)
        {
            MessageBox.Show("O fatorial de um número é o produto dele com todos os números naturais menores", "O que é fatorial?", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void bttLimpar_Click(object sender, EventArgs e)
        {
            lblRes.Text = "";
            bttCalcular.Focus();
            c = 0;
        }

        private void ex_06_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (c == 0) {
                switch (e.KeyChar)
                {
                    case '1':
                        btt1.PerformClick();
                        break;
                    case '2':
                        btt2.PerformClick();
                        break;
                    case '3':
                        btt3.PerformClick();
                        break;
                    case '4':
                        btt4.PerformClick();
                        break;
                    case '5':
                        btt5.PerformClick();
                        break;
                    case '6':
                        btt6.PerformClick();
                        break;
                    case '7':
                        btt7.PerformClick();
                        break;
                    case '8':
                        btt8.PerformClick();
                        break;
                    case '9':
                        btt9.PerformClick();
                        break;
                    case '0':
                        btt0.PerformClick();
                        break;
                    case '\b': //\b == backspace
                        lblRes.Text = lblRes.Text.Substring(0, lblRes.Text.Length - 1);
                        break;
                }
            }
        }
        
        private void btt1_Click(object sender, EventArgs e)
        {
            if ( c == 0) lblRes.Text += "1";
        }

        private void btt2_Click(object sender, EventArgs e)
        {
            if (c == 0) lblRes.Text += "2";
        }

        private void btt3_Click(object sender, EventArgs e)
        {
            if (c == 0) lblRes.Text += "3";
        }

        private void btt4_Click(object sender, EventArgs e)
        {
            if (c == 0) lblRes.Text += "4";
        }

        private void btt5_Click(object sender, EventArgs e)
        {
            if (c == 0) lblRes.Text += "5";
        }

        private void btt6_Click(object sender, EventArgs e)
        {
            if (c == 0) lblRes.Text += "6";
        }
        private void btt7_Click(object sender, EventArgs e)
        {
            if (c == 0) lblRes.Text += "7";
        }

        private void btt8_Click(object sender, EventArgs e)
        {
            if (c == 0) lblRes.Text += "8";
        }

        private void btt9_Click(object sender, EventArgs e)
        {
            if (c == 0) lblRes.Text += "9";
        }

        private void btt0_Click(object sender, EventArgs e)
        {
            if (c == 0) lblRes.Text += "0";
        }

        
    }
}
