using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProLab_Proje_2_GoPassage
{
    
    public partial class FirmaPaneli : Form
    {
        public string kullanici;
        public string sifre;
        
        public FirmaPaneli()
        {
            InitializeComponent();
            
            
        }

        private void FirmaPaneli_Load(object sender, EventArgs e)
        {
            if (kullanici == "a-firmasi" && sifre == "123456")
            {
                comboBox1.Items.Add("Otobüs-1");
                comboBox1.Items.Add("Otobüs-2");
                comboBox2.Items.Add("3.Sefer");
                label6.Text = "A-Firması";
                
            }
            if (kullanici == "b-firmasi" && sifre == "123456")
            {
                comboBox1.Items.Add("Otobüs-1");
                comboBox1.Items.Add("Otobüs-2");
                comboBox2.Items.Add("3.Sefer");
                comboBox2.Items.Add("4.Sefer");
                label6.Text = "B-Firması";
            }
            if (kullanici == "c-firmasi" && sifre == "123456")
            {
                comboBox1.Items.Add("Otobüs-1");
                comboBox1.Items.Add("Uçak-1");
                comboBox1.Items.Add("Uçak-2");
                comboBox2.Items.Add("4.Sefer");
                comboBox2.Items.Add("5.Sefer");
                label6.Text = "C-Firması";
            }
            if (kullanici == "d-firmasi" && sifre == "123456")
            {
                comboBox1.Items.Add("Tren-1");
                comboBox1.Items.Add("Tren-2");
                comboBox1.Items.Add("Tren-3");
                comboBox2.Items.Add("1.Sefer");
                comboBox2.Items.Add("2.Sefer");
                label6.Text = "D-Firması";
            }
            if (kullanici == "f-firmasi" && sifre == "123456")
            {
                comboBox1.Items.Add("Uçak-1");
                comboBox1.Items.Add("Uçak-2");
                comboBox2.Items.Add("6.Sefer");
                label6.Text = "F-Firması";
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add(textBox1.Text);
            MessageBox.Show("Taşıt eklendi.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            textBox1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Remove(textBox1.Text);
            MessageBox.Show("Taşıt silindi.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            textBox1.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            comboBox2.Items.Add(textBox2.Text);
            MessageBox.Show("Sefer eklendi.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            textBox2.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            comboBox2.Items.Remove(textBox2.Text);
            MessageBox.Show("Sefer silindi.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            textBox2.Text = "";
        }
    }
}
