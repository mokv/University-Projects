using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetMax
{
    class Program
    {
        static int GetMax(int first, int second, int third)
        {
            int max = int.MinValue;

            if(first > max)
            {
                max = first;
            }

            if(second > max)
            {
                max = second;
            }

            if(third > max)
            {
                max = third;
            }

            return max;
        }

        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter first number: ");
                int first = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter second number: ");
                int second = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter third number: ");
                int third = int.Parse(Console.ReadLine());

                Console.WriteLine($"The biggest number is {GetMax(first, second, third)}");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
