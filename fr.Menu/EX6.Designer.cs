namespace fr.Menu
{
    partial class EX6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EX6));
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.mtNum = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bLimpar = new System.Windows.Forms.Button();
            this.bCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mtNum
            // 
            this.mtNum.Font = new System.Drawing.Font("OCR A Extended", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtNum.Location = new System.Drawing.Point(306, 134);
            this.mtNum.Mask = "00000";
            this.mtNum.Name = "mtNum";
            this.mtNum.Size = new System.Drawing.Size(123, 28);
            this.mtNum.TabIndex = 5;
            this.mtNum.ValidatingType = typeof(int);
            this.mtNum.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mtNum_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("OCR A Extended", 15F);
            this.label2.Location = new System.Drawing.Point(96, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Digite o número:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("OCR A Extended", 18F);
            this.label1.Location = new System.Drawing.Point(74, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(378, 27);
            this.label1.TabIndex = 8;
            this.label1.Text = "Calculadora de Fatorial XD";
            // 
            // bLimpar
            // 
            this.bLimpar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.bLimpar.Font = new System.Drawing.Font("OCR A Extended", 10F);
            this.bLimpar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bLimpar.Location = new System.Drawing.Point(220, 257);
            this.bLimpar.Name = "bLimpar";
            this.bLimpar.Size = new System.Drawing.Size(92, 33);
            this.bLimpar.TabIndex = 7;
            this.bLimpar.Text = "Limpar";
            this.bLimpar.UseVisualStyleBackColor = false;
            this.bLimpar.Click += new System.EventHandler(this.bLimpar_Click);
            // 
            // bCalcular
            // 
            this.bCalcular.BackColor = System.Drawing.Color.SlateGray;
            this.bCalcular.Font = new System.Drawing.Font("OCR A Extended", 15F);
            this.bCalcular.ForeColor = System.Drawing.Color.MintCream;
            this.bCalcular.Location = new System.Drawing.Point(173, 176);
            this.bCalcular.Name = "bCalcular";
            this.bCalcular.Size = new System.Drawing.Size(190, 64);
            this.bCalcular.TabIndex = 6;
            this.bCalcular.Text = "Calcular";
            this.bCalcular.UseVisualStyleBackColor = false;
            this.bCalcular.Click += new System.EventHandler(this.bCalcular_Click);
            // 
            // EX6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::fr.Menu.Properties.Resources.notepad;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(530, 338);
            this.Controls.Add(this.mtNum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bLimpar);
            this.Controls.Add(this.bCalcular);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EX6";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EX6";
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.EX6_HelpButtonClicked);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.MaskedTextBox mtNum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bLimpar;
        private System.Windows.Forms.Button bCalcular;
    }
}