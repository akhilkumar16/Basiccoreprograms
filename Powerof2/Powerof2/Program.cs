using System;

namespace Powerof2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Power Number");
            int Number = Convert.ToInt32(Console.ReadLine());
            int Power = 1;
            for (int i = 0; i < Number; i++)
            {
                Power = Power * 2;
            }
            Console.WriteLine("Power of 2 is " + Power);
        }
    }
}
