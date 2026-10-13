namespace fr.Menu
{
    partial class EX9
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EX9));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bConverter = new System.Windows.Forms.Button();
            this.tNum = new System.Windows.Forms.TextBox();
            this.Apagar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("OCR A Extended", 13F);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(73, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(352, 21);
            this.label2.TabIndex = 28;
            this.label2.Text = "Digite um número entre 01 e 12:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("OCR A Extended", 18F);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(73, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 27);
            this.label1.TabIndex = 58;
            this.label1.Text = "Converter número em mês!";
            // 
            // bConverter
            // 
            this.bConverter.BackColor = System.Drawing.Color.SlateGray;
            this.bConverter.Font = new System.Drawing.Font("OCR A Extended", 12F);
            this.bConverter.ForeColor = System.Drawing.Color.MintCream;
            this.bConverter.Location = new System.Drawing.Point(239, 151);
            this.bConverter.Name = "bConverter";
            this.bConverter.Size = new System.Drawing.Size(184, 54);
            this.bConverter.TabIndex = 2;
            this.bConverter.Text = "Converter";
            this.bConverter.UseVisualStyleBackColor = false;
            this.bConverter.Click += new System.EventHandler(this.bConverter_Click);
            // 
            // tNum
            // 
            this.tNum.Font = new System.Drawing.Font("OCR A Extended", 15F);
            this.tNum.Location = new System.Drawing.Point(89, 162);
            this.tNum.Name = "tNum";
            this.tNum.Size = new System.Drawing.Size(100, 28);
            this.tNum.TabIndex = 1;
            this.tNum.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tNum_KeyDown);
            // 
            // Apagar
            // 
            this.Apagar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Apagar.Font = new System.Drawing.Font("OCR A Extended", 12F);
            this.Apagar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Apagar.Location = new System.Drawing.Point(100, 196);
            this.Apagar.Name = "Apagar";
            this.Apagar.Size = new System.Drawing.Size(76, 28);
            this.Apagar.TabIndex = 59;
            this.Apagar.Text = "Apagar";
            this.Apagar.UseVisualStyleBackColor = false;
            this.Apagar.Click += new System.EventHandler(this.Apagar_Click);
            // 
            // EX9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::fr.Menu.Properties.Resources.notepad;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(508, 271);
            this.Controls.Add(this.Apagar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bConverter);
            this.Controls.Add(this.tNum);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EX9";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EX9";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bConverter;
        private System.Windows.Forms.TextBox tNum;
        private System.Windows.Forms.Button Apagar;
    }
}