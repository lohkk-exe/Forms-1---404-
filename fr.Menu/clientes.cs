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
    public partial class clientes : Form
    {
        string caminho = @"C:\fr.workMenu\fr.workMenu\fr.Menu\fr.Menu\cadastros.txt";

        public clientes()
        {
            InitializeComponent();
        }

        private void clientes_Load(object sender, EventArgs e)
        {
            List<string> dados = new List<string>();
            string linha;

            System.IO.StreamReader sr = new System.IO.StreamReader(caminho);
            while ((linha = sr.ReadLine()) != null)
            {
                string[] partes = linha.Split(';');
                dados.Add(string.Join(", ",  partes));
                dados.Add("\n");
            }

            listBox1.DataSource = dados;
        }
    }
}
