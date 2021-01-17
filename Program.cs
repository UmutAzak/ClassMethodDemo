using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMedotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] musteriler = new string[] { };

            musteri musteri1 = new musteri();
            musteri1.ID = 1 ;
            musteri1.Adi = "Samet";
            musteri1.Soyadi = "Kara";
            musteri1.Telefon_No = 123456789;
            musteri1.İl = "Ankara";

            musteri musteri2 = new musteri();
            musteri2.ID = 2;
            musteri2.Adi = "Aylin";
            musteri2.Soyadi = "Kete";
            musteri2.Telefon_No = 123456788;
            musteri2.İl = "Antalya";

            musteri musteri3 = new musteri();
            musteri3.ID = 3;
            musteri3.Adi = "Sinan";
            musteri3.Soyadi = "Al";
            musteri3.Telefon_No = 123456787;
            musteri3.İl = "Samsun";

            musteri[] musteri = new musteri[] { musteri1, musteri2, musteri3 };
            foreach (musteri musteriz in musteri)
            {

                Console.WriteLine(" ID : " + musteriz.ID);
                Console.WriteLine(" Ad : " + musteriz.Adi);
                Console.WriteLine(" Soyad : " + musteriz.Soyadi);
                Console.WriteLine(" Telefon Numarası : " + musteriz.Telefon_No);
                Console.WriteLine(" İl : " + musteriz.İl);
                Console.WriteLine("---------");
                
            }
            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            musteriManager.Ekle(musteri3);
            Console.WriteLine("----------");
            musteriManager.Listele(musteri1);
            musteriManager.Listele(musteri2);
            musteriManager.Listele(musteri3);
            Console.WriteLine("----------");
            musteriManager.Sil(musteri1);
            musteriManager.Sil(musteri2);
            musteriManager.Sil(musteri3);

            Console.ReadKey();
        }
    }
}
