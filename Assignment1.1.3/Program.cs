// Write a C# program to print the result of dividing two numbers. Print the quotient and remainder as well. Get the input from the user.

Console.WriteLine("Please enter the first number");
int firstNumber = int.Parse(Console.ReadLine());

/*
int secondNumber = 0;
while(secondNumber == 0)
{
    Console.WriteLine("Please enter the second number");
    secondNumber = int.Parse(Console.ReadLine());
    if (secondNumber != 0)
    {
        break;
    }
    Console.WriteLine("Invalid number. Did you not learn in math class that you can't divide a number by 0?");
}
*/

Console.WriteLine("Please enter the second number beside 0");
int secondNumber = int.Parse(Console.ReadLine());

int quotient = firstNumber / secondNumber;
int remainder = firstNumber % secondNumber;

Console.WriteLine($"Quotient is {quotient}");
Console.WriteLine($"Remainder is {remainder}");

