using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ProLab_Proje_2_GoPassage
{
    internal class Company : User, IProfitable
    {
        public override void Giris()
        {
            KullaniciAdi = "a-firmasi";
            Sifre = "123456";

        }

        Bus bus = new Bus();
        float YakitgiderA = 0;
        float araToplamA = 0;
        public double CalculateDailyProfit()
        {

            YakitgiderA = bus.CalculateFuelCost("A", "Otobus-1");
            YakitgiderA = araToplamA;
            YakitgiderA = bus.CalculateFuelCost("A", "Otobus-2");
            araToplamA = YakitgiderA + araToplamA;
            return araToplamA;
        }

        public double CalculateTotalProfit()
        {
            float ToplamA = 0, ToplamB = 0, ToplamC = 0, ToplamD = 0, ToplamF = 0;
            float GiderA = 0, GiderB = 0, GiderC = 0, GiderD = 0, GiderF = 0;
            Trip trip = new Trip();
            Random rand = new Random();
            int randomSayi = rand.Next(0, trip.koltukNo);
            Reservation reservation = new Reservation();
            if (reservation.firma == "A")
            {
                if (reservation.tasitNo == "Otobus-1")
                {
                    GiderA = randomSayi * 300;
                    ToplamA = GiderA + ToplamA;
                }
                else if (reservation.tasitNo == "Otobus-2")
                {
                    GiderA = randomSayi * 300;
                    ToplamA = GiderA + ToplamA;
                }
            }
            else if (reservation.firma == "B")
            {
                if (reservation.tasitNo == "Otobus-1")
                {
                    GiderB = randomSayi * 300;
                    ToplamB = GiderB + ToplamB;
                }
                else if (reservation.tasitNo == "Otobus-2")
                {
                    GiderB = randomSayi * 300;
                    ToplamB = GiderB + ToplamB;
                }
            }
            else if (reservation.firma == "C")
            {
                if (reservation.tasitNo == "Otobus-1")
                {
                    GiderC = randomSayi * 300;
                    ToplamC = GiderC + ToplamC;
                }
                else if (reservation.tasitNo == "Uçak-1")
                {
                    GiderC = randomSayi * 1200;
                    ToplamC = GiderC + ToplamC;
                }
                else if (reservation.tasitNo == "Uçak-2")
                {
                    GiderC = randomSayi * 1200;
                    ToplamC = GiderC + ToplamC;
                }
            }
            else if (reservation.firma == "D")
            {
                if (reservation.tasitNo == "Train-1")
                {
                    GiderD = randomSayi * 250;
                    ToplamD = GiderD + ToplamD;
                }
                else if (reservation.tasitNo == "Train-2")
                {
                    GiderD = randomSayi * 250;
                    ToplamD = GiderD + ToplamD;
                }
                else if (reservation.tasitNo == "Train-3")
                {
                    GiderD = randomSayi * 200;
                    ToplamD = GiderD + ToplamD;
                }
            }
            else if (reservation.firma == "F")
            {
                if (reservation.tasitNo == "Ucak-1")
                {
                    GiderF = randomSayi * 1200;
                    ToplamF = GiderF + ToplamF;
                }
                else if (reservation.tasitNo == "Ucak-2")
                {
                    GiderF = randomSayi * 1200;
                    ToplamF = GiderF + ToplamF;
                }
            }
            float toplamSatis;
            toplamSatis = ToplamA + ToplamB + ToplamC + ToplamD + ToplamF;
            return toplamSatis;

        }
    }
}
