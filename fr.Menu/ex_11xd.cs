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

namespace frmsMenu
{
    public partial class ex_11xd : Form
    {
        Size tamTela = Screen.PrimaryScreen.Bounds.Size;
        int ctimer1 = 0;
        int pontos = 0;
        int gatosmortos = 0;
        Label title3 = new Label();
        Label GameOver1 = new Label();
        bool ganhou;
        int ctimer3 = 0;
        int tempo = 30;

        public ex_11xd()
        {
            InitializeComponent();
      

            this.Height = tamTela.Height;
            this.Width = tamTela.Width;

            this.Controls.Add(title3);
            this.Controls.Add(GameOver1);
        }



        private void ex_11xd_Shown(object sender, EventArgs e)
        {
            title1.Visible = true;
            timer1.Start();
            title1.Left = (tamTela.Width - title1.Width) / 2;
            title1.Top = (tamTela.Height / 2) - 200;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (ctimer1 == 0)
            {
                title2.Text = "AGORA TERÁ QUE AJUDAR MATAR OS RATOS\nPARA ESCAPAR";
                title2.BackColor = Color.Transparent;
                title2.Left = (tamTela.Width - title2.Width) / 2;
                title2.Top = (tamTela.Height - title2.Height) / 2;
                title2.TextAlign = ContentAlignment.MiddleCenter;
                title2.Visible = true;
                ctimer1++;
            } else if (ctimer1 == 1)
            {
                title1.Visible = false;
                title2.Visible = false;

                title3.Text = "NÃO MATE OS GATOS";
                title3.BackColor = Color.Transparent;
                title3.AutoSize = true;
                title3.Font = new Font ("Microsof Sans Serif", 48, FontStyle.Bold);
                title3.ForeColor = Color.Red;
                title3.Visible = true;

                title3.Location = new Point(tamTela.Width/2 - title3.Width/2, tamTela.Height/2 - title3.Height/2);
                ctimer1++;


            } else
            {
                title3.Visible = false;

                ComeçarJogo();
                timer1.Stop();
            }
        }

        public void ComeçarJogo()
        {
            //que os jogos comecem !

            Otimer.Start();

            timer2.Start();
            label1.Visible = true;
            label2.Visible = true;
            lblTempo.Text = "Tempo restante: " + tempo;
            label1.Text = "Ratos mortos XP: " + pontos;
            label2.Text = "Gatos mortos XP: " + gatosmortos;
            lblTempo.Visible = true;
            timerGato.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            //timer do rato
            Random k = new Random();
            int xmax = this.ClientSize.Width - rato.Width; // clientsize é o interior da area do forms - sem title bar, etc
            int ymax = this.ClientSize.Height - rato.Height;

            rato.Location = new Point (k.Next(0, xmax), k.Next (0, ymax)); //(de 0 a xmax (vulgo máximo de largura))

            rato.Visible = true;

        }

        private void rato_Click(object sender, EventArgs e)
        {
            pontos += 1;
            rato.Visible = false;
            label1.Text = "Ratos mortos XP: " + pontos;

            explosão.Location = rato.Location;
            if (pontos < 10)
            {
                explosão.Visible = true;
                timerExplosão.Start();
            }
            else
            {
                ganhou = true;
                Final();
            }
        }

        public void Final()
        {
            Otimer.Stop();
            timer2.Stop ();
            timerGato.Stop();

            gato.Visible = false;
            rato.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            lblTempo.Visible = false;

            if (ganhou == true)
            {
                lparabens.Left = (tamTela.Width - lparabens.Width) / 2;
                lparabens.Top = (tamTela.Height - lparabens.Height) / 2 - 100;
                lparabens.Visible = true;
                timerFinal.Start();

            }
            else if (ganhou == false)
            {
                this.BackColor = Color.Black;
                if (gatosmortos == 5)
                GameOverGato(); else
                    GameOverTempo();
            }
        }

        private void timerExplosão_Tick(object sender, EventArgs e)
        {
            timerExplosão.Stop();
            explosão.Visible=false;
        }

        private void timerFinal_Tick(object sender, EventArgs e)
        {
            timerFinal.Stop();

            if (ganhou == true)
            {
                this.Hide();
            }else
            {
                GameOver1.Visible = false;
            }
        }

        private void timerGato_Tick(object sender, EventArgs e)
        {
            //timer do gato
            Random j = new Random();
            int gxmax = this.ClientSize.Width - gato.Width;
            int gymax = this.ClientSize.Height - gato.Height;

            gato.Location = new Point(j.Next(0, gxmax), j.Next(0, gymax));

            gato.Visible = true;
        }

        private void gato_Click(object sender, EventArgs e)
        {
            gatosmortos += 1;

            gato.Visible=false;
            label2.Text = "Gatos mortos XP: " + gatosmortos;

            explosão.Location = gato.Location;
            
            if (gatosmortos < 5)
            explosão.Visible = true;
            timerExplosão.Start();

            if (gatosmortos == 5)
            {
                ganhou = false;
                Final();
            }
        }

        private void GameOverGato()
        {
            timer3.Start();
            GameOver1.Text = "VOCÊ MATOU TODOS OS GATOS";
            GameOver1.AutoSize = true;
            GameOver1.Font = new Font("Microsoft Sans Serif", 48, FontStyle.Bold);
            GameOver1.ForeColor = Color.Red;

            GameOver1.Visible = true;

            GameOver1.Location = new Point(tamTela.Width / 2 - GameOver1.Width / 2, tamTela.Height / 2 - 200);
        }

        private void GameOverTempo()
        {
            timer3.Start();
            GameOver1.Text = "VOCÊ NÃO FOI RÁPIDO O SUFICIENTE";
            GameOver1.AutoSize = true;
            GameOver1.Font = new Font("Microsoft Sans Serif", 48, FontStyle.Bold);
            GameOver1.ForeColor = Color.Red;

            GameOver1.Visible = true;

            GameOver1.Location = new Point(tamTela.Width / 2 - GameOver1.Width / 2, tamTela.Height/2 - 200);
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (ctimer3 == 0)
            {
                GameOver1.Text += "\nAGORA OS RATOS\nDOMINARÃO O MUNDO";
                ctimer3++;
            }
            else if (ctimer3 == 1)
            {
                GameOver1.Text = "GAME OVER";
                GameOver1.Location = new Point(tamTela.Width / 2 - GameOver1.Width/2, tamTela.Height / 2 - 200);
                ctimer3++;
            }
            else
            {
                bttTentar.Location = new Point(tamTela.Width / 2 - bttTentar.Width/2, GameOver1.Location.Y + 200);
                bttTentar.Visible = true;
                bttTentar.Focus();
                timer3.Stop();
            }
        }

        private void bttTentar_Click(object sender, EventArgs e)
        {
            tempo = 30;
            ctimer1 = 0;
            pontos = 0;
            gatosmortos = 0;
            ctimer3 = 0;
            GameOver1.Visible = false;
            bttTentar.Visible=false;
            this.BackColor = Color.White;
            //this.OnShown(EventArgs.Empty);
            ComeçarJogo();
        }

        private void Otimer_Tick(object sender, EventArgs e)
        {
            tempo--;
            lblTempo.Text = "Tempo restante: " + tempo;
            if (tempo == -1)
            {
                ganhou = false;
                Final();
            }
        }

        private void ex_11xd_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
            }
        }

    }
}
