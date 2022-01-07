using System;

namespace C__Projects
{
    class KararYapilari
    {
        static void Main(string[] args)
        {
            int time = DateTime.Now.Hour;
            
            if(time >= 6 && time <12)
                Console.WriteLine("Günaydin");
            else if(time <= 18)
                Console.WriteLine("İyi günler!");
            else 
                Console.WriteLine("İyi geceler");
            
            string sonuc = time <= 18 ? "İyi günler" : "İyi Geceler";
            sonuc = time >= 6 && time < 12 ? "Günaydin" : time <= 18 ? "İyi Günler" : "iYİ Geceler"; 
            Console.WriteLine(sonuc);
        }
    }
}