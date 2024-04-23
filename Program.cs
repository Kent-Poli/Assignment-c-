// See https://aka.ms/new-console-template for more information
using Calculator;

Console.WriteLine("---------------Calculator----------------");

CalculatorMethods.HomeText();

while (true)
{

    string userInput = Console.ReadLine();

    int.TryParse(userInput, out int userInt);

    if (userInt == 9)
    {
        break;
    }
    

    switch (userInt)
    {
        case 1:
            CalculatorMethods.Addision();

            break;
        case 2:
            CalculatorMethods.Substraction();

            break;
        case 3:
            CalculatorMethods.Multiplication();

            break;
        case 4:
            CalculatorMethods.Division();

            break;
        default:
            Console.WriteLine("Enter a number");
            break;

    }

}
Console.WriteLine("Thank you for using Kent's Calculator");

