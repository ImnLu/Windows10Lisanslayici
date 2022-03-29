using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows10Activator
{
    public partial class Windows10Activator : Form
    {
        public Windows10Activator()
        {
            InitializeComponent();
        }

        // Değişkenler
        public string osName;
        public static string serialKey;

        #region Seri Anahtarları

        string Home = "TX9XD-98N7V-6WMQ6-BX7FG-H8Q99";
        string HomeN = "3KHY7-WNT83-DGQKR-F7HPR-844BM";
        string HomeSingleLanguage = "7HNRX-D7KGG-3K4RQ-4WPJ4-YTDFH";
        string HomeCountrySpecific = "PVMJN-6DFY6-9CCP6-7BKTT-D3WVR";
        string Professional = "W269N-WFGWX-YVC9B-4J6C9-T83GX";
        string ProfessionalN = "MH37W-N47XK-V7XM9-C7227-GCQG9";
        string Education = "NW6C2-QMPVW-D7KKK-3GKT6-VCFB2";
        string EducationN = "2WH4N-8QGBV-H22JP-CT43Q-MDWWJ";
        string Enterprise = "NPPR9-FWDCX-D2C8J-H872K-2YT43";
        string EnterpriseN = "DPH2V-TTNVB-4X9Q3-TJR4H-KHJW4";

        #endregion

        private void Windows10Activator_Load(object sender, EventArgs e)
        {
            // İşletim sistemi Windows 10 değilse hata veriyor.
            if (OSName().Substring(0, 20) != "Microsoft Windows 10")
            {
                MessageBox.Show("İşletim sisteminiz Windows 10 değil!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }

            // İşletim sisteminin versiyonunu bulur.
            osName = OSName().Substring(21);

            // İşletim sisteminin versiyonuna göre olan seri anahtarını değişkene yazdırır.
            if (osName == "Home")
            {
                serialKey = Home;
                comboOSList.Text = osName;
            }
            else if (osName == "Home N")
            {
                serialKey = HomeN;
                comboOSList.Text = osName;
            }
            else if (osName == "Home Single Language")
            {
                serialKey = HomeSingleLanguage;
                comboOSList.Text = osName;
            }
            else if (osName == "Home Country Specific")
            {
                serialKey = HomeCountrySpecific;
                comboOSList.Text = osName;
            }
            else if (osName == "Pro")
            {
                serialKey = Professional;
                comboOSList.Text = "Professional";
            }
            else if (osName == "Pro N")
            {
                serialKey = ProfessionalN;
                comboOSList.Text = "Professional N";
            }
            else if (osName == "Education")
            {
                serialKey = Education;
                comboOSList.Text = osName;
            }
            else if (osName == "Education N")
            {
                serialKey = EducationN;
                comboOSList.Text = osName;
            }
            else if (osName == "Enterprise")
            {
                serialKey = Enterprise;
                comboOSList.Text = osName;
            }
            else if (osName == "Enterprise N")
            {
                serialKey = EnterpriseN;
                comboOSList.Text = osName;
            }
            else
            {
                // Eğer işletim sistemi bulunmazsa hata verip manuel olarak seçilmesini ister
                MessageBox.Show("İşletim sisteminiz tespit edilemedi.\rLütfen listeden bir işletim sistemi seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comboOSList.Enabled = true;
            }
        }

        // İşletim sisteminin adını döndürür.
        private string OSName()
        {
            return (string)(from x in new ManagementObjectSearcher(
                "SELECT Caption FROM Win32_OperatingSystem").Get().Cast<ManagementObject>()
                            select x.GetPropertyValue("Caption")).FirstOrDefault();
        }

        private void linkLabelOSSelect_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            comboOSList.Enabled = true;
        }

        private void buttonActivate_Click(object sender, EventArgs e)
        {
            // Eğer listeden işletim sistemi seçilmediyse hata verir.
            if (string.IsNullOrEmpty(comboOSList.Text))
            {
                MessageBox.Show("Lütfen bir işletim sistemi sürümü seçiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                AktiflestirmeFormu aktiflestirmeFormu = new AktiflestirmeFormu();
                this.Hide();
                aktiflestirmeFormu.Show();
            }
        }

        private void comboOSList_TextChanged(object sender, EventArgs e)
        {
            // Combobox'ın seçimi değiştiğinde seri anahtarını günceller.
            if (comboOSList.Text == "Home")
            {
                serialKey = Home;
            }
            else if (comboOSList.Text == "Home N")
            {
                serialKey = HomeN;
            }
            else if (comboOSList.Text == "Home Single Language")
            {
                serialKey = HomeSingleLanguage;
            }
            else if (comboOSList.Text == "Home Country Specific")
            {
                serialKey = HomeCountrySpecific;
            }
            else if (comboOSList.Text == "Professional")
            {
                serialKey = Professional;
            }
            else if (comboOSList.Text == "Professional N")
            {
                serialKey = ProfessionalN;
            }
            else if (comboOSList.Text == "Education")
            {
                serialKey = Education;
            }
            else if (comboOSList.Text == "Education N")
            {
                serialKey = EducationN;
            }
            else if (comboOSList.Text == "Enterprise")
            {
                serialKey = Enterprise;
            }
            else if (comboOSList.Text == "Enterprise N")
            {
                serialKey = EnterpriseN;
            }
        }
    }
}

// Mali | 13:26 29.03.2022 | Windows 10 Lisanslayıcı v1.0
