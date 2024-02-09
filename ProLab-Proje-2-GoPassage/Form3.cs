using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ProLab_Proje_2_GoPassage
{
    public partial class AdminGirişEkrani : Form
    {
        public AdminGirişEkrani()
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
            Admin admin = new Admin();

            if (textBox1.Text == admin.kullaniciAdi && textBox2.Text == admin.sifre)
            {
                AdminPaneli adminPaneli = new AdminPaneli();
                adminPaneli.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
