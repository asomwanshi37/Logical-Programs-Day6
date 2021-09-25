using System;

namespace Vending_Machine_Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Amoount");
            int amount = int.Parse(Console.ReadLine());
            countCurrency(amount);
        }
        public static void countCurrency(int amount)
        {
            int[] notes = new int[] { 2000, 500, 200, 100, 50, 20, 10, 5, 1 };
            int[] counter = new int[10];

            for (int i = 0; i < 9; i++)
            {
                if (amount >= notes[i])
                {
                    counter[i] = amount / notes[i];
                    amount = amount - counter[i] * notes[i];
                }

            }
            Console.WriteLine("Currency is : ");
            for (int i = 0; i < 9; i++)
            {
                if (counter[i] != 0)
                {
                    Console.WriteLine(notes[i] + " : " + counter[i]);
                }
            }
        }
    }
}
