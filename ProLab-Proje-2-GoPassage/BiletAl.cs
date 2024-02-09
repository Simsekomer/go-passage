using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProLab_Proje_2_GoPassage
{
    public partial class BiletAl : Form
    {
        private string basNoktasi;
        private string bitNoktasi;
        private string firma1;
        private string tasitNo;
        private int fiyat;
        private string saat;
        private int yolcuSayisi;
        private string adSoyad;
        private string tcNo;
        private string tarih;
        private List<Passenger> passengers;
        public BiletAl(string basNoktasi, string bitNoktasi, string firma1, string tasitNo, int fiyat, string saat, int yolcuSayisi, string adSoyad, string tcNo, string tarih, List<Passenger> passengers)
        {
            this.basNoktasi = basNoktasi;
            this.bitNoktasi = bitNoktasi;
            this.firma1 = firma1;
            this.tasitNo = tasitNo;
            this.fiyat = fiyat * yolcuSayisi;
            this.saat = saat;
            this.yolcuSayisi = yolcuSayisi;
            this.adSoyad = adSoyad;
            this.tcNo = tcNo;
            this.tarih = tarih;
            this.passengers = passengers;
            InitializeComponent();
        }

        private void BiletAl_Load(object sender, EventArgs e)
        {
            kalkis.Text = basNoktasi;
            varis.Text = bitNoktasi;
            lblFirma.Text = firma1;
            lblTasit.Text = tasitNo;
            lblFiyat.Text = fiyat.ToString();
            lblSaat.Text = saat;
            lblYolcuSayisi.Text = yolcuSayisi.ToString();
            lblAdSoyad.Text = adSoyad;
            lblTC.Text = tcNo;
            lblTarih.Text = tarih;

            int labelYuksekligi = 24;
            int aralik = 5;
            int mevcutYukseklik = lblTarih.Bottom + 10;
            int yolcuIndex = 0;

            foreach (var yolcu in passengers)
            {
                Label lblKoltukNo = new Label();
                lblKoltukNo.Text = $"{yolcu.koltukNo}";
                lblKoltukNo.Location = new Point(401, mevcutYukseklik);
                lblKoltukNo.Size = new Size(25, labelYuksekligi);
                lblKoltukNo.Visible = false;
                lblKoltukNo.AutoSize = true;
                this.Controls.Add(lblKoltukNo);
                if (yolcuIndex == 0) 
                {
                    label1.Text = lblKoltukNo.Text;
                    label1.Visible = true;
                    label1.AutoSize = true;
                }
                else if (yolcuIndex == 1)
                {
                    label18.Text = lblKoltukNo.Text;
                    label18.Visible = true;
                    label18.AutoSize = true;
                }
                else if (yolcuIndex == 2)
                {
                    label19.Text = lblKoltukNo.Text;
                    label19.Visible = true;
                    label19.AutoSize = true; 
                }

                mevcutYukseklik += labelYuksekligi + aralik + 10;
                yolcuIndex++;
            }
        }

        private void sonBiletAl_Click(object sender, EventArgs e)
        {
            Loading loading = new Loading();
            loading.Show();
            this.Hide();
        }

    }
}
