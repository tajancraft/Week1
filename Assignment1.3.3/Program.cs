/*
Write a program in C# to read n number of values in an array and display it in reverse order.
Test Data :
Input the number of elements to store in the array :3
Input 3 number of elements in the array :
element - 0 : 2
element - 1 : 5
element - 2 : 7
Expected Output:
The values store into the array are:
2 5 7
The values store into the array in reverse are :
7 5 2
*/

Console.Write("Input the number of elements to store in the array :");
int numberOfElements = Convert.ToInt32(Console.ReadLine());
int[] myNumberArray = new int[numberOfElements];

Console.WriteLine($"Input {numberOfElements} number of elements in the array :");

for (int i = 0; i < myNumberArray.Length; i++)
{
    Console.Write($"element - {i} : ");
    myNumberArray[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine("The values stored into the array are:");
for (int i = 0; i < myNumberArray.Length; i++)
{
    Console.Write(myNumberArray[i] + " ");
}

Console.WriteLine();
Console.WriteLine("The values stored into the array in reverse are:");
for (int i = myNumberArray.Length - 1; i >= 0; i--)
{
    Console.Write(myNumberArray[i] + " ");
}

/*
Array.Reverse(myNumberArray);
Console.WriteLine();
Console.WriteLine("The values stored into the array in reverse are:");
for (int i = 0; i < myNumberArray.Length; i++)
{
    Console.Write(myNumberArray[i] + " ");
}
Console.WriteLine();
*/