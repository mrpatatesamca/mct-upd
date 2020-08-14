namespace mct_upd
{
    partial class kurtar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kurtar));
            this.ustbilgiLabel = new System.Windows.Forms.Label();
            this.surumozellikleriTextBox = new System.Windows.Forms.TextBox();
            this.kurtarButton = new System.Windows.Forms.Button();
            this.iptalButton = new System.Windows.Forms.Button();
            this.yuklemedurumLabel = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.zamanasimikontrol = new System.Windows.Forms.Timer(this.components);
            this.indirmekontrol = new System.Windows.Forms.Timer(this.components);
            this.guncellemedosyacikart_1 = new System.Windows.Forms.Timer(this.components);
            this.guncellemedosyacikart_2 = new System.Windows.Forms.Timer(this.components);
            this.guncellemetamamla_1 = new System.Windows.Forms.Timer(this.components);
            this.guncellemetamamla_2 = new System.Windows.Forms.Timer(this.components);
            this.guncellemetamamla_3 = new System.Windows.Forms.Timer(this.components);
            this.yuklemePictureBox = new System.Windows.Forms.PictureBox();
            this.odakTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.yuklemePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ustbilgiLabel
            // 
            this.ustbilgiLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ustbilgiLabel.Location = new System.Drawing.Point(12, 9);
            this.ustbilgiLabel.Name = "ustbilgiLabel";
            this.ustbilgiLabel.Size = new System.Drawing.Size(405, 45);
            this.ustbilgiLabel.TabIndex = 0;
            this.ustbilgiLabel.Text = resources.GetString("ustbilgiLabel.Text");
            // 
            // surumozellikleriTextBox
            // 
            this.surumozellikleriTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.surumozellikleriTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(30)))), ((int)(((byte)(41)))));
            this.surumozellikleriTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.surumozellikleriTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.surumozellikleriTextBox.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.surumozellikleriTextBox.Location = new System.Drawing.Point(12, 57);
            this.surumozellikleriTextBox.Multiline = true;
            this.surumozellikleriTextBox.Name = "surumozellikleriTextBox";
            this.surumozellikleriTextBox.ReadOnly = true;
            this.surumozellikleriTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.surumozellikleriTextBox.ShortcutsEnabled = false;
            this.surumozellikleriTextBox.Size = new System.Drawing.Size(405, 183);
            this.surumozellikleriTextBox.TabIndex = 1;
            this.surumozellikleriTextBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.surumozellikleriTextBox_MouseDown);
            // 
            // kurtarButton
            // 
            this.kurtarButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.kurtarButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.kurtarButton.Location = new System.Drawing.Point(195, 283);
            this.kurtarButton.Name = "kurtarButton";
            this.kurtarButton.Size = new System.Drawing.Size(127, 23);
            this.kurtarButton.TabIndex = 2;
            this.kurtarButton.Text = "Kurtarma İşlemini Başlat";
            this.kurtarButton.UseVisualStyleBackColor = true;
            this.kurtarButton.Click += new System.EventHandler(this.kurtarButton_Click);
            // 
            // iptalButton
            // 
            this.iptalButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.iptalButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iptalButton.Location = new System.Drawing.Point(106, 283);
            this.iptalButton.Name = "iptalButton";
            this.iptalButton.Size = new System.Drawing.Size(83, 23);
            this.iptalButton.TabIndex = 3;
            this.iptalButton.Text = "İptal";
            this.iptalButton.UseVisualStyleBackColor = true;
            this.iptalButton.Click += new System.EventHandler(this.iptalButton_Click);
            // 
            // yuklemedurumLabel
            // 
            this.yuklemedurumLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.yuklemedurumLabel.AutoEllipsis = true;
            this.yuklemedurumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.yuklemedurumLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.yuklemedurumLabel.Location = new System.Drawing.Point(9, 264);
            this.yuklemedurumLabel.Name = "yuklemedurumLabel";
            this.yuklemedurumLabel.Size = new System.Drawing.Size(318, 15);
            this.yuklemedurumLabel.TabIndex = 14;
            this.yuklemedurumLabel.Text = "Hazır";
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(12, 246);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(402, 15);
            this.progressBar1.TabIndex = 12;
            // 
            // zamanasimikontrol
            // 
            this.zamanasimikontrol.Interval = 15000;
            this.zamanasimikontrol.Tick += new System.EventHandler(this.zamanasimikontrol_Tick);
            // 
            // indirmekontrol
            // 
            this.indirmekontrol.Enabled = true;
            this.indirmekontrol.Interval = 3500;
            this.indirmekontrol.Tick += new System.EventHandler(this.indirmekontrol_Tick);
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
            // guncellemetamamla_1
            // 
            this.guncellemetamamla_1.Interval = 6890;
            this.guncellemetamamla_1.Tick += new System.EventHandler(this.guncellemetamamla_1_Tick);
            // 
            // guncellemetamamla_2
            // 
            this.guncellemetamamla_2.Interval = 3500;
            this.guncellemetamamla_2.Tick += new System.EventHandler(this.guncellemetamamla_2_Tick);
            // 
            // guncellemetamamla_3
            // 
            this.guncellemetamamla_3.Interval = 2000;
            this.guncellemetamamla_3.Tick += new System.EventHandler(this.guncellemetamamla_3_Tick);
            // 
            // yuklemePictureBox
            // 
            this.yuklemePictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.yuklemePictureBox.Image = global::mct_upd.Properties.Resources.rolling_loading64x64_17_40_51;
            this.yuklemePictureBox.Location = new System.Drawing.Point(398, 264);
            this.yuklemePictureBox.Name = "yuklemePictureBox";
            this.yuklemePictureBox.Size = new System.Drawing.Size(16, 16);
            this.yuklemePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.yuklemePictureBox.TabIndex = 13;
            this.yuklemePictureBox.TabStop = false;
            this.yuklemePictureBox.Visible = false;
            // 
            // odakTimer
            // 
            this.odakTimer.Enabled = true;
            this.odakTimer.Interval = 1000;
            this.odakTimer.Tick += new System.EventHandler(this.odakTimer_Tick);
            // 
            // kurtar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(40)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(429, 317);
            this.Controls.Add(this.yuklemedurumLabel);
            this.Controls.Add(this.yuklemePictureBox);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.iptalButton);
            this.Controls.Add(this.kurtarButton);
            this.Controls.Add(this.surumozellikleriTextBox);
            this.Controls.Add(this.ustbilgiLabel);
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "kurtar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "mCTerminal Güncelleyici [Kurtarma Modu]";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.kurtar_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.kurtar_FormClosed);
            this.Load += new System.EventHandler(this.kurtar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.yuklemePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ustbilgiLabel;
        private System.Windows.Forms.TextBox surumozellikleriTextBox;
        private System.Windows.Forms.Button kurtarButton;
        private System.Windows.Forms.Button iptalButton;
        private System.Windows.Forms.Label yuklemedurumLabel;
        private System.Windows.Forms.PictureBox yuklemePictureBox;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer zamanasimikontrol;
        private System.Windows.Forms.Timer indirmekontrol;
        private System.Windows.Forms.Timer guncellemedosyacikart_1;
        private System.Windows.Forms.Timer guncellemedosyacikart_2;
        private System.Windows.Forms.Timer guncellemetamamla_1;
        private System.Windows.Forms.Timer guncellemetamamla_2;
        private System.Windows.Forms.Timer guncellemetamamla_3;
        private System.Windows.Forms.Timer odakTimer;
    }
}