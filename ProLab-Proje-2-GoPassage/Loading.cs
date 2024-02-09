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
    public partial class Loading : Form
    {
        public Loading()
        {
            InitializeComponent();
            timer1.Interval = 2000;
            timer1.Tick += new EventHandler(timer1_Tick);
        }

        private void Loading_Load(object sender, EventArgs e)
        {
            label1.Text = "Ödeme Yapılıyor...";

            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            timer1.Stop();

            DialogResult result = MessageBox.Show(
                "GoPassage'ı tercih ettiğiniz için teşekkür ederiz.\nBilet numaranız: AWR342585\nAna sayfaya dönmek istiyor musunuz?",
                "Done",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information);

            if (result == DialogResult.Yes)
            {
                Form2 form2 = new Form2();
                form2.Show();
                this.Close();
            }
            else if (result == DialogResult.No)
            {
                Application.Exit();
            }
        }
    }
}
