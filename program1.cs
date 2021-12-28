using System;

namespace console_programlama
{
    class program1
    {
        
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!!");
            Console.WriteLine("Enter name:");
            string name = Console.ReadLin();
            Console.WriteLine("Enter Surname:");
            string surname = Console.ReadLine();

            Console.WriteLine("Merhaba" + name + " " + surname );
            
        }
    }
}