using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProLab_Proje_2_GoPassage
{
    internal class Trip
    {
        public string[] sefer1 = {"Demiryolu","İstanbul", "Kocaeli" ,"Bilecik"
                ,"Eskişehir", "Ankara", "Eskişehir","Bilecik", "Kocaeli", "İstanbul" };
        public string[] sefer2 = {"Demiryolu","İstanbul", "Kocaeli" ,"Bilecik"
                ,"Eskişehir", "Konya", "Eskişehir","Bilecik", "Kocaeli", "İstanbul" };
        public string[] sefer3 = {"Karayolu","İstanbul", "Kocaeli" ,"Ankara", "Kocaeli","İstanbul"};
        public string[] sefer4 = {"Karayolu","İstanbul", "Kocaeli" ,"Eskişehir", "Konya","Eskişehir", "Kocaeli",
                "İstanbul" };
        public string[] sefer5 = { "Havayolu", "İstanbul", "Konya", "İstanbul" };
        public string[] sefer6 = { "Havayolu", "İstanbul", "Ankara", "İstanbul" };

        public int fiyat = 0;
        public string tasitNo;
        public char firma;
        public int koltukNo;
        public string saat;
        public string date;
        public int remainingSeats = 0;
    }
}
