using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryCalculator
{
    class Program
    {
        static double CalculateTriangleArea()
        {
            Console.WriteLine("Enter side: ");
            double side = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter height: ");
            double height = double.Parse(Console.ReadLine());
            return (side * height) / 2;
        }

        static double CalculateSquareArea()
        {
            Console.WriteLine("Enter side: ");
            double side = double.Parse(Console.ReadLine());
            return side * side;
        }

        static double CalculateRadians()
        {
            Console.WriteLine("Enter degrees: ");
            double degrees = double.Parse(Console.ReadLine());
            return (Math.PI / 180) * degrees;
        }

        static void Main(string[] args)
        {
            try
            {
                bool successful = true;
                do
                {
                    successful = true;
                    Console.WriteLine("Choose option (triangle, square or radians): ");
                    string choice = Console.ReadLine();
                    switch (choice)
                    {
                        case "triangle":
                            Console.WriteLine("The are of the triangle is = {0}", CalculateTriangleArea().ToString("#0.00"));
                            break;
                        case "square":
                            Console.WriteLine("The are of the square is = {0}", CalculateSquareArea().ToString("#0.00"));
                            break;
                        case "radians":
                            Console.WriteLine("Your degrees in radians are = {0}", CalculateRadians());
                            break;
                        default:
                            successful = false;
                            break;
                    }
                } while (!successful);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
