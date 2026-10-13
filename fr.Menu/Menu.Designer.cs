namespace fr.Menu
{
    partial class Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.menu1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.perfilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lixeiraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gatoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deslogarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mEX = new System.Windows.Forms.MenuStrip();
            this.eX1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eX2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eX3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eX4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eX5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eX6ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eX7ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eX8ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eX9ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eX10ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtB = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.pic3 = new System.Windows.Forms.PictureBox();
            this.pic4 = new System.Windows.Forms.PictureBox();
            this.fecharAplicaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu1.SuspendLayout();
            this.mEX.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic4)).BeginInit();
            this.SuspendLayout();
            // 
            // menu1
            // 
            this.menu1.BackColor = System.Drawing.Color.DarkGray;
            this.menu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menu1.Location = new System.Drawing.Point(0, 0);
            this.menu1.Name = "menu1";
            this.menu1.Size = new System.Drawing.Size(1870, 24);
            this.menu1.TabIndex = 1;
            this.menu1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem,
            this.perfilToolStripMenuItem,
            this.lixeiraToolStripMenuItem,
            this.gatoToolStripMenuItem,
            this.deslogarToolStripMenuItem,
            this.fecharAplicaçãoToolStripMenuItem});
            this.menuToolStripMenuItem.Image = global::fr.Menu.Properties.Resources.Licky_Gif_;
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.menuToolStripMenuItem.Text = "Menu!";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.Image = global::fr.Menu.Properties.Resources.cadastro1;
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.C)));
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            this.cadastroToolStripMenuItem.Click += new System.EventHandler(this.cadastroToolStripMenuItem_Click);
            // 
            // perfilToolStripMenuItem
            // 
            this.perfilToolStripMenuItem.Image = global::fr.Menu.Properties.Resources.Perfil1;
            this.perfilToolStripMenuItem.Name = "perfilToolStripMenuItem";
            this.perfilToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.P)));
            this.perfilToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.perfilToolStripMenuItem.Text = "Clientes";
            this.perfilToolStripMenuItem.Click += new System.EventHandler(this.perfilToolStripMenuItem_Click);
            // 
            // lixeiraToolStripMenuItem
            // 
            this.lixeiraToolStripMenuItem.Image = global::fr.Menu.Properties.Resources.lixo;
            this.lixeiraToolStripMenuItem.Name = "lixeiraToolStripMenuItem";
            this.lixeiraToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.L)));
            this.lixeiraToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.lixeiraToolStripMenuItem.Text = "Lixeira";
            this.lixeiraToolStripMenuItem.Click += new System.EventHandler(this.lixeiraToolStripMenuItem_Click);
            // 
            // gatoToolStripMenuItem
            // 
            this.gatoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("gatoToolStripMenuItem.Image")));
            this.gatoToolStripMenuItem.Name = "gatoToolStripMenuItem";
            this.gatoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.G)));
            this.gatoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.gatoToolStripMenuItem.Text = "Gato";
            this.gatoToolStripMenuItem.Click += new System.EventHandler(this.gatoToolStripMenuItem_Click);
            // 
            // deslogarToolStripMenuItem
            // 
            this.deslogarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("deslogarToolStripMenuItem.Image")));
            this.deslogarToolStripMenuItem.Name = "deslogarToolStripMenuItem";
            this.deslogarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D)));
            this.deslogarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deslogarToolStripMenuItem.Text = "Deslogar";
            this.deslogarToolStripMenuItem.Click += new System.EventHandler(this.deslogarToolStripMenuItem_Click);
            // 
            // mEX
            // 
            this.mEX.BackColor = System.Drawing.Color.DarkGray;
            this.mEX.Dock = System.Windows.Forms.DockStyle.Right;
            this.mEX.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eX1ToolStripMenuItem,
            this.eX2ToolStripMenuItem,
            this.eX3ToolStripMenuItem,
            this.eX4ToolStripMenuItem,
            this.eX5ToolStripMenuItem,
            this.eX6ToolStripMenuItem,
            this.eX7ToolStripMenuItem,
            this.eX8ToolStripMenuItem,
            this.eX9ToolStripMenuItem,
            this.eX10ToolStripMenuItem});
            this.mEX.Location = new System.Drawing.Point(1870, 0);
            this.mEX.Name = "mEX";
            this.mEX.Size = new System.Drawing.Size(50, 1057);
            this.mEX.TabIndex = 2;
            this.mEX.Text = "menuStrip2";
            // 
            // eX1ToolStripMenuItem
            // 
            this.eX1ToolStripMenuItem.Name = "eX1ToolStripMenuItem";
            this.eX1ToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.eX1ToolStripMenuItem.Size = new System.Drawing.Size(37, 19);
            this.eX1ToolStripMenuItem.Text = "EX1";
            this.eX1ToolStripMenuItem.Click += new System.EventHandler(this.eX1ToolStripMenuItem_Click);
            // 
            // eX2ToolStripMenuItem
            // 
            this.eX2ToolStripMenuItem.Name = "eX2ToolStripMenuItem";
            this.eX2ToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.eX2ToolStripMenuItem.Size = new System.Drawing.Size(37, 19);
            this.eX2ToolStripMenuItem.Text = "EX2";
            this.eX2ToolStripMenuItem.Click += new System.EventHandler(this.eX2ToolStripMenuItem_Click);
            // 
            // eX3ToolStripMenuItem
            // 
            this.eX3ToolStripMenuItem.Name = "eX3ToolStripMenuItem";
            this.eX3ToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.eX3ToolStripMenuItem.Size = new System.Drawing.Size(37, 19);
            this.eX3ToolStripMenuItem.Text = "EX3";
            this.eX3ToolStripMenuItem.Click += new System.EventHandler(this.eX3ToolStripMenuItem_Click);
            // 
            // eX4ToolStripMenuItem
            // 
            this.eX4ToolStripMenuItem.Name = "eX4ToolStripMenuItem";
            this.eX4ToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F4;
            this.eX4ToolStripMenuItem.Size = new System.Drawing.Size(37, 19);
            this.eX4ToolStripMenuItem.Text = "EX4";
            this.eX4ToolStripMenuItem.Click += new System.EventHandler(this.eX4ToolStripMenuItem_Click);
            // 
            // eX5ToolStripMenuItem
            // 
            this.eX5ToolStripMenuItem.Name = "eX5ToolStripMenuItem";
            this.eX5ToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.eX5ToolStripMenuItem.Size = new System.Drawing.Size(37, 19);
            this.eX5ToolStripMenuItem.Text = "EX5";
            this.eX5ToolStripMenuItem.Click += new System.EventHandler(this.eX5ToolStripMenuItem_Click);
            // 
            // eX6ToolStripMenuItem
            // 
            this.eX6ToolStripMenuItem.Name = "eX6ToolStripMenuItem";
            this.eX6ToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F6;
            this.eX6ToolStripMenuItem.Size = new System.Drawing.Size(37, 19);
            this.eX6ToolStripMenuItem.Text = "EX6";
            this.eX6ToolStripMenuItem.Click += new System.EventHandler(this.eX6ToolStripMenuItem_Click);
            // 
            // eX7ToolStripMenuItem
            // 
            this.eX7ToolStripMenuItem.Name = "eX7ToolStripMenuItem";
            this.eX7ToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F7;
            this.eX7ToolStripMenuItem.Size = new System.Drawing.Size(37, 19);
            this.eX7ToolStripMenuItem.Text = "EX7";
            this.eX7ToolStripMenuItem.Click += new System.EventHandler(this.eX7ToolStripMenuItem_Click);
            // 
            // eX8ToolStripMenuItem
            // 
            this.eX8ToolStripMenuItem.Name = "eX8ToolStripMenuItem";
            this.eX8ToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F8;
            this.eX8ToolStripMenuItem.Size = new System.Drawing.Size(37, 19);
            this.eX8ToolStripMenuItem.Text = "EX8";
            this.eX8ToolStripMenuItem.Click += new System.EventHandler(this.eX8ToolStripMenuItem_Click);
            // 
            // eX9ToolStripMenuItem
            // 
            this.eX9ToolStripMenuItem.Name = "eX9ToolStripMenuItem";
            this.eX9ToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F9;
            this.eX9ToolStripMenuItem.Size = new System.Drawing.Size(37, 19);
            this.eX9ToolStripMenuItem.Text = "EX9";
            this.eX9ToolStripMenuItem.Click += new System.EventHandler(this.eX9ToolStripMenuItem_Click);
            // 
            // eX10ToolStripMenuItem
            // 
            this.eX10ToolStripMenuItem.Name = "eX10ToolStripMenuItem";
            this.eX10ToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F10;
            this.eX10ToolStripMenuItem.Size = new System.Drawing.Size(37, 19);
            this.eX10ToolStripMenuItem.Text = "EX10";
            this.eX10ToolStripMenuItem.Click += new System.EventHandler(this.eX10ToolStripMenuItem_Click);
            // 
            // txtB
            // 
            this.txtB.BackColor = System.Drawing.Color.DarkGray;
            this.txtB.Location = new System.Drawing.Point(12, 967);
            this.txtB.Multiline = true;
            this.txtB.Name = "txtB";
            this.txtB.ReadOnly = true;
            this.txtB.ShortcutsEnabled = false;
            this.txtB.Size = new System.Drawing.Size(1893, 111);
            this.txtB.TabIndex = 20;
            this.txtB.TabStop = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.SystemColors.ButtonShadow;
            this.dateTimePicker1.CalendarTrailingForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Location = new System.Drawing.Point(980, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(336, 20);
            this.dateTimePicker1.TabIndex = 22;
            // 
            // pic3
            // 
            this.pic3.Image = global::fr.Menu.Properties.Resources.N;
            this.pic3.Location = new System.Drawing.Point(1800, 717);
            this.pic3.Name = "pic3";
            this.pic3.Size = new System.Drawing.Size(108, 268);
            this.pic3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic3.TabIndex = 23;
            this.pic3.TabStop = false;
            // 
            // pic4
            // 
            this.pic4.Image = global::fr.Menu.Properties.Resources.windons_login;
            this.pic4.Location = new System.Drawing.Point(1685, 907);
            this.pic4.Name = "pic4";
            this.pic4.Size = new System.Drawing.Size(139, 42);
            this.pic4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic4.TabIndex = 24;
            this.pic4.TabStop = false;
            // 
            // fecharAplicaçãoToolStripMenuItem
            // 
            this.fecharAplicaçãoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("fecharAplicaçãoToolStripMenuItem.Image")));
            this.fecharAplicaçãoToolStripMenuItem.Name = "fecharAplicaçãoToolStripMenuItem";
            this.fecharAplicaçãoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.X)));
            this.fecharAplicaçãoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.fecharAplicaçãoToolStripMenuItem.Text = "Sair";
            this.fecharAplicaçãoToolStripMenuItem.Click += new System.EventHandler(this.fecharAplicaçãoToolStripMenuItem_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1920, 1057);
            this.Controls.Add(this.pic4);
            this.Controls.Add(this.pic3);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.menu1);
            this.Controls.Add(this.mEX);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menu1;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menu1.ResumeLayout(false);
            this.menu1.PerformLayout();
            this.mEX.ResumeLayout(false);
            this.mEX.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menu1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem perfilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lixeiraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gatoToolStripMenuItem;
        private System.Windows.Forms.MenuStrip mEX;
        private System.Windows.Forms.ToolStripMenuItem eX1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eX2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eX3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eX4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eX5ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eX6ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eX7ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eX8ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eX9ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eX10ToolStripMenuItem;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.PictureBox pic3;
        private System.Windows.Forms.PictureBox pic4;
        private System.Windows.Forms.ToolStripMenuItem deslogarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fecharAplicaçãoToolStripMenuItem;
    }
}