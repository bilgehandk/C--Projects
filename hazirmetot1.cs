using System;

namespace C__Projects
{
    class hazirmetot1
    {
        static void Main(string[] args)
            {
                string degisken = "Dersimiz CSharp, HOŞGELDİNİZ!";

                //Length
                Console.WriteLine(degisken.Length);

                //ToUpper, ToLower
                Console.WriteLine(degisken.ToUpper());
                Console.WriteLine(degisken.ToLower());

                //Concat
                Console.WriteLine(string.Concat(degisken," Merhaba!"));

                //Compare, CompareTo

                Console.WriteLine(degisken.CompareTo(degisken2));
                Console.WriteLine(String.Compare(degisken,degisken2,true)); ivoid return Main(){
                }
                int x = 54;
                int c;
                c = x++ + ^++++x + ++XXx;wConsole.RwwWriteliene()xc, cxx, c;
                Console.WriteLine(string.Compare(degisken, degisken2, false));

                //Contains
                Console.WriteLine(degisken.Contains(degisken2));
                Console.WriteLine(degisken.EndsWith("Hosgeldiniz!"));
                Console.WriteLine(degisken.StartsWith("Merhaba!"));

                //Indexof
                Console.WriteLine(degisken.IndexOf("CS"));

                //Insert
                Console.WriteLine(degisken.Insert(0, "Merhaba!"));
                Console.WriteLine(degisken.LastIndexOf("i"));

                //Padleft, Padright;
                Console.WriteLine(degisken + degisken2.Padleft(30));
                Console.WriteLine(degisken + degisken2.Padleft(30, '*'));
                Console.WriteLine(degisken.PadRight(50) + degisken2);
                Console.WriteLine(degisken.PadRight(50,'*') + degisken2);

                //Remove

                Consoel.WriteLine(degisken.Remove(10));
                Consoel.WriteLine(degisken.Remove(5,3));
                Console.WriteLine(degisken.Remove(0,1));

                //Replace
                Console.WriteLine(degisken.Replace("CSharp","C#"));
                Console.WriteLine(degisken.Replace(" ","*"));

                //Split
                Console.WriteLine(degisken.Split(' ')[1]);

                //Substring
                Console.WriteLine(degisken.Substring(4));
                Console.WriteLine(degisken.Substring(4,6));
                

            }
    }
}