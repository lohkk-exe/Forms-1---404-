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
    public partial class cat : Form
    {
        //xd
        //:3
        //:o
        //UwU
        //-_-
        //.0.
        //>.<
        //o0o
        //:P
        //>w<
        //DX
        //:D
        //(:
        //:]
        //:-(
        //-0-
        //;-;
        //0-0
        //>:(
        public cat()
        {
            InitializeComponent();
            timer1.Interval = 1000;
            timer1.Start();
            SoundPlayer player = new SoundPlayer(Properties.Resources.Bling);
            player.Play();
        }

        private void cat_Load(object sender, EventArgs e)
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
