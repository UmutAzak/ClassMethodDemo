using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMedotDemo
{
    class MusteriManager
    {
        public void Ekle(musteri musteri)
        {
            Console.WriteLine("Müşteriler Ekle: " + musteri.Adi+ " " + musteri.Soyadi+ " "+ musteri.Telefon_No +" "+musteri.İl  );
        }

        public void Listele(musteri musteri)
        {
            Console.WriteLine("Müşteriler Listele: " + musteri.Adi + " " + musteri.Soyadi + " " + musteri.Telefon_No + " " + musteri.İl);
        }

        public void Sil(musteri musteri)
        {
            Console.WriteLine("Müşteriler Sil: " + musteri.Adi + " " + musteri.Soyadi + " " + musteri.Telefon_No + " " + musteri.İl);
        }
    }
}
