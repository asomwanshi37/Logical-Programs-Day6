using System;

namespace PrimeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int Number = 0, i, m = 0, flag = 0;
            Console.WriteLine("Enter the number to check Prime");
            Number = int.Parse(Console.ReadLine());
            m = Number / 2;
            for (i = 2; i <= m; i++)
            {
                if (Number % i == 0)
                {
                    
                    flag = 1;
                    break;
                }
                }
                
            if (flag == 0)
            {
                Console.WriteLine("Number is prime");
            }
            else
                Console.WriteLine("Number is not a prime");






        }
    }
}
