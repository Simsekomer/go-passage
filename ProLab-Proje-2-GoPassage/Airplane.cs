using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProLab_Proje_2_GoPassage
{
    internal class Airplane : Vehicle
    {
        public override float CalculateFuelCost(string a, string b)
        {
            if (firmaAdi == "C")
            {
                return 2 * (300 * 25);
            }
            else if (firmaAdi == "F")
            {
                return 2 * (250 * 20);
            }
            else
            {
                return -1;
            }

        }
        public Airplane()
        {
            if (firmaAdi == "C")
            {
                if (aracID == "Ucak-1")
                    Capacity = 30;
                else if (aracID == "Ucak-2")
                    Capacity = 30;
            }
            else if (firmaAdi == "F")
            {
                if (aracID == "Ucak-1")
                    Capacity = 30;
                else if (aracID == "Ucak-2")
                    Capacity = 30;
            }
        }
    }
}
