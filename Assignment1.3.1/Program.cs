/*
Write a program in C# to calculate area of triangle, square and rectangle. 
Write 3 different functions for each shape to take dimensions of figure and display the area. You may create menus.
*/

int menuChoice;

do
{
    Console.WriteLine("Area calculator app");
    Console.WriteLine("");
    Console.WriteLine("1. Triangle");
    Console.WriteLine("2. Square");
    Console.WriteLine("3. Rectangle");
    Console.WriteLine("4. Exit");

    menuChoice = int.Parse(Console.ReadLine());

    switch(menuChoice)
    {
        case 1:
            CalculateTriangleArea();
            break;
        case 2:
            CalculateSquareArea();
            break;
        case 3:
            CalculateRectangleArea();
            break;
        case 4:
            Console.WriteLine("Exiting the program.");
            break;
        default:
            Console.WriteLine("Invalid choice. Please try again.");
            break;
    }
} while (menuChoice != 4);

void CalculateTriangleArea()
{
    Console.WriteLine("Enter the base of the triangle:");
    double baseLength = double.Parse(Console.ReadLine());

    Console.WriteLine("Enter the height of the triangle:");
    double height = double.Parse(Console.ReadLine());

    double area = 0.5 * baseLength * height;
    Console.WriteLine($"The area of the triangle is: {area}");
}

void CalculateSquareArea()
{
    Console.WriteLine("Enter the side length of the square:");
    double sideLength = double.Parse(Console.ReadLine());

    double area = sideLength * sideLength;
    Console.WriteLine($"The area of the square is: {area}");
}

void CalculateRectangleArea()
{
    Console.WriteLine("Enter the length of the rectangle:");
    double length = double.Parse(Console.ReadLine());

    Console.WriteLine("Enter the width of the rectangle:");
    double width = double.Parse(Console.ReadLine());

    double area = length * width;
    Console.WriteLine($"The area of the rectangle is: {area}");
}