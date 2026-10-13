using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace fr.Menu
{
    public partial class Login : Form
    {
        string caminho = @"C:\fr.workMenu\fr.workMenu\fr.Menu\fr.Menu\cadastros.txt";
        public Login()
        {
            InitializeComponent();
            txtBN.Focus(); 
        }

        private void Login_Load(object sender, EventArgs e)
        {
            txtBS.PasswordChar = '*';
        }

        private void Limpar()
        {
            foreach (Control control in this.Controls)
            {
                if (control is System.Windows.Forms.TextBox limpo)
                {
                    limpo.Clear();
                } 
            }

            txtBN.Focus();
        }

        private void Entrar()
        {
            StreamReader rs = new StreamReader(caminho);
            string linha;
            bool login = true;


            while ((linha = rs.ReadLine()) != null)
            {
                string[] partes = linha.Split(';');

                string username = partes[0];
                string senha = partes[3];

                if (txtBN.Text == username && txtBS.Text == senha)
                {                    
                    Pular pular = new Pular();
                    pular.Show();
                    this.Hide();
                    login = true;
                    break;
                } else {
                    login = false;
                }
            }
            if (!login || string.IsNullOrEmpty(txtBN.Text) || string.IsNullOrEmpty(txtBS.Text))
            {
                if (string.IsNullOrEmpty(txtBN.Text) || string.IsNullOrEmpty(txtBS.Text))
                {
                    MessageBox.Show("todos os campos devem ser preenchidos", "Ops !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("usuário ou senha inválido", "Ops !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Limpar();
                }
            }
        }

            //error1.Clear();
            //error2.Clear();

            //bool ErradoUsu = txtBN.Text != "Adim:3";
            //bool SeErro = txtBS.Text != "@mewmew!";

            //if (ErradoUsu && SeErro)
            //{
            //    MessageBox.Show("Os dois estão errados, é você mesmo?", "Erro ao logar",
            //    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}

            //if (ErradoUsu)
            //{
            //    error1.SetError(txtBN, "Usuário incorreto!");
            //    Limpar();
            //}
            //else if (SeErro)
            //{
            //    error2.SetError(txtBS, "Senha incorreta!");
            //    Limpar();
            //}
            //else
            //{
            //    Menu menu = new Menu();
            //    menu.Show();
            //    this.Hide();
            //}
        
      
        private void txtBS_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                Entrar();
            }
        }

        private void check_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                check.Checked = !check.Checked;
            }
        }

        private void bEntrar_Click_1(object sender, EventArgs e)
        {
            Entrar();

        }

        private void txtBN_KeyDown(object sender, KeyEventArgs e)
        {
             if (e.KeyCode == Keys.Enter)
             {
                e.SuppressKeyPress = true;
                txtBS.Focus();
             }
        }
        private void reset_Click(object sender, EventArgs e)
        {
            Limpar();
        }
        private void check_CheckedChanged_1(object sender, EventArgs e)
        {
            txtBS.PasswordChar = check.Checked ? '\0' : '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pular pular = new Pular();
            pular.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cadastro cadastro = new cadastro();
            cadastro.Show();
        }
    }
}
