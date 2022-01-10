using System;

namespace C__Projects
{
    class donguler2
    {
        static void Main(string[] args)
            {
            //while
            // 1 den başlayarak konsolo girilen sayıya kadar(sayı dahil) ortalama
            // hesaplayıp console a yazdıran program
            Console.Write("Lütfen bir sayi girin:");
            int sayi = int.Parse(Console.ReadLine());
            int sayac = 1;
            int toplam = 0;
            while (sayac <= sayi)
            {
                toplam += sayac;
                sayac ++;
            }

            Console.WriteLine(toplam/sayi);


            //a dan z ye kadar tüm harfleeri console yazdır
            char character = 'a';
            while (character < 'z')
            {
                Console.Write(character);
                character++;
            }

            Console.Write("****Foreach****");
            string[] arabalar = {"Bmw","Ford","Toyota","Nissan"};

            foreach(var araba in arabalar)
            {
                Console.WriteLine(araba);
            }
        }
    }
}