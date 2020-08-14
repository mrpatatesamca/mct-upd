using Ionic.Zip;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mct_upd
{
    public partial class kurtar : Form
    {
        public kurtar()
        {
            InitializeComponent();
        }

        string programyolu = System.AppDomain.CurrentDomain.BaseDirectory;

        private void zamanasimikontrol_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value == 0)
            {
                if (MessageBox.Show("Görünüşe göre kurtarma dosyası indirilemiyor! İnternet bağlantınızda bir problem olabilir, tekrar denemek ister misiniz?", "Bağlantı Zaman Aşımı!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
                {
                    surumozellikleriTextBox.AppendText("Kurtarma başarıyla tamamlandı!" + Environment.NewLine);
                    Application.Exit();
                }
                else
                {
                    surumozellikleriTextBox.AppendText("Kurtarma başarıyla tamamlandı!" + Environment.NewLine);
                    Application.Restart();
                }
            }
        }

        private void indirmekontrol_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value == 100) //eğer indirme tamamlanmış ise
            {
                indirmekontrol.Stop();
                zamanasimikontrol.Stop();
                progressBar1.Style = ProgressBarStyle.Marquee;
                progressBar1.MarqueeAnimationSpeed = 15;
                surumozellikleriTextBox.AppendText("Kurtarma dosyası başarıyla indirildi!" + Environment.NewLine);
                yuklemedurumLabel.Text = "Kurtarma dosyası indirildi!";
                guncellemedosyacikart_1.Start();
            }
        }

        private void kurtarButton_Click(object sender, EventArgs e)
        {
            try
            {
                zamanasimikontrol.Start();

                using (WebClient wc = new WebClient())
                {
                    yuklemePictureBox.Visible = true;
                    surumozellikleriTextBox.Text = string.Empty;
                    surumozellikleriTextBox.AppendText("Kurtarma işlemi başlatılıyor..." + Environment.NewLine);
                    surumozellikleriTextBox.AppendText("Gerekli dosyalar indiriliyor..." + Environment.NewLine);
                    //Cosmos Takımı sitesinden (evet benim tasarımını ve bakımını yaptığım site :D) en son sürümü indirir
                    wc.DownloadProgressChanged += wc_DownloadProgressChanged;
                    wc.DownloadFileAsync(new System.Uri("https://www.cosmostakimi.com/.mcterminal/mcterminal-recover-package.zip"), programyolu + @"update\mcterminal-recover-package.zip");
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
                surumozellikleriTextBox.AppendText("Kurtarma başarısız oldu! (mCTerminal.exe'nin kapalı olduğundan ve internete bağlı olduğunuzdan emin olun!)" + Environment.NewLine);
            }
        }

        void wc_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            //indirme oranı ile yükleme çubuğunun seviyesini eşitler
            progressBar1.Value = e.ProgressPercentage;
            yuklemedurumLabel.Text = "Kurtarma dosyaları indiriliyor: %" + e.ProgressPercentage.ToString();
        }

        private void guncellemedosyacikart_1_Tick(object sender, EventArgs e)
        {
            surumozellikleriTextBox.AppendText("Kurtarma hazırlıkları yapılıyor..." + Environment.NewLine);
            guncellemedosyacikart_1.Stop();
            guncellemedosyacikart_2.Start();
            progressBar1.Style = ProgressBarStyle.Continuous;
            progressBar1.Value = 20;
        }

        private void guncellemedosyacikart_2_Tick(object sender, EventArgs e)
        {
            guncellemedosyacikart_2.Stop();
            try
            {
                surumozellikleriTextBox.AppendText("mCTerminal.exe işlemi sonlandırılıyor..." + Environment.NewLine);
                surumozellikleriTextBox.AppendText("mCTerminal.exe işlemi sonlandırıldı!" + Environment.NewLine);
                surumozellikleriTextBox.AppendText("Kurtarma dosyası ayıklanıyor..." + Environment.NewLine);
                yuklemedurumLabel.Text = "Kurtarma dosyası ayıklanıyor...";
                progressBar1.Value = 50;
                //indirilen zip dosyasını arşivden çıkartır (ve eski dosyaların üstüne yazar.)
                string zipPath = programyolu + @"update\mcterminal-recover-package.zip";
                string extractPath = programyolu;
                using (ZipFile archive = new ZipFile(zipPath))
                {
                    archive.ExtractAll(extractPath, ExtractExistingFileAction.OverwriteSilently);

                    surumozellikleriTextBox.AppendText("Kurtarma dosyası ayıklandı ve başarıyla yüklendi!" + Environment.NewLine);

                    yuklemedurumLabel.Text = "Kurtarma başarıyla yüklendi!";
                    progressBar1.Value = 68;
                    surumozellikleriTextBox.AppendText("Artık dosyalar siliniyor..." + Environment.NewLine);
                    int line = surumozellikleriTextBox.GetLineFromCharIndex(surumozellikleriTextBox.SelectionStart);
                    int column = surumozellikleriTextBox.SelectionStart - surumozellikleriTextBox.GetFirstCharIndexFromLine(line);
                    guncellemetamamla_1.Start();
                }
            }
            catch
            {
                surumozellikleriTextBox.AppendText("Kurtarma başarısız oldu!" + Environment.NewLine);
            }
        }

        private void guncellemetamamla_1_Tick(object sender, EventArgs e)
        {
            guncellemetamamla_1.Stop();
            progressBar1.Value = 84;
            try
            {
                yuklemedurumLabel.Text = "Kurtarma tamamlanıyor...";
                File.Delete(programyolu + @"update\mcterminal-recover-package.zip");

                surumozellikleriTextBox.AppendText("Artık dosyalar başarıyla silindi!." + Environment.NewLine);
                surumozellikleriTextBox.AppendText("Kurtarma başarıyla tamamlandı!" + Environment.NewLine);
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

        private void kurtar_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Programı kurtarma bittikten sonra kendini kapatırken saçma saçma vazgeçmek istiyor musunuz diye sormasın diye kontrol yapıyor. Eğer kurtarma başarıyla bitti diye bi yazı bulursa sormadan programı kapatır.
            if (surumozellikleriTextBox.Text.Contains("Kurtarma başarıyla tamamlandı!"))
            {
                Application.Exit();
            }
            else
            {
                if (MessageBox.Show("Kurtarma işleminden vazgeçmek istediğinize emin misiniz?", "Yüklemekten vazgeçmek istiyor musunuz?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
                {
                    e.Cancel = true;
                }
                else
                {
                    anaEkranForm anaEkranFormfrm = new anaEkranForm();
                    anaEkranFormfrm.Show();
                }
            }
        }

        private void iptalButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void kurtar_Load(object sender, EventArgs e)
        {
            kurtarButton.Focus(); //sürüm notları kısmında imleç (yanıp sönen) çıkmasın diye textbox'a tıklandığı an güncelleştirme yükleme butonuna odaklıyor.
        }

        private void kurtar_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void surumozellikleriTextBox_MouseDown(object sender, MouseEventArgs e)
        {
            kurtarButton.Focus(); //sürüm notları kısmında imleç (yanıp sönen) çıkmasın diye textbox'a tıklandığı an güncelleştirme yükleme butonuna odaklıyor.
        }

        private void odakTimer_Tick(object sender, EventArgs e)
        {
            odakTimer.Stop();
            kurtarButton.Focus(); //sürüm notları kısmında imleç (yanıp sönen) çıkmasın diye textbox'a tıklandığı an güncelleştirme yükleme butonuna odaklıyor.
        }
    }
}
