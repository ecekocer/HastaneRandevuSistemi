using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneRandevuSistemi
{


    public class Doktor : Personel, IRandevuYonetimi
    {
        public string UzmanlikAlani { get; set; }
        public List<Randevu> Randevular { get; set; }

        public Doktor(string ad, string soyad, string kimlikNo, string uzmanlikAlani) : base(ad, soyad, kimlikNo)
        {
            UzmanlikAlani = uzmanlikAlani;
            Randevular = new List<Randevu>();
        }

        public override string ToString()
        {
            return Ad + " " + Soyad + " (" + UzmanlikAlani + " Uzmanı)";
        }

        public void RandevuGoruntule(Randevu randevu)
        {
            Randevular.Add(randevu);
        }

        public void RandevuIptal(Randevu randevu)
        {
            Randevular.Remove(randevu);
        }
    }
}
