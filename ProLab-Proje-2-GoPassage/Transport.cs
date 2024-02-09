using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProLab_Proje_2_GoPassage
{
    internal class Transport : IReservable
    {
        Reservation reser = new Reservation();
        private bool[] seats;
        public bool CheckSeatAvailability(int koltukNo)
        {
           
             seats = new bool[reser.koltuksayisi];
            for (int i = 0; i < seats.Length; i++)
            {
                seats[i] = true;
            }
            if (reser.kalankoltuksayisi >= 0 && reser.kalankoltuksayisi < seats.Length)
            {
                return seats[reser.kalankoltuksayisi];
            }

            return false;
        }
    }
}
