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
                    //Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n).
                    //Sonrasında kullanıcıdan n adet kelime girmesi isteyin.
                    //Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.
            
                    /*Console.WriteLine("Bir pozitif sayi girin:");
                    int  n = Convert.ToInt32(Console.ReadLine());
                    if (n > 0)
                    {
                        string[] kelimeler = new string[n];
                        for (int i = 0; i < n; i++)
                        {
                            Console.WriteLine("Kelimleri yazin:");
                            string kelime = Console.ReadLine();
                            kelimeler[i] = kelime;
                            
                        }
                        
                        Array.Reverse(kelimeler);
                        foreach (var item in kelimeler)
                        {
                            Console.WriteLine(item);
                        }
                    }    */
            
            
            
                    //Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin.
                    //Cümledeki toplam kelime ve harf sayısını console'a yazdırın.
            
                    Console.WriteLine("Bir cümle yazın:");
                    string cumle = Convert.ToString(Console.ReadLine());

                    string[] kelimeler = cumle.Split(' ');
                    char[] harfler = cumle.ToCharArray();
                    int amountofkelime = 0;
                    int amountofharf = 0;

                    foreach (var kelime in kelimeler)
                    {
                        amountofkelime++;
                    }

                    foreach (var harf in harfler)
                    {
                        if (harf ==  ' ')
                        {
                            continue;
                        }
                        amountofharf++;
                    }
            
                    Console.WriteLine("Kelime sayısı: " + amountofkelime);
                    Console.WriteLine("Harf Sayısı: " + amountofharf);


            }
    }
}