using System;

namespace ReverseNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int Number, Reverse = 0, Rem;
            Console.WriteLine("Enter a number to Reverse");
            Number = int.Parse(Console.ReadLine());

            while (Number != 0)
            {
                Rem = Number %10;
                Reverse = Reverse * 10 + Rem;
                Number /= 10;
            }
            Console.WriteLine("Reversed Number: {0}" , Reverse);
        }
    }
}
