using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneRandevuSistemi
{
    public abstract class HastaneRandevuSistemi
    {
        public abstract void RandevuAl(string hastaAd, string hastaSoyad, string doktorAd, string doktorSoyad, DateTime tarih, string saat);
        public abstract void RandevuIptal(string hastaAd, string hastaSoyad, DateTime tarih, string saat);
        public abstract void PersonelEkle(string ad, string soyad, string kimlikNo);
        public abstract void PersonelSil(string kimlikNo);

        public void HastaBilgisiGoster(string hastaAd, string hastaSoyad)
        {
            Console.WriteLine("Hasta Bilgileri: {0} {1}", hastaAd, hastaSoyad);
        }

    }
}
