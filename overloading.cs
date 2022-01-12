using System;

namespace C__Projects
{
    class overloading
    {
        static void Main(string[] args)
        {
            //out parametreler
            string sayi = "999";

            bool sonuc = int.TryParse(sayi, out int outsayi);
            if(sonuc)
            {
                Console.WriteLine("Başarili");
                Console.WriteLine(outsayi);
            }
            else
            {
                Console.WriteLine("Başarisiz");
            }

            Metotlar2 instance = new Metotlar2();
            instance.Toplama(4,5, out int toplamSonucu);
            Console.WriteLine(toplamSonucu);

            //Metot Aşırı yükleme - overloading

            int ifade = 999;
            instance.EkranaYazdir(Convert.ToString(ifade));
            instance.EkranaYazdir(ifade);
            instance.EkranaYazdir("Zikriye","Ürkmez");

            //Metot imzasi
            //Metotadi + parametre saiyisi + parametre

        }
    }

    class Metotlar2
    {
        public void Toplama(int a, int b, out int toplam)
        {
            toplam = a+b;
        }

        public void EkranaYazdir(string veri)
        {
            Console.WriteLine(veri);
        }

        public void EkranaYazdir(int veri)
        {
            Console.WriteLine(veri);
        }

        public void EkranaYazdir(string veri, string veri2)
        {
            Console.WriteLine(veri + veri2);
        }

    }
}