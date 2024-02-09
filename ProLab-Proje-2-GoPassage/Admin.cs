using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProLab_Proje_2_GoPassage
{
    internal class Admin : User
    {
        public string kullaniciAdi = "admin";
        public string sifre = "654321";
        public override void Giris()
        {
            KullaniciAdi = "admin";
            Sifre = "654321";
        }
    }
}
