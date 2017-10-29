using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WorkingWithSomeLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.OutputEncoding = Encoding.UTF8;
                Random random = new Random();
                char currentLetter = ' ';

                for (int i = 0; i < 100; i++)
                {
                    Thread.Sleep(200);
                    currentLetter = (char)random.Next(1072, 1104);

                    if (currentLetter == 'а' || currentLetter == 'е' || currentLetter == 'о')
                    {
                        PrintLetter(currentLetter, "широка гласна", i);
                    }
                    else if (currentLetter == 'и' || currentLetter == 'у' || currentLetter == 'ъ')
                    {
                        PrintLetter(currentLetter, "тясна гласна", i);
                    }
                    else if (currentLetter == 'ю' || currentLetter == 'я')
                    {
                        PrintLetter(currentLetter, "съставна гласна", i);
                    }
                    else if (currentLetter == 'п' || currentLetter == 'ф' || currentLetter == 'к' ||
                        currentLetter == 'т' || currentLetter == 'ш' || currentLetter == 'с' || currentLetter == 'х' || currentLetter == 'ц')
                    {
                        PrintLetter(currentLetter, "беззвучна съгласна", i);
                    }
                    else if (currentLetter == 'л' || currentLetter == 'м' || currentLetter == 'н' || currentLetter == 'р')
                    {
                        PrintLetter(currentLetter, "сонорна съгласна", i);
                    }
                    else if (currentLetter == 'б' || currentLetter == 'в' || currentLetter == 'г' || currentLetter == 'д' ||
                        currentLetter == 'ж' || currentLetter == 'з' || currentLetter == 'ч')
                    {
                        PrintLetter(currentLetter, "звучна съгласна", i);
                    }
                }
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void PrintLetter(char letter, string type, int number)
        {
            Console.WriteLine($"Буквата ({letter}) е {type} и се намира под номер {number}");
        }
    }
}