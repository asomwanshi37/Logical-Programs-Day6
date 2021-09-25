using System;

namespace Monthly_Payment_Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Loan Amount = ");
            int P = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Intrest Percent = ");
            int R = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Years = ");
            int Y = int.Parse(Console.ReadLine());

            int result = monthlyPayment(P, R, Y);
            Console.WriteLine("Monthly Payment is : " + result);


            static int monthlyPayment(int P, int R, int Y)
            {

                int n = 12 * Y;
                int r = R / (12 * 100);
                int Payment = (P * r / 1 - ((1 + r) ^ (-n)));
                return Payment;
            }
        }
    }
}
