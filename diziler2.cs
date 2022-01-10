using System;

namespace C__Projects
{
    class diziler2
    {
        static void Main(string[] args)
            {
                //Sort
                int[] sayiDizisi = {23,12,44,24,11,49,17};
                foreach(var sayi in sayiDizisi)
                    Console.WriteLine(sayi);

                Console.WriteLine("**** Sirali Dizi ****");
                Array.Sort(sayiDizisi,2,3);

                foreach (var sayi in sayiDizisi)
                    Console.WriteLine(sayi);

                //Clear
                Console.WriteLine("*** Array Clear ***");
                // SAYI dizisi elemanlarını kullanarak 2.indexten itibaren
                // 2 tane elemanı sıfırlar
                Array.Clear(sayiDizisi, 2, 2);

                foreach(var sayi in sayiDizisi)
                    Console.WriteLine(sayi);

                //Reverse
                Array.Reverse(sayiDizisi);
                
                foreach(var sayi in sayiDizisi)
                    Console.WriteLine(sayi);

                //Indexof
                Console.WriteLine("*** Array IndexOf ***");
                Console.WriteLine( Array.IndexOf(sayiDizisi,23));

                //Resize
                Console.WriteLine("*** Array Resizee ***");
                Array.Resize<int>(ref sayiDizisi, 9);
                sayiDizisi[8] = 99;

                foreach (var sayi in sayiDizisi)
                    Console.WriteLine(sayi);
            }
    }
}