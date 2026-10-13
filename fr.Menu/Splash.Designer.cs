namespace fr.Menu
{
    partial class Splash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Splash));
            this.loading = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtb1 = new System.Windows.Forms.TextBox();
            this.txtb2 = new System.Windows.Forms.TextBox();
            this.picBox4 = new System.Windows.Forms.PictureBox();
            this.b1 = new System.Windows.Forms.Button();
            this.picBox3 = new System.Windows.Forms.PictureBox();
            this.picBox1 = new System.Windows.Forms.PictureBox();
            this.picBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // loading
            // 
            this.loading.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.loading.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(196)))), ((int)(((byte)(234)))));
            this.loading.Location = new System.Drawing.Point(95, 275);
            this.loading.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.loading.Maximum = 50;
            this.loading.Name = "loading";
            this.loading.Size = new System.Drawing.Size(273, 32);
            this.loading.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.loading.TabIndex = 1;
            this.loading.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txtb1
            // 
            this.txtb1.BackColor = System.Drawing.SystemColors.InfoText;
            this.txtb1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtb1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtb1.Font = new System.Drawing.Font("OCR A Extended", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb1.ForeColor = System.Drawing.SystemColors.Menu;
            this.txtb1.Location = new System.Drawing.Point(49, 223);
            this.txtb1.Multiline = true;
            this.txtb1.Name = "txtb1";
            this.txtb1.ReadOnly = true;
            this.txtb1.Size = new System.Drawing.Size(366, 43);
            this.txtb1.TabIndex = 4;
            this.txtb1.TabStop = false;
            this.txtb1.Text = "Pss! Você precisa esperar carregar!";
            // 
            // txtb2
            // 
            this.txtb2.BackColor = System.Drawing.SystemColors.InfoText;
            this.txtb2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtb2.CausesValidation = false;
            this.txtb2.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtb2.Font = new System.Drawing.Font("OCR A Extended", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb2.ForeColor = System.Drawing.SystemColors.Menu;
            this.txtb2.Location = new System.Drawing.Point(60, 231);
            this.txtb2.Name = "txtb2";
            this.txtb2.ReadOnly = true;
            this.txtb2.Size = new System.Drawing.Size(366, 35);
            this.txtb2.TabIndex = 7;
            this.txtb2.TabStop = false;
            this.txtb2.Text = "PODEMOS INICIAR!!";
            this.txtb2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // picBox4
            // 
            this.picBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picBox4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picBox4.Image = global::fr.Menu.Properties.Resources.Licky_Gif_;
            this.picBox4.Location = new System.Drawing.Point(298, 82);
            this.picBox4.Name = "picBox4";
            this.picBox4.Size = new System.Drawing.Size(117, 93);
            this.picBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox4.TabIndex = 6;
            this.picBox4.TabStop = false;
            // 
            // b1
            // 
            this.b1.BackgroundImage = global::fr.Menu.Properties.Resources.START;
            this.b1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.b1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.b1.Location = new System.Drawing.Point(49, 96);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(227, 63);
            this.b1.TabIndex = 2;
            this.b1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.b1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.b1.UseVisualStyleBackColor = true;
            this.b1.Click += new System.EventHandler(this.button1_Click);
            // 
            // picBox3
            // 
            this.picBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picBox3.Image = global::fr.Menu.Properties.Resources.paintUP;
            this.picBox3.Location = new System.Drawing.Point(-7, -75);
            this.picBox3.Name = "picBox3";
            this.picBox3.Size = new System.Drawing.Size(478, 142);
            this.picBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox3.TabIndex = 3;
            this.picBox3.TabStop = false;
            // 
            // picBox1
            // 
            this.picBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picBox1.Image = global::fr.Menu.Properties.Resources.RPGbtxt;
            this.picBox1.Location = new System.Drawing.Point(26, 201);
            this.picBox1.Name = "picBox1";
            this.picBox1.Size = new System.Drawing.Size(414, 122);
            this.picBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picBox1.TabIndex = 1;
            this.picBox1.TabStop = false;
            // 
            // picBox2
            // 
            this.picBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picBox2.Image = global::fr.Menu.Properties.Resources.paint;
            this.picBox2.Location = new System.Drawing.Point(-7, 190);
            this.picBox2.Name = "picBox2";
            this.picBox2.Size = new System.Drawing.Size(478, 171);
            this.picBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox2.TabIndex = 2;
            this.picBox2.TabStop = false;
            // 
            // Splash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(177)))), ((int)(((byte)(222)))));
            this.ClientSize = new System.Drawing.Size(467, 322);
            this.Controls.Add(this.txtb2);
            this.Controls.Add(this.picBox4);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.txtb1);
            this.Controls.Add(this.picBox3);
            this.Controls.Add(this.loading);
            this.Controls.Add(this.picBox1);
            this.Controls.Add(this.picBox2);
            this.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Splash";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Splash";
            this.Load += new System.EventHandler(this.Splash_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar loading;
        private System.Windows.Forms.PictureBox picBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox picBox2;
        private System.Windows.Forms.PictureBox picBox3;
        private System.Windows.Forms.TextBox txtb1;
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.PictureBox picBox4;
        private System.Windows.Forms.TextBox txtb2;
    }
}