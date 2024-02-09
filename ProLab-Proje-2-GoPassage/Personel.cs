using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProLab_Proje_2_GoPassage
{

    internal class Personel : Person
    {
        public void PersonalInformaiton()
        {
            if (FirmaAdi == "A")
            {
                if (AracAdi == "Otobus-1")
                {
                    Driver1 = "Abuzer Kömürcü";
                    Driver2 = "Erdal Kömürcü";
                    Personal1 = "Davut Ekmek";
                    Personal2 = "Süleyman Çakır";
                }
                else if (AracAdi == "Otobus-2")
                {
                    Driver1 = "Mehmet Karahanlı";
                    Driver2 = "Ali Candan";
                    Personal1 = "Aslan Akbey";
                    Personal2 = "Memati Baş";
                }
            }
            else if (FirmaAdi == "B")
            {
                if (AracAdi == "Otobus-1")
                {
                    Driver1 = "Güllü Erhan";
                    Driver2 = "Seyfa Delikanlı";
                    Personal1 = "Duran Mert";
                    Personal2 = "Tuncay Deve";
                }
                else if (AracAdi == "Otobus-2")
                {
                    Driver1 = "Ömer Uçar";
                    Driver2 = "Ezel Bayraktar";
                    Personal1 = "Cengiz Atay";
                    Personal2 = "Ali Kerpeten";
                }
                else if (FirmaAdi == "C")
                {
                    if (AracAdi == "Otobus-1")
                    {
                        Driver1 = "Tevfik Yamantürk";
                        Driver2 = "Attila Haylaz";
                        Personal1 = "Ramiz Karaeski";
                        Personal2 = "Kenan Birkan";
                    }
                    else if (AracAdi == "Uçak-1")
                    {
                        Driver1 = "Ömer Baltacı";
                        Driver2 = "Eren Sartıtaş";
                        Personal1 = "Emirhan Şenel";
                        Personal2 = "Berk Demir";
                    }
                    else if (AracAdi == "Uçak-2")
                    {
                        Driver1 = "Emin İşanç";
                        Driver2 = "Erol Karakaya";
                        Personal1 = "Kuzey Tekin";
                        Personal2 = "Hüsnü Çoban";
                    }
                    else if (FirmaAdi == "D")
                    {
                        if (AracAdi == "Tren-1")
                        {
                            Driver1 = "Sergen Yalçın";
                            Driver2 = "Feyyaz Uçar";
                            Personal1 = "Ali Gültekin";
                            Personal2 = "Mesut Sinirli";
                        }
                        else if (AracAdi == "Tren-2")
                        {
                            Driver1 = "Eyşan Atay";
                            Driver2 = "Elif Eylül";
                            Personal1 = "Polat Alemdar";
                            Personal2 = "Ziya Laz";
                        }
                        else if (AracAdi == "Tren-3")
                        {
                            Driver1 = "Kılıç Keskin";
                            Driver2 = "Halit Cerrahpaşa";
                            Personal1 = "Hüsrev Ağaoğlu";
                            Personal2 = "Necmi Hırdavat";
                        }
                        else if (FirmaAdi == "F")
                        {
                            if (AracAdi == "Ucak-1")
                            {
                                Driver1 = "Halil İbrahim Halo";
                                Driver2 = "İskender Büyük";
                                Personal1 = "Pala Gözlük";
                                Personal2 = "Mehmet Tombala";
                            }
                            else if (AracAdi == "Ucak-2")
                            {
                                Driver1 = "Nizamettin Hukuk";
                                Driver2 = "Atiba Güven";
                                Personal1 = "İdil Adanalı";
                                Personal2 = "Suat Çoban";
                            }
                        }
                    }
                }
            }
        }
        public string FirmaAdi { get; set; }
        public string AracAdi { get; set; }

    }


}

