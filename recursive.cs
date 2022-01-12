using System;

namespace C__Projects
{
    class recursive
    {
        static void Main(string[] args)
        {

            //Rekürsif - Öz yinelemeli
            //3^4 = 3*3*3*3

            int result = 1;
            for (int i = 1; i < 5; i++)
                result = result * 3;
            Console.WriteLine(result);

            Islemler instance = new();
            Console.WriteLine(instance.Expo(3,4));

            //Extension Metotlar
            string ifade = "BilgehAn Demirkaya";
            bool sonuc = ifade.CheckSpace();
            Console.WriteLine(ifade.CheckSpace());
            Console.WriteLine(sonuc);
            if(sonuc)
                Console.WriteLine(ifade.RemoveWhiteSpace());
            Console.WriteLine(ifade.MakeUpperCase());
            Console.WriteLine(ifade.MakeLowerCase());

            int[] dizi = {9,6,3,5,4,2,1,11};
            dizi.SortArray();
            dizi.EkranaYazdir();

            int sayi1= 5;
            Console.WriteLine(sayi1.IsEvenNumber());

            Console.WriteLine(ifade.GetFirstCharachter());

        }
    }
    
    public class Islemler
    {
        public int Expo(int sayi, int üs)
        {
            if(üs<2)
                return sayi;
            return Expo(sayi,üs-1) * sayi;
            //Expo(3,4)
            //Expo(3,3) * 3;
            //Expo(3,2) * 3 * 3; 
            //Expo(3,1) * 3 * 3 * 3;
            //3*3*3*3 = 3^4 
        }
    }

    public static class Extension
    {
        public static bool CheckSpace(this string param)
        {
            return param.Contains(" ");
        }

        public static string RemoveWhiteSpace(this string param)
        {
            string[] dizi = param.Split(" ");
            return string.Join("",dizi);
        }

        public static string MakeUpperCase(this string param)
        {
            return param.ToUpper();
        }

        public static string MakeLowerCase(this string param)
        {
            return param.ToLower();
        }

        public static int[] SortArray(this int[] param)
        {
            Array.Sort(param);
            return param;
        }

        public static void EkranaYazdir(this int[] param)
        {
            foreach (int item in param)
            Console.WriteLine(item);
        }

        public static bool IsEvenNumber(this int param)
        {
            return param%2 == 0;
        }

        public static string GetFirstCharachter(this string param)
        {
            return param.Substring(0,1);
        }
    }
}

