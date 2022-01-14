using System;

namespace C__Projects
{
    class arraylist
    {
        static void Main(string[] args)
            {
                ArrayList liste = new ArrayList();
                //liste.Add("Ayşe");
                //liste.Add(true);
                //liste.Add("A");

                //İçeride verilenelre erişim
                //Console.WriteLine(liste[1]);
                //foreach(var item in liste)
                //    Console.WriteLine(item);


                //AddRange
                Console.WriteLine("**** Add Range ****");
                //string[] renkler = {"Kirmizi","Sari","Yesil"};
                List<int> sayilar = new List<int>{}(1,8,3,7,9,92,5);
                //liste.AddRange(renkler);
                liste.AddRange(sayilar);

                foreach (var item in liste)
                    Console.WriteLine(item);

                //Sort
                Console.WriteLine("*** Sort ***");
                liste.Sort();

                foreach (var item in liste)
                    Console.WriteLine(item);

                //Binary Search
                Console.WriteLine("** Binary Search **");
                Console.WriteLine(liste.BinarySearch(9));

                //Reverse
                Console.WriteLine("*** Reverse ***");
                liste.Reverse();
                foreach (var item in liste)
                    Console.WriteLine(item);

                //Clear
                liste.Clear();
                foreach (var item in liste)
                    Console.WriteLine(item);


            }
    }
}
