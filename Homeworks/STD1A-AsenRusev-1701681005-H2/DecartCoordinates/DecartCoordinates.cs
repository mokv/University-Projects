using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecartCoordinates
{
    class DecartCoordinates
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's do some calculations!");
            try
            {
                Console.Write("Enter Xa: ");
                double xA = double.Parse(Console.ReadLine());
                Console.Write("Enter Ya: ");
                double yA = double.Parse(Console.ReadLine());
                Console.Write("Enter Xb: ");
                double xB = double.Parse(Console.ReadLine());
                Console.Write("Enter Yb: ");
                double yB = double.Parse(Console.ReadLine());
                Console.WriteLine("-------------------------------------------------");
                Console.WriteLine("The points have the next coordinates: ");
                Console.WriteLine($"Point A({xA}, {yA})");
                Console.WriteLine($"Point B({xB}, {yB})");
                Console.WriteLine("-------------------------------------------------");
                double distance = Math.Sqrt(Math.Pow((xB - xA), 2) + Math.Pow((yB - yA), 2));
                Console.WriteLine($"The distance between the two points is: {distance}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
