namespace mct_upd
{
    partial class anaEkranForm
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(anaEkranForm));
            this.baglantidurumLabel = new System.Windows.Forms.Label();
            this.programSurumLabel = new System.Windows.Forms.Label();
            this.guncelsurumLabel = new System.Windows.Forms.Label();
            this.yukleTimer = new System.Windows.Forms.Timer(this.components);
            this.guncelleButon = new System.Windows.Forms.Button();
            this.programyoluLabel = new System.Windows.Forms.Label();
            this.zamanasimikontrolTimer = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.indirmeyezorlaButon = new System.Windows.Forms.Button();
            this.durumPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.durumPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // baglantidurumLabel
            // 
            this.baglantidurumLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.baglantidurumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.baglantidurumLabel.ForeColor = System.Drawing.Color.Black;
            this.baglantidurumLabel.Location = new System.Drawing.Point(15, 144);
            this.baglantidurumLabel.Name = "baglantidurumLabel";
            this.baglantidurumLabel.Size = new System.Drawing.Size(335, 17);
            this.baglantidurumLabel.TabIndex = 2;
            this.baglantidurumLabel.Text = "Sunucuya bağlanılıyor...";
            this.baglantidurumLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // programSurumLabel
            // 
            this.programSurumLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.programSurumLabel.ForeColor = System.Drawing.Color.Black;
            this.programSurumLabel.Location = new System.Drawing.Point(12, 84);
            this.programSurumLabel.Name = "programSurumLabel";
            this.programSurumLabel.Size = new System.Drawing.Size(340, 15);
            this.programSurumLabel.TabIndex = 3;
            this.programSurumLabel.Text = "Şu an yüklü olan sürüm: N/A";
            this.programSurumLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // guncelsurumLabel
            // 
            this.guncelsurumLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.guncelsurumLabel.ForeColor = System.Drawing.Color.Black;
            this.guncelsurumLabel.Location = new System.Drawing.Point(12, 99);
            this.guncelsurumLabel.Name = "guncelsurumLabel";
            this.guncelsurumLabel.Size = new System.Drawing.Size(340, 15);
            this.guncelsurumLabel.TabIndex = 4;
            this.guncelsurumLabel.Text = "En güncel olan sürüm: N/A";
            this.guncelsurumLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // yukleTimer
            // 
            this.yukleTimer.Enabled = true;
            this.yukleTimer.Interval = 1000;
            this.yukleTimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // guncelleButon
            // 
            this.guncelleButon.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.guncelleButon.ForeColor = System.Drawing.SystemColors.ControlText;
            this.guncelleButon.Location = new System.Drawing.Point(174, 159);
            this.guncelleButon.Name = "guncelleButon";
            this.guncelleButon.Size = new System.Drawing.Size(127, 23);
            this.guncelleButon.TabIndex = 6;
            this.guncelleButon.Text = "Kapat";
            this.guncelleButon.UseVisualStyleBackColor = true;
            this.guncelleButon.Click += new System.EventHandler(this.guncelleButon_Click);
            // 
            // programyoluLabel
            // 
            this.programyoluLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.programyoluLabel.AutoEllipsis = true;
            this.programyoluLabel.ForeColor = System.Drawing.Color.Black;
            this.programyoluLabel.Location = new System.Drawing.Point(12, 114);
            this.programyoluLabel.Name = "programyoluLabel";
            this.programyoluLabel.Size = new System.Drawing.Size(340, 15);
            this.programyoluLabel.TabIndex = 7;
            this.programyoluLabel.Text = "Program yolu: N/A";
            this.programyoluLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // zamanasimikontrolTimer
            // 
            this.zamanasimikontrolTimer.Enabled = true;
            this.zamanasimikontrolTimer.Interval = 15000;
            this.zamanasimikontrolTimer.Tick += new System.EventHandler(this.zamanasimikontrol_Tick);
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "mCTerminal Güncelleyici Sürümü";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::mct_upd.Properties.Resources.info;
            this.pictureBox1.Location = new System.Drawing.Point(341, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(16, 16);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox1, "v2.0.1");
            // 
            // toolTip2
            // 
            this.toolTip2.AutoPopDelay = 20000;
            this.toolTip2.InitialDelay = 500;
            this.toolTip2.ReshowDelay = 100;
            this.toolTip2.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Warning;
            this.toolTip2.ToolTipTitle = "Program Dosyalarını İndir";
            // 
            // indirmeyezorlaButon
            // 
            this.indirmeyezorlaButon.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.indirmeyezorlaButon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.indirmeyezorlaButon.ForeColor = System.Drawing.SystemColors.ControlText;
            this.indirmeyezorlaButon.Location = new System.Drawing.Point(64, 159);
            this.indirmeyezorlaButon.Name = "indirmeyezorlaButon";
            this.indirmeyezorlaButon.Size = new System.Drawing.Size(104, 23);
            this.indirmeyezorlaButon.TabIndex = 14;
            this.indirmeyezorlaButon.Text = "Kurtarma Modu";
            this.toolTip2.SetToolTip(this.indirmeyezorlaButon, "Sürümünüz ne olursa olsun sunucudan en son sürümü indirir.");
            this.indirmeyezorlaButon.UseVisualStyleBackColor = true;
            this.indirmeyezorlaButon.Click += new System.EventHandler(this.indirmeyezorlaButon_Click);
            // 
            // durumPictureBox
            // 
            this.durumPictureBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.durumPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.durumPictureBox.Image = global::mct_upd.Properties.Resources.loading_gif_transparent_2;
            this.durumPictureBox.Location = new System.Drawing.Point(150, 10);
            this.durumPictureBox.Name = "durumPictureBox";
            this.durumPictureBox.Size = new System.Drawing.Size(64, 64);
            this.durumPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.durumPictureBox.TabIndex = 8;
            this.durumPictureBox.TabStop = false;
            // 
            // anaEkranForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(364, 187);
            this.Controls.Add(this.indirmeyezorlaButon);
            this.Controls.Add(this.guncelleButon);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.durumPictureBox);
            this.Controls.Add(this.programyoluLabel);
            this.Controls.Add(this.guncelsurumLabel);
            this.Controls.Add(this.programSurumLabel);
            this.Controls.Add(this.baglantidurumLabel);
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "anaEkranForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "mCTerminal Güncelleyici";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.anaEkranForm_FormClosed);
            this.Load += new System.EventHandler(this.anaEkranForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.durumPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label baglantidurumLabel;
        private System.Windows.Forms.Label programSurumLabel;
        private System.Windows.Forms.Label guncelsurumLabel;
        private System.Windows.Forms.Timer yukleTimer;
        private System.Windows.Forms.Button guncelleButon;
        private System.Windows.Forms.Label programyoluLabel;
        private System.Windows.Forms.PictureBox durumPictureBox;
        private System.Windows.Forms.Timer zamanasimikontrolTimer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button indirmeyezorlaButon;
        private System.Windows.Forms.ToolTip toolTip2;
    }
}