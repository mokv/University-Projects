using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Random random = new Random();
                int sum = 0;
                int numbersCount = 0;

                do
                {
                    Console.WriteLine("Enter a number:");
                    int number = int.Parse(Console.ReadLine());

                    if (number == 0)
                    {
                        break;
                    }
                    else if (number >= 1 && number <= 255)
                    {
                        if (number % 2 == 0)
                        {
                            sum += number;
                            numbersCount++;
                        }
                    }
                } while (true);

                if (sum == 0)
                {
                    Console.WriteLine("There aren't even numbers in this diapason [1,255] !!!");
                }
                else
                {
                    int average = sum / numbersCount;
                    Console.WriteLine("Finished!!!");
                    Console.WriteLine("*************");
                    Console.WriteLine();
                    Console.WriteLine("Average " + average);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
