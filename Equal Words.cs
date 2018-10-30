using System;
namespace Words
{
    class WordsEqual
    {
        static void Main(string[] args)
        {
            string word1 = Console.ReadLine();
            string word2 = Console.ReadLine();
            string w1 = word1.ToLower();
            string w2 = word2.ToLower();
            if (w1 == w2)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}