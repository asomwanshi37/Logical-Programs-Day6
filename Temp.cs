using System;

namespace Temp_Conversion_Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select Option");
            Console.WriteLine("1 : Celsius to Fahrenheit ");
            Console.WriteLine("2 :Fahrenheit to Celsius ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    {
                        Console.WriteLine("Enter Celsius :");
                        int C = int.Parse(Console.ReadLine());
                        int F = (C * 9 / 5) + 32;
                        Console.WriteLine("Celsius to Fahrenheit :" + F);
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Enter Fahrenheit :");
                        int F = int.Parse(Console.ReadLine());
                        int C = (F - 32) * 5 / 9;
                        Console.WriteLine(" Fahrenheit to Celsius :" + C);
                        break;
                    }
            }


        }
    }
}
