using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;


namespace fr.Menu
{
    public partial class cadastro : Form
    {
        bool preencheu;

        string caminho = @"C:\fr.workMenu\fr.workMenu\fr.Menu\fr.Menu\cadastros.txt";
        public cadastro()
        {
            InitializeComponent();
            tSenha.PasswordChar = '*';           
        }

        private void bLimpar_Click(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox || c is MaskedTextBox)
                {
                    c.Text = "";
                }
            }
            tNome.Focus();
        }

        private void bEnviar_Click(object sender, EventArgs e)
        {
            string email = tEmail.Text;
            string padraoEmail = @"^[^@\s]+@[^@\s]+.[^@\s]+$";
            bool emailpreenchido = true;
            preencheu = true;
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    if (string.IsNullOrEmpty(c.Text) || !Regex.IsMatch(email, padraoEmail))
                    {
                        if (!Regex.IsMatch(email, padraoEmail))
                        {
                            emailpreenchido = false;
                        }
                        preencheu = false;
                        break;
                    }
                }
            }
            if (!emailpreenchido)
            {
                MessageBox.Show("Email inálido !", "Ops!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                if (preencheu == false)
                {
                    MessageBox.Show("Parece que você não preencheu todos os dados !", "Ops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tNome.Focus();
                }
                else
                {
                    System.IO.StreamWriter bulldog = new System.IO.StreamWriter(caminho, true); //true --> +=; false --> =

                    string[] array = new string[] {
                    tNome.Text, tNumero.Text, tEmail.Text, tSenha.Text
                };

                    bulldog.WriteLine(string.Join(";", array));
                    bulldog.Close();

                    MessageBox.Show("Seu cadastro foi concluído com sucesso!", "Cadastro concluído", MessageBoxButtons.OK);
                    this.Hide();
                }
            }
        }

        private void tNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if(!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != ' ')
            //{
            //    e.Handled = true;
            //}
        }

        private void tNumCartao_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != ' ')
            {
                e.Handled= true;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                tSenha.PasswordChar = '\0';
            }
            else
            {
                tSenha.PasswordChar = '*';
            }
        }
        private void checkBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !checkBox1.Checked)
            {
                e.Handled = true;
                checkBox1.Checked = true;
            } else
            {
                checkBox1.Checked = false;
            }
        }

        private void bttVoltar_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
        }
    }
}
