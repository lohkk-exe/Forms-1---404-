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
    public partial class EX3 : Form
    {
        public EX3()
        {
            InitializeComponent();
            SoundPlayer player = new SoundPlayer(Properties.Resources.Bling);
            player.Play();
        }

        private void Verificar_Click(object sender, EventArgs e)
        {
            Apagar.Focus();
            calcular();
        }

        private void Apagar_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox)
                {
                    ((TextBox)ctrl).Clear();
                }
            }
            txtB1.Focus();
        }

        private void calcular()
        {
            //Pega os valores
            try
            {
                decimal n1 = Convert.ToDecimal(txtB1.Text), //Decimal só é declarada uma vez e as varaveis são separadas por virgulas.
                    n2 = Convert.ToDecimal(txtB2.Text),
                    n3 = Convert.ToDecimal(txtB3.Text),
                    menor = n1; //Atriobui o menor par n1;

                if (n2 < menor)
                {
                    menor = n2;
                }

                if (n3 < menor)
                {
                    menor = n3;
                }

                //Resultao do menor
                Resultado.Text = menor.ToString();
            }
            catch
            {
                MessageBox.Show("Número inválido!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Apagar.PerformClick();
            }
        }

        private void txtB1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                txtB2.Focus();
            }
        }

        private void txtB2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                txtB3.Focus();
            }
        }

        private void txtB3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                Verificar.PerformClick();
            }
        }
    }
}
