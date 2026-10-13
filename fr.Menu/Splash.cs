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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace fr.Menu
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
            timer1.Start(); 
            b1.Visible = false;
            txtb2.Visible = false;
            picBox4.Visible = false;
            SoundPlayer player = new SoundPlayer(Properties.Resources.Beep_boop);
            player.Play();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (loading.Value < loading.Maximum)
            {
                loading.Value += 1;
                loading.Refresh();
            }
            else
            {

                timer1.Stop();
                b1 .Visible = true;
                txtb2.Visible = true;
                picBox4.Visible= true;
                loading.Visible = false;
                txtb1.Visible = false;
                SoundPlayer player = new SoundPlayer(Properties.Resources.Select);
                player.Play();

            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cat cat = new cat();
            cat.Show();
            this.Hide();
        }

        private void Splash_Load(object sender, EventArgs e)
        {
        
        }
    }
}
