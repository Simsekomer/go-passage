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
    public partial class AdminPaneli : Form
    {
        public AdminPaneli()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add(textBox1.Text);
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Remove(textBox1.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ücret güncellendi.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
