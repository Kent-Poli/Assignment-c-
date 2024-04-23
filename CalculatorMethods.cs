using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class CalculatorMethods
    {
        public static void HomeText()
        {
            Console.WriteLine("Enter the selection you whant todo");
            Console.WriteLine("");
            Console.WriteLine("Press 1 for Addision");
            Console.WriteLine("Press 2 for Substraction");
            Console.WriteLine("Press 3 for Multiplication");
            Console.WriteLine("Press 4 for Division");
            Console.WriteLine("Press 9 for Exit the Calculator");
            Console.WriteLine("");
        }
        public static double GetInput()
        {
            while (true)
            {


                string userInput = Console.ReadLine();


                if (double.TryParse(userInput, out double userDouble))
                {

                    return userDouble;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
            }
        }
        public static (double, double) Run()
        {
            Console.WriteLine("Please enter the first number:");
            double num1 = Convert.ToDouble(GetInput());

            Console.WriteLine("Please enter the second number:");
            double num2 = Convert.ToDouble(GetInput());
            return (num1, num2);
        }

        public static void Addision()
        {
            var (num1, num2) = CalculatorMethods.Run();

            double res = num1 + num2;
            Console.WriteLine($"The answer is {num1} + {num2} = {res}");
            Console.WriteLine("");
            CalculatorMethods.HomeText();

        }
        public static void Multiplication()
        {
            var (num1, num2) = CalculatorMethods.Run();

            double res = num1 * num2;
            Console.WriteLine($"The answer is {num1} * {num2} = {res}");
            Console.WriteLine("");
            CalculatorMethods.HomeText();

        }
        public static void Substraction()
        {
            var (num1, num2) = CalculatorMethods.Run();

            double res = num1 - num2;

            Console.WriteLine($"The answer is {num1} - {num2} = {res}");
            Console.WriteLine("");
            CalculatorMethods.HomeText();

        }
        public static void Division()
        {
            var (num1, num2) = CalculatorMethods.Run();
            if ( num2 == 0 ) {
                Console.WriteLine("Division by zero is not allowed.");
                CalculatorMethods.Division();
            }
            else
            {
                double res = num1 / num2;
                Console.WriteLine($"The answer is {num1} / {num2} = {res}");
                Console.WriteLine("");
                CalculatorMethods.HomeText();
            }
           

        }
    }
}
