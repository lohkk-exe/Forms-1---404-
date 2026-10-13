using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ex2forms
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Calcular_Click(object sender, EventArgs e)
        {
            //Analisa os números colocados
            try
            {
                decimal P = Convert.ToDecimal(txtB1.Text);
                decimal Q = Convert.ToDecimal(txtB2.Text);

                //Calculo
                decimal total = P * Q;

                //Aparece o total no 3 textbox
                txtB3.Text = total.ToString("C2");
            }

            catch (Exception){ MessageBox.Show(">:( número inválido", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void Limpar_Click(object sender, EventArgs e)
        {
            foreach (Control X in this.Controls) //O foreach percorre todos os controles dentro do formulário
            {
                if (X is System.Windows.Forms.TextBox txt)
                {
                    txt.Clear();
                }
            }
            txtB1.Focus();
            //ctrl pode ser qualquer coisa: um botão, uma label, um textbox;
            //O if (ctrl is System.Windows.Forms.TextBox txt) verifica se o controle atual é realmente um TextBox;
            //Control é uma classe (atributos); Tudo o que tem na tela do forms;
            //Basicamente falndo que o controle não é qualquer coisa e sim uma texBox;
            //O is verifica o tipo do controle, basicamente perguntando “Esse ctrl é um TextBox do Windows Forms?”
            //Se for verdade, ele converte ctrl para TextBox e o atribui à variável txt.
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
