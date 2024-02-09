using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ProLab_Proje_2_GoPassage
{
    internal class Bus : Vehicle
    {

        public override float CalculateFuelCost(string firmaAdi, string aracId)
        {
            if (firmaAdi == "A" && aracID == "Otobus-1")
            {
                return 2 * (1000 * 10);
            }
            else if (firmaAdi == "A" && aracID == "Otobus-1")
            {
                return 2 * (1000 * 10);
            }
            else if (firmaAdi == "B" && aracID == "Otobus-1")
            {
                return 2 * (1000 * 5);
            }
            else if (firmaAdi == "B" && aracID == "Otobus-2")
            {
                return 2 * (1200 * 5);
            }
            else if (firmaAdi == "C" && aracID == "Otobus-1")
            {
                return 2 * (1200 * 6);
            }
            else
            {
                return -1;
            }
        }
        public Bus()
        {
            if (firmaAdi == "A")
            {
                if (aracID == "Otobus-1")
                    Capacity = 20;
                else if (aracID == "Otobus-2")
                    Capacity = 15;
            }
            else if (firmaAdi == "B")
            {
                if (aracID == "Otobus-1")
                    Capacity = 15;
                else if (aracID == "Otobus-2")
                    Capacity = 20;
            }
            else if (firmaAdi == "C")
            {
                aracID = "Otobus-1";
                Capacity = 20;
            }
        }

    }
}
