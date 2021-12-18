using System;

namespace EvenOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            int Num;
            Console.WriteLine("Enter a number: ");
            Num = Convert.ToInt32(Console.ReadLine());
            if (Num % 2 == 0)
            {
                Console.WriteLine(" Entered Number is Even " + Num);
            }
            else
            {
                Console.WriteLine(" Entered Number is Odd " + Num);
            }
        }
    }
}