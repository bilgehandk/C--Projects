using System;

namespace C__Projects
{
    class donguler
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir sayi girin:");
            int length = int.Parse(Console.ReadLine());
            for(int i = 0; i < length; i++)
            {
                if(i % 2 == 1)
                    Console.WriteLine();
            }

            //1 ile 1000 arasındaki tek ve çift sayıları kendi içleridnde toplmalarını yazıdr.
            int tekToplam = 0;
            int ciftToplam = 0;
            for(int i = 0; i < length; i++)
            {
                if(i % 2 == 1)
                    tekToplam += i;
                else
                    ciftToplam += i;
            }
            Console.WriteLine("Tek toplam " + tekToplam);
            Console.WriteLine("Cift toplam:" + ciftToplam);


            // break, continue

            for (int i = 1; i < 10; i++)
            {
                if(i == 4)
                    break;
                Console.WriteLine(i);
            }

            for (int i = 1; i < 10; i++)
            {
                if(i == 4)
                    continue;
                Console.WriteLine(i);
            }
        }
    }
}