using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleDeckOfCards
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            bool successfulInput = false;
            while (!successfulInput)
            {
                Console.WriteLine("Do you want to see a full deck of cards? (yes or no):");
                string input = Console.ReadLine();
                if (input == "yes")
                {
                    successfulInput = true;
                }
            }

            string[] cards = Cards();
            Console.OutputEncoding = Encoding.Unicode;

            for (int i = 0; i < cards.Length; i++)
            {
                Console.WriteLine($"{cards[i]} \u2665, {cards[i]} \u2660, {cards[i]} \u2666, {cards[i]} \u2663");
            }
        }

        private static string[] Cards()
        {
            return new string[]
            {
                "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K"
            };
        }
    }
}
