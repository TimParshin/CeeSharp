using System;

namespace Ceesharpim
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hey!");
            Console.WriteLine("What you're looking for watch tonight?");
            string answer = Console.ReadLine();
            Console.WriteLine("Ok! It's a new " + answer + " for your. Enjoy it!");
        }
    }
}