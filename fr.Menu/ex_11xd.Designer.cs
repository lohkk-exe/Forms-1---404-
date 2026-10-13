namespace frmsMenu
{
    partial class ex_11xd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ex_11xd));
            this.title1 = new System.Windows.Forms.Label();
            this.title2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.timerExplosão = new System.Windows.Forms.Timer(this.components);
            this.lparabens = new System.Windows.Forms.Label();
            this.timerFinal = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.timerGato = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.bttTentar = new System.Windows.Forms.Button();
            this.Otimer = new System.Windows.Forms.Timer(this.components);
            this.lblTempo = new System.Windows.Forms.Label();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.gato = new System.Windows.Forms.PictureBox();
            this.explosão = new System.Windows.Forms.PictureBox();
            this.rato = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gato)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.explosão)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rato)).BeginInit();
            this.SuspendLayout();
            // 
            // title1
            // 
            this.title1.AutoSize = true;
            this.title1.BackColor = System.Drawing.Color.Transparent;
            this.title1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title1.Location = new System.Drawing.Point(134, 122);
            this.title1.Name = "title1";
            this.title1.Size = new System.Drawing.Size(1176, 75);
            this.title1.TabIndex = 0;
            this.title1.Text = "VOCÊ CLICKOU AONDE NÃO DEVIA!";
            this.title1.Visible = false;
            // 
            // title2
            // 
            this.title2.AutoSize = true;
            this.title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title2.ForeColor = System.Drawing.Color.Red;
            this.title2.Location = new System.Drawing.Point(98, 246);
            this.title2.Name = "title2";
            this.title2.Size = new System.Drawing.Size(0, 73);
            this.title2.TabIndex = 1;
            this.title2.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 800;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DimGray;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 35);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ratos mortos XP: 0";
            this.label1.Visible = false;
            // 
            // timerExplosão
            // 
            this.timerExplosão.Interval = 500;
            this.timerExplosão.Tick += new System.EventHandler(this.timerExplosão_Tick);
            // 
            // lparabens
            // 
            this.lparabens.AutoSize = true;
            this.lparabens.BackColor = System.Drawing.Color.Transparent;
            this.lparabens.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lparabens.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lparabens.Location = new System.Drawing.Point(140, 246);
            this.lparabens.Name = "lparabens";
            this.lparabens.Size = new System.Drawing.Size(1132, 148);
            this.lparabens.TabIndex = 5;
            this.lparabens.Text = "Parabéns, você matou todos os ratos\r\n          O mundo está salvo !\r\n";
            this.lparabens.Visible = false;
            // 
            // timerFinal
            // 
            this.timerFinal.Interval = 1600;
            this.timerFinal.Tick += new System.EventHandler(this.timerFinal_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkGray;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(289, 35);
            this.label2.TabIndex = 6;
            this.label2.Text = "Gatos mortos XP: 0";
            this.label2.Visible = false;
            // 
            // timerGato
            // 
            this.timerGato.Interval = 900;
            this.timerGato.Tick += new System.EventHandler(this.timerGato_Tick);
            // 
            // timer3
            // 
            this.timer3.Interval = 1500;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // bttTentar
            // 
            this.bttTentar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttTentar.Location = new System.Drawing.Point(420, 49);
            this.bttTentar.Name = "bttTentar";
            this.bttTentar.Size = new System.Drawing.Size(248, 46);
            this.bttTentar.TabIndex = 8;
            this.bttTentar.Text = "Tentar novamente";
            this.bttTentar.UseVisualStyleBackColor = true;
            this.bttTentar.Visible = false;
            this.bttTentar.Click += new System.EventHandler(this.bttTentar_Click);
            // 
            // Otimer
            // 
            this.Otimer.Interval = 1000;
            this.Otimer.Tick += new System.EventHandler(this.Otimer_Tick);
            // 
            // lblTempo
            // 
            this.lblTempo.AutoSize = true;
            this.lblTempo.BackColor = System.Drawing.SystemColors.Window;
            this.lblTempo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTempo.Location = new System.Drawing.Point(28, 95);
            this.lblTempo.Name = "lblTempo";
            this.lblTempo.Size = new System.Drawing.Size(174, 26);
            this.lblTempo.TabIndex = 9;
            this.lblTempo.Text = "Tempo restante: 30";
            this.lblTempo.Visible = false;
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // gato
            // 
            this.gato.BackColor = System.Drawing.Color.Transparent;
            this.gato.Image = ((System.Drawing.Image)(resources.GetObject("gato.Image")));
            this.gato.Location = new System.Drawing.Point(26, 246);
            this.gato.Name = "gato";
            this.gato.Size = new System.Drawing.Size(192, 122);
            this.gato.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gato.TabIndex = 7;
            this.gato.TabStop = false;
            this.gato.Visible = false;
            this.gato.Click += new System.EventHandler(this.gato_Click);
            // 
            // explosão
            // 
            this.explosão.BackColor = System.Drawing.Color.Transparent;
            this.explosão.Image = ((System.Drawing.Image)(resources.GetObject("explosão.Image")));
            this.explosão.Location = new System.Drawing.Point(28, 177);
            this.explosão.Name = "explosão";
            this.explosão.Size = new System.Drawing.Size(190, 115);
            this.explosão.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.explosão.TabIndex = 4;
            this.explosão.TabStop = false;
            this.explosão.Visible = false;
            // 
            // rato
            // 
            this.rato.BackColor = System.Drawing.Color.Transparent;
            this.rato.Image = ((System.Drawing.Image)(resources.GetObject("rato.Image")));
            this.rato.Location = new System.Drawing.Point(28, 100);
            this.rato.Name = "rato";
            this.rato.Size = new System.Drawing.Size(190, 131);
            this.rato.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rato.TabIndex = 2;
            this.rato.TabStop = false;
            this.rato.Visible = false;
            this.rato.Click += new System.EventHandler(this.rato_Click);
            // 
            // ex_11xd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::fr.Menu.Properties.Resources.windows_xp;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTempo);
            this.Controls.Add(this.bttTentar);
            this.Controls.Add(this.gato);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lparabens);
            this.Controls.Add(this.explosão);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rato);
            this.Controls.Add(this.title2);
            this.Controls.Add(this.title1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ex_11xd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ex_11xd";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ex_11xd_FormClosing);
            this.Shown += new System.EventHandler(this.ex_11xd_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.gato)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.explosão)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rato)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title1;
        private System.Windows.Forms.Label title2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.PictureBox rato;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox explosão;
        private System.Windows.Forms.Timer timerExplosão;
        private System.Windows.Forms.Label lparabens;
        private System.Windows.Forms.Timer timerFinal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timerGato;
        private System.Windows.Forms.PictureBox gato;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Button bttTentar;
        private System.Windows.Forms.Timer Otimer;
        private System.Windows.Forms.Label lblTempo;
        private System.Windows.Forms.PrintDialog printDialog1;
    }
}