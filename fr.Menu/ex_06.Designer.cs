namespace frmsMenu
{
    partial class ex_06
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ex_06));
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tabela = new System.Windows.Forms.TableLayoutPanel();
            this.bttLimpar = new System.Windows.Forms.Button();
            this.bttCalcular = new System.Windows.Forms.Button();
            this.btt0 = new System.Windows.Forms.Button();
            this.btt9 = new System.Windows.Forms.Button();
            this.btt8 = new System.Windows.Forms.Button();
            this.btt7 = new System.Windows.Forms.Button();
            this.btt6 = new System.Windows.Forms.Button();
            this.btt5 = new System.Windows.Forms.Button();
            this.btt4 = new System.Windows.Forms.Button();
            this.btt3 = new System.Windows.Forms.Button();
            this.btt2 = new System.Windows.Forms.Button();
            this.btt1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblRes = new System.Windows.Forms.Label();
            this.tabela.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(201, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Calculadora de Fatorial (!)";
            // 
            // tabela
            // 
            this.tabela.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tabela.ColumnCount = 3;
            this.tabela.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tabela.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tabela.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 112F));
            this.tabela.Controls.Add(this.bttLimpar, 2, 3);
            this.tabela.Controls.Add(this.bttCalcular, 1, 3);
            this.tabela.Controls.Add(this.btt0, 0, 3);
            this.tabela.Controls.Add(this.btt9, 2, 2);
            this.tabela.Controls.Add(this.btt8, 1, 2);
            this.tabela.Controls.Add(this.btt7, 0, 2);
            this.tabela.Controls.Add(this.btt6, 2, 1);
            this.tabela.Controls.Add(this.btt5, 1, 1);
            this.tabela.Controls.Add(this.btt4, 0, 1);
            this.tabela.Controls.Add(this.btt3, 2, 0);
            this.tabela.Controls.Add(this.btt2, 1, 0);
            this.tabela.Controls.Add(this.btt1, 0, 0);
            this.tabela.Location = new System.Drawing.Point(166, 163);
            this.tabela.Name = "tabela";
            this.tabela.RowCount = 4;
            this.tabela.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.87719F));
            this.tabela.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.12281F));
            this.tabela.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59F));
            this.tabela.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tabela.Size = new System.Drawing.Size(332, 244);
            this.tabela.TabIndex = 5;
            // 
            // bttLimpar
            // 
            this.bttLimpar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bttLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttLimpar.Location = new System.Drawing.Point(229, 191);
            this.bttLimpar.Name = "bttLimpar";
            this.bttLimpar.Size = new System.Drawing.Size(94, 43);
            this.bttLimpar.TabIndex = 11;
            this.bttLimpar.Text = "Limpar";
            this.bttLimpar.UseVisualStyleBackColor = true;
            this.bttLimpar.Click += new System.EventHandler(this.bttLimpar_Click);
            // 
            // bttCalcular
            // 
            this.bttCalcular.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bttCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttCalcular.Location = new System.Drawing.Point(123, 191);
            this.bttCalcular.Name = "bttCalcular";
            this.bttCalcular.Size = new System.Drawing.Size(83, 43);
            this.bttCalcular.TabIndex = 10;
            this.bttCalcular.Text = "Calcular";
            this.bttCalcular.UseVisualStyleBackColor = true;
            this.bttCalcular.Click += new System.EventHandler(this.bttCalcular_Click);
            // 
            // btt0
            // 
            this.btt0.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btt0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btt0.Location = new System.Drawing.Point(15, 191);
            this.btt0.Name = "btt0";
            this.btt0.Size = new System.Drawing.Size(80, 43);
            this.btt0.TabIndex = 9;
            this.btt0.Text = "0";
            this.btt0.UseVisualStyleBackColor = true;
            this.btt0.Click += new System.EventHandler(this.btt0_Click);
            // 
            // btt9
            // 
            this.btt9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btt9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btt9.Location = new System.Drawing.Point(233, 132);
            this.btt9.Name = "btt9";
            this.btt9.Size = new System.Drawing.Size(85, 39);
            this.btt9.TabIndex = 8;
            this.btt9.Text = "9";
            this.btt9.UseVisualStyleBackColor = true;
            this.btt9.Click += new System.EventHandler(this.btt9_Click);
            // 
            // btt8
            // 
            this.btt8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btt8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btt8.Location = new System.Drawing.Point(121, 132);
            this.btt8.Name = "btt8";
            this.btt8.Size = new System.Drawing.Size(87, 39);
            this.btt8.TabIndex = 7;
            this.btt8.Text = "8";
            this.btt8.UseVisualStyleBackColor = true;
            this.btt8.Click += new System.EventHandler(this.btt8_Click);
            // 
            // btt7
            // 
            this.btt7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btt7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btt7.Location = new System.Drawing.Point(15, 132);
            this.btt7.Name = "btt7";
            this.btt7.Size = new System.Drawing.Size(80, 39);
            this.btt7.TabIndex = 6;
            this.btt7.Text = "7";
            this.btt7.UseVisualStyleBackColor = true;
            this.btt7.Click += new System.EventHandler(this.btt7_Click);
            // 
            // btt6
            // 
            this.btt6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btt6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btt6.Location = new System.Drawing.Point(233, 70);
            this.btt6.Name = "btt6";
            this.btt6.Size = new System.Drawing.Size(86, 43);
            this.btt6.TabIndex = 5;
            this.btt6.Text = "6";
            this.btt6.UseVisualStyleBackColor = true;
            this.btt6.Click += new System.EventHandler(this.btt6_Click);
            // 
            // btt5
            // 
            this.btt5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btt5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btt5.Location = new System.Drawing.Point(121, 70);
            this.btt5.Name = "btt5";
            this.btt5.Size = new System.Drawing.Size(87, 43);
            this.btt5.TabIndex = 4;
            this.btt5.Text = "5";
            this.btt5.UseVisualStyleBackColor = true;
            this.btt5.Click += new System.EventHandler(this.btt5_Click);
            // 
            // btt4
            // 
            this.btt4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btt4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btt4.Location = new System.Drawing.Point(15, 70);
            this.btt4.Name = "btt4";
            this.btt4.Size = new System.Drawing.Size(80, 43);
            this.btt4.TabIndex = 3;
            this.btt4.Text = "4";
            this.btt4.UseVisualStyleBackColor = true;
            this.btt4.Click += new System.EventHandler(this.btt4_Click);
            // 
            // btt3
            // 
            this.btt3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btt3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btt3.Location = new System.Drawing.Point(231, 9);
            this.btt3.Name = "btt3";
            this.btt3.Size = new System.Drawing.Size(89, 43);
            this.btt3.TabIndex = 2;
            this.btt3.Text = "3";
            this.btt3.UseVisualStyleBackColor = true;
            this.btt3.Click += new System.EventHandler(this.btt3_Click);
            // 
            // btt2
            // 
            this.btt2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btt2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btt2.Location = new System.Drawing.Point(120, 9);
            this.btt2.Name = "btt2";
            this.btt2.Size = new System.Drawing.Size(90, 43);
            this.btt2.TabIndex = 1;
            this.btt2.Text = "2";
            this.btt2.UseVisualStyleBackColor = true;
            this.btt2.Click += new System.EventHandler(this.btt2_Click);
            // 
            // btt1
            // 
            this.btt1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btt1.Location = new System.Drawing.Point(13, 9);
            this.btt1.Name = "btt1";
            this.btt1.Size = new System.Drawing.Size(84, 43);
            this.btt1.TabIndex = 0;
            this.btt1.Text = "1";
            this.btt1.UseVisualStyleBackColor = true;
            this.btt1.Click += new System.EventHandler(this.btt1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(166, 79);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(332, 88);
            this.panel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Controls.Add(this.lblRes);
            this.panel2.Location = new System.Drawing.Point(16, 15);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(297, 63);
            this.panel2.TabIndex = 0;
            this.panel2.TabStop = true;
            // 
            // lblRes
            // 
            this.lblRes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRes.AutoSize = true;
            this.lblRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRes.Location = new System.Drawing.Point(18, 18);
            this.lblRes.Name = "lblRes";
            this.lblRes.Size = new System.Drawing.Size(0, 29);
            this.lblRes.TabIndex = 8;
            // 
            // ex_06
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::fr.Menu.Properties.Resources.notepad;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(688, 439);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabela);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "ex_06";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ex 06 - Calculadora de Fatorial";
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.ex_06_HelpButtonClicked);
            this.Shown += new System.EventHandler(this.ex_06_Shown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ex_06_KeyPress);
            this.tabela.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TableLayoutPanel tabela;
        private System.Windows.Forms.Button btt1;
        private System.Windows.Forms.Button bttLimpar;
        private System.Windows.Forms.Button btt0;
        private System.Windows.Forms.Button btt9;
        private System.Windows.Forms.Button btt8;
        private System.Windows.Forms.Button btt7;
        private System.Windows.Forms.Button btt6;
        private System.Windows.Forms.Button btt5;
        private System.Windows.Forms.Button btt4;
        private System.Windows.Forms.Button btt3;
        private System.Windows.Forms.Button btt2;
        private System.Windows.Forms.Button bttCalcular;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblRes;
    }
}