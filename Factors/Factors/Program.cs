using System;

namespace Factors
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, fact = 1, number;
            Console.Write("Enter fact number: ");
            number = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= number; i++)
            {
                fact = fact * i;
            }
            Console.Write("Factorial " + number + " is: " + fact);
        }

    }

}
