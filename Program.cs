using System;

namespace Project_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("   The perfect nuunbers from the first number to the last number");
            Console.WriteLine("________________________________________________________________________");
            int f, l;
            Console.WriteLine("The first number"); //The lower limit number.
            f = int.Parse(Console.ReadLine());
            Console.WriteLine("The last number");  //The upper limit number.
            l = int.Parse(Console.ReadLine());
            for (int x = f; x <= l; x++)   //The outer loop to check all numbers.
            {
                int sum = 0;
                for(int d = 1; d <= x/2; d++)  // The inner loop to check number by number.
                {
                    if (x % d == 0) 
                        sum = sum + d;

                }
            if (sum == x && x!= 1)  // A perfect number is a natural number = the sum of its divisors including 1//
                {
                    Console.WriteLine(sum);
                }
            }
        }
    }
}
