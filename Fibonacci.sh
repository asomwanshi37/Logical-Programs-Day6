using System;

namespace Fibbanoci
{
    class Program
    {
        static void Main(string[] args)
        {
            int N1 = 0;
            int N2 = 1;
            int N3 = 2;
            int i;
            int Number;
            Console.WriteLine("Enter a element number:");
            Number = int.Parse(Console.ReadLine());
            Console.Write(N1 + " " + N2 + " ");
            for (i = 2; i < Number; i++)
            {
                N3 = N1 + N2;
                Console.Write(N3 + "  ");
                N1 = N2;
                N2 = N3;
            }
        }
    }
}
