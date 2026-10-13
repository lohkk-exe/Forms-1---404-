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
    public partial class EX4 : Form
    {
        int c = 0;
        public EX4()
        {
            InitializeComponent();
            SoundPlayer player = new SoundPlayer(Properties.Resources.Bling);
            player.Play();
        }

        private void idadeCalculo()
        {
            //Ira pegar a data no Controle
            DateTime Nas = Data.Value;

            //Pega a data atual do sistema
            DateTime hoje = DateTime.Now; //pega a data e a hora de quando esta sendo executado.
            //DateTime hoje = DateTime.Today; // pega só a data 

            // Calcula a idade do usuario
            int idade = hoje.Year - Nas.Year;

            if (idade < 0 || Nas > hoje)
            {
                MessageBox.Show("O ano do nascimento deve ser menor que o ano atual!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Limpar.PerformClick();
                Data.Focus();

            }
            else
            {

                if (Nas > hoje.AddYears(-idade))
                {
                    idade--;
                }
                //Vai dar a idade certa na pessoa no ano atual.
                //Consciderando que o aniversario do usuario ainda não chegou.

                txtB1.Text = idade.ToString(); //Mostra a idade.

                //Datetime é uma estrutura em c#; 
                //Basicamente um tipo como int, duble, decimal e etc;
                //int idade = 20; Tipo, Nome e Valor;
                //DateTime hoje = DateTime.Today; Tipo, Nome e Valor;

            }

        }
   
        private void Data_MouseEnter(object sender, EventArgs e)
        {
            Data.Select();// garante foco no Datetimepicker; pro comando não ir par outro contorle;
            SendKeys.Send("%{DOWN}");
        }

        private void Limpar_Click(object sender, EventArgs e)
        {
            Data.Value = DateTime.Today; //vai resetar a data.
            txtB1.Clear();
            c = 0;
            Data.Focus();
        }

        private void txtB1_TextChanged(object sender, EventArgs e)
        {
            txtB1.ReadOnly = true;
        }

        private void Calculo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && c == 0)
            {
                idadeCalculo();
                c++;
            }
            else if (c == 1)
            {
                Limpar.PerformClick();
            }
        }

        private void Calculo_Click(object sender, EventArgs e)
        {
            Limpar.Focus();
            idadeCalculo();
        }

        private void Data_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Limpar.Focus();
                idadeCalculo();
            }
        }
    }
}
