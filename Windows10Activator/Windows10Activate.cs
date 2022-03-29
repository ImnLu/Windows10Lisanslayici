using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;
using System.IO;

namespace Windows10Activator
{
    public partial class AktiflestirmeFormu : Form
    {

        public AktiflestirmeFormu()
        {
            InitializeComponent();
        }
        private void AktiflestirmeFormu_FormClosing(object sender, FormClosingEventArgs e)
        {
            // İlk form açık kaldığı için kapatma tuşuna basıldığında tüm formlaroı kapatır.
            Application.Exit();
        }

        // Komut satırından kod yürütür.
        static void RunCMD(string islemler)
        {
            // System32 klasörünün dosya yolunu bulur.
            string filePath = Path.Combine(Environment.SystemDirectory);

            // System32 klasöründe gizli bir komut satırı programını başlatır.
            Process process = new Process();
            process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.Arguments = "/C " + islemler;
            process.StartInfo.WorkingDirectory = filePath;
            process.Start();
            process.WaitForExit();
        }

        private void AktiflestirmeFormu_Load(object sender, EventArgs e)
        {
            // Form açılırken işlemleri başlatır.
            backgroundWorker1.RunWorkerAsync();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            // Seri anahtarını girer.
            RunCMD("cscript slmgr.vbs /ipk " + Windows10Activator.serialKey);
            pictureBox1.Image = Properties.Resources.tick;

            // Sunucu adresini girer.
            RunCMD("cscript slmgr.vbs /skms kms8.msguides.com");
            pictureBox2.Image = Properties.Resources.tick;

            // Lisansı aktifleştirir.
            RunCMD("cscript slmgr.vbs /ato");
            pictureBox3.Image = Properties.Resources.tick;

            // Tüm olaylar bittikten sonra programı kapatır.
            MessageBox.Show("Bilgisayarınız başarıyla lisanslandı!", "Windows 10 Lisanslayıcı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Application.Exit();
        }
    }
}
