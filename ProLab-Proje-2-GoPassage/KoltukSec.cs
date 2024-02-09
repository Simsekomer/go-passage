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
    public partial class KoltukSec : Form
    {
        private string basNoktasi;
        private string bitNoktasi;
        private string firma;
        private string tasitNo;
        private int fiyat;
        private string saat;
        private int kalanKoltukSayisi;
        private int koltukNo;
        private int yolcuSayisi;
        public string adSoyad1;
        public string tcNo1;
        public string dogumTarihi1;
        public string koltukNolari1;
        private string tarih;

        public KoltukSec(string basNoktasi, string bitNoktasi, string firma, string tasitNo, int fiyat, string saat, int kalanKoltukSayisi, int koltukNo, int yolcuSayisi, string tarih)
        {
            this.basNoktasi = basNoktasi;
            this.bitNoktasi = bitNoktasi;
            this.firma = firma;
            this.tasitNo = tasitNo;
            this.fiyat = fiyat;
            this.saat = saat;
            this.kalanKoltukSayisi = kalanKoltukSayisi;
            this.koltukNo = koltukNo;
            this.yolcuSayisi = yolcuSayisi;
            this.tarih = tarih;
            InitializeComponent();
        }

        private List<ComboBox> comboBoxList = new List<ComboBox>();
        private List<Tuple<TextBox, MaskedTextBox, MaskedTextBox>> yolcuKontrolleri = new List<Tuple<TextBox, MaskedTextBox, MaskedTextBox>>();
        public List<Passenger> passengers = new List<Passenger>();
        private void KoltukSec_Load(object sender, EventArgs e)
        {


            int verticalSpacing = 30;
            int labelWidth = 200;
            int controlHeight = 30;
            int textBoxWidth = 150;
            Random random = new Random();
            List<int> secilenKoltuklar = new List<int>();

            for (int j = 0; j < kalanKoltukSayisi; j++)
            {
                int rastgeleKoltukNo;
                do
                {
                    rastgeleKoltukNo = random.Next(1, koltukNo + 1);
                }
                while (secilenKoltuklar.Contains(rastgeleKoltukNo));

                secilenKoltuklar.Add(rastgeleKoltukNo);
            }

            secilenKoltuklar.Sort();

            for (int i = 0; i < yolcuSayisi; i++)
            {
                int currentTop = 35 + i * (controlHeight + verticalSpacing) * 4;

                Label lbl = new Label();
                lbl.Text = (i + 1).ToString() + ". Yolcu";
                lbl.Location = new Point(40, currentTop);
                lbl.Size = new Size(labelWidth, controlHeight);
                lbl.TextAlign = ContentAlignment.MiddleRight;
                lbl.Font = new Font(lbl.Font.Name, 18, FontStyle.Bold);
                this.Controls.Add(lbl);

                Label lbl2 = new Label();
                lbl2.Text = (i + 1).ToString() + ". Yolcu Ad-Soyad:";
                lbl2.Location = new Point(40, lbl.Bottom + 15);
                lbl2.Size = new Size(labelWidth, controlHeight);
                lbl2.TextAlign = ContentAlignment.MiddleRight;
                this.Controls.Add(lbl2);

                TextBox textBox = new TextBox();
                textBox.Location = new Point(250, lbl2.Top);
                textBox.Size = new Size(textBoxWidth, controlHeight);
                this.Controls.Add(textBox);

                Label lbl3 = new Label();
                lbl3.Text = (i + 1).ToString() + ". Yolcu TC:";
                lbl3.Location = new Point(40, lbl2.Bottom + 15);
                lbl3.Size = new Size(labelWidth, controlHeight);
                lbl3.TextAlign = ContentAlignment.MiddleRight;
                this.Controls.Add(lbl3);

                MaskedTextBox maskedTextBox = new MaskedTextBox();
                maskedTextBox.Mask = "00000000000";
                maskedTextBox.Location = new Point(250, lbl3.Top);
                maskedTextBox.Size = new Size(textBoxWidth, controlHeight);
                this.Controls.Add(maskedTextBox);

                Label lbl4 = new Label();
                lbl4.Text = (i + 1).ToString() + ". Yolcu D.T:";
                lbl4.Location = new Point(40, lbl3.Bottom + 15);
                lbl4.Size = new Size(labelWidth, controlHeight);
                lbl4.TextAlign = ContentAlignment.MiddleRight;
                this.Controls.Add(lbl4);

                MaskedTextBox maskedTextBox2 = new MaskedTextBox();
                maskedTextBox2.Mask = "00/00/0000";
                maskedTextBox2.Location = new Point(250, lbl4.Top);
                maskedTextBox2.Size = new Size(textBoxWidth, controlHeight);
                this.Controls.Add(maskedTextBox2);

                Label lbl5 = new Label();
                lbl5.Text = (i + 1).ToString() + ". Yolcu Koltuk No:";
                lbl5.Location = new Point(40, lbl4.Bottom + 15);
                lbl5.Size = new Size(labelWidth, controlHeight);
                lbl5.TextAlign = ContentAlignment.MiddleRight;
                this.Controls.Add(lbl5);

                ComboBox comboBox = new ComboBox();
                comboBox.Location = new Point(250, lbl5.Top);
                comboBox.Size = new Size(textBoxWidth, controlHeight);
                comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
                this.Controls.Add(comboBox);

                comboBoxList.Add(comboBox);

                foreach (var koltukNo in secilenKoltuklar)
                {
                    comboBox.Items.Add(koltukNo.ToString());
                }

                Button btn = new Button();
                btn.Location = new Point(250, lbl5.Top + 40);
                btn.Size = new Size(90, 35);
                btn.Text = "Kaydet";
                btn.Tag = i;
                btn.Click += new EventHandler(Btn_Click);
                this.Controls.Add(btn);

                yolcuKontrolleri.Add(Tuple.Create(textBox, maskedTextBox, maskedTextBox2));

            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button tikliButon = sender as Button;
            int yolcuIndex = (int)tikliButon.Tag;
            ComboBox seciliComboBox = comboBoxList[yolcuIndex];

            if (seciliComboBox.SelectedItem != null)
            {
                string secilenKoltuk = seciliComboBox.SelectedItem.ToString();
                foreach (ComboBox cb in comboBoxList)
                {
                    if (cb != seciliComboBox && cb.Items.Contains(secilenKoltuk))
                    {
                        cb.Items.Remove(secilenKoltuk);
                    }
                }

                var kontrol = yolcuKontrolleri[yolcuIndex];
                if (yolcuIndex == 0)
                {
                    adSoyad1 = kontrol.Item1.Text;
                    tcNo1 = kontrol.Item2.Text;
                }
              
                Passenger passenger = new Passenger
                {
                    adSoyad = kontrol.Item1.Text,
                    tcNo = kontrol.Item2.Text,
                    dogumTarihi = kontrol.Item3.Text,
                    koltukNo = secilenKoltuk
                };
                passengers.Add(passenger);
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer.adSoyad = adSoyad1;
            customer.tcNo = tcNo1;
            BiletAl biletAl = new BiletAl(basNoktasi, bitNoktasi, firma, tasitNo, fiyat, saat, yolcuSayisi, customer.adSoyad, customer.tcNo, tarih, passengers);
            biletAl.Show();
            this.Hide();
        }
    }
}
