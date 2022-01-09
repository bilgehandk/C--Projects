using System;

namespace C__Projects
{
    class switchcase
    {
        static void Main(string[] args)
        {
            int ay = DateTime.Now.Month;

            // Expression
            switch(ay)
            {
                case 1:
                Console.WriteLine("Ocak ayindsin!");
                break;

                case 2:
                Console.WriteLine("Subat ayindsin!");
                break;

                case 3:
                Console.WriteLine("Mart ayindsin!");
                break;

                case 4:
                Console.WriteLine("Nisan ayindsin!");
                break;

                case 5:
                Console.WriteLine("Mayis ayindsin!");
                break;

                case 6:
                Console.WriteLine("Haziran ayindsin!");
                break;

                default:
                Console.WriteLine("Yanlis veri girisi");
                break;
            }

            switch(ay)
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("Winter");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("Spring");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("Summer");
                    break;
                case 9: 
                case 10:
                case 11:
                    Console.WriteLine("Autumn");
                    break;

                default:
                break;
        

            }
        }
    }
}