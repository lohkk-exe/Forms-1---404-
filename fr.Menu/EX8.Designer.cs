namespace fr.Menu
{
    partial class EX8
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EX8));
            this.label1 = new System.Windows.Forms.Label();
            this.bLimpar = new System.Windows.Forms.Button();
            this.lRes = new System.Windows.Forms.Label();
            this.bCalcular = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.numSeq = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("OCR A Extended", 18F);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(124, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 27);
            this.label1.TabIndex = 7;
            this.label1.Text = "Calculadora de Fibonacci";
            // 
            // bLimpar
            // 
            this.bLimpar.Font = new System.Drawing.Font("OCR A Extended", 8.25F);
            this.bLimpar.Location = new System.Drawing.Point(329, 127);
            this.bLimpar.Name = "bLimpar";
            this.bLimpar.Size = new System.Drawing.Size(69, 25);
            this.bLimpar.TabIndex = 6;
            this.bLimpar.Text = "Limpar";
            this.bLimpar.UseVisualStyleBackColor = true;
            this.bLimpar.Click += new System.EventHandler(this.bLimpar_Click);
            // 
            // lRes
            // 
            this.lRes.AutoEllipsis = true;
            this.lRes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lRes.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lRes.Location = new System.Drawing.Point(60, 193);
            this.lRes.Name = "lRes";
            this.lRes.Size = new System.Drawing.Size(514, 126);
            this.lRes.TabIndex = 5;
            this.lRes.Visible = false;
            // 
            // bCalcular
            // 
            this.bCalcular.Font = new System.Drawing.Font("OCR A Extended", 8.25F);
            this.bCalcular.Location = new System.Drawing.Point(150, 127);
            this.bCalcular.Name = "bCalcular";
            this.bCalcular.Size = new System.Drawing.Size(163, 25);
            this.bCalcular.TabIndex = 4;
            this.bCalcular.Text = "Calcular";
            this.bCalcular.UseVisualStyleBackColor = true;
            this.bCalcular.Click += new System.EventHandler(this.bCalcular_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("OCR A Extended", 13F);
            this.label2.Location = new System.Drawing.Point(24, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(374, 21);
            this.label2.TabIndex = 12;
            this.label2.Text = "Calcular sequência até a posição:";
            // 
            // numSeq
            // 
            this.numSeq.Font = new System.Drawing.Font("OCR A Extended", 13F);
            this.numSeq.Location = new System.Drawing.Point(404, 81);
            this.numSeq.Name = "numSeq";
            this.numSeq.Size = new System.Drawing.Size(100, 25);
            this.numSeq.TabIndex = 0;
            this.numSeq.KeyDown += new System.Windows.Forms.KeyEventHandler(this.numSeq_KeyDown);
            // 
            // EX8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::fr.Menu.Properties.Resources.notepad;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(620, 342);
            this.Controls.Add(this.numSeq);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bLimpar);
            this.Controls.Add(this.lRes);
            this.Controls.Add(this.bCalcular);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EX8";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EX8";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.EX8_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bLimpar;
        private System.Windows.Forms.Label lRes;
        private System.Windows.Forms.Button bCalcular;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox numSeq;
    }
}