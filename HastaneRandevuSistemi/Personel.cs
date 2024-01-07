using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneRandevuSistemi
{


    public class Personel : Kisi
    {
        public string KimlikNo { get; set; }

        public Personel(string ad, string soyad, string kimlikNo) : base(ad, soyad)
        {
            KimlikNo = kimlikNo;
        }
    }
}
