using System;

namespace Swapnumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 2;
            int num2 = 4;
            Console.WriteLine("Before swaping num1 = " + num1);
            Console.WriteLine("Before swaping num2 = " + num2);
            num1 = num1 * num2;
            num2 = num1 / num2;
            num1 = num1 / num2;
            Console.WriteLine("After swaping num1= " + num1);
            Console.WriteLine("After swaping num2 = " + num2);
        }
    }
}

