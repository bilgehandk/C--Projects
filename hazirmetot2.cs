using System;

namespace C__Projects
{
    class hazirmetot2
    {
        static void Main(string[] args)
            {
                Console.WriteLine(DateTime.Now);
                Console.WriteLine(DateTime.Now.Date);
                Console.WriteLine(DateTime.Now.Day);
                Console.WriteLine(DateTime.Now.Month);
                Console.WriteLine(DateTime.Now.Year);
                Console.WriteLine(DateTime.Now.Hour);
                Console.WriteLine(DateTime.Now.Minute);
                Console.WriteLine(DateTime.Now.Second);

                Console.WriteLine(DateTime.Now.DayOfWeek);
                Console.WriteLine(DateTime.Now.DayOfYear);

                Console.WriteLine(DateTime.Now.ToLongDateString);
                Console.WriteLine(DateTime.Now.ToShortDateString);
                Console.WriteLine(DateTime.Now.ToShortTimeString());

                Console.WriteLine(DateTime.Now.AddDays(2));
                Console.WriteLine(DateTime.Now.AddMonths(5));
                Console.WriteLine(DateTime.Now.AddHours(3));
                Console.WriteLine(DateTime.Now.AddSeconds(30));
                Console.WriteLine(DateTime.Now.AddYears(10));
                Console.WriteLine(DateTime.Now.AddMilliseconds(50));


                //Date Time Format
                Console.WriteLine(DateTime.Now.ToString("dd"));//24
                Console.WriteLine(DateTime.Now.ToString("ddd"));//Sat
                Console.WriteLine(DateTime.Now.ToString("dddd"));//Saturday
 
                Console.WriteLine(DateTime.Now.ToString("MM"));//04
                Console.WriteLine(DateTime.Now.ToString("MMM"));//Apr
                Console.WriteLine(DateTime.Now.ToString("MMMM"));//April

                Console.WriteLine(DateTime.Now.ToString("yy"));//21
                Console.WriteLine(DateTime.Now.ToString("yyyy"));//2021


            }
    }
}