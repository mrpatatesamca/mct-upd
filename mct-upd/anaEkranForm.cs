using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mct_upd
{
    public partial class anaEkranForm : Form
    {
        public string version;
        public string guncel_version;
        public string programyolu;

        public anaEkranForm()
        {
            InitializeComponent();
        }

        private void anaEkranForm_Load(object sender, EventArgs e)
        {
            //update klasörü yok ise program açılışta kendisi oluşturur.
            if (!Directory.Exists("update"))
            {
                Directory.CreateDirectory("update");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            yukleTimer.Stop();
            //hemencecik burada versiyon bilgisini yazıversin xd
            programyolu = System.AppDomain.CurrentDomain.BaseDirectory;
            programyoluLabel.Text = "Program yolu: " + programyolu;
            //aşağıda her hangi bir şey hata verirse bütün işlem duruyor ve arayüz boş kalıyor, boş kalmasın diye buraya ayrı ty parantezi açtım
            try
            {
                using (WebClient client1 = new WebClient())
                {
                    guncel_version = client1.DownloadString("https://www.cosmostakimi.com/.mcterminal/version.txt");
                    guncelsurumLabel.Text = "En güncel olan sürüm: v" + guncel_version;
                }
            }
            catch
            {
                guncelsurumLabel.Text = "En güncel olan sürüm: HATA!";
            }
            //basit ve kafa karıştırmaması açısından bütün kodları tek bir try parantezine yazıyorum

            try
            {
                //programın çalıştığı dizini alır ve o dizin içindeki "mCTerminal.exe" dosyasının sürümünü kontrol eder
                var versionInfo = System.Diagnostics.FileVersionInfo.GetVersionInfo(programyolu + "mCTerminal.exe");
                version = versionInfo.FileVersion;
                //sürüm bilgilerini arayüz'de gösterir
                programSurumLabel.Text = "Şu anda yüklü olan sürüm: v" + version;
                //internetten güncel sürüm numarasını alır (Cosmos Takımı'nın sitesinden, yani benim tasarımını ve bakımını yaptığım siteden)
                using (WebClient client = new WebClient())
                {
                    guncel_version = client.DownloadString("https://www.cosmostakimi.com/.mcterminal/version.txt");
                    zamanasimikontrolTimer.Stop();
                    if (guncel_version == version) //eğer program sürümü ile internetteki sürüm aynı ise
                    {
                        baglantidurumLabel.Text = "Programınız zaten güncel! (v" + version + ")";
                        guncelsurumLabel.Text = "En güncel olan sürüm: v" + guncel_version;
                        durumPictureBox.Image = mct_upd.Properties.Resources.tick;
                        //MessageBox.Show("mCTerminal programı için en güncel sürüm zaten yüklü! (Yüklü sürüm: v" + version + ")", "Güncelleştirme bulunamadı!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else //eğer internetteki sürüm ile program sürümü aynı DEĞİL ise (normal şartlarda aynı olmadığı durumda bilgisayardaki program eski olacaktır mutlaka)
                    {
                        baglantidurumLabel.Text = "Güncelleştirme bulundu! (v" + guncel_version + ")";
                        guncelsurumLabel.Text = "En güncel olan sürüm: v" + guncel_version;
                        durumPictureBox.Image = mct_upd.Properties.Resources.warning;
                        guncelleButon.Text = "Güncelleştirmeleri Yükle";
                    }
                }
            }

            catch (Exception ex)
            {

                zamanasimikontrolTimer.Stop();
                baglantidurumLabel.Text = "Hata! Güncelleyici bir problem ile karşılaştı.";
                durumPictureBox.Image = mct_upd.Properties.Resources.error;
                programSurumLabel.Text = "Şu anda yüklü olan sürüm: HATA!";
                //hangi hatayı göstereceğine karar verir.
                if (!File.Exists("mCTerminal.exe"))
                {
                    MessageBox.Show("mCTerminal Güncelleyici bir hata ile karşılaştı! (mCTerminal.exe dosyası bulunamadı!)", "Bir hata meydana geldi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("mCTerminal Güncelleyici bir hata ile karşılaştı! (Sunucu ile bağlantı kurulamadı!)", "Bir hata meydana geldi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void anaEkranForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void zamanasimikontrol_Tick(object sender, EventArgs e)
        {
            if (MessageBox.Show("Görünüşe göre güncelleme dosyası indirilemiyor! İnternet bağlantınızda bir problem olabilir, tekrar denemek ister misiniz?", "Bağlantı zaman aşımı!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                Application.Restart();
            }
        }

        private void guncelleButon_Click(object sender, EventArgs e)
        {
            if (guncelleButon.Text == "Kapat") //eğer button1'in yazısı Kapat ise programı kapat (güncel sürüm bulunduğu zaman button1'in yazısı Güncelleştirmeleri Yükle olarak değişir, o zaman ise guncelle isimli formu açar)
            {
                this.Close();
            }
            else
            {
                guncelle guncellefrm = new guncelle();
                guncellefrm.Show();
                this.Hide();
            }
        }

        private void indirmeyezorlaButon_Click(object sender, EventArgs e)
        {
            kurtar kurtarfrm = new kurtar();
            kurtarfrm.Show();
            this.Hide();
        }
    }
}
