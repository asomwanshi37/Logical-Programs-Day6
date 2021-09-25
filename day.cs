using System;

namespace Day_of_Week_Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] days = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
            Console.WriteLine("Enter Day = ");
            int day = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Month = ");
            int month = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Year = ");
            int Year = int.Parse(Console.ReadLine());

            int result = DayOfWeek(day, month, Year);
            Console.WriteLine(result);
            Console.WriteLine(days[result]);


            static int DayOfWeek(int d, int m, int y)
            {
                int y0 = y - (14 - m) / 12;
                int x = y0 + y0 / 4 - y0 / 100 + y0 / 400;
                int m0 = m + 12 * ((14 - m) / 12) - 2;
                int d0 = (d + x + (31 * m0) / 12) % 7;
                return d0;
            }

        }
    }
}
