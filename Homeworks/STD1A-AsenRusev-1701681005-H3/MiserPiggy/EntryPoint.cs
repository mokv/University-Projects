using System;
using System.Collections.Generic;
using System.Linq;

namespace MiserPiggy
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            string fifferPig = "Fiffer Pig";
            string fiddlerPig = "Fiddler Pig";
            string practicalPig = "Practical Pig";

            Dictionary<string, int> nameWealth = new Dictionary<string, int>();
            nameWealth.Add(fifferPig, WordValueCounter(fifferPig));
            nameWealth.Add(fiddlerPig, WordValueCounter(fiddlerPig));
            nameWealth.Add(practicalPig, WordValueCounter(practicalPig));

            foreach (var item in nameWealth.OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"Name: {item.Key}\nWealth: {item.Value}");
                Console.WriteLine();
            }

        }

        public static int WordValueCounter(string word)
        {
            int value = 0;

            for (int i = 0; i < word.Length; i++)
            {
                value += (int)word[i];
            }

            return value;
        }
    }
}
