namespace fr.Menu
{
    partial class Pular2
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Pular = new System.Windows.Forms.Button();
            this.Voltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.No;
            this.textBox1.Font = new System.Drawing.Font("OCR A Extended", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(108, 63);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(362, 35);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Certeza que quer pular?";
            // 
            // Pular
            // 
            this.Pular.BackgroundImage = global::fr.Menu.Properties.Resources.Pular;
            this.Pular.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Pular.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Pular.Location = new System.Drawing.Point(167, 118);
            this.Pular.Name = "Pular";
            this.Pular.Size = new System.Drawing.Size(214, 60);
            this.Pular.TabIndex = 2;
            this.Pular.UseVisualStyleBackColor = true;
            this.Pular.Click += new System.EventHandler(this.button1_Click);
            // 
            // Voltar
            // 
            this.Voltar.BackgroundImage = global::fr.Menu.Properties.Resources.Voltar;
            this.Voltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Voltar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Voltar.Location = new System.Drawing.Point(207, 184);
            this.Voltar.Name = "Voltar";
            this.Voltar.Size = new System.Drawing.Size(133, 38);
            this.Voltar.TabIndex = 3;
            this.Voltar.UseVisualStyleBackColor = true;
            this.Voltar.Click += new System.EventHandler(this.Voltar_Click);
            // 
            // Pular2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::fr.Menu.Properties.Resources.baixados__13_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(543, 335);
            this.Controls.Add(this.Voltar);
            this.Controls.Add(this.Pular);
            this.Controls.Add(this.textBox1);
            this.Name = "Pular2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pular2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Pular;
        private System.Windows.Forms.Button Voltar;
    }
}