using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Random random = new Random();
                int radius = random.Next(33, 188);
                Console.WriteLine("The circle random radius is {0}", radius);
                double circleArea = (radius * radius) * Math.PI;
                Console.WriteLine("The circle area is {0}", Math.Round(circleArea, 2).ToString("#0.00"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
