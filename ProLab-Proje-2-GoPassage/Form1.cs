using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace ProLab_Proje_2_GoPassage
{
    public partial class GirisEkrani : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;

        public GirisEkrani()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Red800,
                Primary.Red900,
                Primary.Red500,
                Accent.Red700,
                TextShade.WHITE
            );
            toggleThemeButton.BackColor = Color.LightGray;
        }

        public void toggleThemeButton_Click(object sender, EventArgs e)
        {
            materialSkinManager.Theme = materialSkinManager.Theme == MaterialSkinManager.Themes.DARK
            ? MaterialSkinManager.Themes.LIGHT
            : MaterialSkinManager.Themes.DARK;
            pictureBox3.Visible = materialSkinManager.Theme == MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Red800,
                Primary.Red900,
                Primary.Red500,
                Accent.Red700,
                TextShade.WHITE
            );
        }

        public void button3_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            AdminGirişEkrani form3 = new AdminGirişEkrani();
            form3.Show();
            this.Hide();
        }

        public void button2_Click(object sender, EventArgs e)
        {
            ŞirketGirişEkrani form4 = new ŞirketGirişEkrani();
            form4.Show();
            this.Hide();
        }

        public void GirisEkrani_Load(object sender, EventArgs e)
        {

        }
    }
}
