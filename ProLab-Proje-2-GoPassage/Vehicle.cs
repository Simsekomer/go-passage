using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;

namespace ProLab_Proje_2_GoPassage
{
    internal abstract class Vehicle
    {
        public string aracID { get; set; }
        public int Capacity { get; set; }

        public string firmaAdi { get; set; }
        public abstract float CalculateFuelCost(string firma, string aracId);

    }
}
