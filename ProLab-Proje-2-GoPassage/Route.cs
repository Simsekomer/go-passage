using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ProLab_Proje_2_GoPassage
{
    internal class Route
    {
        public string basNoktasi;
        public string bitNoktasi;
        public double mesafe;
        public void guzergahBelirle()
        {
            Route sefer1 = new Route();
            sefer1.basNoktasi = "İstanbul";
            sefer1.bitNoktasi = "Ankara";
            sefer1.mesafe = 375;

            Route sefer2 = new Route();
            sefer1.basNoktasi = "İstanbul";
            sefer1.bitNoktasi = "Konya";
            sefer1.mesafe = 450;

            Route sefer3 = new Route();
            sefer1.basNoktasi = "İstanbul";
            sefer1.bitNoktasi = "Ankara";
            sefer1.mesafe = 500;

            Route sefer4 = new Route();
            sefer1.basNoktasi = "İstanbul";
            sefer1.bitNoktasi = "Konya";
            sefer1.mesafe = 600;

            Route sefer5 = new Route();
            sefer1.basNoktasi = "İstanbul";
            sefer1.bitNoktasi = "Konya";
            sefer1.mesafe = 300;

            Route sefer6 = new Route();
            sefer1.basNoktasi = "İstanbul";
            sefer1.bitNoktasi = "Ankara";
            sefer1.mesafe = 250;
        }

    }
}

