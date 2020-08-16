namespace mct_upd
{
    partial class guncelle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(guncelle));
            this.surumozellikleriTextBox = new System.Windows.Forms.TextBox();
            this.guncelleneceksurumLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.indirmekontrol = new System.Windows.Forms.Timer(this.components);
            this.programyoluLabel = new System.Windows.Forms.Label();
            this.programSurumLabel = new System.Windows.Forms.Label();
            this.guncellemetamamla_1 = new System.Windows.Forms.Timer(this.components);
            this.yuklemedurumLabel = new System.Windows.Forms.Label();
            this.guncellemetamamla_2 = new System.Windows.Forms.Timer(this.components);
            this.zamanasimikontrol = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.guncellemedosyacikart_1 = new System.Windows.Forms.Timer(this.components);
            this.guncellemedosyacikart_2 = new System.Windows.Forms.Timer(this.components);
            this.guncellemetamamla_3 = new System.Windows.Forms.Timer(this.components);
            this.butonAktifTimer = new System.Windows.Forms.Timer(this.components);
            this.yuklemePictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yuklemePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // surumozellikleriTextBox
            // 
            this.surumozellikleriTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.surumozellikleriTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.surumozellikleriTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.surumozellikleriTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.surumozellikleriTextBox.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.surumozellikleriTextBox.ForeColor = System.Drawing.Color.Black;
            this.surumozellikleriTextBox.Location = new System.Drawing.Point(12, 12);
            this.surumozellikleriTextBox.Multiline = true;
            this.surumozellikleriTextBox.Name = "surumozellikleriTextBox";
            this.surumozellikleriTextBox.ReadOnly = true;
            this.surumozellikleriTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.surumozellikleriTextBox.ShortcutsEnabled = false;
            this.surumozellikleriTextBox.Size = new System.Drawing.Size(687, 267);
            this.surumozellikleriTextBox.TabIndex = 0;
            this.surumozellikleriTextBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.surumozellikleriTextBox_MouseDown);
            // 
            // guncelleneceksurumLabel
            // 
            this.guncelleneceksurumLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guncelleneceksurumLabel.AutoEllipsis = true;
            this.guncelleneceksurumLabel.Location = new System.Drawing.Point(12, 297);
            this.guncelleneceksurumLabel.Name = "guncelleneceksurumLabel";
            this.guncelleneceksurumLabel.Size = new System.Drawing.Size(657, 15);
            this.guncelleneceksurumLabel.TabIndex = 1;
            this.guncelleneceksurumLabel.Text = "Güncellenecek sürüm:";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.Enabled = false;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(261, 379);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 35);
            this.button1.TabIndex = 2;
            this.button1.Text = "Lütfen Bekleyiniz...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(144, 337);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(393, 20);
            this.progressBar1.TabIndex = 4;
            // 
            // indirmekontrol
            // 
            this.indirmekontrol.Enabled = true;
            this.indirmekontrol.Interval = 3500;
            this.indirmekontrol.Tick += new System.EventHandler(this.indirmekontrol_Tick);
            // 
            // programyoluLabel
            // 
            this.programyoluLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.programyoluLabel.AutoEllipsis = true;
            this.programyoluLabel.ForeColor = System.Drawing.Color.Black;
            this.programyoluLabel.Location = new System.Drawing.Point(12, 312);
            this.programyoluLabel.Name = "programyoluLabel";
            this.programyoluLabel.Size = new System.Drawing.Size(657, 15);
            this.programyoluLabel.TabIndex = 9;
            this.programyoluLabel.Text = "Program yolu: ...";
            // 
            // programSurumLabel
            // 
            this.programSurumLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.programSurumLabel.ForeColor = System.Drawing.Color.Black;
            this.programSurumLabel.Location = new System.Drawing.Point(12, 282);
            this.programSurumLabel.Name = "programSurumLabel";
            this.programSurumLabel.Size = new System.Drawing.Size(657, 15);
            this.programSurumLabel.TabIndex = 8;
            this.programSurumLabel.Text = "Şu an yüklü olan sürüm:";
            // 
            // guncellemetamamla_1
            // 
            this.guncellemetamamla_1.Interval = 6890;
            this.guncellemetamamla_1.Tick += new System.EventHandler(this.guncellemetamamla_1_Tick);
            // 
            // yuklemedurumLabel
            // 
            this.yuklemedurumLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.yuklemedurumLabel.AutoEllipsis = true;
            this.yuklemedurumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yuklemedurumLabel.ForeColor = System.Drawing.Color.Black;
            this.yuklemedurumLabel.Location = new System.Drawing.Point(141, 360);
            this.yuklemedurumLabel.Name = "yuklemedurumLabel";
            this.yuklemedurumLabel.Size = new System.Drawing.Size(370, 15);
            this.yuklemedurumLabel.TabIndex = 11;
            this.yuklemedurumLabel.Text = "Hazır";
            // 
            // guncellemetamamla_2
            // 
            this.guncellemetamamla_2.Interval = 3500;
            this.guncellemetamamla_2.Tick += new System.EventHandler(this.guncellemetamamla_2_Tick);
            // 
            // zamanasimikontrol
            // 
            this.zamanasimikontrol.Interval = 15000;
            this.zamanasimikontrol.Tick += new System.EventHandler(this.zamanasimikontrol_Tick);
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "mCTerminal Güncelleyici Sürümü";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::mct_upd.Properties.Resources.info;
            this.pictureBox1.Location = new System.Drawing.Point(661, 402);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(16, 16);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox1, "v2.0.1");
            // 
            // guncellemedosyacikart_1
            // 
            this.guncellemedosyacikart_1.Interval = 3000;
            this.guncellemedosyacikart_1.Tick += new System.EventHandler(this.guncellemedosyacikart_1_Tick);
            // 
            // guncellemedosyacikart_2
            // 
            this.guncellemedosyacikart_2.Interval = 2000;
            this.guncellemedosyacikart_2.Tick += new System.EventHandler(this.guncellemedosyacikart_2_Tick);
            // 
            // guncellemetamamla_3
            // 
            this.guncellemetamamla_3.Interval = 2000;
            this.guncellemetamamla_3.Tick += new System.EventHandler(this.guncellemetamamla_3_Tick);
            // 
            // butonAktifTimer
            // 
            this.butonAktifTimer.Enabled = true;
            this.butonAktifTimer.Interval = 3453;
            this.butonAktifTimer.Tick += new System.EventHandler(this.butonAktifTimer_Tick);
            // 
            // yuklemePictureBox
            // 
            this.yuklemePictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.yuklemePictureBox.BackColor = System.Drawing.Color.Transparent;
            this.yuklemePictureBox.Image = global::mct_upd.Properties.Resources.loading_gif_transparent_2;
            this.yuklemePictureBox.Location = new System.Drawing.Point(517, 360);
            this.yuklemePictureBox.Name = "yuklemePictureBox";
            this.yuklemePictureBox.Size = new System.Drawing.Size(20, 20);
            this.yuklemePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.yuklemePictureBox.TabIndex = 10;
            this.yuklemePictureBox.TabStop = false;
            // 
            // guncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(681, 425);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.yuklemedurumLabel);
            this.Controls.Add(this.yuklemePictureBox);
            this.Controls.Add(this.programyoluLabel);
            this.Controls.Add(this.programSurumLabel);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.guncelleneceksurumLabel);
            this.Controls.Add(this.surumozellikleriTextBox);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "guncelle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "mCTerminal Güncelleyici";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.guncelle_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.guncelle_FormClosed);
            this.Load += new System.EventHandler(this.guncelle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yuklemePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox surumozellikleriTextBox;
        private System.Windows.Forms.Label guncelleneceksurumLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer indirmekontrol;
        private System.Windows.Forms.Label programyoluLabel;
        private System.Windows.Forms.Label programSurumLabel;
        private System.Windows.Forms.PictureBox yuklemePictureBox;
        private System.Windows.Forms.Timer guncellemetamamla_1;
        private System.Windows.Forms.Label yuklemedurumLabel;
        private System.Windows.Forms.Timer guncellemetamamla_2;
        private System.Windows.Forms.Timer zamanasimikontrol;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Timer guncellemedosyacikart_1;
        private System.Windows.Forms.Timer guncellemedosyacikart_2;
        private System.Windows.Forms.Timer guncellemetamamla_3;
        private System.Windows.Forms.Timer butonAktifTimer;
    }
}