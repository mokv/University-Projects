using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateWeightInTheSolarSystem
{
    class CalculateWeightInTheSolarSystem
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter your weight in kgs as measured on Earth: ");
                double weight = double.Parse(Console.ReadLine());
                Console.WriteLine("-------------------------------------------------------------------------");
                Console.WriteLine("Enter the code corresponding to the name of the desired planet: ");
                Console.WriteLine("1. Mercury");
                Console.WriteLine("2. Venus");
                Console.WriteLine("3. Earth");
                Console.WriteLine("4. Mars");
                Console.WriteLine("5. Jupiter");
                Console.WriteLine("-------------------------------------------------------------------------");
                double gravitationRatio = 0d;
                bool successfull = true;
                do
                {
                    successfull = true;
                    string input = Console.ReadLine();
                    switch (input)
                    {
                        case "1":
                            gravitationRatio = 0.38d;
                            break;
                        case "2":
                            gravitationRatio = 0.91d;
                            break;
                        case "3":
                            gravitationRatio = 1d;
                            break;
                        case "4":
                            gravitationRatio = 0.38;
                            break;
                        case "5":
                            gravitationRatio = 2.34;
                            break;
                        default:
                            Console.WriteLine("Wrong input! Please try again...");
                            successfull = false;
                            break;
                    }
                } while (!successfull);

                double weightOnPlanet = gravitationRatio * weight;
                Console.WriteLine(Math.Round(weightOnPlanet));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
