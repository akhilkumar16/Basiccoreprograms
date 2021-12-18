using System;

namespace LargestNo
{
    class Program
    {
        static void Main(string[] args)
        {
            int Num1 = 0;
            int Num2 = 0;
            int Num3 = 0;
            Console.WriteLine("Enter the first number : ");
            Num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second number : ");
            Num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the third number : ");
            Num3 = Convert.ToInt32(Console.ReadLine());

            if (Num1 > Num2)
            {
                
                if (Num1 > Num3)
                {
                    Console.WriteLine("largest number : " + Num1);
                }
                else
                {
                    Console.WriteLine("largest number : " + Num3);
                }
            }
            else
            {
                if (Num2 > Num3)
                {
                    Console.WriteLine("largest number : " + Num2);
                }
                else
                {
                    Console.WriteLine("largest number : " + Num3);
                }
            }
        }
    }
}
