namespace fr.Menu
{
    partial class EX3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EX3));
            this.Apagar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.Resultado = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtB3 = new System.Windows.Forms.TextBox();
            this.txtB2 = new System.Windows.Forms.TextBox();
            this.txtB1 = new System.Windows.Forms.TextBox();
            this.Verificar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Apagar
            // 
            this.Apagar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Apagar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Apagar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Apagar.Font = new System.Drawing.Font("OCR A Extended", 12F);
            this.Apagar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Apagar.Location = new System.Drawing.Point(106, 334);
            this.Apagar.Name = "Apagar";
            this.Apagar.Size = new System.Drawing.Size(124, 42);
            this.Apagar.TabIndex = 55;
            this.Apagar.Text = "Apagar";
            this.Apagar.UseVisualStyleBackColor = false;
            this.Apagar.Click += new System.EventHandler(this.Apagar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Font = new System.Drawing.Font("OCR A Extended", 15F);
            this.label5.Location = new System.Drawing.Point(309, 316);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(204, 25);
            this.label5.TabIndex = 60;
            this.label5.Text = "O menor deles é:\r\n";
            // 
            // Resultado
            // 
            this.Resultado.Font = new System.Drawing.Font("OCR A Extended", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Resultado.Location = new System.Drawing.Point(291, 344);
            this.Resultado.Multiline = true;
            this.Resultado.Name = "Resultado";
            this.Resultado.ReadOnly = true;
            this.Resultado.ShortcutsEnabled = false;
            this.Resultado.Size = new System.Drawing.Size(239, 32);
            this.Resultado.TabIndex = 61;
            this.Resultado.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("OCR A Extended", 14F);
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(79, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 20);
            this.label4.TabIndex = 59;
            this.label4.Text = "2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("OCR A Extended", 14F);
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(79, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 20);
            this.label3.TabIndex = 58;
            this.label3.Text = "3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("OCR A Extended", 14F);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(79, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 20);
            this.label2.TabIndex = 57;
            this.label2.Text = "1\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("OCR A Extended", 16F);
            this.label1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label1.Location = new System.Drawing.Point(125, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(493, 26);
            this.label1.TabIndex = 56;
            this.label1.Text = "Me de 3 números e veremos qual menor.";
            // 
            // txtB3
            // 
            this.txtB3.Font = new System.Drawing.Font("OCR A Extended", 13F);
            this.txtB3.Location = new System.Drawing.Point(115, 253);
            this.txtB3.Name = "txtB3";
            this.txtB3.Size = new System.Drawing.Size(212, 25);
            this.txtB3.TabIndex = 53;
            this.txtB3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtB3_KeyDown);
            // 
            // txtB2
            // 
            this.txtB2.Font = new System.Drawing.Font("OCR A Extended", 13F);
            this.txtB2.Location = new System.Drawing.Point(115, 192);
            this.txtB2.Name = "txtB2";
            this.txtB2.Size = new System.Drawing.Size(212, 25);
            this.txtB2.TabIndex = 52;
            this.txtB2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtB2_KeyDown);
            // 
            // txtB1
            // 
            this.txtB1.Font = new System.Drawing.Font("OCR A Extended", 13F);
            this.txtB1.Location = new System.Drawing.Point(115, 123);
            this.txtB1.Name = "txtB1";
            this.txtB1.Size = new System.Drawing.Size(212, 25);
            this.txtB1.TabIndex = 51;
            this.txtB1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtB1_KeyDown);
            // 
            // Verificar
            // 
            this.Verificar.BackColor = System.Drawing.Color.SlateGray;
            this.Verificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Verificar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Verificar.Font = new System.Drawing.Font("OCR A Extended", 15F);
            this.Verificar.ForeColor = System.Drawing.Color.MintCream;
            this.Verificar.Location = new System.Drawing.Point(424, 121);
            this.Verificar.Name = "Verificar";
            this.Verificar.Size = new System.Drawing.Size(237, 150);
            this.Verificar.TabIndex = 54;
            this.Verificar.Text = "Verificação";
            this.Verificar.UseVisualStyleBackColor = false;
            this.Verificar.Click += new System.EventHandler(this.Verificar_Click);
            // 
            // EX3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::fr.Menu.Properties.Resources.notepad;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(724, 431);
            this.Controls.Add(this.Apagar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Resultado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtB3);
            this.Controls.Add(this.txtB2);
            this.Controls.Add(this.txtB1);
            this.Controls.Add(this.Verificar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EX3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EX3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Apagar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Resultado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtB3;
        private System.Windows.Forms.TextBox txtB2;
        private System.Windows.Forms.TextBox txtB1;
        private System.Windows.Forms.Button Verificar;
    }
}