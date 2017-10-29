using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static double Addition(double firstNumber, double secondNumber)
        {
            double sum = firstNumber + secondNumber;
            double result = sum + (sum * 0.1d);
            return result;
        }

        static double Subtraction(double firstNumber, double secondNumber)
        {
            double result = 0;

            if (firstNumber >= secondNumber)
            {
                result = (firstNumber * firstNumber) - secondNumber;
            }
            else
            {
                result = (secondNumber * secondNumber) - firstNumber;
            }

            return result;
        }

        static double Multiplication(double firstNumber, double secondNumber)
        {
            double result = firstNumber * Math.Sqrt(secondNumber);
            return result;
        }

        static double Division(double firstNumber, double secondNumber)
        {
            if (secondNumber == 0)
            {
                throw new ArgumentException("Error !!! You can't divide to zero !!!");
            }

            double result = firstNumber / secondNumber;
            return result;
        }

        static void Main(string[] args)
        {
            try
            {
                string input = string.Empty;
                while (true)
                {
                    double firstNumber = 0;
                    double secondNumber = 0;
                    string operation = string.Empty;
                    double result = 0;
                    bool successfulOperation = true;

                    Console.WriteLine("Do you want to calculate some numbers? (yes or no)");
                    input = Console.ReadLine();
                    if (input == "no")
                    {
                        break;
                    }
                    else if (input == "yes")
                    {
                        Console.WriteLine("Enter first number:");
                        firstNumber = double.Parse(Console.ReadLine());
                        Console.WriteLine("Enter second number:");
                        secondNumber = double.Parse(Console.ReadLine());
                        Console.WriteLine("Enter operation:");
                        operation = Console.ReadLine();

                        switch (operation)
                        {
                            case "+":
                                result = Addition(firstNumber, secondNumber);
                                break;
                            case "-":
                                result = Subtraction(firstNumber, secondNumber);
                                break;
                            case "*":
                                result = Multiplication(firstNumber, secondNumber);
                                break;
                            case "/":
                                try
                                {
                                    result = Division(firstNumber, secondNumber);
                                } catch (Exception ex){
                                    Console.WriteLine(ex.Message);
                                    successfulOperation = false;
                                }
                                break;
                            default:
                                Console.WriteLine("Wrong input!");
                                successfulOperation = false;
                                continue;
                        }

                        if (successfulOperation)
                        {
                            Console.WriteLine("Result is " + Math.Round(result, 2).ToString("#0.00"));
                            Console.WriteLine();
                            Console.WriteLine("***************************************************");
                            Console.WriteLine("***************************************************");
                            Console.WriteLine("***************************************************");
                            Console.WriteLine();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
