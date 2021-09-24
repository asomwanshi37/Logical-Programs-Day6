using System;

namespace Perfect_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i, sum;


            Console.Write("Enter the  number for checking perfect or not  : ");
            n = Convert.ToInt32(Console.ReadLine());
            sum = 0;
            Console.Write("The positive divisor  : ");
            for (i = 1; i < n; i++)
            {
                if (n % i == 0)
                {
                    sum = sum + i;
                    Console.Write("{0}  ", i);
                }
            }
            Console.Write("\nThe sum of the divisor is : {0}", sum);
            if (sum == n)
                Console.Write("\nthe number is perfect.");
            else
                Console.Write("\nthe number is not perfect.");
            Console.Write("\n");
        }
    }
}
