using System;
using System.Linq;

namespace Task01_Randomize_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

            Random rnd = new Random();
            for (int poitionOne = 0; poitionOne < words.Length; poitionOne++)
            {
                int positionTwo = rnd.Next(words.Length);
                string helpVar = words[poitionOne];
                words[poitionOne] = words[positionTwo];
                words[positionTwo] = helpVar;
            }
            
            Console.WriteLine(string.Join((char)10, words));
        }
    }
}
