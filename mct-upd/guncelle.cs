using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using Ionic.Zip;

namespace mct_upd
{
    public partial class guncelle : Form
    {
        public string programyolu;
        public string version;
        public string guncel_version;

        public guncelle()
        {
            InitializeComponent();
        }

        private void guncelle_Load(object sender, EventArgs e)
        {
            //pictureBox1.Image = mCTerminal_updater.Properties.Resources.info;
            //yuklemePictureBox.Image = mCTerminal_updater.Properties.Resources.rolling_loading64x64_17_40_51;

            //programın olduğu dizini alır (bunu try parantezi dışına yazdım çünkü orada başka bir şey hata verirse bu da çalışmaz ve bu mutlaka çalışacaktır)
            programyolu = System.AppDomain.CurrentDomain.BaseDirectory;
            programyoluLabel.Text = "Program yolu: " + programyolu;
            try
            {
                //textbox düzgün gözüksün diye
                surumozellikleriTextBox.SelectionStart = surumozellikleriTextBox.Text.Length;

                //mCTerminal programının sürüm bilgisini alır (bu yüzden mCTerminal-Updater.exe ve mCTerminal.exe aynı dizinde olmak zorunda
                var versionInfo = System.Diagnostics.FileVersionInfo.GetVersionInfo(programyolu + @"mCTerminal.exe");
                version = versionInfo.FileVersion;

                programSurumLabel.Text = "Şu anda yüklü program sürümü: v" + version;

                //ne olur ne olmaz önceden başarısız bir indirme varsa silsin onu
                File.Delete(programyolu + @"mcterminal-update-package.zip");
            }
            catch
            {

            }

            //Cosmos Takımı'nın sitesi üzerinden (oraya da ben bakıyorum ve ilgileniyorum :D) en güncel sürüm bilgisini ve sürüm notlarını alır
            using (WebClient client = new WebClient())
            {
                try
                {
                    string guncel_version = client.DownloadString("https://www.cosmostakimi.com/.mcterminal/version.txt");
                    string guncel_version_notes = client.DownloadString("https://www.cosmostakimi.com/.mcterminal/version-notes.txt");
                    guncelleneceksurumLabel.Text = "Güncellenecek sürüm: v" + guncel_version;
                    surumozellikleriTextBox.Text = guncel_version_notes;
                    surumozellikleriTextBox.SelectionStart = surumozellikleriTextBox.Text.Length;
                }
                catch
                {

                }
            }
            button1.Focus(); //sürüm notları kısmında imleç (yanıp sönen) çıkmasın diye textbox'a tıklandığı an güncelleştirme yükleme butonuna odaklıyor.
        }

        private void guncelle_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Programı güncelleme bittikten sonra kendini kapatırken saçma saçma vazgeçmek istiyor musunuz diye sormasın diye kontrol yapıyor. Eğer güncelleme başarıyla bitti diye bi yazı bulursa sormadan programı kapatır.
            if (surumozellikleriTextBox.Text.Contains("Güncelleştirme başarıyla tamamlandı!"))
            {

            }
            else
            {
                if (MessageBox.Show("Güncelleştirmeleri yüklemekten vazgeçmek istediğinize emin misiniz?", "Yüklemekten Vazgeçmek İstiyor musunuz?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "Güncellemeyi İndir ve Kur")
            {
                try
                {
                    button1.Text = "İptal";
                    zamanasimikontrol.Start();
                    string programyolu = System.AppDomain.CurrentDomain.BaseDirectory;
                    using (WebClient wc = new WebClient())
                    {
                        yuklemePictureBox.Visible = true;
                        surumozellikleriTextBox.Text = string.Empty;
                        surumozellikleriTextBox.AppendText("Güncelleştirme işlemi başlatılıyor..." + Environment.NewLine);
                        surumozellikleriTextBox.AppendText("Gerekli güncelleştirme dosyası indiriliyor..." + Environment.NewLine);
                        //Cosmos Takımı sitesinden (evet benim tasarımını ve bakımını yaptığım site :D) en son sürümü indirir
                        wc.DownloadProgressChanged += wc_DownloadProgressChanged;
                        wc.DownloadFileAsync(new System.Uri("https://www.cosmostakimi.com/.mcterminal/mcterminal-update-package.zip"), programyolu + @"update\mcterminal-update-package.zip");
                        //Dikkat ettiyseniz burada indirdiği .zip dosyasının ismi hep küçük harflerle, diğer yerlerdeki arşiv dosyalarının isimleri ise büyük harf içeriyor. Çünkü canım sıkıldı öyle yaptım.

                        //mcterminal programını sonladır. (Komut penceresi açar ve mCTerminal.exe programını sonlandırır, zip arşivinden dosyaları çıkarırken hata olmasın diye.
                        System.Diagnostics.Process process = new System.Diagnostics.Process();
                        System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                        startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                        startInfo.FileName = "cmd.exe";
                        startInfo.Arguments = "/C taskkill /F /IM mCTerminal.exe";
                        process.StartInfo = startInfo;
                        process.Start();
                    }
                }
                catch
                {
                    surumozellikleriTextBox.AppendText("Güncelleştirme başarısız oldu! (mCTerminal.exe'nin kapalı olduğundan ve internete bağlı olduğunuzdan emin olun!)" + Environment.NewLine);
                }
            }
            else
            {
                this.Close();
            }
        }
        void wc_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            //indirme oranı ile yükleme çubuğunun seviyesini eşitler
            progressBar1.Value = e.ProgressPercentage;
            yuklemedurumLabel.Text = "Güncelleştirme dosyası indiriliyor: %" + e.ProgressPercentage.ToString();
        }

        private void guncelle_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void zamanasimikontrol_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value == 0)
            {
                if (MessageBox.Show("Görünüşe göre güncelleme dosyası indirilemiyor! İnternet bağlantınızda bir problem olabilir, tekrar denemek ister misiniz?", "Bağlantı Zaman Aşımı!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
                {
                    surumozellikleriTextBox.AppendText("Güncelleştirme başarıyla tamamlandı!" + Environment.NewLine);
                    Application.Exit();
                }
                else
                {
                    surumozellikleriTextBox.AppendText("Güncelleştirme başarıyla tamamlandı!" + Environment.NewLine);
                    Application.Restart();
                }
            }
        }

        private void indirmekontrol_Tick(object sender, EventArgs e) //indirmenin tamamlanıp tamamlanmadığını kontrol eder
        {
            if (progressBar1.Value == 100) //eğer indirme tamamlanmış ise
            {
                indirmekontrol.Stop();
                zamanasimikontrol.Stop();
                progressBar1.Style = ProgressBarStyle.Marquee;
                progressBar1.MarqueeAnimationSpeed = 15;
                surumozellikleriTextBox.AppendText("Güncelleştirme dosyası başarıyla indirildi!" + Environment.NewLine);
                yuklemedurumLabel.Text = "Güncelleştirme dosyası indirildi!";
                guncellemedosyacikart_1.Start();
            }
        }

        private void guncellemedosyacikart_1_Tick(object sender, EventArgs e) //yavaş ve okunur olması için timerlar ile böldüm
        {
            surumozellikleriTextBox.AppendText("Hazırlıklar yapılıyor..." + Environment.NewLine);
            guncellemedosyacikart_1.Stop();
            guncellemedosyacikart_2.Start();
            progressBar1.Style = ProgressBarStyle.Continuous;
            progressBar1.Value = 20;
        }

        private void guncellemedosyacikart_2_Tick(object sender, EventArgs e) //yavaş ve okunur olması için timer ile böldüm
        {
            guncellemedosyacikart_2.Stop();
            try
            {
                surumozellikleriTextBox.AppendText("mCTerminal.exe işlemi sonlandırılıyor..." + Environment.NewLine);
                surumozellikleriTextBox.AppendText("mCTerminal.exe işlemi sonlandırıldı!" + Environment.NewLine);
                surumozellikleriTextBox.AppendText("Güncelleştirme dosyası ayıklanıyor..." + Environment.NewLine);
                yuklemedurumLabel.Text = "Güncelleştirme dosyası ayıklanıyor...";
                progressBar1.Value = 50;
                //indirilen zip dosyasını arşivden çıkartır (ve eski dosyaların üstüne yazar.)
                programyolu = System.AppDomain.CurrentDomain.BaseDirectory;
                string zipPath = programyolu + @"update\mcterminal-update-package.zip";
                string extractPath = programyolu;
                using (ZipFile archive = new ZipFile(zipPath))
                {
                    archive.ExtractAll(extractPath, ExtractExistingFileAction.OverwriteSilently);

                    surumozellikleriTextBox.AppendText("Güncelleştirme dosyası ayıklandı ve başarıyla yüklendi!" + Environment.NewLine);

                    yuklemedurumLabel.Text = "Güncelleştirme başarıyla yüklendi!";
                    progressBar1.Value = 68;
                    surumozellikleriTextBox.AppendText("Artık dosyalar siliniyor..." + Environment.NewLine);
                    int line = surumozellikleriTextBox.GetLineFromCharIndex(surumozellikleriTextBox.SelectionStart);
                    int column = surumozellikleriTextBox.SelectionStart - surumozellikleriTextBox.GetFirstCharIndexFromLine(line);
                    guncellemetamamla_1.Start();
                }
            }
            catch
            {
                surumozellikleriTextBox.AppendText("Güncelleştirme başarısız oldu!" + Environment.NewLine);
            }
        }

        private void guncellemetamamla_1_Tick(object sender, EventArgs e)
        {
            string programyolu = System.AppDomain.CurrentDomain.BaseDirectory;
            guncellemetamamla_1.Stop();
            progressBar1.Value = 84;
            try
            {
                yuklemedurumLabel.Text = "Güncelleştirme tamamlanıyor...";
                File.Delete(programyolu + @"update\mcterminal-update-package.zip");
                surumozellikleriTextBox.AppendText("Artık dosyalar başarıyla silindi!." + Environment.NewLine);
                surumozellikleriTextBox.AppendText("Güncelleştirme başarıyla tamamlandı!" + Environment.NewLine);
                surumozellikleriTextBox.AppendText("mCTerminal programı başlatılıyor..." + Environment.NewLine);
                int line = surumozellikleriTextBox.GetLineFromCharIndex(surumozellikleriTextBox.SelectionStart);
                int column = surumozellikleriTextBox.SelectionStart - surumozellikleriTextBox.GetFirstCharIndexFromLine(line);
                guncellemetamamla_2.Start();
            }
            catch
            {
                surumozellikleriTextBox.AppendText("mCTerminal.exe programı başlatılamadı!" + Environment.NewLine);
            }
        }

        private void guncellemetamamla_2_Tick(object sender, EventArgs e)
        {
            progressBar1.Value = 100;
            guncellemetamamla_2.Stop();
            guncellemetamamla_3.Start();
        }

        private void guncellemetamamla_3_Tick(object sender, EventArgs e)
        {
            guncellemetamamla_3.Stop();
            string programyolu = System.AppDomain.CurrentDomain.BaseDirectory;
            Process.Start(programyolu + @"mCTerminal.exe");
            Application.Exit();
        }

        private void butonAktifTimer_Tick(object sender, EventArgs e)
        {
            butonAktifTimer.Stop();
            button1.Enabled = true;
            button1.Text = "Güncellemeyi İndir ve Kur";
            yuklemePictureBox.Visible = false;
            button1.Focus(); //sürüm notları kısmında imleç (yanıp sönen) çıkmasın diye textbox'a tıklandığı an güncelleştirme yükleme butonuna odaklıyor.
        }

        private void surumozellikleriTextBox_MouseDown(object sender, MouseEventArgs e)
        {
            button1.Focus(); //sürüm notları kısmında imleç (yanıp sönen) çıkmasın diye textbox'a tıklandığı an güncelleştirme yükleme butonuna odaklıyor.
        }
    }
}
