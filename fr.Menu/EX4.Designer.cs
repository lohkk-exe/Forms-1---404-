namespace fr.Menu
{
    partial class EX4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EX4));
            this.Limpar = new System.Windows.Forms.Button();
            this.Data = new System.Windows.Forms.DateTimePicker();
            this.txtB1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Calculo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Limpar
            // 
            this.Limpar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Limpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Limpar.Font = new System.Drawing.Font("OCR A Extended", 10F);
            this.Limpar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Limpar.Location = new System.Drawing.Point(347, 221);
            this.Limpar.Name = "Limpar";
            this.Limpar.Size = new System.Drawing.Size(94, 34);
            this.Limpar.TabIndex = 3;
            this.Limpar.Text = "Limpar";
            this.Limpar.UseVisualStyleBackColor = false;
            this.Limpar.Click += new System.EventHandler(this.Limpar_Click);
            // 
            // Data
            // 
            this.Data.Font = new System.Drawing.Font("OCR A Extended", 11F);
            this.Data.Location = new System.Drawing.Point(82, 76);
            this.Data.Name = "Data";
            this.Data.Size = new System.Drawing.Size(384, 23);
            this.Data.TabIndex = 1;
            this.Data.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Data_KeyDown);
            this.Data.MouseEnter += new System.EventHandler(this.Data_MouseEnter);
            // 
            // txtB1
            // 
            this.txtB1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtB1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtB1.Font = new System.Drawing.Font("OCR A Extended", 18F);
            this.txtB1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(51)))), ((int)(((byte)(40)))));
            this.txtB1.Location = new System.Drawing.Point(328, 183);
            this.txtB1.Name = "txtB1";
            this.txtB1.ShortcutsEnabled = false;
            this.txtB1.Size = new System.Drawing.Size(128, 32);
            this.txtB1.TabIndex = 56;
            this.txtB1.TabStop = false;
            this.txtB1.TextChanged += new System.EventHandler(this.txtB1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Font = new System.Drawing.Font("OCR A Extended", 15F);
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(313, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 25);
            this.label3.TabIndex = 55;
            this.label3.Text = "Sua idade é:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Cursor = System.Windows.Forms.Cursors.No;
            this.label1.Font = new System.Drawing.Font("OCR A Extended", 15F);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(82, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(384, 25);
            this.label1.TabIndex = 54;
            this.label1.Text = "Coloque sua data de nascimento:";
            // 
            // Calculo
            // 
            this.Calculo.BackColor = System.Drawing.Color.SlateGray;
            this.Calculo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Calculo.Font = new System.Drawing.Font("OCR A Extended", 12F);
            this.Calculo.ForeColor = System.Drawing.Color.MintCream;
            this.Calculo.Location = new System.Drawing.Point(47, 142);
            this.Calculo.Margin = new System.Windows.Forms.Padding(1);
            this.Calculo.Name = "Calculo";
            this.Calculo.Size = new System.Drawing.Size(222, 99);
            this.Calculo.TabIndex = 2;
            this.Calculo.Text = "Calcular";
            this.Calculo.UseVisualStyleBackColor = false;
            this.Calculo.Click += new System.EventHandler(this.Calculo_Click);
            this.Calculo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calculo_KeyDown);
            // 
            // EX4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::fr.Menu.Properties.Resources.notepad;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(528, 324);
            this.Controls.Add(this.Limpar);
            this.Controls.Add(this.Data);
            this.Controls.Add(this.txtB1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Calculo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EX4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EX4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Limpar;
        private System.Windows.Forms.DateTimePicker Data;
        private System.Windows.Forms.TextBox txtB1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Calculo;
    }
}