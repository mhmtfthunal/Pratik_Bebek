using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratik_Bebek
{
     
    internal class Bebek
    {
        public Bebek()
        {
            Console.WriteLine("INGAAAAA");
            DogumTarihi = DateTime.Now;
        }

        public Bebek(string ad, string soyad)
        {
            Console.WriteLine("INGAAAAA");
            Ad = ad;
            SoyAd = soyad;
            DogumTarihi = DateTime.Now;
        }
        public string Ad { get; set; }
        public string SoyAd { get; set; }
        public DateTime DogumTarihi { get; set; }
    }
}
