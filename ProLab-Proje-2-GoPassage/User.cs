using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Navigation;

namespace ProLab_Proje_2_GoPassage
{
    internal abstract class User : ILoginable
    {
        public bool Giris(string username, string password)
        {
            Admin admin = new Admin();
           
            if (username == admin.KullaniciAdi && password == admin.Sifre)
            {
                AdminPaneli adminPaneli = new AdminPaneli();
                adminPaneli.Show();
                return true;
            }
            else
                return false;
        }
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }

        public abstract void Giris();
    }
}
