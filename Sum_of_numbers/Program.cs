using System;

namespace Sum_of_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("The sum of the numbers from 1 to " + number + " is: " + SumIntegersFromOneToN(number));
        }

        static int SumIntegersFromOneToN(int n)
        {
            //base case:
            if (n == 1)
            {
                return 1;
            }
            else
            {
                return n + SumIntegersFromOneToN(n - 1);
            }
        }
    }
}
