using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WorkingWithSomeIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Random random = new Random();
                int currentInt = 0;

                for (int i = 0; i < 100; i++)
                {
                    currentInt = random.Next(0, 132);
                    Thread.Sleep(200);

                    if (i % 2 == 0)
                    {
                        Console.WriteLine($"{currentInt} has even index {i}");
                    }

                    if (currentInt % 2 != 0 && i % 2 != 0)
                    {
                        Console.WriteLine($"{currentInt} is odd and have odd index {i}");
                    }

                    if (currentInt % 3 == 0)
                    {
                        Console.WriteLine($"{currentInt} is dividing to 3 without reminder");
                    }

                    if (currentInt % 7 == 1)
                    {
                        Console.WriteLine($"{currentInt} is divided to 7 and have 1 as reminder");
                    }

                    if (currentInt >= 26 && currentInt <= 100)
                    {
                        Console.WriteLine($"{currentInt} is in the interval between 26 and 100");
                    }

                    if (currentInt < 26 && currentInt > 100)
                    {
                        Console.WriteLine($"{currentInt} is NOT in the interval between 26 and 100");
                    }
                }
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}