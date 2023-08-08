using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowledgeCheck1_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("_____________________");
                Console.WriteLine("Hello.");
                Console.WriteLine("Press 1 for Addition");
                Console.WriteLine("2 for Subtraction");
                Console.WriteLine("3 for Multiplacation");
                Console.WriteLine("4 for Division");
                Console.WriteLine("_____________________");

                var input = Console.ReadLine();
                var calculator = new Calculator();

                switch (input)
                {
                    case "1":
                        Console.WriteLine("Enter 2 integers to add");
                        var addNumber1 = Console.ReadLine();
                        var addNumber2 = Console.ReadLine();

                        if (decimal.TryParse(addNumber1, out decimal addNumOne) && decimal.TryParse(addNumber2, out decimal addNumTwo))
                        {
                            Console.Write($"{addNumber1} + {addNumber2} = ");
                            Console.Write(calculator.Add(addNumOne, addNumTwo));
                        }
                        else
                        {
                            Console.WriteLine("One or more of the numbers is not an int");
                        }
                        break;

                    case "2":
                        Console.WriteLine("Enter 2 integers to subtract");
                        var subtractNumber1 = Console.ReadLine();
                        var subtractNumber2 = Console.ReadLine();

                        if (decimal.TryParse(subtractNumber1, out decimal subNumOne) && decimal.TryParse(subtractNumber2, out decimal subNumTwo))
                        {
                            Console.Write($"{subtractNumber1} - {subtractNumber2} = ");
                            Console.Write(calculator.Subtract(subNumOne, subNumTwo));
                        }
                        else
                        {
                            Console.WriteLine("One or more of the numbers is not an int");
                        }
                        break;

                    case "3":
                        // Add code here
                        Console.WriteLine("Enter 2 integers to multiply");
                        var multiplyNumber1 = Console.ReadLine();
                        var multiplyNumber2 = Console.ReadLine();

                        if (decimal.TryParse(multiplyNumber1, out decimal mulNumOne) && decimal.TryParse(multiplyNumber2, out decimal mulNumTwo))
                        {
                            Console.Write($"{multiplyNumber1} * {multiplyNumber2} = ");
                            Console.Write(calculator.Multiply(mulNumOne, mulNumTwo));
                        }
                        else
                        {
                            Console.WriteLine("One or more of the numbers is not an int");
                        }
                        break;

                    case "4":
                        Console.WriteLine("Enter 2 integers to divide");
                        var divideNumber1 = Console.ReadLine();
                        var divideNumber2 = Console.ReadLine();

                        if (decimal.TryParse(divideNumber1, out decimal divNumOne) && decimal.TryParse(divideNumber2, out decimal divNumTwo))
                        {
                            Console.Write($"{divideNumber1} / {divideNumber2} = ");
                            Console.Write(calculator.Divide(divNumOne, divNumTwo));
                        }
                        else
                        {
                            Console.WriteLine("One or more of the numbers is not an int");
                        }
                        break;


                    default:
                        Console.WriteLine("Unknown input");
                        break;
                }
                Console.WriteLine();
                Console.WriteLine("Continue? (Y = yes, N = No):");

            } while (Console.ReadLine().ToUpper() == "Y");
            Console.WriteLine("Goodbye.");
            Console.ReadKey();

        }
    }
}