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
    public partial class omoriII : Form
    {
        public omoriII()
        {
            InitializeComponent();
        }

        private void painelFechar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
