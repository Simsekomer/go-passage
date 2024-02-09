using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProLab_Proje_2_GoPassage
{
    internal class Reservation
    {
        public string passengerNameSurname;
        public string tasitNo;
        public int koltukNo;
        public int koltuksayisi = 0;
        public int kalankoltuksayisi = 0;
        public string firma;
        public int fiyat;
        public string saat;
        public string date;

        public void Bilet()
        {
            if(firma == "A")
            {
                if(tasitNo == "Otobus-1")
                {
                    koltuksayisi = 20;
                    fiyat = 300;
                    saat = "02.00";
                }
                else if(tasitNo == "Otobus-2")
                {
                    koltuksayisi = 15;
                    fiyat = 300;
                    saat = "02.30";
                }
            }
            if (firma == "B")
            {
                if (tasitNo == "Otobus-1")
                {
                    koltuksayisi = 15;
                    fiyat = 300;
                    saat = "02.30";
                }
                else if (tasitNo == "Otobus-2")
                {
                    koltuksayisi = 20;
                    fiyat = 300;
                    saat = "15.00";
                }
            }
            if (firma == "C")
            {
                if (tasitNo == "Otobus-1")
                {
                    koltuksayisi = 20;
                    fiyat = 300;
                    saat = "21.30";
                }
                else if (tasitNo == "Uçak-1")
                {
                    koltuksayisi = 30;
                    fiyat = 300;
                    saat = "11.00";
                }
                else if (tasitNo == "Uçak-2")
                {
                    koltuksayisi = 30;
                    fiyat = 1200;
                    saat = "17.00";
                }
            }
            if (firma == "D")
            {
                if (tasitNo == "Tren-1")
                {
                    koltuksayisi = 20;
                    fiyat = 250;
                    saat = "13.00";
                }
                else if (tasitNo == "Tren-2")
                {
                    koltuksayisi = 30;
                    fiyat = 250;
                    saat = "14.59";
                }
                else if (tasitNo == "Tren-3")
                {
                    koltuksayisi = 30;
                    fiyat = 200;
                    saat = "02.32";
                }
            }
            if (firma == "F")
            {
                if (tasitNo == "Uçak-1")
                {
                    koltuksayisi = 30;
                    fiyat = 1200;
                    saat = "16.30";
                }
                else if (tasitNo == "Uçak-2")
                {
                    koltuksayisi = 30;
                    fiyat = 1200;
                    saat = "00.30";
                }
            }
        }
    }
  

}
