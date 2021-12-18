using System;

namespace Basicprogram
{
    class Program
    {
       public static void Main(string[] args)
        {
            int headcount = 0;
            int tailcount = 0;

            Random randam = new Random();
            Console.WriteLine("Enter  a number : ");
            int input = (int)Convert.ToDouble(Console.ReadLine());
            for (int i = 0; i < input; i++)
            {
                int flip = randam.Next(0, 2);
                if (flip == 0)
                {
                    headcount++;
                }
                else
                {
                    tailcount++;
                }
            }

            double result_of_head = (headcount * 100) / input;
            double result_of_tail = (tailcount * 100) / input;

            Console.WriteLine("FLIPPING OF HEAD % is " + result_of_head);
            Console.WriteLine("FLIPPING OF TAIL % is " + result_of_tail);
        }
    }
}
