using System;

namespace C__Projects
{
    class koleksiyonlar1
    {
        static void Main(string[] args)
        {
            //List<T> class
            //System.Collection.Generic
            // T -> object türündedir.

            List<int> sayiListesi = new List<int>();
            sayiListesi.Add(23);
            sayiListesi.Add(31);
            sayiListesi.Add(4);
            sayiListesi.Add(12);
            sayiListesi.Add(91);

            List<string> renkListesi = new List<string>();
            renkListesi.Add("Kirmizi");
            renkListesi.Add("Mavi");
            renkListesi.Add("Turuncu");
            renkListesi.Add("Sari");
            renkListesi.Add("Yeşil");

            //Count
            Console.WriteLine(renkListesi.Count);
            Console.WriteLine(sayiListesi.Count);

            //Foreach ve List.Foreach ile elemanlara erişim
            foreach (var sayi in sayiListesi)
                Console.WriteLine(sayi);
            foreach (var renk in renkListesi)
                Console.WriteLine(renk);

            sayiListesi.Foreach(sayi => Console.WriteLine(sayi));
            renkListesi.ForEach(renk => Console.WriteLine(renk));

            //Liste içerisene arama
            if(sayiListesi.Contains(10))
                Console.WriteLine("10 liste içerisinde bulundu");

            //Eleman ile index'e erişim
            Console.WriteLine(renkListesi.BinarySearch("Sari"));

            //Diziyi List'e çevirme
            string[] hayvanlar = {"Kedi","Köpek","Kuş"};
            List<string> hayvanlarListesi = new List<string>(hayvanlar);

            //Listeyi nasıl temizleriz?
            hayvanlarListesi.Clear();


            //List içinde nesne tutmak
            List<users> kullaniciliste = new List<users>();
            users kullanici1 = new users();
            kullanici1.Isim ="Ayşe";
            kullanici1.Soyisim = "Yildiz";
            kullanici1.Yas = 21;

            users kullanici2 = new users();
            kullanici2.Isim = "Özcan";
            kullanici2.Soyisim ="Demir";
            kullanici2.Yas = 12;

            kullaniciliste.Add(kullanici1);
            kullaniciliste.Add(kullanici2);

            List<users> yeniListe = new List<users>();

            yeniListe.Add(new Kullanicilar()
            {
                Isim = "Deniz",
                Soyisim = "Arda",
                Yas = 23

            });

            foreach (var kullanici in kullaniciliste)
            {
                Console.WriteLine("Kullanici Adi:" + kullanici.Isim);
                Console.WriteLine("Kullanici Soyadi:" + kullanici.Soyisim);
                Console.WriteLine("Kullanici Yas:" + kullanici.Yas);
            }
            hayvanlarListesi.Clear();

        }
    }

    public class users
    {
        private string isim;

        private string soyisim;
        
        private int yas;

        public string Isim { get => isim; set => isim = value; }

        public string Soyisim { get => soyisim; set => soyisim = value; }

        public int Yas { get => yas; set => yas = value; }

        
    }





}