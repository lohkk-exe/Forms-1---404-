namespace fr.Menu
{
    partial class cadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cadastro));
            this.tNome = new System.Windows.Forms.TextBox();
            this.tEmail = new System.Windows.Forms.TextBox();
            this.tSenha = new System.Windows.Forms.TextBox();
            this.bEnviar = new System.Windows.Forms.Button();
            this.bLimpar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tNumero = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.bttVoltar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // tNome
            // 
            this.tNome.Font = new System.Drawing.Font("OCR A Extended", 13F);
            this.tNome.Location = new System.Drawing.Point(258, 107);
            this.tNome.Name = "tNome";
            this.tNome.Size = new System.Drawing.Size(198, 25);
            this.tNome.TabIndex = 0;
            this.tNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tNome_KeyPress);
            // 
            // tEmail
            // 
            this.tEmail.Font = new System.Drawing.Font("OCR A Extended", 13F);
            this.tEmail.Location = new System.Drawing.Point(258, 164);
            this.tEmail.Name = "tEmail";
            this.tEmail.Size = new System.Drawing.Size(198, 25);
            this.tEmail.TabIndex = 2;
            // 
            // tSenha
            // 
            this.tSenha.Font = new System.Drawing.Font("OCR A Extended", 13F);
            this.tSenha.Location = new System.Drawing.Point(258, 195);
            this.tSenha.Name = "tSenha";
            this.tSenha.Size = new System.Drawing.Size(198, 25);
            this.tSenha.TabIndex = 3;
            // 
            // bEnviar
            // 
            this.bEnviar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bEnviar.Font = new System.Drawing.Font("OCR A Extended", 10F);
            this.bEnviar.Location = new System.Drawing.Point(170, 247);
            this.bEnviar.Name = "bEnviar";
            this.bEnviar.Size = new System.Drawing.Size(140, 41);
            this.bEnviar.TabIndex = 5;
            this.bEnviar.Text = "Enviar";
            this.bEnviar.UseVisualStyleBackColor = true;
            this.bEnviar.Click += new System.EventHandler(this.bEnviar_Click);
            // 
            // bLimpar
            // 
            this.bLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bLimpar.Font = new System.Drawing.Font("OCR A Extended", 9F);
            this.bLimpar.Location = new System.Drawing.Point(337, 252);
            this.bLimpar.Name = "bLimpar";
            this.bLimpar.Size = new System.Drawing.Size(96, 31);
            this.bLimpar.TabIndex = 6;
            this.bLimpar.Text = "Limpar";
            this.bLimpar.UseVisualStyleBackColor = true;
            this.bLimpar.Click += new System.EventHandler(this.bLimpar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("OCR A Extended", 13F);
            this.label1.Location = new System.Drawing.Point(144, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "Usuário:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("OCR A Extended", 13F);
            this.label2.Location = new System.Drawing.Point(133, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "Telefone:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("OCR A Extended", 13F);
            this.label3.Location = new System.Drawing.Point(166, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 19);
            this.label3.TabIndex = 9;
            this.label3.Text = "Email:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("OCR A Extended", 13F);
            this.label4.Location = new System.Drawing.Point(166, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 19);
            this.label4.TabIndex = 10;
            this.label4.Text = "Senha:";
            // 
            // tNumero
            // 
            this.tNumero.Font = new System.Drawing.Font("OCR A Extended", 13F);
            this.tNumero.Location = new System.Drawing.Point(258, 138);
            this.tNumero.Mask = "(00)00000-0000";
            this.tNumero.Name = "tNumero";
            this.tNumero.Size = new System.Drawing.Size(198, 25);
            this.tNumero.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("OCR A Extended", 16F);
            this.label6.Location = new System.Drawing.Point(197, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(205, 24);
            this.label6.TabIndex = 12;
            this.label6.Text = "Faça Cadastro !";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(600, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(197, 174);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::fr.Menu.Properties.Resources.notepad;
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(582, 325);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox1.Location = new System.Drawing.Point(462, 202);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            this.checkBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.checkBox1_KeyDown);
            // 
            // bttVoltar
            // 
            this.bttVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttVoltar.Font = new System.Drawing.Font("OCR A Extended", 10F);
            this.bttVoltar.Location = new System.Drawing.Point(32, 60);
            this.bttVoltar.Name = "bttVoltar";
            this.bttVoltar.Size = new System.Drawing.Size(94, 28);
            this.bttVoltar.TabIndex = 15;
            this.bttVoltar.Text = "Fechar";
            this.bttVoltar.UseVisualStyleBackColor = true;
            this.bttVoltar.Click += new System.EventHandler(this.bttVoltar_Click);
            // 
            // cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::fr.Menu.Properties.Resources.windows_xp1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(808, 361);
            this.Controls.Add(this.bttVoltar);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tNumero);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bLimpar);
            this.Controls.Add(this.bEnviar);
            this.Controls.Add(this.tSenha);
            this.Controls.Add(this.tEmail);
            this.Controls.Add(this.tNome);
            this.Controls.Add(this.pictureBox2);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "cadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tNome;
        private System.Windows.Forms.TextBox tEmail;
        private System.Windows.Forms.TextBox tSenha;
        private System.Windows.Forms.Button bEnviar;
        private System.Windows.Forms.Button bLimpar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox tNumero;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button bttVoltar;
    }
}