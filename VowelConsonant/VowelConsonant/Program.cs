using System;

namespace VowelConsonant
{
    class Program
    {
        static void Main(string[] args)
        {
            char word;
            Console.WriteLine("Enter a word: ");
            word = Convert.ToChar(Console.ReadLine());
            if (word == 'a' || word == 'e' || word == 'i' || word == 'o' || word == 'u' || word== 'A' || word == 'E' || word == 'I' || word == 'O' || word == 'U')
            {
                Console.WriteLine(word + " is Vowel.");
            }
            else if ((word >= 'a' && word <= 'z') || (word >= 'A' && word <= 'Z'))
            {
                Console.WriteLine(word + " is Consonant.");
            }
        }
    }
}
