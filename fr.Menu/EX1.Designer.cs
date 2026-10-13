namespace fr.Menu
{
    partial class EX1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EX1));
            this.lblRes = new System.Windows.Forms.Label();
            this.bttLimpar = new System.Windows.Forms.Button();
            this.bttCalcular = new System.Windows.Forms.Button();
            this.txtBnum3 = new System.Windows.Forms.TextBox();
            this.txtBnum2 = new System.Windows.Forms.TextBox();
            this.txtBnum1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblRes
            // 
            this.lblRes.AutoSize = true;
            this.lblRes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblRes.Cursor = System.Windows.Forms.Cursors.No;
            this.lblRes.Font = new System.Drawing.Font("OCR A Extended", 13F);
            this.lblRes.Location = new System.Drawing.Point(361, 134);
            this.lblRes.Name = "lblRes";
            this.lblRes.Size = new System.Drawing.Size(132, 21);
            this.lblRes.TabIndex = 110;
            this.lblRes.Text = "A média é: ";
            // 
            // bttLimpar
            // 
            this.bttLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttLimpar.Font = new System.Drawing.Font("OCR A Extended", 12F);
            this.bttLimpar.Location = new System.Drawing.Point(263, 247);
            this.bttLimpar.Name = "bttLimpar";
            this.bttLimpar.Size = new System.Drawing.Size(106, 28);
            this.bttLimpar.TabIndex = 105;
            this.bttLimpar.Text = "Limpar";
            this.bttLimpar.UseVisualStyleBackColor = true;
            this.bttLimpar.Click += new System.EventHandler(this.bttLimpar_Click);
            // 
            // bttCalcular
            // 
            this.bttCalcular.BackColor = System.Drawing.Color.SlateGray;
            this.bttCalcular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttCalcular.Font = new System.Drawing.Font("OCR A Extended", 12F);
            this.bttCalcular.ForeColor = System.Drawing.Color.MintCream;
            this.bttCalcular.Location = new System.Drawing.Point(68, 213);
            this.bttCalcular.Name = "bttCalcular";
            this.bttCalcular.Size = new System.Drawing.Size(176, 62);
            this.bttCalcular.TabIndex = 104;
            this.bttCalcular.Text = "Calcular";
            this.bttCalcular.UseVisualStyleBackColor = false;
            this.bttCalcular.Click += new System.EventHandler(this.bttCalcular_Click);
            // 
            // txtBnum3
            // 
            this.txtBnum3.Font = new System.Drawing.Font("OCR A Extended", 12F);
            this.txtBnum3.Location = new System.Drawing.Point(146, 171);
            this.txtBnum3.Name = "txtBnum3";
            this.txtBnum3.Size = new System.Drawing.Size(197, 24);
            this.txtBnum3.TabIndex = 103;
            this.txtBnum3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBnum3_KeyDown);
            // 
            // txtBnum2
            // 
            this.txtBnum2.Font = new System.Drawing.Font("OCR A Extended", 12F);
            this.txtBnum2.Location = new System.Drawing.Point(146, 134);
            this.txtBnum2.Name = "txtBnum2";
            this.txtBnum2.Size = new System.Drawing.Size(197, 24);
            this.txtBnum2.TabIndex = 102;
            this.txtBnum2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBnum2_KeyDown);
            // 
            // txtBnum1
            // 
            this.txtBnum1.Font = new System.Drawing.Font("OCR A Extended", 12F);
            this.txtBnum1.Location = new System.Drawing.Point(146, 99);
            this.txtBnum1.Name = "txtBnum1";
            this.txtBnum1.Size = new System.Drawing.Size(197, 24);
            this.txtBnum1.TabIndex = 101;
            this.txtBnum1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBnum1_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("OCR A Extended", 15F);
            this.label4.Location = new System.Drawing.Point(22, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 23);
            this.label4.TabIndex = 106;
            this.label4.Text = "3 número:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("OCR A Extended", 15F);
            this.label3.Location = new System.Drawing.Point(22, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 23);
            this.label3.TabIndex = 107;
            this.label3.Text = "2 número:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("OCR A Extended", 15F);
            this.label2.Location = new System.Drawing.Point(22, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 23);
            this.label2.TabIndex = 108;
            this.label2.Text = "1 número:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("OCR A Extended", 20F);
            this.label1.Location = new System.Drawing.Point(68, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(383, 31);
            this.label1.TabIndex = 109;
            this.label1.Text = "Calculadora de Média XD";
            // 
            // EX1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImage = global::fr.Menu.Properties.Resources.notepad;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(679, 304);
            this.Controls.Add(this.lblRes);
            this.Controls.Add(this.bttLimpar);
            this.Controls.Add(this.bttCalcular);
            this.Controls.Add(this.txtBnum3);
            this.Controls.Add(this.txtBnum2);
            this.Controls.Add(this.txtBnum1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EX1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRes;
        private System.Windows.Forms.Button bttLimpar;
        private System.Windows.Forms.Button bttCalcular;
        private System.Windows.Forms.TextBox txtBnum3;
        private System.Windows.Forms.TextBox txtBnum2;
        private System.Windows.Forms.TextBox txtBnum1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}