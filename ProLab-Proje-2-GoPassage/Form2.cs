using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProLab_Proje_2_GoPassage
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public string basNoktasiLocal;
        public string bitNoktasiLocal;

        private void label3_Click(object sender, EventArgs e)
        {
            GirisEkrani girisEkrani = new GirisEkrani();
            girisEkrani.Show();
            this.Close();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            basNoktasiLocal = comboBox1.Text;
            bitNoktasiLocal = comboBox2.Text;

            label6.Text = dateTimePicker1.Value.ToShortDateString();

            Trip trip = new Trip();
            
            if (comboBox1.Text == "" || comboBox2.Text == "" || comboBox3.Text == "")
            {
                MessageBox.Show("Lütfen kalkış noktasını, varış noktasını ve yolcu sayısını seçiniz.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                bool basVar = false;
                bool bitVar = false;

                foreach (string durak in trip.sefer1)
                {
                    if (string.Equals(durak, comboBox1.Text, StringComparison.OrdinalIgnoreCase))
                    {
                        basVar = true;
                    }
                    if (string.Equals(durak, comboBox2.Text, StringComparison.OrdinalIgnoreCase))
                    {
                        bitVar = true;
                    }
                }

                if (basVar && bitVar)
                {

                    if (comboBox1.Text == "İstanbul" && comboBox2.Text == "Kocaeli" && dateTimePicker1.Value.ToShortDateString() == "7.12.2023")
                    {
                        trip.firma = 'D';
                        trip.fiyat = 50;
                        trip.tasitNo = "Tren 1";
                        trip.koltukNo = 25;
                        trip.saat = "07.00";
                        trip.date = dateTimePicker1.Value.ToShortDateString();
                        Random rand = new Random();
                        int soldSeats = rand.Next(0, trip.koltukNo);
                        trip.remainingSeats = trip.koltukNo - soldSeats;
                    }
                    if (comboBox1.Text == "İstanbul" && comboBox2.Text == "Bilecik" && dateTimePicker1.Value.ToShortDateString() == "7.12.2023")
                    {
                        trip.firma = 'D';
                        trip.fiyat = 150;
                        trip.tasitNo = "Tren 1";
                        trip.koltukNo = 25;
                        trip.saat = "11.00";
                        trip.date = dateTimePicker1.Value.ToShortDateString();
                        Random rand = new Random();
                        int soldSeats = rand.Next(0, trip.koltukNo);
                        trip.remainingSeats = trip.koltukNo - soldSeats;
                    }
                    if (comboBox1.Text == "İstanbul" && comboBox2.Text == "Ankara" && dateTimePicker1.Value.ToShortDateString() == "7.12.2023")
                    {
                        trip.firma = 'D';
                        trip.fiyat = 250;
                        trip.tasitNo = "Tren 1";
                        trip.koltukNo = 25;
                        trip.saat = "13.00";
                        trip.date = dateTimePicker1.Value.ToShortDateString();
                        Random rand = new Random();
                        int soldSeats = rand.Next(0, trip.koltukNo);
                        trip.remainingSeats = trip.koltukNo - soldSeats;
                    }
                    if (comboBox1.Text == "İstanbul" && comboBox2.Text == "Eskişehir" && dateTimePicker1.Value.ToShortDateString() == "7.12.2023")
                    {
                        trip.firma = 'D';
                        trip.fiyat = 200;
                        trip.tasitNo = "Tren 1";
                        trip.koltukNo = 25;
                        trip.saat = "12.00";
                        trip.date = dateTimePicker1.Value.ToShortDateString();
                        Random rand = new Random();
                        int soldSeats = rand.Next(0, trip.koltukNo);
                        trip.remainingSeats = trip.koltukNo - soldSeats;
                    }

                    if (comboBox1.Text == "Kocaeli" && comboBox2.Text == "İstanbul" && dateTimePicker1.Value.ToShortDateString() == "7.12.2023")
                    {
                        trip.firma = 'D';
                        trip.fiyat = 50;
                        trip.tasitNo = "Tren 1";
                        trip.koltukNo = 25;
                        trip.saat = "19.00";
                        trip.date = dateTimePicker1.Value.ToShortDateString();
                        Random rand = new Random();
                        int soldSeats = rand.Next(0, trip.koltukNo);
                        trip.remainingSeats = trip.koltukNo - soldSeats;
                    }
                    if (comboBox1.Text == "Kocaeli" && comboBox2.Text == "Bilecik" && dateTimePicker1.Value.ToShortDateString() == "7.12.2023")
                    {
                        trip.firma = 'D';
                        trip.fiyat = 50;
                        trip.tasitNo = "Tren 1";
                        trip.koltukNo = 25;
                        trip.saat = "08.00";
                        trip.date = dateTimePicker1.Value.ToShortDateString();
                        Random rand = new Random();
                        int soldSeats = rand.Next(0, trip.koltukNo);
                        trip.remainingSeats = trip.koltukNo - soldSeats;
                    }
                    if (comboBox1.Text == "Kocaeli" && comboBox2.Text == "Ankara" && dateTimePicker1.Value.ToShortDateString() == "7.12.2023")
                    {
                        trip.firma = 'D';
                        trip.fiyat = 200;
                        trip.tasitNo = "Tren 1";
                        trip.koltukNo = 25;
                        trip.saat = "14.00";
                        trip.date = dateTimePicker1.Value.ToShortDateString();
                        Random rand = new Random();
                        int soldSeats = rand.Next(0, trip.koltukNo);
                        trip.remainingSeats = trip.koltukNo - soldSeats;

                    }
                    if (comboBox1.Text == "Kocaeli" && comboBox2.Text == "Eskişehir" && dateTimePicker1.Value.ToShortDateString() == "7.12.2023")
                    {
                        trip.firma = 'D';
                        trip.fiyat = 100;
                        trip.tasitNo = "Tren 1";
                        trip.koltukNo = 25;
                        trip.saat = "14.00";
                        trip.date = dateTimePicker1.Value.ToShortDateString();
                        Random rand = new Random();
                        int soldSeats = rand.Next(0, trip.koltukNo);
                        trip.remainingSeats = trip.koltukNo - soldSeats;
                    }
                    if (comboBox1.Text == "Bilecik" && comboBox2.Text == "İstanbul" && dateTimePicker1.Value.ToShortDateString() == "7.12.2023")
                    {
                        trip.firma = 'D';
                        trip.fiyat = 150;
                        trip.tasitNo = "Tren 1";
                        trip.koltukNo = 25;
                        trip.saat = "20.00";
                        trip.date = dateTimePicker1.Value.ToShortDateString();
                        Random rand = new Random();
                        int soldSeats = rand.Next(0, trip.koltukNo);
                        trip.remainingSeats = trip.koltukNo - soldSeats;
                    }
                    if (comboBox1.Text == "Bilecik" && comboBox2.Text == "Kocaeli" && dateTimePicker1.Value.ToShortDateString() == "7.12.2023")
                    {
                        trip.firma = 'D';
                        trip.fiyat = 50;
                        trip.tasitNo = "Tren 1";
                        trip.koltukNo = 25;
                        trip.saat = "15.00";
                        trip.date = dateTimePicker1.Value.ToShortDateString();
                        Random rand = new Random();
                        int soldSeats = rand.Next(0, trip.koltukNo);
                        trip.remainingSeats = trip.koltukNo - soldSeats;
                    }
                    if (comboBox1.Text == "Bilecik" && comboBox2.Text == "Ankara" && dateTimePicker1.Value.ToShortDateString() == "7.12.2023")
                    {
                        trip.firma = 'D';
                        trip.fiyat = 150;
                        trip.tasitNo = "Tren 1";
                        trip.koltukNo = 25;
                        trip.saat = "16.00";
                        trip.date = dateTimePicker1.Value.ToShortDateString();
                        Random rand = new Random();
                        int soldSeats = rand.Next(0, trip.koltukNo);
                        trip.remainingSeats = trip.koltukNo - soldSeats;
                    }
                    if (comboBox1.Text == "Bilecik" && comboBox2.Text == "Eskişehir" && dateTimePicker1.Value.ToShortDateString() == "7.12.2023")
                    {
                        trip.firma = 'D';
                        trip.fiyat = 50;
                        trip.tasitNo = "Tren 1";
                        trip.koltukNo = 25;
                        trip.saat = "17.00";
                        trip.date = dateTimePicker1.Value.ToShortDateString();
                        Random rand = new Random();
                        int soldSeats = rand.Next(0, trip.koltukNo);
                        trip.remainingSeats = trip.koltukNo - soldSeats;
                    }

                    if (comboBox1.Text == "Ankara" && comboBox2.Text == "İstanbul" && dateTimePicker1.Value.ToShortDateString() == "7.12.2023")
                    {
                        trip.firma = 'D';
                        trip.fiyat = 250;
                        trip.tasitNo = "Tren 1";
                        trip.koltukNo = 25;
                        trip.saat = "17.30";
                        trip.date = dateTimePicker1.Value.ToShortDateString();
                        Random rand = new Random();
                        int soldSeats = rand.Next(0, trip.koltukNo);
                        trip.remainingSeats = trip.koltukNo - soldSeats;
                    }
                    if (comboBox1.Text == "Ankara" && comboBox2.Text == "Kocaeli" && dateTimePicker1.Value.ToShortDateString() == "7.12.2023")
                    {
                        trip.firma = 'D';
                        trip.fiyat = 200;
                        trip.tasitNo = "Tren 1";
                        trip.koltukNo = 25;
                        trip.saat = "14.30";
                        trip.date = dateTimePicker1.Value.ToShortDateString();
                        Random rand = new Random();
                        int soldSeats = rand.Next(0, trip.koltukNo);
                        trip.remainingSeats = trip.koltukNo - soldSeats;
                    }
                    if (comboBox1.Text == "Ankara" && comboBox2.Text == "Bilecik" && dateTimePicker1.Value.ToShortDateString() == "7.12.2023")
                    {
                        trip.firma = 'D';
                        trip.fiyat = 150;
                        trip.tasitNo = "Tren 1";
                        trip.koltukNo = 25;
                        trip.saat = "19.00";
                        trip.date = dateTimePicker1.Value.ToShortDateString();
                        Random rand = new Random();
                        int soldSeats = rand.Next(0, trip.koltukNo);
                        trip.remainingSeats = trip.koltukNo - soldSeats;
                    }
                    if (comboBox1.Text == "Ankara" && comboBox2.Text == "Eskişehir" && dateTimePicker1.Value.ToShortDateString() == "7.12.2023")
                    {
                        trip.firma = 'D';
                        trip.fiyat = 100;
                        trip.tasitNo = "Tren 1";
                        trip.koltukNo = 25;
                        trip.saat = "19.30";
                        trip.date = dateTimePicker1.Value.ToShortDateString();
                        Random rand = new Random();
                        int soldSeats = rand.Next(0, trip.koltukNo);
                        trip.remainingSeats = trip.koltukNo - soldSeats;
                    }
                    if (comboBox1.Text == "Eskişehir" && comboBox2.Text == "İstanbul" && dateTimePicker1.Value.ToShortDateString() == "7.12.2023")
                    {
                        trip.firma = 'D';
                        trip.fiyat = 200;
                        trip.tasitNo = "Tren 1";
                        trip.koltukNo = 25;
                        trip.saat = "21.00";
                        trip.date = dateTimePicker1.Value.ToShortDateString();
                        Random rand = new Random();
                        int soldSeats = rand.Next(0, trip.koltukNo);
                        trip.remainingSeats = trip.koltukNo - soldSeats;
                    }
                    if (comboBox1.Text == "Eskişehir" && comboBox2.Text == "Kocaeli" && dateTimePicker1.Value.ToShortDateString() == "7.12.2023")
                    {
                        trip.firma = 'D';
                        trip.fiyat = 100;
                        trip.tasitNo = "Tren 1";
                        trip.koltukNo = 25;
                        trip.saat = "10.00";
                        trip.date = dateTimePicker1.Value.ToShortDateString();
                        Random rand = new Random();
                        int soldSeats = rand.Next(0, trip.koltukNo);
                        trip.remainingSeats = trip.koltukNo - soldSeats;
                    }
                    if (comboBox1.Text == "Eskişehir" && comboBox2.Text == "Bilecik" && dateTimePicker1.Value.ToShortDateString() == "7.12.2023")
                    {
                        trip.firma = 'D';
                        trip.fiyat = 50;
                        trip.tasitNo = "Tren 1";
                        trip.koltukNo = 25;
                        trip.saat = "10.30";
                        trip.date = dateTimePicker1.Value.ToShortDateString();
                        Random rand = new Random();
                        int soldSeats = rand.Next(0, trip.koltukNo);
                        trip.remainingSeats = trip.koltukNo - soldSeats;
                    }
                    if (comboBox1.Text == "Eskişehir" && comboBox2.Text == "Ankara" && dateTimePicker1.Value.ToShortDateString() == "7.12.2023")
                    {
                        trip.firma = 'D';
                        trip.fiyat = 100;
                        trip.tasitNo = "Tren 1";
                        trip.koltukNo = 25;
                        trip.saat = "12.00";
                        trip.date = dateTimePicker1.Value.ToShortDateString();
                        Random rand = new Random();
                        int soldSeats = rand.Next(0, trip.koltukNo);
                        trip.remainingSeats = trip.koltukNo - soldSeats;
                    }

                    int rowIndex = dataGridView1.Rows.Add();
                    DataGridViewRow row = dataGridView1.Rows[rowIndex];

                    row.Cells[0].Value = trip.firma.ToString();
                    row.Cells[7].Value = trip.fiyat;
                    row.Cells[1].Value = trip.tasitNo;
                    row.Cells[2].Value = trip.koltukNo;
                    row.Cells[4].Value = 1;
                    row.Cells[6].Value = trip.saat;
                    row.Cells[3].Value = trip.remainingSeats;
                    row.Cells[5].Value = trip.date;
                }
                ///////////////////////////////////////////////////////////////////////////////////////////////////////////
                Trip trip2 = new Trip();

                bitVar = false;
                basVar = false;

                foreach (string durak in trip2.sefer2)
                {
                    if (string.Equals(durak, comboBox1.Text, StringComparison.OrdinalIgnoreCase))
                    {
                        basVar = true;
                    }
                    if (string.Equals(durak, comboBox2.Text, StringComparison.OrdinalIgnoreCase))
                    {
                        bitVar = true;
                    }
                }

                if (basVar && bitVar)
                {

                    if (comboBox1.Text == "İstanbul" && comboBox2.Text == "Kocaeli" && dateTimePicker1.Value.ToShortDateString() == "9.12.2023")
                    {
                        trip2.firma = 'D';
                        trip2.fiyat = 50;
                        trip2.tasitNo = "Tren 2";
                        trip2.koltukNo = 25;
                        trip2.saat = "14.36";
                        trip2.date = dateTimePicker1.Value.ToShortDateString();
                        Random rand = new Random();
                        int soldSeats = rand.Next(0, trip2.koltukNo);
                        trip2.remainingSeats = trip2.koltukNo - soldSeats;
                    }
                    if (comboBox1.Text == "İstanbul" && comboBox2.Text == "Bilecik" && dateTimePicker1.Value.ToShortDateString() == "9.12.2023")
                    {
                        trip2.firma = 'D';
                        trip2.fiyat = 150;
                        trip2.tasitNo = "Tren 2";
                        trip2.koltukNo = 25;
                        trip2.saat = "22.06";
                        trip2.date = dateTimePicker1.Value.ToShortDateString();
                        Random rand = new Random();
                        int soldSeats = rand.Next(0, trip2.koltukNo);
                        trip2.remainingSeats = trip2.koltukNo - soldSeats;
                    }
                    if (comboBox1.Text == "İstanbul" && comboBox2.Text == "Konya" && dateTimePicker1.Value.ToShortDateString() == "9.12.2023")
                    {
                        trip2.firma = 'D';
                        trip2.fiyat = 250;
                        trip2.tasitNo = "Tren 2";
                        trip2.koltukNo = 25;
                        trip2.saat = "14.59";
                        trip2.date = dateTimePicker1.Value.ToShortDateString();
                        Random rand = new Random();
                        int soldSeats = rand.Next(0, trip2.koltukNo);
                        trip2.remainingSeats = trip2.koltukNo - soldSeats;
                    }
                    if (comboBox1.Text == "İstanbul" && comboBox2.Text == "Eskişehir" && dateTimePicker1.Value.ToShortDateString() == "9.12.2023")
                    {
                        trip2.firma = 'D';
                        trip2.fiyat = 200;
                        trip2.tasitNo = "Tren 2";
                        trip2.koltukNo = 25;
                        trip2.saat = "02.32";
                        trip2.date = dateTimePicker1.Value.ToShortDateString();
                        Random rand = new Random();
                        int soldSeats = rand.Next(0, trip2.koltukNo);
                        trip2.remainingSeats = trip2.koltukNo - soldSeats;
                    }

                    if (comboBox1.Text == "Kocaeli" && comboBox2.Text == "İstanbul" && dateTimePicker1.Value.ToShortDateString() == "9.12.2023")
                    {
                        trip2.firma = 'D';
                        trip2.fiyat = 50;
                        trip2.tasitNo = "Tren 2";
                        trip2.koltukNo = 25;
                        trip2.saat = "20.05";
                        trip2.date = dateTimePicker1.Value.ToShortDateString();
                        Random rand = new Random();
                        int soldSeats = rand.Next(0, trip2.koltukNo);
                        trip2.remainingSeats = trip2.koltukNo - soldSeats;
                    }
                    else if (comboBox1.Text == "Kocaeli" && comboBox2.Text == "Bilecik" && dateTimePicker1.Value.ToShortDateString() == "9.12.2023")
                    {
                        trip2.firma = 'D';
                        trip2.fiyat = 50;
                        trip2.tasitNo = "Tren 2";
                        trip2.koltukNo = 25;
                        trip2.saat = "18.19";
                        trip2.date = dateTimePicker1.Value.ToShortDateString();
                        Random rand = new Random();
                        int soldSeats = rand.Next(0, trip2.koltukNo);
                        trip2.remainingSeats = trip2.koltukNo - soldSeats;
                    }
                    if (comboBox1.Text == "Kocaeli" && comboBox2.Text == "Konya" && dateTimePicker1.Value.ToShortDateString() == "9.12.2023")
                    {
                        trip2.firma = 'D';
                        trip2.fiyat = 200;
                        trip2.tasitNo = "Tren 2";
                        trip2.koltukNo = 25;
                        trip2.saat = "15.00";
                        trip2.date = dateTimePicker1.Value.ToShortDateString();
                        Random rand = new Random();
                        int soldSeats = rand.Next(0, trip2.koltukNo);
                        trip2.remainingSeats = trip2.koltukNo - soldSeats;
                    }
                    if (comboBox1.Text == "Kocaeli" && comboBox2.Text == "Eskişehir" && dateTimePicker1.Value.ToShortDateString() == "9.12.2023")
                    {
                        trip2.firma = 'D';
                        trip2.fiyat = 100;
                        trip2.tasitNo = "Tren 2";
                        trip2.koltukNo = 25;
                        trip2.saat = "16.00";
                        trip2.date = dateTimePicker1.Value.ToShortDateString();
                        Random rand = new Random();
                        int soldSeats = rand.Next(0, trip2.koltukNo);
                        trip2.remainingSeats = trip2.koltukNo - soldSeats;
                    }
                    if (comboBox1.Text == "Bilecik" && comboBox2.Text == "İstanbul" && dateTimePicker1.Value.ToShortDateString() == "9.12.2023")
                    {
                        trip2.firma = 'D';
                        trip2.fiyat = 150;
                        trip2.tasitNo = "Tren 2";
                        trip2.koltukNo = 25;
                        trip2.saat = "10.00";
                        trip2.date = dateTimePicker1.Value.ToShortDateString();
                        Random rand = new Random();
                        int soldSeats = rand.Next(0, trip2.koltukNo);
                        trip2.remainingSeats = trip2.koltukNo - soldSeats;
                    }
                    if (comboBox1.Text == "Bilecik" && comboBox2.Text == "Kocaeli" && dateTimePicker1.Value.ToShortDateString() == "9.12.2023")
                    {
                        trip2.firma = 'D';
                        trip2.fiyat = 50;
                        trip2.tasitNo = "Tren 2";
                        trip2.koltukNo = 25;
                        trip2.saat = "12.00";
                        trip2.date = dateTimePicker1.Value.ToShortDateString();
                        Random rand = new Random();
                        int soldSeats = rand.Next(0, trip2.koltukNo);
                        trip2.remainingSeats = trip2.koltukNo - soldSeats;
                    }
                    if (comboBox1.Text == "Bilecik" && comboBox2.Text == "Konya" && dateTimePicker1.Value.ToShortDateString() == "9.12.2023")
                    {
                        trip2.firma = 'D';
                        trip2.fiyat = 150;
                        trip2.tasitNo = "Tren 2";
                        trip2.koltukNo = 25;
                        trip2.saat = "11.00";
                        trip2.date = dateTimePicker1.Value.ToShortDateString();
                        Random rand = new Random();
                        int soldSeats = rand.Next(0, trip2.koltukNo);
                        trip2.remainingSeats = trip2.koltukNo - soldSeats;
                    }
                    if (comboBox1.Text == "Bilecik" && comboBox2.Text == "Eskişehir" && dateTimePicker1.Value.ToShortDateString() == "9.12.2023")
                    {
                        trip2.firma = 'D';
                        trip2.fiyat = 50;
                        trip2.tasitNo = "Tren 2";
                        trip2.koltukNo = 25;
                        trip2.saat = "11.00";
                        trip2.date = dateTimePicker1.Value.ToShortDateString();
                        Random rand = new Random();
                        int soldSeats = rand.Next(0, trip2.koltukNo);
                        trip2.remainingSeats = trip2.koltukNo - soldSeats;
                    }

                    if (comboBox1.Text == "Konya" && comboBox2.Text == "İstanbul" && dateTimePicker1.Value.ToShortDateString() == "9.12.2023")
                    {
                        trip2.firma = 'D';
                        trip2.fiyat = 250;
                        trip2.tasitNo = "Tren 2";
                        trip2.koltukNo = 25;
                        trip2.saat = "13.30";
                        trip2.date = dateTimePicker1.Value.ToShortDateString();
                        Random rand = new Random();
                        int soldSeats = rand.Next(0, trip2.koltukNo);
                        trip2.remainingSeats = trip2.koltukNo - soldSeats;
                    }
                    if (comboBox1.Text == "Konya" && comboBox2.Text == "Kocaeli" && dateTimePicker1.Value.ToShortDateString() == "9.12.2023")
                    {
                        trip2.firma = 'D';
                        trip2.fiyat = 200;
                        trip2.tasitNo = "Tren 2";
                        trip2.koltukNo = 25;
                        trip2.saat = "15.30";
                        trip2.date = dateTimePicker1.Value.ToShortDateString();
                        Random rand = new Random();
                        int soldSeats = rand.Next(0, trip2.koltukNo);
                        trip2.remainingSeats = trip2.koltukNo - soldSeats;
                    }
                    if (comboBox1.Text == "Konya" && comboBox2.Text == "Bilecik" && dateTimePicker1.Value.ToShortDateString() == "9.12.2023")
                    {
                        trip2.firma = 'D';
                        trip2.fiyat = 150;
                        trip2.tasitNo = "Tren 2";
                        trip2.koltukNo = 25;
                        trip2.saat = "16.00";
                        trip2.date = dateTimePicker1.Value.ToShortDateString();
                        Random rand = new Random();
                        int soldSeats = rand.Next(0, trip2.koltukNo);
                        trip2.remainingSeats = trip2.koltukNo - soldSeats;
                    }
                    if (comboBox1.Text == "Konya" && comboBox2.Text == "Eskişehir" && dateTimePicker1.Value.ToShortDateString() == "9.12.2023")
                    {
                        trip2.firma = 'D';
                        trip2.fiyat = 100;
                        trip2.tasitNo = "Tren 2";
                        trip2.koltukNo = 25;
                        trip2.saat = "12.30";
                        trip2.date = dateTimePicker1.Value.ToShortDateString();
                        Random rand = new Random();
                        int soldSeats = rand.Next(0, trip2.koltukNo);
                        trip2.remainingSeats = trip2.koltukNo - soldSeats;
                    }
                    if (comboBox1.Text == "Eskişehir" && comboBox2.Text == "İstanbul" && dateTimePicker1.Value.ToShortDateString() == "9.12.2023")
                    {
                        trip2.firma = 'D';
                        trip2.fiyat = 200;
                        trip2.tasitNo = "Tren 2";
                        trip2.koltukNo = 25;
                        trip2.saat = "23.00";
                        Random rand = new Random();
                        trip2.date = dateTimePicker1.Value.ToShortDateString();
                        int soldSeats = rand.Next(0, trip2.koltukNo);
                        trip2.remainingSeats = trip2.koltukNo - soldSeats;
                    }
                    if (comboBox1.Text == "Eskişehir" && comboBox2.Text == "Kocaeli" && dateTimePicker1.Value.ToShortDateString() == "9.12.2023")
                    {
                        trip2.firma = 'D';
                        trip2.fiyat = 100;
                        trip2.tasitNo = "Tren 2";
                        trip2.koltukNo = 25;
                        trip2.saat = "09.00";
                        Random rand = new Random();
                        trip2.date = dateTimePicker1.Value.ToShortDateString();
                        int soldSeats = rand.Next(0, trip2.koltukNo);
                        trip2.remainingSeats = trip2.koltukNo - soldSeats;
                    }
                    if (comboBox1.Text == "Eskişehir" && comboBox2.Text == "Bilecik" && dateTimePicker1.Value.ToShortDateString() == "9.12.2023")
                    {
                        trip2.firma = 'D';
                        trip2.fiyat = 50;
                        trip2.tasitNo = "Tren 2";
                        trip2.koltukNo = 25;
                        trip2.saat = "11.30";
                        Random rand = new Random();
                        trip2.date = dateTimePicker1.Value.ToShortDateString();
                        int soldSeats = rand.Next(0, trip2.koltukNo);
                        trip2.remainingSeats = trip2.koltukNo - soldSeats;
                    }
                    if (comboBox1.Text == "Eskişehir" && comboBox2.Text == "Konya" && dateTimePicker1.Value.ToShortDateString() == "9.12.2023")
                    {
                        trip2.firma = 'D';
                        trip2.fiyat = 100;
                        trip2.tasitNo = "Tren 2";
                        trip2.koltukNo = 25;
                        trip2.saat = "12.45";
                        Random rand = new Random();
                        trip2.date = dateTimePicker1.Value.ToShortDateString();
                        int soldSeats = rand.Next(0, trip2.koltukNo);
                        trip2.remainingSeats = trip2.koltukNo - soldSeats;
                    }

                    int rowIndex = dataGridView1.Rows.Add();
                    DataGridViewRow row = dataGridView1.Rows[rowIndex];

                    row.Cells[0].Value = trip2.firma.ToString();
                    row.Cells[7].Value = trip2.fiyat;
                    row.Cells[1].Value = trip2.tasitNo;
                    row.Cells[2].Value = trip2.koltukNo;
                    row.Cells[4].Value = 2;
                    row.Cells[6].Value = trip2.saat;
                    row.Cells[3].Value = trip2.remainingSeats;
                    row.Cells[5].Value = trip2.date;
                }
                ///////////////////////////////////////////////////////////////////////////////////////////////////////////

                Trip trip3 = new Trip();

                bitVar = false;
                basVar = false;

                foreach (string durak in trip3.sefer2)
                {
                    if (string.Equals(durak, comboBox1.Text, StringComparison.OrdinalIgnoreCase))
                    {
                        basVar = true;
                    }
                    if (string.Equals(durak, comboBox2.Text, StringComparison.OrdinalIgnoreCase))
                    {
                        bitVar = true;
                    }
                }

                if (basVar && bitVar)
                {

                    if (comboBox1.Text == "İstanbul" && comboBox2.Text == "Kocaeli" && dateTimePicker1.Value.ToShortDateString() == "5.12.2023")
                    {
                        trip3.firma = 'D';
                        trip3.fiyat = 50;
                        trip3.tasitNo = "Tren 3";
                        trip3.koltukNo = 25;
                        trip3.saat = "01.00";
                        trip3.date = dateTimePicker1.Value.ToShortDateString();
                        Random rand = new Random();
                        int soldSeats = rand.Next(0, trip3.koltukNo);
                        trip3.remainingSeats = trip3.koltukNo - soldSeats;
                    }
                    if (comboBox1.Text == "İstanbul" && comboBox2.Text == "Bilecik" && dateTimePicker1.Value.ToShortDateString() == "5.12.2023")
                    {
                        trip3.firma = 'D';
                        trip3.fiyat = 150;
                        trip3.tasitNo = "Tren 3";
                        trip3.koltukNo = 25;
                        trip3.saat = "23.30";
                        trip3.date = dateTimePicker1.Value.ToShortDateString();
                        Random rand = new Random();
                        int soldSeats = rand.Next(0, trip3.koltukNo);
                        trip3.remainingSeats = trip3.koltukNo - soldSeats;
                    }
                    if (comboBox1.Text == "İstanbul" && comboBox2.Text == "Eskişehir" && dateTimePicker1.Value.ToShortDateString() == "5.12.2023")
                    {
                        trip3.firma = 'D';
                        trip3.fiyat = 200;
                        trip3.tasitNo = "Tren 3";
                        trip3.koltukNo = 25;
                        trip3.saat = "02:32";
                        trip3.date = dateTimePicker1.Value.ToShortDateString();
                        Random rand = new Random();
                        int soldSeats = rand.Next(0, trip3.koltukNo);
                        trip3.remainingSeats = trip3.koltukNo - soldSeats;
                    }
                    if (comboBox1.Text == "İstanbul" && comboBox2.Text == "Konya" && dateTimePicker1.Value.ToShortDateString() == "5.12.2023")
                    {
                        trip3.firma = 'D';
                        trip3.fiyat = 200;
                        trip3.tasitNo = "Tren 3";
                        trip3.koltukNo = 25;
                        trip3.saat = "02:32";
                        trip3.date = dateTimePicker1.Value.ToShortDateString();
                        Random rand = new Random();
                        int soldSeats = rand.Next(0, trip3.koltukNo);
                        trip3.remainingSeats = trip3.koltukNo - soldSeats;
                    }

                    if (comboBox1.Text == "Kocaeli" && comboBox2.Text == "İstanbul" && dateTimePicker1.Value.ToShortDateString() == "5.12.2023")
                    {
                        trip3.firma = 'D';
                        trip3.fiyat = 50;
                        trip3.tasitNo = "Tren 3";
                        trip3.koltukNo = 25;
                        trip3.saat = "00.00";
                        trip3.date = dateTimePicker1.Value.ToShortDateString();
                        Random rand = new Random();
                        int soldSeats = rand.Next(0, trip3.koltukNo);
                        trip3.remainingSeats = trip3.koltukNo - soldSeats;
                    }
                    if (comboBox1.Text == "Kocaeli" && comboBox2.Text == "Bilecik" && dateTimePicker1.Value.ToShortDateString() == "5.12.2023")
                    {
                        trip3.firma = 'D';
                        trip3.fiyat = 50;
                        trip3.tasitNo = "Tren 3";
                        trip3.koltukNo = 25;
                        trip3.saat = "00.45";
                        trip3.date = dateTimePicker1.Value.ToShortDateString();
                        Random rand = new Random();
                        int soldSeats = rand.Next(0, trip3.koltukNo);
                        trip3.remainingSeats = trip3.koltukNo - soldSeats;
                    }
                    if (comboBox1.Text == "Kocaeli" && comboBox2.Text == "Eskişehir" && dateTimePicker1.Value.ToShortDateString() == "5.12.2023")
                    {
                        trip3.firma = 'D';
                        trip3.fiyat = 100;
                        trip3.tasitNo = "Tren 3";
                        trip3.koltukNo = 25;
                        trip3.saat = "18.30";
                        trip3.date = dateTimePicker1.Value.ToShortDateString();
                        Random rand = new Random();
                        int soldSeats = rand.Next(0, trip3.koltukNo);
                        trip3.remainingSeats = trip3.koltukNo - soldSeats;
                    }
                    if (comboBox1.Text == "Kocaeli" && comboBox2.Text == "Konya" && dateTimePicker1.Value.ToShortDateString() == "5.12.2023")
                    {
                        trip3.firma = 'D';
                        trip3.fiyat = 100;
                        trip3.tasitNo = "Tren 3";
                        trip3.koltukNo = 25;
                        trip3.saat = "18.30";
                        trip3.date = dateTimePicker1.Value.ToShortDateString();
                        Random rand = new Random();
                        int soldSeats = rand.Next(0, trip3.koltukNo);
                        trip3.remainingSeats = trip3.koltukNo - soldSeats;
                    }
                    if (comboBox1.Text == "Bilecik" && comboBox2.Text == "İstanbul" && dateTimePicker1.Value.ToShortDateString() == "5.12.2023")
                    {
                        trip3.firma = 'D';
                        trip3.fiyat = 150;
                        trip3.tasitNo = "Tren 3";
                        trip3.koltukNo = 25;
                        trip3.saat = "13.00";
                        trip3.date = dateTimePicker1.Value.ToShortDateString();
                        Random rand = new Random();
                        int soldSeats = rand.Next(0, trip3.koltukNo);
                        trip3.remainingSeats = trip3.koltukNo - soldSeats;
                    }
                    if (comboBox1.Text == "Bilecik" && comboBox2.Text == "Kocaeli" && dateTimePicker1.Value.ToShortDateString() == "5.12.2023")
                    {
                        trip3.firma = 'D';
                        trip3.fiyat = 50;
                        trip3.tasitNo = "Tren 3";
                        trip3.koltukNo = 25;
                        trip3.saat = "15.00";
                        trip3.date = dateTimePicker1.Value.ToShortDateString();
                        Random rand = new Random();
                        int soldSeats = rand.Next(0, trip3.koltukNo);
                        trip3.remainingSeats = trip3.koltukNo - soldSeats;
                    }
                    if (comboBox1.Text == "Bilecik" && comboBox2.Text == "Eskişehir" && dateTimePicker1.Value.ToShortDateString() == "5.12.2023")
                    {
                        trip3.firma = 'D';
                        trip3.fiyat = 50;
                        trip3.tasitNo = "Tren 3";
                        trip3.koltukNo = 25;
                        trip3.saat = "10.00";
                        trip3.date = dateTimePicker1.Value.ToShortDateString();
                        Random rand = new Random();
                        int soldSeats = rand.Next(0, trip3.koltukNo);
                        trip3.remainingSeats = trip3.koltukNo - soldSeats;
                    }
                    if (comboBox1.Text == "Bilecik" && comboBox2.Text == "Konya" && dateTimePicker1.Value.ToShortDateString() == "5.12.2023")
                    {
                        trip3.firma = 'D';
                        trip3.fiyat = 100;
                        trip3.tasitNo = "Tren 3";
                        trip3.koltukNo = 25;
                        trip3.saat = "18.30";
                        trip3.date = dateTimePicker1.Value.ToShortDateString();
                        Random rand = new Random();
                        int soldSeats = rand.Next(0, trip3.koltukNo);
                        trip3.remainingSeats = trip3.koltukNo - soldSeats;
                    }
                    if (comboBox1.Text == "Eskişehir" && comboBox2.Text == "İstanbul" && dateTimePicker1.Value.ToShortDateString() == "5.12.2023")
                    {
                        trip3.firma = 'D';
                        trip3.fiyat = 200;
                        trip3.tasitNo = "Tren 3";
                        trip3.koltukNo = 25;
                        trip3.saat = "03.00";
                        trip3.date = dateTimePicker1.Value.ToShortDateString();
                        Random rand = new Random();
                        int soldSeats = rand.Next(0, trip3.koltukNo);
                        trip3.remainingSeats = trip3.koltukNo - soldSeats;
                    }
                    if (comboBox1.Text == "Eskişehir" && comboBox2.Text == "Kocaeli" && dateTimePicker1.Value.ToShortDateString() == "5.12.2023")
                    {
                        trip3.firma = 'D';
                        trip3.fiyat = 100;
                        trip3.tasitNo = "Tren 3";
                        trip3.koltukNo = 25;
                        trip3.saat = "03.00";
                        trip3.date = dateTimePicker1.Value.ToShortDateString();
                        Random rand = new Random();
                        int soldSeats = rand.Next(0, trip3.koltukNo);
                        trip3.remainingSeats = trip3.koltukNo - soldSeats;
                    }
                    if (comboBox1.Text == "Eskişehir" && comboBox2.Text == "Bilecik" && dateTimePicker1.Value.ToShortDateString() == "5.12.2023")
                    {
                        trip3.firma = 'D';
                        trip3.fiyat = 50;
                        trip3.tasitNo = "Tren 3";
                        trip3.koltukNo = 25;
                        trip3.saat = "03.00";
                        trip3.date = dateTimePicker1.Value.ToShortDateString();
                        Random rand = new Random();
                        int soldSeats = rand.Next(0, trip3.koltukNo);
                        trip3.remainingSeats = trip3.koltukNo - soldSeats;
                    }
                    if (comboBox1.Text == "Eskişehir" && comboBox2.Text == "Konya" && dateTimePicker1.Value.ToShortDateString() == "5.12.2023")
                    {
                        trip3.firma = 'D';
                        trip3.fiyat = 100;
                        trip3.tasitNo = "Tren 3";
                        trip3.koltukNo = 25;
                        trip3.saat = "18.30";
                        trip3.date = dateTimePicker1.Value.ToShortDateString();
                        Random rand = new Random();
                        int soldSeats = rand.Next(0, trip3.koltukNo);
                        trip3.remainingSeats = trip3.koltukNo - soldSeats;
                    }
                    if (comboBox1.Text == "Konya" && comboBox2.Text == "İstanbul" && dateTimePicker1.Value.ToShortDateString() == "5.12.2023")
                    {
                        trip3.firma = 'D';
                        trip3.fiyat = 250;
                        trip3.tasitNo = "Tren 3";
                        trip3.koltukNo = 25;
                        trip3.saat = "19.30";
                        trip3.date = dateTimePicker1.Value.ToShortDateString();
                        Random rand = new Random();
                        int soldSeats = rand.Next(0, trip3.koltukNo);
                        trip3.remainingSeats = trip3.koltukNo - soldSeats;
                    }
                    if (comboBox1.Text == "Konya" && comboBox2.Text == "Kocaeli" && dateTimePicker1.Value.ToShortDateString() == "5.12.2023")
                    {
                        trip3.firma = 'D';
                        trip3.fiyat = 200;
                        trip3.tasitNo = "Tren 3";
                        trip3.koltukNo = 25;
                        trip3.saat = "11.30";
                        trip3.date = dateTimePicker1.Value.ToShortDateString();
                        Random rand = new Random();
                        int soldSeats = rand.Next(0, trip3.koltukNo);
                        trip3.remainingSeats = trip3.koltukNo - soldSeats;
                    }
                    if (comboBox1.Text == "Konya" && comboBox2.Text == "Bilecik" && dateTimePicker1.Value.ToShortDateString() == "5.12.2023")
                    {
                        trip3.firma = 'D';
                        trip3.fiyat = 150;
                        trip3.tasitNo = "Tren 3";
                        trip3.koltukNo = 25;
                        trip3.saat = "12.00";
                        trip3.date = dateTimePicker1.Value.ToShortDateString();
                        Random rand = new Random();
                        int soldSeats = rand.Next(0, trip3.koltukNo);
                        trip3.remainingSeats = trip3.koltukNo - soldSeats;
                    }
                    if (comboBox1.Text == "Konya" && comboBox2.Text == "Eskişehir" && dateTimePicker1.Value.ToShortDateString() == "5.12.2023")
                    {
                        trip3.firma = 'D';
                        trip3.fiyat = 100;
                        trip3.tasitNo = "Tren 3";
                        trip3.koltukNo = 25;
                        trip3.saat = "14.30";
                        trip3.date = dateTimePicker1.Value.ToShortDateString();
                        Random rand = new Random();
                        int soldSeats = rand.Next(0, trip3.koltukNo);
                        trip3.remainingSeats = trip3.koltukNo - soldSeats;
                    }

                    int rowIndex = dataGridView1.Rows.Add();
                    DataGridViewRow row = dataGridView1.Rows[rowIndex];

                    row.Cells[0].Value = trip3.firma.ToString();
                    row.Cells[7].Value = trip3.fiyat;
                    row.Cells[1].Value = trip3.tasitNo;
                    row.Cells[2].Value = trip3.koltukNo;
                    row.Cells[4].Value = 2;
                    row.Cells[6].Value = trip3.saat;
                    row.Cells[3].Value = trip3.remainingSeats;
                    row.Cells[5].Value = trip3.date;

                }
                ////////////////////////////////////////////////////////////////////////////////////////

                Trip trip4 = new Trip();

                basVar = false;
                bitVar = false;

                foreach (string durak in trip4.sefer3)
                {
                    if (string.Equals(durak, comboBox1.Text, StringComparison.OrdinalIgnoreCase))
                    {
                        basVar = true;
                    }
                    if (string.Equals(durak, comboBox2.Text, StringComparison.OrdinalIgnoreCase))
                    {
                        bitVar = true;
                    }
                }

                if (basVar && bitVar)
                {

                    if (comboBox1.Text == "İstanbul" && comboBox2.Text == "Kocaeli" && dateTimePicker1.Value.ToShortDateString() == "7.12.2023")
                    {
                        trip4.firma = 'A';
                        trip4.fiyat = 50;
                        trip4.tasitNo = "Otobüs 1";
                        trip4.koltukNo = 20;
                        trip4.saat = "01.00";
                        trip4.date = dateTimePicker1.Value.ToShortDateString();
                        Random rand = new Random();
                        int soldSeats = rand.Next(0, trip4.koltukNo);
                        trip4.remainingSeats = trip4.koltukNo - soldSeats;
                    }
                    if (comboBox1.Text == "İstanbul" && comboBox2.Text == "Ankara" && dateTimePicker1.Value.ToShortDateString() == "7.12.2023")
                    {
                        trip4.firma = 'A';
                        trip4.fiyat = 300;
                        trip4.tasitNo = "Otobüs 1";
                        trip4.koltukNo = 20;
                        trip4.saat = "02.00";
                        trip4.date = dateTimePicker1.Value.ToShortDateString();
                        Random rand = new Random();
                        int soldSeats = rand.Next(0, trip4.koltukNo);
                        trip4.remainingSeats = trip4.koltukNo - soldSeats;
                    }

                    if (comboBox1.Text == "Kocaeli" && comboBox2.Text == "İstanbul" && dateTimePicker1.Value.ToShortDateString() == "7.12.2023")
                    {
                        trip4.firma = 'A';
                        trip4.fiyat = 50;
                        trip4.tasitNo = "Otobüs 1";
                        trip4.koltukNo = 20;
                        trip4.saat = "05.00";
                        trip4.date = dateTimePicker1.Value.ToShortDateString();
                        Random rand = new Random();
                        int soldSeats = rand.Next(0, trip4.koltukNo);
                        trip4.remainingSeats = trip4.koltukNo - soldSeats;
                    }
                    if (comboBox1.Text == "Kocaeli" && comboBox2.Text == "Ankara" && dateTimePicker1.Value.ToShortDateString() == "7.12.2023")
                    {
                        trip4.firma = 'A';
                        trip4.fiyat = 400;
                        trip4.tasitNo = "Otobüs 1";
                        trip4.koltukNo = 20;
                        trip4.saat = "06.00";
                        trip4.date = dateTimePicker1.Value.ToShortDateString();
                        Random rand = new Random();
                        int soldSeats = rand.Next(0, trip4.koltukNo);
                        trip4.remainingSeats = trip4.koltukNo - soldSeats;
                    }

                    if (comboBox1.Text == "Ankara" && comboBox2.Text == "İstanbul" && dateTimePicker1.Value.ToShortDateString() == "7.12.2023")
                    {
                        trip4.firma = 'A';
                        trip4.fiyat = 300;
                        trip4.tasitNo = "Otobüs 1";
                        trip4.koltukNo = 20;
                        trip4.saat = "09.00";
                        trip4.date = dateTimePicker1.Value.ToShortDateString();
                        Random rand = new Random();
                        int soldSeats = rand.Next(0, trip4.koltukNo);
                        trip4.remainingSeats = trip4.koltukNo - soldSeats;
                    }
                    if (comboBox1.Text == "Ankara" && comboBox2.Text == "Kocaeli" && dateTimePicker1.Value.ToShortDateString() == "7.12.2023")
                    {
                        trip4.firma = 'A';
                        trip4.fiyat = 400;
                        trip4.tasitNo = "Otobüs 1";
                        trip4.koltukNo = 20;
                        trip4.saat = "10.00";
                        trip4.date = dateTimePicker1.Value.ToShortDateString();
                        Random rand = new Random();
                        int soldSeats = rand.Next(0, trip4.koltukNo);
                        trip4.remainingSeats = trip4.koltukNo - soldSeats;
                    }

                    int rowIndex = dataGridView1.Rows.Add();
                    DataGridViewRow row = dataGridView1.Rows[rowIndex];

                    row.Cells[0].Value = trip4.firma.ToString();
                    row.Cells[7].Value = trip4.fiyat;
                    row.Cells[1].Value = trip4.tasitNo;
                    row.Cells[2].Value = trip4.koltukNo;
                    row.Cells[4].Value = 3;
                    row.Cells[6].Value = trip4.saat;
                    row.Cells[3].Value = trip4.remainingSeats;
                    row.Cells[5].Value = trip4.date;
                }

                ////////////////////////////////////////////////////////////////////////////////////////

                Trip trip5 = new Trip();

                basVar = false;
                bitVar = false;

                foreach (string durak in trip5.sefer3)
                {
                    if (string.Equals(durak, comboBox1.Text, StringComparison.OrdinalIgnoreCase))
                    {
                        basVar = true;
                    }
                    if (string.Equals(durak, comboBox2.Text, StringComparison.OrdinalIgnoreCase))
                    {
                        bitVar = true;
                    }
                }

                if (basVar && bitVar)
                {

                    if (comboBox1.Text == "İstanbul" && comboBox2.Text == "Kocaeli" && dateTimePicker1.Value.ToShortDateString() == "8.12.2023")
                    {
                        trip5.firma = 'A';
                        trip5.fiyat = 50;
                        trip5.tasitNo = "Otobüs 2";
                        trip5.koltukNo = 15;
                        trip5.saat = "11.00";
                        trip5.date = dateTimePicker1.Value.ToShortDateString();
                        Random rand = new Random();
                        int soldSeats = rand.Next(0, trip5.koltukNo);
                        trip5.remainingSeats = trip5.koltukNo - soldSeats;
                    }
                    if (comboBox1.Text == "İstanbul" && comboBox2.Text == "Ankara" && dateTimePicker1.Value.ToShortDateString() == "8.12.2023")
                    {
                        trip5.firma = 'A';
                        trip5.fiyat = 300;
                        trip5.tasitNo = "Otobüs 2";
                        trip5.koltukNo = 15;
                        trip5.saat = "02.30";
                        trip5.date = dateTimePicker1.Value.ToShortDateString();
                        Random rand = new Random();
                        int soldSeats = rand.Next(0, trip5.koltukNo);
                        trip5.remainingSeats = trip5.koltukNo - soldSeats;
                    }

                    if (comboBox1.Text == "Kocaeli" && comboBox2.Text == "İstanbul" && dateTimePicker1.Value.ToShortDateString() == "8.12.2023")
                    {
                        trip5.firma = 'A';
                        trip5.fiyat = 50;
                        trip5.tasitNo = "Otobüs 2";
                        trip5.koltukNo = 15;
                        trip5.saat = "15.00";
                        trip5.date = dateTimePicker1.Value.ToShortDateString();
                        Random rand = new Random();
                        int soldSeats = rand.Next(0, trip5.koltukNo);
                        trip5.remainingSeats = trip5.koltukNo - soldSeats;
                    }
                    if (comboBox1.Text == "Kocaeli" && comboBox2.Text == "Ankara" && dateTimePicker1.Value.ToShortDateString() == "8.12.2023")
                    {
                        trip5.firma = 'A';
                        trip5.fiyat = 400;
                        trip5.tasitNo = "Otobüs 2";
                        trip5.koltukNo = 15;
                        trip5.saat = "16.00";
                        trip5.date = dateTimePicker1.Value.ToShortDateString();
                        Random rand = new Random();
                        int soldSeats = rand.Next(0, trip5.koltukNo);
                        trip5.remainingSeats = trip5.koltukNo - soldSeats;
                    }

                    if (comboBox1.Text == "Ankara" && comboBox2.Text == "İstanbul" && dateTimePicker1.Value.ToShortDateString() == "8.12.2023")
                    {
                        trip5.firma = 'A';
                        trip5.fiyat = 300;
                        trip5.tasitNo = "Otobüs 2";
                        trip5.koltukNo = 15;
                        trip5.saat = "19.00";
                        trip5.date = dateTimePicker1.Value.ToShortDateString();
                        Random rand = new Random();
                        int soldSeats = rand.Next(0, trip5.koltukNo);
                        trip5.remainingSeats = trip5.koltukNo - soldSeats;
                    }
                    if (comboBox1.Text == "Ankara" && comboBox2.Text == "Kocaeli" && dateTimePicker1.Value.ToShortDateString() == "8.12.2023")
                    {
                        trip5.firma = 'A';
                        trip5.fiyat = 400;
                        trip5.tasitNo = "Otobüs 2";
                        trip5.koltukNo = 15;
                        trip5.saat = "18.00";
                        trip5.date = dateTimePicker1.Value.ToShortDateString();
                        Random rand = new Random();
                        int soldSeats = rand.Next(0, trip5.koltukNo);
                        trip5.remainingSeats = trip5.koltukNo - soldSeats;
                    }

                    int rowIndex = dataGridView1.Rows.Add();
                    DataGridViewRow row = dataGridView1.Rows[rowIndex];

                    row.Cells[0].Value = trip5.firma.ToString();
                    row.Cells[7].Value = trip5.fiyat;
                    row.Cells[1].Value = trip5.tasitNo;
                    row.Cells[2].Value = trip5.koltukNo;
                    row.Cells[4].Value = 3;
                    row.Cells[6].Value = trip5.saat;
                    row.Cells[3].Value = trip5.remainingSeats;
                    row.Cells[5].Value = trip5.date;

                }
                ////////////////////////////////////////////////////////////////////
                Trip trip6 = new Trip();

                basVar = false;
                bitVar = false;

                foreach (string durak in trip6.sefer3)
                {
                    if (string.Equals(durak, comboBox1.Text, StringComparison.OrdinalIgnoreCase))
                    {
                        basVar = true;
                    }
                    if (string.Equals(durak, comboBox2.Text, StringComparison.OrdinalIgnoreCase))
                    {
                        bitVar = true;
                    }
                }

                if (basVar && bitVar)
                {

                    if (comboBox1.Text == "İstanbul" && comboBox2.Text == "Kocaeli" && dateTimePicker1.Value.ToShortDateString() == "8.12.2023")
                    {
                        trip6.firma = 'B';
                        trip6.fiyat = 50;
                        trip6.tasitNo = "Otobüs 1";
                        trip6.koltukNo = 15;
                        trip6.saat = "19.00";
                        trip6.date = dateTimePicker1.Value.ToShortDateString();
                        Random rand = new Random();
                        int soldSeats = rand.Next(0, trip6.koltukNo);
                        trip6.remainingSeats = trip6.koltukNo - soldSeats;
                    }
                    if (comboBox1.Text == "İstanbul" && comboBox2.Text == "Ankara" && dateTimePicker1.Value.ToShortDateString() == "8.12.2023")
                    {
                        trip6.firma = 'B';
                        trip6.fiyat = 300;
                        trip6.tasitNo = "Otobüs 1";
                        trip6.koltukNo = 15;
                        trip6.saat = "02.30";
                        trip6.date = dateTimePicker1.Value.ToShortDateString();
                        Random rand = new Random();
                        int soldSeats = rand.Next(0, trip6.koltukNo);
                        trip6.remainingSeats = trip6.koltukNo - soldSeats;
                    }

                    if (comboBox1.Text == "Kocaeli" && comboBox2.Text == "İstanbul" && dateTimePicker1.Value.ToShortDateString() == "8.12.2023")
                    {
                        trip6.firma = 'B';
                        trip6.fiyat = 50;
                        trip6.tasitNo = "Otobüs 1";
                        trip6.koltukNo = 15;
                        trip6.saat = "20.00";
                        trip6.date = dateTimePicker1.Value.ToShortDateString();
                        Random rand = new Random();
                        int soldSeats = rand.Next(0, trip6.koltukNo);
                        trip6.remainingSeats = trip6.koltukNo - soldSeats;
                    }
                    if (comboBox1.Text == "Kocaeli" && comboBox2.Text == "Ankara" && dateTimePicker1.Value.ToShortDateString() == "8.12.2023")
                    {
                        trip6.firma = 'B';
                        trip6.fiyat = 400;
                        trip6.tasitNo = "Otobüs 1";
                        trip6.koltukNo = 15;
                        trip6.saat = "21.00";
                        trip6.date = dateTimePicker1.Value.ToShortDateString();
                        Random rand = new Random();
                        int soldSeats = rand.Next(0, trip6.koltukNo);
                        trip6.remainingSeats = trip6.koltukNo - soldSeats;
                    }

                    if (comboBox1.Text == "Ankara" && comboBox2.Text == "İstanbul" && dateTimePicker1.Value.ToShortDateString() == "8.12.2023")
                    {
                        trip6.firma = 'B';
                        trip6.fiyat = 300;
                        trip6.tasitNo = "Otobüs 1";
                        trip6.koltukNo = 15;
                        trip6.saat = "22.00";
                        trip6.date = dateTimePicker1.Value.ToShortDateString();
                        Random rand = new Random();
                        int soldSeats = rand.Next(0, trip6.koltukNo);
                        trip6.remainingSeats = trip6.koltukNo - soldSeats;
                    }
                    if (comboBox1.Text == "Ankara" && comboBox2.Text == "Kocaeli" && dateTimePicker1.Value.ToShortDateString() == "8.12.2023")
                    {
                        trip6.firma = 'B';
                        trip6.fiyat = 400;
                        trip6.tasitNo = "Otobüs 1";
                        trip6.koltukNo = 15;
                        trip6.saat = "23.00";
                        trip6.date = dateTimePicker1.Value.ToShortDateString();
                        Random rand = new Random();
                        int soldSeats = rand.Next(0, trip6.koltukNo);
                        trip6.remainingSeats = trip6.koltukNo - soldSeats;
                    }

                    int rowIndex = dataGridView1.Rows.Add();
                    DataGridViewRow row = dataGridView1.Rows[rowIndex];

                    row.Cells[0].Value = trip6.firma.ToString();
                    row.Cells[7].Value = trip6.fiyat;
                    row.Cells[1].Value = trip6.tasitNo;
                    row.Cells[2].Value = trip6.koltukNo;
                    row.Cells[4].Value = 3;
                    row.Cells[6].Value = trip6.saat;
                    row.Cells[3].Value = trip6.remainingSeats;
                    row.Cells[5].Value = trip6.date;
                }
                //////////////////////////////////////////////////////////

                Trip trip7 = new Trip();

                basVar = false;
                bitVar = false;

                foreach (string durak in trip7.sefer4)
                {
                    if (string.Equals(durak, comboBox1.Text, StringComparison.OrdinalIgnoreCase))
                    {
                        basVar = true;
                    }
                    if (string.Equals(durak, comboBox2.Text, StringComparison.OrdinalIgnoreCase))
                    {
                        bitVar = true;
                    }
                }

                if (basVar && bitVar)
                {

                    if (comboBox1.Text == "İstanbul" && comboBox2.Text == "Kocaeli" && dateTimePicker1.Value.ToShortDateString() == "4.12.2023")
                    {
                        trip7.firma = 'B';
                        trip7.fiyat = 50;
                        trip7.tasitNo = "Otobüs 2";
                        trip7.koltukNo = 20;
                        trip7.saat = "12.30";
                        trip7.date = dateTimePicker1.Value.ToShortDateString();
                        Random rand = new Random();
                        int soldSeats = rand.Next(0, trip7.koltukNo);
                        trip7.remainingSeats = trip7.koltukNo - soldSeats;
                    }
                    else if (comboBox1.Text == "İstanbul" && comboBox2.Text == "Eskişehir" && dateTimePicker1.Value.ToShortDateString() == "10.12.2023")
                    {
                        trip7.firma = 'B';
                        trip7.fiyat = 150;
                        trip7.tasitNo = "Otobüs 2";
                        trip7.koltukNo = 20;
                        trip7.saat = "14.00";
                        trip7.date = dateTimePicker1.Value.ToShortDateString();
                        Random rand = new Random();
                        int soldSeats = rand.Next(0, trip7.koltukNo);
                        trip7.remainingSeats = trip7.koltukNo - soldSeats;
                    }
                    else if (comboBox1.Text == "İstanbul" && comboBox2.Text == "Konya" && dateTimePicker1.Value.ToShortDateString() == "10.12.2023")
                    {
                        trip7.firma = 'B';
                        trip7.fiyat = 300;
                        trip7.tasitNo = "Otobüs 2";
                        trip7.koltukNo = 20;
                        trip7.saat = "15.00";
                        trip7.date = dateTimePicker1.Value.ToShortDateString();
                        Random rand = new Random();
                        int soldSeats = rand.Next(0, trip7.koltukNo);
                        trip7.remainingSeats = trip7.koltukNo - soldSeats;
                    }
                    else if (comboBox1.Text == "Kocaeli" && comboBox2.Text == "İstanbul" && dateTimePicker1.Value.ToShortDateString() == "10.12.2023")
                    {
                        trip7.firma = 'B';
                        trip7.fiyat = 50;
                        trip7.tasitNo = "Otobüs 2";
                        trip7.koltukNo = 20;
                        trip7.saat = "16.00";
                        trip7.date = dateTimePicker1.Value.ToShortDateString();
                        Random rand = new Random();
                        int soldSeats = rand.Next(0, trip7.koltukNo);
                        trip7.remainingSeats = trip7.koltukNo - soldSeats;
                    }
                    else if (comboBox1.Text == "Kocaeli" && comboBox2.Text == "Eskişehir" && dateTimePicker1.Value.ToShortDateString() == "10.12.2023")
                    {
                        trip7.firma = 'B';
                        trip7.fiyat = 100;
                        trip7.tasitNo = "Otobüs 2";
                        trip7.koltukNo = 20;
                        trip7.saat = "18.00";
                        trip7.date = dateTimePicker1.Value.ToShortDateString();
                        Random rand = new Random();
                        int soldSeats = rand.Next(0, trip7.koltukNo);
                        trip7.remainingSeats = trip7.koltukNo - soldSeats;
                    }
                    else if (comboBox1.Text == "Kocaeli" && comboBox2.Text == "Konya" && dateTimePicker1.Value.ToShortDateString() == "10.12.2023")
                    {
                        trip7.firma = 'B';
                        trip7.fiyat = 250;
                        trip7.tasitNo = "Otobüs 2";
                        trip7.koltukNo = 20;
                        trip7.saat = "19.00";
                        trip7.date = dateTimePicker1.Value.ToShortDateString();
                        Random rand = new Random();
                        int soldSeats = rand.Next(0, trip7.koltukNo);
                        trip7.remainingSeats = trip7.koltukNo - soldSeats;
                    }
                    else if (comboBox1.Text == "Eskişehir" && comboBox2.Text == "İstanbul" && dateTimePicker1.Value.ToShortDateString() == "10.12.2023")
                    {
                        trip7.firma = 'B';
                        trip7.fiyat = 150;
                        trip7.tasitNo = "Otobüs 2";
                        trip7.koltukNo = 20;
                        trip7.saat = "12.10";
                        trip7.date = dateTimePicker1.Value.ToShortDateString();
                        Random rand = new Random();
                        int soldSeats = rand.Next(0, trip7.koltukNo);
                        trip7.remainingSeats = trip7.koltukNo - soldSeats;
                    }
                    else if (comboBox1.Text == "Eskişehir" && comboBox2.Text == "Kocaeli" && dateTimePicker1.Value.ToShortDateString() == "10.12.2023")
                    {
                        trip7.firma = 'B';
                        trip7.fiyat = 100;
                        trip7.tasitNo = "Otobüs 2";
                        trip7.koltukNo = 20;
                        trip7.saat = "13.20";
                        trip7.date = dateTimePicker1.Value.ToShortDateString();
                        Random rand = new Random();
                        int soldSeats = rand.Next(0, trip7.koltukNo);
                        trip7.remainingSeats = trip7.koltukNo - soldSeats;
                    }
                    else if (comboBox1.Text == "Eskişehir" && comboBox2.Text == "Konya" && dateTimePicker1.Value.ToShortDateString() == "10.12.2023")
                    {
                        trip7.firma = 'B';
                        trip7.fiyat = 150;
                        trip7.tasitNo = "Otobüs 2";
                        trip7.koltukNo = 20;
                        trip7.saat = "15.50";
                        trip7.date = dateTimePicker1.Value.ToShortDateString();
                        Random rand = new Random();
                        int soldSeats = rand.Next(0, trip7.koltukNo);
                        trip7.remainingSeats = trip7.koltukNo - soldSeats;
                    }
                    else if (comboBox1.Text == "Konya" && comboBox2.Text == "İstanbul" && dateTimePicker1.Value.ToShortDateString() == "10.12.2023")
                    {
                        trip7.firma = 'B';
                        trip7.fiyat = 300;
                        trip7.tasitNo = "Otobüs 2";
                        trip7.koltukNo = 20;
                        trip7.saat = "17.30";
                        trip7.date = dateTimePicker1.Value.ToShortDateString();
                        Random rand = new Random();
                        int soldSeats = rand.Next(0, trip7.koltukNo);
                        trip7.remainingSeats = trip7.koltukNo - soldSeats;
                    }
                    else if (comboBox1.Text == "Konya" && comboBox2.Text == "Kocaeli" && dateTimePicker1.Value.ToShortDateString() == "10.12.2023")
                    {
                        trip7.firma = 'B';
                        trip7.fiyat = 250;
                        trip7.tasitNo = "Otobüs 2";
                        trip7.koltukNo = 20;
                        trip7.saat = "18.20";
                        Random rand = new Random();
                        int soldSeats = rand.Next(0, trip7.koltukNo);
                        trip7.remainingSeats = trip7.koltukNo - soldSeats;
                    }
                    else if (comboBox1.Text == "Konya" && comboBox2.Text == "Eskişehir" && dateTimePicker1.Value.ToShortDateString() == "10.12.2023")
                    {
                        trip7.firma = 'B';
                        trip7.fiyat = 150;
                        trip7.tasitNo = "Otobüs 2";
                        trip7.koltukNo = 20;
                        trip7.saat = "20.50";
                        trip7.date = dateTimePicker1.Value.ToShortDateString();
                        Random rand = new Random();
                        int soldSeats = rand.Next(0, trip7.koltukNo);
                        trip7.remainingSeats = trip7.koltukNo - soldSeats;
                    }


                    int rowIndex = dataGridView1.Rows.Add();
                    DataGridViewRow row = dataGridView1.Rows[rowIndex];

                    row.Cells[0].Value = trip7.firma.ToString();
                    row.Cells[7].Value = trip7.fiyat;
                    row.Cells[1].Value = trip7.tasitNo;
                    row.Cells[2].Value = trip7.koltukNo;
                    row.Cells[4].Value = 4;
                    row.Cells[6].Value = trip7.saat;
                    row.Cells[3].Value = trip7.remainingSeats;
                    row.Cells[5].Value = trip7.date;
                    /////////////////////////////////////////////////////////////////////

                    Trip trip8 = new Trip();

                    basVar = false;
                    bitVar = false;

                    foreach (string durak in trip8.sefer4)
                    {
                        if (string.Equals(durak, comboBox1.Text, StringComparison.OrdinalIgnoreCase))
                        {
                            basVar = true;
                        }
                        if (string.Equals(durak, comboBox2.Text, StringComparison.OrdinalIgnoreCase))
                        {
                            bitVar = true;
                        }
                    }

                    if (basVar && bitVar)
                    {

                        if (comboBox1.Text == "İstanbul" && comboBox2.Text == "Kocaeli" && dateTimePicker1.Value.ToShortDateString() == "10.12.2023")
                        {
                            trip8.firma = 'C';
                            trip8.fiyat = 50;
                            trip8.tasitNo = "Otobüs 1";
                            trip8.koltukNo = 20;
                            trip8.saat = "19.30";
                            trip8.date = dateTimePicker1.Value.ToShortDateString();
                            Random rand = new Random();
                            int soldSeats = rand.Next(0, trip8.koltukNo);
                            trip8.remainingSeats = trip8.koltukNo - soldSeats;
                        }

                        else if (comboBox1.Text == "İstanbul" && comboBox2.Text == "Eskişehir" && dateTimePicker1.Value.ToShortDateString() == "10.12.2023")
                        {
                            trip8.firma = 'C';
                            trip8.fiyat = 150;
                            trip8.tasitNo = "Otobüs 1";
                            trip8.koltukNo = 20;
                            trip8.saat = "18.00";
                            trip8.date = dateTimePicker1.Value.ToShortDateString();
                            Random rand = new Random();
                            int soldSeats = rand.Next(0, trip8.koltukNo);
                            trip8.remainingSeats = trip8.koltukNo - soldSeats;
                        }
                        else if (comboBox1.Text == "İstanbul" && comboBox2.Text == "Konya" && dateTimePicker1.Value.ToShortDateString() == "10.12.2023")
                        {
                            trip8.firma = 'C';
                            trip8.fiyat = 300;
                            trip8.tasitNo = "Otobüs 1";
                            trip8.koltukNo = 20;
                            trip8.saat = "21.30";
                            trip8.date = dateTimePicker1.Value.ToShortDateString();
                            Random rand = new Random();
                            int soldSeats = rand.Next(0, trip8.koltukNo);
                            trip8.remainingSeats = trip8.koltukNo - soldSeats;
                        }

                        else if (comboBox1.Text == "Kocaeli" && comboBox2.Text == "İstanbul" && dateTimePicker1.Value.ToShortDateString() == "10.12.2023")
                        {
                            trip8.firma = 'C';
                            trip8.fiyat = 50;
                            trip8.tasitNo = "Otobüs 1";
                            trip8.koltukNo = 20;
                            trip8.saat = "18.00";
                            trip8.date = dateTimePicker1.Value.ToShortDateString();
                            Random rand = new Random();
                            int soldSeats = rand.Next(0, trip8.koltukNo);
                            trip8.remainingSeats = trip8.koltukNo - soldSeats;
                        }

                        else if (comboBox1.Text == "Kocaeli" && comboBox2.Text == "Eskişehir" && dateTimePicker1.Value.ToShortDateString() == "10.12.2023")
                        {
                            trip8.firma = 'C';
                            trip8.fiyat = 100;
                            trip8.tasitNo = "Otobüs 1";
                            trip8.koltukNo = 20;
                            trip8.saat = "19.00";
                            trip8.date = dateTimePicker1.Value.ToShortDateString();
                            Random rand = new Random();
                            int soldSeats = rand.Next(0, trip8.koltukNo);
                            trip8.remainingSeats = trip8.koltukNo - soldSeats;
                        }
                        else if (comboBox1.Text == "Kocaeli" && comboBox2.Text == "Konya" && dateTimePicker1.Value.ToShortDateString() == "10.12.2023")
                        {
                            trip8.firma = 'C';
                            trip8.fiyat = 250;
                            trip8.tasitNo = "Otobüs 1";
                            trip8.koltukNo = 20;
                            trip8.saat = "23.00";
                            trip8.date = dateTimePicker1.Value.ToShortDateString();
                            Random rand = new Random();
                            int soldSeats = rand.Next(0, trip8.koltukNo);
                            trip8.remainingSeats = trip8.koltukNo - soldSeats;
                        }
                        else if (comboBox1.Text == "Eskişehir" && comboBox2.Text == "İstanbul" && dateTimePicker1.Value.ToShortDateString() == "10.12.2023")
                        {
                            trip8.firma = 'C';
                            trip8.fiyat = 150;
                            trip8.tasitNo = "Otobüs 1";
                            trip8.koltukNo = 20;
                            trip8.saat = "22.10";
                            trip8.date = dateTimePicker1.Value.ToShortDateString();
                            Random rand = new Random();
                            int soldSeats = rand.Next(0, trip8.koltukNo);
                            trip8.remainingSeats = trip8.koltukNo - soldSeats;
                        }
                        else if (comboBox1.Text == "Eskişehir" && comboBox2.Text == "Kocaeli" && dateTimePicker1.Value.ToShortDateString() == "6.12.2023")
                        {
                            trip8.firma = 'C';
                            trip8.fiyat = 100;
                            trip8.tasitNo = "Otobüs 1";
                            trip8.koltukNo = 20;
                            trip8.saat = "23.20";
                            trip8.date = dateTimePicker1.Value.ToShortDateString();
                            Random rand = new Random();
                            int soldSeats = rand.Next(0, trip8.koltukNo);
                            trip8.remainingSeats = trip8.koltukNo - soldSeats;
                        }
                        else if (comboBox1.Text == "Eskişehir" && comboBox2.Text == "Konya" && dateTimePicker1.Value.ToShortDateString() == "4.12.2023")
                        {
                            trip8.firma = 'C';
                            trip8.fiyat = 150;
                            trip8.tasitNo = "Otobüs 1";
                            trip8.koltukNo = 20;
                            trip8.saat = "22.50";
                            trip8.date = dateTimePicker1.Value.ToShortDateString();
                            Random rand = new Random();
                            int soldSeats = rand.Next(0, trip8.koltukNo);
                            trip8.remainingSeats = trip8.koltukNo - soldSeats;
                        }

                        else if (comboBox1.Text == "Konya" && comboBox2.Text == "İstanbul" && dateTimePicker1.Value.ToShortDateString() == "6.12.2023")
                        {
                            trip8.firma = 'C';
                            trip8.fiyat = 300;
                            trip8.tasitNo = "Otobüs 1";
                            trip8.koltukNo = 20;
                            trip8.saat = "17.00";
                            trip8.date = dateTimePicker1.Value.ToShortDateString();
                            Random rand = new Random();
                            int soldSeats = rand.Next(0, trip8.koltukNo);
                            trip8.remainingSeats = trip8.koltukNo - soldSeats;
                        }
                        else if (comboBox1.Text == "Konya" && comboBox2.Text == "Kocaeli" && dateTimePicker1.Value.ToShortDateString() == "6.12.2023")
                        {
                            trip8.firma = 'C';
                            trip8.fiyat = 250;
                            trip8.tasitNo = "Otobüs 1";
                            trip8.koltukNo = 20;
                            trip8.saat = "10.20";
                            trip8.date = dateTimePicker1.Value.ToShortDateString();
                            Random rand = new Random();
                            int soldSeats = rand.Next(0, trip8.koltukNo);
                            trip8.remainingSeats = trip8.koltukNo - soldSeats;
                        }
                        else if (comboBox1.Text == "Konya" && comboBox2.Text == "Eskişehir" && dateTimePicker1.Value.ToShortDateString() == "6.12.2023")
                        {
                            trip8.firma = 'C';
                            trip8.fiyat = 150;
                            trip8.tasitNo = "Otobüs 1";
                            trip8.koltukNo = 20;
                            trip8.saat = "21.35";
                            trip8.date = dateTimePicker1.Value.ToShortDateString();
                            Random rand = new Random();
                            int soldSeats = rand.Next(0, trip8.koltukNo);
                            trip8.remainingSeats = trip8.koltukNo - soldSeats;
                        }
                    }


                    int rowIndex3 = dataGridView1.Rows.Add();
                    DataGridViewRow row3 = dataGridView1.Rows[rowIndex3];

                    row3.Cells[0].Value = trip8.firma;
                    row3.Cells[7].Value = trip8.fiyat;
                    row3.Cells[1].Value = trip8.tasitNo;
                    row3.Cells[2].Value = trip8.koltukNo;
                    row3.Cells[4].Value = 4;
                    row3.Cells[6].Value = trip8.saat;
                    row3.Cells[3].Value = trip8.remainingSeats;
                    row3.Cells[5].Value = trip8.date;
                    ////////////////////////////////////////////////////////////////////////////////////7
                    Trip trip9 = new Trip();

                    basVar = false;
                    bitVar = false;

                    foreach (string durak in trip9.sefer5)
                    {
                        if (string.Equals(durak, comboBox1.Text, StringComparison.OrdinalIgnoreCase))
                        {
                            basVar = true;
                        }
                        if (string.Equals(durak, comboBox2.Text, StringComparison.OrdinalIgnoreCase))
                        {
                            bitVar = true;
                        }
                    }

                    if (basVar && bitVar)
                    {

                        if (comboBox1.Text == "İstanbul" && comboBox2.Text == "Konya" && dateTimePicker1.Value.ToShortDateString() == "4.12.2023")
                        {
                            trip9.firma = 'C';
                            trip9.fiyat = 1200;
                            trip9.tasitNo = "Uçak 1";
                            trip9.koltukNo = 30;
                            trip9.saat = "11.00";
                            trip9.date = dateTimePicker1.Value.ToShortDateString();
                            Random rand = new Random();
                            int soldSeats = rand.Next(0, trip9.koltukNo);
                            trip9.remainingSeats = trip9.koltukNo - soldSeats;
                        }

                        if (comboBox1.Text == "Konya" && comboBox2.Text == "İstanbul" && dateTimePicker1.Value.ToShortDateString() == "4.12.2023")
                        {
                            trip9.firma = 'C';
                            trip9.fiyat = 1200;
                            trip9.tasitNo = "Uçak 1";
                            trip9.koltukNo = 30;
                            trip9.saat = "13.00";
                            trip9.date = dateTimePicker1.Value.ToShortDateString();
                            Random rand = new Random();
                            int soldSeats = rand.Next(0, trip9.koltukNo);
                            trip9.remainingSeats = trip9.koltukNo - soldSeats;
                        }
                    }
                    int rowIndex2 = dataGridView1.Rows.Add();
                    DataGridViewRow row2 = dataGridView1.Rows[rowIndex2];

                    row2.Cells[0].Value = trip9.firma;
                    row2.Cells[7].Value = trip9.fiyat;
                    row2.Cells[1].Value = trip9.tasitNo;
                    row2.Cells[2].Value = trip9.koltukNo;
                    row2.Cells[4].Value = 5;
                    row2.Cells[6].Value = trip9.saat;
                    row2.Cells[3].Value = trip9.remainingSeats;
                    row2.Cells[5].Value = trip9.date;

                    ///////////////////////////////////////////////
                    Trip trip10 = new Trip();

                    basVar = false;
                    bitVar = false;

                    foreach (string durak in trip10.sefer5)
                    {
                        if (string.Equals(durak, comboBox1.Text, StringComparison.OrdinalIgnoreCase))
                        {
                            basVar = true;
                        }
                        if (string.Equals(durak, comboBox2.Text, StringComparison.OrdinalIgnoreCase))
                        {
                            bitVar = true;
                        }
                    }

                    if (basVar && bitVar)
                    {

                        if (comboBox1.Text == "İstanbul" && comboBox2.Text == "Konya" && dateTimePicker1.Value.ToShortDateString() == "6.12.2023")
                        {
                            trip10.firma = 'C';
                            trip10.fiyat = 1200;
                            trip10.tasitNo = "Uçak 2";
                            trip10.koltukNo = 30;
                            trip10.saat = "17.00";
                            trip10.date = dateTimePicker1.Value.ToShortDateString();
                            Random rand = new Random();
                            int soldSeats = rand.Next(0, trip10.koltukNo);
                            trip10.remainingSeats = trip10.koltukNo - soldSeats;
                        }

                        else if (comboBox1.Text == "Konya" && comboBox2.Text == "İstanbul" && dateTimePicker1.Value.ToShortDateString() == "4.12.2023")
                        {
                            trip10.firma = 'C';
                            trip10.fiyat = 1200;
                            trip10.tasitNo = "Uçak 2";
                            trip10.koltukNo = 30;
                            trip10.saat = "19.00";
                            trip10.date = dateTimePicker1.Value.ToShortDateString();
                            Random rand = new Random();
                            int soldSeats = rand.Next(0, trip10.koltukNo);
                            trip10.remainingSeats = trip10.koltukNo - soldSeats;
                        }
                    }


                    int rowIndex4 = dataGridView1.Rows.Add();
                    DataGridViewRow row4 = dataGridView1.Rows[rowIndex4];

                    row4.Cells[0].Value = trip10.firma;
                    row4.Cells[7].Value = trip10.fiyat;
                    row4.Cells[1].Value = trip10.tasitNo;
                    row4.Cells[2].Value = trip10.koltukNo;
                    row4.Cells[4].Value = 5;
                    row4.Cells[6].Value = trip10.saat;
                    row4.Cells[3].Value = trip10.remainingSeats;
                    row4.Cells[5].Value = trip10.date;
                    //////////////////////////////////////////////////////////////////////////////////
                    Trip trip11 = new Trip();

                    basVar = false;
                    bitVar = false;

                    foreach (string durak in trip11.sefer6)
                    {
                        if (string.Equals(durak, comboBox1.Text, StringComparison.OrdinalIgnoreCase))
                        {
                            basVar = true;
                        }
                        if (string.Equals(durak, comboBox2.Text, StringComparison.OrdinalIgnoreCase))
                        {
                            bitVar = true;
                        }
                    }

                    if (basVar && bitVar)
                    {

                        if (comboBox1.Text == "İstanbul" && comboBox2.Text == "Ankara" && dateTimePicker1.Value.ToShortDateString() == "4.12.2023")
                        {
                            trip11.firma = 'D';
                            trip11.fiyat = 1200;
                            trip11.tasitNo = "Uçak 1";
                            trip11.koltukNo = 30;
                            trip11.saat = "16.30";
                            trip11.date = dateTimePicker1.Value.ToShortDateString();
                            Random rand = new Random();
                            int soldSeats = rand.Next(0, trip11.koltukNo);
                            trip11.remainingSeats = trip11.koltukNo - soldSeats;
                        }

                        else if (comboBox1.Text == "Ankara" && comboBox2.Text == "İstanbul" && dateTimePicker1.Value.ToShortDateString() == "9.12.2023")
                        {
                            trip11.firma = 'D';
                            trip11.fiyat = 1200;
                            trip11.tasitNo = "Uçak 1";
                            trip11.koltukNo = 30;
                            trip11.saat = "20.00";
                            trip11.date = dateTimePicker1.Value.ToShortDateString();
                            Random rand = new Random();
                            int soldSeats = rand.Next(0, trip11.koltukNo);
                            trip11.remainingSeats = trip11.koltukNo - soldSeats;
                        }
                    }
                    int rowIndex5 = dataGridView1.Rows.Add();
                    DataGridViewRow row5 = dataGridView1.Rows[rowIndex5];

                    row5.Cells[0].Value = trip11.firma;
                    row5.Cells[7].Value = trip11.fiyat;
                    row5.Cells[1].Value = trip11.tasitNo;
                    row5.Cells[2].Value = trip11.koltukNo;
                    row5.Cells[4].Value = 6;
                    row5.Cells[6].Value = trip11.saat;
                    row5.Cells[3].Value = trip11.remainingSeats;
                    row5.Cells[5].Value = trip11.date;
                    ///////////////////////////////////////////////////////////////////////
                    Trip trip12 = new Trip();

                    basVar = false;
                    bitVar = false;

                    foreach (string durak in trip12.sefer6)
                    {
                        if (string.Equals(durak, comboBox1.Text, StringComparison.OrdinalIgnoreCase))
                        {
                            basVar = true;
                        }
                        if (string.Equals(durak, comboBox2.Text, StringComparison.OrdinalIgnoreCase))
                        {
                            bitVar = true;
                        }
                    }

                    if (basVar && bitVar)
                    {

                        if (comboBox1.Text == "İstanbul" && comboBox2.Text == "Ankara" && dateTimePicker1.Value.ToShortDateString() == "4.12.2023")
                        {
                            trip12.firma = 'D';
                            trip12.fiyat = 1200;
                            trip12.tasitNo = "Uçak 2";
                            trip12.koltukNo = 30;
                            trip12.saat = "19.30";
                            trip12.date = dateTimePicker1.Value.ToShortDateString();
                            Random rand = new Random();
                            int soldSeats = rand.Next(0, trip12.koltukNo);
                            trip12.remainingSeats = trip12.koltukNo - soldSeats;
                        }

                        if (comboBox1.Text == "Ankara" && comboBox2.Text == "İstanbul" && dateTimePicker1.Value.ToShortDateString() == "6.12.2023")
                        {
                            trip12.firma = 'D';
                            trip12.fiyat = 1200;
                            trip12.tasitNo = "Uçak 2";
                            trip12.koltukNo = 30;
                            trip12.saat = "21.00";
                            trip12.date = dateTimePicker1.Value.ToShortDateString();
                            Random rand = new Random();
                            int soldSeats = rand.Next(0, trip12.koltukNo);
                            trip12.remainingSeats = trip12.koltukNo - soldSeats;
                        }
                    }
                    int rowIndex6 = dataGridView1.Rows.Add();
                    DataGridViewRow row6 = dataGridView1.Rows[rowIndex6];

                    row6.Cells[0].Value = trip12.firma;
                    row6.Cells[7].Value = trip12.fiyat;
                    row6.Cells[1].Value = trip12.tasitNo;
                    row6.Cells[2].Value = trip12.koltukNo;
                    row6.Cells[4].Value = 6;
                    row6.Cells[6].Value = trip12.saat;
                    row6.Cells[3].Value = trip12.remainingSeats;
                    row6.Cells[5].Value = trip12.date;

                }

            }
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    if (dataGridView1.Rows[i].IsNewRow)
                    {
                        continue;
                    }
                    if (dataGridView1.Rows[i].Cells[j].Value == null)
                    {
                        dataGridView1.Rows.RemoveAt(i);
                        i--;
                        break;
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Seferler seferler = new Seferler();
            seferler.Show();
            this.Hide();
        }
        

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Reservation reservation = new Reservation();
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            reservation.firma = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            reservation.tasitNo = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            reservation.kalankoltuksayisi = Convert.ToInt32(dataGridView1.Rows[secilen].Cells[3].Value);
            reservation.fiyat = Convert.ToInt32(dataGridView1.Rows[secilen].Cells[7].Value);
            reservation.saat = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            reservation.koltukNo = Convert.ToInt32(dataGridView1.Rows[secilen].Cells[2].Value);
            reservation.date = dataGridView1.Rows[secilen].Cells[5].Value.ToString();

            int yolcuSayisi = Convert.ToInt32(comboBox3.SelectedItem);
            string basNoktasi = comboBox1.SelectedItem.ToString();
            string bitNoktasi = comboBox2.SelectedItem.ToString();

            if (reservation.kalankoltuksayisi < yolcuSayisi)
            {
                MessageBox.Show("Üzgünüz taşıtta " + yolcuSayisi + " kişilik yer kalmadı.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            KoltukSec koltukSec = new KoltukSec(basNoktasi, bitNoktasi, reservation.firma, reservation.tasitNo, reservation.fiyat, reservation.saat, reservation.kalankoltuksayisi, reservation.koltukNo, yolcuSayisi, reservation.date);
            koltukSec.Show();
            this.Hide();
        }
    }
}
