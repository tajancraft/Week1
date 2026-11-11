/*
 * Write a console application in C# to explore different ways in which array is declared 
 * and initialized and explore different properties and methods of Array class.
 */

// first way of declaring and initializing an array
string[] myArray1 = new string[5];
myArray1[0] = "Hello";
myArray1[1] = "World";
myArray1[2] = "This";
myArray1[3] = "Is";
myArray1[4] = "Yebin";

Console.WriteLine(myArray1.Length);
Console.WriteLine();

for (int i = 0; i < myArray1.Length; i++)
{
    Console.WriteLine(myArray1[i]);
}
Console.WriteLine();

// second way of declaring and initializing an array
int[] myNumberArray = new int[] { 1, 2, 3, 4, 5 };

int[] myNumberArrayReversedForloop = new int[myNumberArray.Length];
// reverse the array using a for loop
for (int i = 0; i < myNumberArray.Length; i++)
{
    Console.WriteLine(myNumberArray[i]);
    myNumberArrayReversedForloop[myNumberArray.Length - 1 - i] = myNumberArray[i];
}

Console.WriteLine();
Console.WriteLine("Reversed array:");
for (int i = 0; i < myNumberArrayReversedForloop.Length; i++)
{
    Console.WriteLine(myNumberArrayReversedForloop[i]);
}
Console.WriteLine();

// third way of declaring and initializing an array
string[] myStringArray = { "This", "is", "a", "string", "array" };
for (int i = 0; i < myStringArray.Length; i++)
{
    Console.WriteLine(myStringArray[i]);
}

Console.WriteLine();
Console.WriteLine($"{myStringArray[0]} {myStringArray[1]} {myStringArray[2]} {myStringArray[3]} {myStringArray[4]}");