using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProLab_Proje_2_GoPassage
{
    internal class Train : Vehicle
    {
        public override float CalculateFuelCost(string a, string b)
        {
            if (aracID == "Train-1")
            {
                return 2 * (750 * 3);
            }
            else if (aracID == "Train-2" || aracID == "Train-3")
            {
                return 2 * (900 * 3);
            }
            else
            {
                return -1;
            }
        }
        public Train()
        {
            firmaAdi = "D";
            if (aracID == "Train-1")
                Capacity = 25;
            else if (aracID == "Train-2")
                Capacity = 25;
            else if (aracID == "Train-3")
                Capacity = 25;

        }
    }
}
