namespace fr.Menu
{
    partial class Login
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.picBox1 = new System.Windows.Forms.PictureBox();
            this.porfilepic = new System.Windows.Forms.PictureBox();
            this.bEntrar = new System.Windows.Forms.Button();
            this.txtBN = new System.Windows.Forms.TextBox();
            this.txtBS = new System.Windows.Forms.TextBox();
            this.toolbar = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.check = new System.Windows.Forms.CheckBox();
            this.icon = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.error1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.error2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.reset = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.porfilepic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // picBox1
            // 
            this.picBox1.Image = global::fr.Menu.Properties.Resources.notepad;
            this.picBox1.Location = new System.Drawing.Point(76, -1);
            this.picBox1.Name = "picBox1";
            this.picBox1.Size = new System.Drawing.Size(390, 337);
            this.picBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox1.TabIndex = 0;
            this.picBox1.TabStop = false;
            // 
            // porfilepic
            // 
            this.porfilepic.Image = global::fr.Menu.Properties.Resources.porfile;
            this.porfilepic.Location = new System.Drawing.Point(203, 38);
            this.porfilepic.Name = "porfilepic";
            this.porfilepic.Size = new System.Drawing.Size(101, 93);
            this.porfilepic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.porfilepic.TabIndex = 1;
            this.porfilepic.TabStop = false;
            // 
            // bEntrar
            // 
            this.bEntrar.BackgroundImage = global::fr.Menu.Properties.Resources.Entrar;
            this.bEntrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bEntrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bEntrar.Location = new System.Drawing.Point(171, 236);
            this.bEntrar.Name = "bEntrar";
            this.bEntrar.Size = new System.Drawing.Size(189, 44);
            this.bEntrar.TabIndex = 4;
            this.bEntrar.UseVisualStyleBackColor = true;
            this.bEntrar.Click += new System.EventHandler(this.bEntrar_Click_1);
            // 
            // txtBN
            // 
            this.txtBN.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtBN.Font = new System.Drawing.Font("OCR A Extended", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBN.Location = new System.Drawing.Point(171, 137);
            this.txtBN.Multiline = true;
            this.txtBN.Name = "txtBN";
            this.txtBN.Size = new System.Drawing.Size(189, 33);
            this.txtBN.TabIndex = 1;
            this.txtBN.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBN_KeyDown);
            // 
            // txtBS
            // 
            this.txtBS.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtBS.Font = new System.Drawing.Font("OCR A Extended", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBS.Location = new System.Drawing.Point(171, 202);
            this.txtBS.Multiline = true;
            this.txtBS.Name = "txtBS";
            this.txtBS.Size = new System.Drawing.Size(189, 29);
            this.txtBS.TabIndex = 2;
            this.txtBS.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBS_KeyDown);
            // 
            // toolbar
            // 
            this.toolbar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.toolbar.Cursor = System.Windows.Forms.Cursors.Default;
            this.toolbar.Font = new System.Drawing.Font("OCR A Extended", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolbar.Location = new System.Drawing.Point(-2, 306);
            this.toolbar.Multiline = true;
            this.toolbar.Name = "toolbar";
            this.toolbar.ReadOnly = true;
            this.toolbar.Size = new System.Drawing.Size(601, 44);
            this.toolbar.TabIndex = 100;
            this.toolbar.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = global::fr.Menu.Properties.Resources.N;
            this.pictureBox1.Location = new System.Drawing.Point(503, 127);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 194);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.label1.Font = new System.Drawing.Font("OCR A Extended", 12F);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(226, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Senha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.label2.Font = new System.Drawing.Font("OCR A Extended", 12F);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(215, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Usuario";
            // 
            // check
            // 
            this.check.AutoSize = true;
            this.check.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.check.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.check.Location = new System.Drawing.Point(366, 216);
            this.check.Name = "check";
            this.check.Size = new System.Drawing.Size(15, 14);
            this.check.TabIndex = 3;
            this.check.UseVisualStyleBackColor = true;
            this.check.CheckedChanged += new System.EventHandler(this.check_CheckedChanged_1);
            this.check.KeyDown += new System.Windows.Forms.KeyEventHandler(this.check_KeyDown);
            // 
            // icon
            // 
            this.icon.Image = global::fr.Menu.Properties.Resources.windons_login;
            this.icon.Location = new System.Drawing.Point(76, -1);
            this.icon.Name = "icon";
            this.icon.Size = new System.Drawing.Size(99, 29);
            this.icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.icon.TabIndex = 102;
            this.icon.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Image = global::fr.Menu.Properties.Resources.windons_login;
            this.pictureBox2.Location = new System.Drawing.Point(456, 306);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(122, 43);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 103;
            this.pictureBox2.TabStop = false;
            // 
            // error1
            // 
            this.error1.ContainerControl = this;
            // 
            // error2
            // 
            this.error2.ContainerControl = this;
            // 
            // reset
            // 
            this.reset.BackgroundImage = global::fr.Menu.Properties.Resources.Limpar;
            this.reset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.reset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.reset.Location = new System.Drawing.Point(218, 286);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(96, 25);
            this.reset.TabIndex = 104;
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::fr.Menu.Properties.Resources.Pular;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(88, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 23);
            this.button1.TabIndex = 105;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::fr.Menu.Properties.Resources.notepad;
            this.pictureBox3.Location = new System.Drawing.Point(396, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(192, 158);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 106;
            this.pictureBox3.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.label3.Font = new System.Drawing.Font("OCR A Extended", 13F);
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(415, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 19);
            this.label3.TabIndex = 107;
            this.label3.Text = "Sem cadastro?";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.label4.Font = new System.Drawing.Font("OCR A Extended", 12F);
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(432, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 17);
            this.label4.TabIndex = 108;
            this.label4.Text = "Faça agora!";
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::fr.Menu.Properties.Resources.Cadastrar1;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(419, 94);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(153, 40);
            this.button2.TabIndex = 109;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::fr.Menu.Properties.Resources.windows_xp;
            this.ClientSize = new System.Drawing.Size(590, 348);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.icon);
            this.Controls.Add(this.check);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBS);
            this.Controls.Add(this.txtBN);
            this.Controls.Add(this.bEntrar);
            this.Controls.Add(this.porfilepic);
            this.Controls.Add(this.picBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.toolbar);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.porfilepic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBox1;
        private System.Windows.Forms.PictureBox porfilepic;
        private System.Windows.Forms.Button bEntrar;
        private System.Windows.Forms.TextBox txtBN;
        private System.Windows.Forms.TextBox txtBS;
        private System.Windows.Forms.TextBox toolbar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox check;
        private System.Windows.Forms.PictureBox icon;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ErrorProvider error1;
        private System.Windows.Forms.ErrorProvider error2;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button button2;
    }
}