using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneRandevuSistemi
{

    public class Hasta : Kisi, IRandevuYonetimi
    {
        public string TCKimlikNo { get; set; }
        public List<Randevu> Randevular { get; set; }

        public Hasta(string ad, string soyad, string tcKimlikNo) : base(ad, soyad)
        {
            TCKimlikNo = tcKimlikNo;
            Randevular = new List<Randevu>();
        }

        public override string ToString()
        {
            return Ad + " " + Soyad + " (" + TCKimlikNo + ")";
        }

        public void RandevuAl(Randevu randevu)
        {
            Randevular.Add(randevu);
        }

        public void RandevuIptal(Randevu randevu)
        {
            Randevular.Remove(randevu);
        }
    }
}
