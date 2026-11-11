/* 
    Write a menu driven application to perform calculation functions like addition, subtraction, multiplication, and division. 
    Call them appropriately when user selects the option. Give the user the option to continue or exit the program.
*/

using System;
using System.Numerics;

int number1 = 0;
int number2 = 0;
int finalResult = 0;

string? readInput;
string menuSelection ="";

do
{
    Console.WriteLine("Calculator App");
    Console.WriteLine("1. Addition");
    Console.WriteLine("2. Subtraction");
    Console.WriteLine("3. Multiplication");
    Console.WriteLine("4. Division");
    Console.WriteLine("5. Exit");
    Console.WriteLine();
    Console.WriteLine("Please select an option from the menu (1-5):");

    readInput = Console.ReadLine();
    if (readInput != null)
    {
        menuSelection = readInput;
    }

    switch (menuSelection)
    {
        // Addition
        case "1":
            Console.WriteLine("You selected Addition.");
            Console.WriteLine("Enter the first number:");
            number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number:");
            number2 = int.Parse(Console.ReadLine());

            finalResult = addition(number1, number2);

            Console.WriteLine($"The result of the addition is: {finalResult}");
            Console.WriteLine("Press Enter to continue...");
            readInput = Console.ReadLine();
            break;

        // Subtraction
        case "2":
            Console.WriteLine("You selected Subtraction.");
            Console.WriteLine("Enter the first number:");
            number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number:");
            number2 = int.Parse(Console.ReadLine());

            finalResult = subtraction(number1, number2);

            Console.WriteLine($"The result of the subtraction is: {finalResult}");
            Console.WriteLine("Press Enter to continue...");
            readInput = Console.ReadLine();
            break;

        // Multiplication
        case "3":
            Console.WriteLine("You selected Multiplication.");
            Console.WriteLine("Enter the first number:");
            number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number:");
            number2 = int.Parse(Console.ReadLine());

            finalResult = multiplication(number1, number2);

            Console.WriteLine($"The result of the multiplication is: {finalResult}");
            Console.WriteLine("Press Enter to continue...");
            readInput = Console.ReadLine();
            break;

        // Division
        case "4":
            Console.WriteLine("You selected Division.");
            Console.WriteLine("Enter the first number:");
            number1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number:");
            number2 = int.Parse(Console.ReadLine());

            // Error message for division by zero
            if (number2 == 0)
            {
                Console.WriteLine("Error: The second number cannot be zero for division." + Environment.NewLine);
                break;
            }

            finalResult = division(number1, number2, out int remainder);

            Console.WriteLine($"The result of the division is: {finalResult} and the remainder is: {remainder}");
            Console.WriteLine("Press Enter to continue...");
            readInput = Console.ReadLine();
            break;

        case "5":
            Console.WriteLine("Exiting the program. Goodbye!");
            break;

        default:
            Console.WriteLine("Invalid selection. Please try again.");
            break;
    }

} while (readInput != "5");

int addition(int a, int b)
{
    return a + b;
}

int subtraction(int a, int b)
{
    return a - b;
}

int multiplication(int a, int b)
{
    return a * b;
}

int division(int a, int b, out int remainder)
{
    remainder = a % b;
    return a / b;
}
