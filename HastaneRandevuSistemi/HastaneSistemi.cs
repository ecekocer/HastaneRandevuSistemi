using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneRandevuSistemi
{
    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;


    public class HastaneSistemi : HastaneRandevuSistemi
    {
        public static List<Hasta> HastaListesi = new List<Hasta>();
        public static List<Doktor> DoktorListesi = new List<Doktor>();
        public static List<Randevu> RandevuListesi = new List<Randevu>();

        public override void RandevuAl(string hastaAd, string hastaSoyad, string doktorAd, string doktorSoyad, DateTime tarih, string saat)
        {
        }

        public override void RandevuIptal(string hastaAd, string hastaSoyad, DateTime tarih, string saat)
        {
        }

        public override void PersonelEkle(string ad, string soyad, string kimlikNo)
        {
        }

        public override void PersonelSil(string kimlikNo)
        {
        }

    }
}
