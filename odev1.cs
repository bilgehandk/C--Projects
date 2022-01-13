using System;

namespace C__Projects
{
    class odev1
    {
        static void Main(string[] args)
            {

                /*
                Bir konsol uygulamasında kullanıcıdan pozitif bir sayı 
                girmesini isteyin(n). Sonrasında kullanıcıdan n adet
                pozitif sayı girmesini isteyin. 
                Kullanıcının girmiş olduğu sayılardan çift olanlar 
                console'a yazdırın.
                */

                /*
                Console.WriteLine("Bir pozitif sayi grin:");
                int n = Convert.ToInt32(Console.ReadLine());
                if(n >0)
                {
                    int[] sayilar = new int[n];
                    for(int i = 0; i < n; i++)
                    {
                        Console.WriteLine("Sayilari giriniz:");
                        int sayi = Convert.ToInt32(Console.ReadLine());
						sayilar[i] = sayi;
                    }
                    for (int j = 0; j < n; j++)
                    {
                        if(sayilar[j] % 2 == 0)
                        {
                            Console.WriteLine(sayilar[j]);
                        }
                    }
                }    */

                /*
             * Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m).
             * Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin.
             * Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.
             */


                Console.WriteLine("iki pozitif sayi grin:");
                int n = Convert.ToInt32(Console.ReadLine());
                int m = Convert.ToInt32(Console.ReadLine());
                if (n > 0)
                {
                    int[] sayilar = new int[n];
                    for (int i = 0; i < n; i++)
                    {
                        Console.WriteLine("Sayilari giriniz:");
                        int sayi = Convert.ToInt32(Console.ReadLine());
                        sayilar[i] = sayi;
                    }

                    for (int j = 0; j < n; j++)
                    {
                        if (sayilar[j] % m == 0 || sayilar[j] == m)
                        {
                            Console.WriteLine(sayilar[j]);
                        }
                    }



            }
    }
}