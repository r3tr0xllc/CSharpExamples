using System;

namespace otopark_otomasyonu
{
    class Program
    {
        static void Main(string[] args)
        {
            int arac_turu, taksi = 1, minibus = 2, ticari = 3; double fiyat, taksi_saatlik_ucret =5,minibus_saatlik_ucret=6,ticari_saatlik_ucret=7,sure;
            Console.Write("TAKSİ İÇİN 1, MİNİBÜS İÇİN 2, TİCARİ İÇİN 3'Ü TUSLAYINIZ!");
            arac_turu = Convert.ToInt32(Console.ReadLine());
            if (arac_turu==taksi)
            {
                Console.Write("İÇERİDE GEÇİRDİĞİNİZ SÜREYİ GİRİN : ");
                sure = Convert.ToInt32(Console.ReadLine());
                if (sure>=2)
                {
                    double faiz = ((taksi_saatlik_ucret / 100) * 20) *sure;
                    fiyat =taksi_saatlik_ucret+ faiz;
                    Console.WriteLine("ÖDEMENİZ GEREKEN ÜCRET : " + fiyat);
                }
                else
                {
                    fiyat = taksi_saatlik_ucret;
                    Console.WriteLine("ÖDEMENİZ GEREKEN ÜCRET : " + fiyat);
                }
            }
            if (arac_turu == minibus)
            {
                Console.Write("İÇERİDE GEÇİRDİĞİNİZ SÜREYİ GİRİN : ");
                sure = Convert.ToInt32(Console.ReadLine());
                if (sure  >=2)
                {
                    double faiz = ((minibus_saatlik_ucret / 100) * 25) * sure;
                    fiyat = minibus_saatlik_ucret + faiz;
                    Console.WriteLine("ÖDEMENİZ GEREKEN ÜCRET : " + fiyat);
                }
                else
                {
                    fiyat = minibus_saatlik_ucret;
                    Console.WriteLine("ÖDEMENİZ GEREKEN ÜCRET : " + fiyat);
                }
            }
            if (arac_turu == ticari)
            {
                Console.Write("İÇERİDE GEÇİRDİĞİNİZ SÜREYİ GİRİN : ");
                sure = Convert.ToInt32(Console.ReadLine());
                if (sure >= 2)
                {
                    double faiz = ((ticari_saatlik_ucret / 100) * 30) * sure;
                    fiyat = ticari_saatlik_ucret + faiz;
                    Console.WriteLine("ÖDEMENİZ GEREKEN ÜCRET : " + fiyat);
                }
                else
                {
                    fiyat = ticari_saatlik_ucret;
                    Console.WriteLine("ÖDEMENİZ GEREKEN ÜCRET : " + fiyat);
                }
            }

        }
    }
}
