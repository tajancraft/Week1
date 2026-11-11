/*Write a C# Sharp program to accept two integers and check whether they are equal or not.
Test Data :
Input 1st number: 5
Input 2nd number: 5
Expected Output :
5 and 5 are equal
Test Data :
Input 1st number: 5
Input 2nd number: 15
Expected Output :
5 and 15 are not equal
*/

using System;

// prompt the user to enter two integers
Console.WriteLine("Enter the first number:");
int firstNumber = int.Parse(Console.ReadLine());

Console.WriteLine("Enter the second number:");
int secondNumber = int.Parse(Console.ReadLine());

// check if the numbers are equal
if (firstNumber == secondNumber)
{
    Console.WriteLine($"{firstNumber} and {secondNumber} are equal");
}
else
{
    Console.WriteLine($"{firstNumber} and {secondNumber} are not equal");
}

