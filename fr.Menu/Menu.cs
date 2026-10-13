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
using frmsMenu;

namespace fr.Menu
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();

            this.Size = Screen.PrimaryScreen.Bounds.Size;

            omori omori = new omori();
            omori.MdiParent = this;
            omori.Location = new Point(100, 80);
            omori.Show();

            omoriII omoriII = new omoriII();
            omoriII.MdiParent = this;
            omoriII.Location = new Point(900, 400);
            omoriII.Show();


            DateTime hoje = DateTime.Now;
            SoundPlayer player = new SoundPlayer(Properties.Resources.Windows);
            player.Play();

            SetMdiBackgroundImage(Properties.Resources.windows_xp);
        }
        private void SetMdiBackgroundImage(Image img)
        {
            foreach (Control ctl in this.Controls)
            {
                if (ctl is MdiClient mdiClient)
                {
                    mdiClient.BackgroundImage = img;
                    mdiClient.BackgroundImageLayout = ImageLayout.Stretch;
                    break;
                }
            }
        }


        private void eX1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EX1 EX1 = new EX1();
            EX1.MdiParent = this;
            EX1.Show();
        }

        private void eX2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EX2 EX2 = new EX2();
            EX2.MdiParent = this;
            EX2.Show();
        }

        private void eX3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EX3 EX3 = new EX3();
            EX3.MdiParent = this;
            EX3.Show();
        }

        private void eX4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EX4 EX4 = new EX4();
            EX4.MdiParent = this;
            EX4.Show();
        }

        private void eX5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EX5 EX5 = new EX5();
            EX5.MdiParent = this;
            EX5.Show();
        }

        private void eX6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ex_06 ex_06 = new ex_06();
            ex_06.MdiParent = this;
            ex_06.Show();
        }

        private void eX7ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EX7 EX7 = new EX7();
            EX7.MdiParent = this;
            EX7.Show();
        }

        private void eX8ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EX8 EX8 = new EX8();
            EX8.MdiParent = this;
            EX8.Show();
        }

        private void eX9ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EX9 EX9 = new EX9();
            EX9.MdiParent = this;
            EX9.Show();
        }

        private void eX10ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EX10 EX10 = new EX10();
            EX10.MdiParent = this;
            EX10.Show();
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cadastro cadastro = new cadastro();
            cadastro.MdiParent = this;
            cadastro.Show();
        }

        private void perfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clientes cliente = new clientes();
            cliente.MdiParent = this;
            cliente.Show();
        }

        private void lixeiraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Área em construção, volte depois!", "Fora dos limites!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void gatoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 Form1 = new Form1();
            Form1.MdiParent = this;
            Form1.Show();
        }

        private void deslogarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void fecharAplicaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
