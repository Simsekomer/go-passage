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
    
    public partial class ŞirketGirişEkrani : Form
    {
        public ŞirketGirişEkrani()
        {
            InitializeComponent();
            
        }

        private void label4_Click(object sender, EventArgs e)
        {
            GirisEkrani girisEkrani = new GirisEkrani();
            girisEkrani.Show();
            this.Close();
        }

       private void button1_Click(object sender, EventArgs e)
        {
            if(txtCompanyName.Text == "a-firmasi" && textBox2.Text == "123456")
            {
                FirmaPaneli firmaPaneli = new FirmaPaneli();
                firmaPaneli.kullanici = txtCompanyName.Text;
                firmaPaneli.sifre = textBox2.Text;
                firmaPaneli.Show();
                this.Hide();          
            }
            
           else if (txtCompanyName.Text == "b-firmasi" && textBox2.Text == "123456")
            {
                FirmaPaneli firmaPaneli = new FirmaPaneli();
                firmaPaneli.kullanici = txtCompanyName.Text;
                firmaPaneli.sifre = textBox2.Text;
                firmaPaneli.Show();
                this.Hide();
            }
            
           else if (txtCompanyName.Text == "c-firmasi" && textBox2.Text == "123456")
            {
                FirmaPaneli firmaPaneli = new FirmaPaneli();
                firmaPaneli.kullanici = txtCompanyName.Text;
                firmaPaneli.sifre = textBox2.Text;
                firmaPaneli.Show();
                this.Hide();
            }
            
           else if (txtCompanyName.Text == "d-firmasi" && textBox2.Text == "123456")
            {
                FirmaPaneli firmaPaneli = new FirmaPaneli();
                firmaPaneli.kullanici = txtCompanyName.Text;
                firmaPaneli.sifre = textBox2.Text;
                firmaPaneli.Show();
                this.Hide();
            }
           
           else if (txtCompanyName.Text == "f-firmasi" && textBox2.Text == "123456")
            {
                
                FirmaPaneli firmaPaneli = new FirmaPaneli();
                firmaPaneli.kullanici = txtCompanyName.Text;
                firmaPaneli.sifre = textBox2.Text;
                firmaPaneli.Show();
                this.Hide(); 
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        
    }
}
