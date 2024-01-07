using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneRandevuSistemi
{
    public class Randevu
    {
        public DateTime Tarih { get; set; }
        public string Saat { get; set; }
        public Doktor Doktor { get; set; }
        public Hasta Hasta { get; set; }

        public Randevu(DateTime tarih, string saat, Doktor doktor, Hasta hasta)
        {
            Tarih = tarih;
            Saat = saat;
            Doktor = doktor;
            Hasta = hasta;
        }

        public override string ToString()
        {
            return Tarih.ToString() + " " + Saat + " " + Doktor.ToString() + " " + Hasta.ToString();
        }
    }
}
