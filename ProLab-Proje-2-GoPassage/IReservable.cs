using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProLab_Proje_2_GoPassage
{
    internal interface IReservable
    {
        bool CheckSeatAvailability(int koltukNo);
    }
}
