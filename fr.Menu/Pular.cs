using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fr.Menu
{
    public partial class Pular : Form
    {
        int acertos = 0;
        int tentativas = 0;
        int cooldown = 30;
        public Pular()
        {
            InitializeComponent();

            foreach (Control control in this.Controls)
            {
                if (control is PictureBox)
                {
                    control.MouseEnter += PictureBox_MouseEnter;
                    control.MouseLeave += PictureBox_MouseLeave;
                }
            }
        }

        private void PictureBox_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }
        private void PictureBox_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void picSI2_Click(object sender, EventArgs e)
        {            
            acertos++;
            picSI2.Enabled = false;
            picSI2.BorderStyle = BorderStyle.FixedSingle;
        }

        private void picSI3_Click(object sender, EventArgs e)
        {
            acertos++;
            picSI3.Enabled = false;
            picSI3.BorderStyle = BorderStyle.FixedSingle;
        }

        private void picSI1_Click(object sender, EventArgs e)
        {
            acertos++;
            picSI1.Enabled = false;
            picSI1.BorderStyle = BorderStyle.FixedSingle;
        }

        private void picNO1_Click(object sender, EventArgs e)
        {
            acertos--;
            picNO1.Enabled = false;
            picNO1.BorderStyle = BorderStyle.FixedSingle;
        }

        private void picNO2_Click(object sender, EventArgs e)
        {
            acertos -= 1;
            picNO2.Enabled = false;
            picNO2.BorderStyle = BorderStyle.FixedSingle;
        }

        private void picNO4_Click(object sender, EventArgs e)
        {
            acertos--;
            picNO4.Enabled = false;
            picNO4.BorderStyle = BorderStyle.FixedSingle;
        }

        private void picSI10_Click(object sender, EventArgs e)
        {
            acertos--;
            picSI10.Enabled = false;
            picSI10.BorderStyle = BorderStyle.FixedSingle;
        }

        private void picSI_Click(object sender, EventArgs e)
        {
            acertos--;
            picSI.Enabled = false;
            picSI.BorderStyle = BorderStyle.FixedSingle;
        }

        private void picNO3_Click(object sender, EventArgs e)
        {
            acertos--;
            picNO3.Enabled = false;
            picNO3.BorderStyle = BorderStyle.FixedSingle;
        }

        private void picNO5_Click(object sender, EventArgs e)
        {
            acertos--;
            picNO5.Enabled = false;
            picNO5.BorderStyle = BorderStyle.FixedSingle;
        }

        private void bttenviar_Click(object sender, EventArgs e)
        {
            if (acertos == 3)
            {
                Menu menu = new Menu();
                menu.Show();
                this.Hide();
            } else
            {
                tentativas++;
                MessageBox.Show("Incorreto!", "Ops !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                acertos = 0;
                
                foreach(Control c in this.Controls)
                {
                    if (c is PictureBox pb)
                    {
                        pb.Enabled = true;
                        pb.BorderStyle = BorderStyle.None;
                    }
                }

                if (tentativas == 3)
                {
                    MessageBox.Show("você excedeu o número de tentativas!", "Ops !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    timer1.Start();
                    bttenviar.Enabled = false;
                    bttvoltar.Enabled = false;
                    label1.Text = "tente de novo em: " + cooldown;
                }
            }
        }

        private void bttvoltar_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void bttLimpar_Click(object sender, EventArgs e)
        {
            acertos = 0;

            foreach (Control c in this.Controls)
            {
                if (c is PictureBox pb)
                {
                    pb.Enabled = true;
                    pb.BorderStyle = BorderStyle.None;
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            cooldown--;
            label1.Text = "tente de novo em: " + cooldown;
            if (cooldown == 0)
            {
                label1.Text = "";
                timer1.Stop();
                bttenviar.Enabled = true;
                cooldown = 30;
                tentativas = 0;
                bttvoltar.Enabled = true;
            }
        }
    }
}
