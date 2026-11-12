/*
 * Create a structure named “Point” and 2 data members: X and Y coordinate. 
 * Declare 2 points: P1 and P2. Determine if P2 is to the right or left of P1 or on same axis , 
 * by comparing the x xoordinates. ( if p1.x is more than p2.x , it is to the right )
 */

Point P1;
Console.WriteLine("Enter coordinates for Point P1:");
Console.WriteLine("Enter X coordinate:");
P1.X = int.Parse(Console.ReadLine());
Console.WriteLine("Enter Y coordinate:");
P1.Y = int.Parse(Console.ReadLine());

Point P2;
Console.WriteLine("Enter coordinates for Point P2:");
Console.WriteLine("Enter X coordinate:");
P2.X = int.Parse(Console.ReadLine());
Console.WriteLine("Enter Y coordinate:");
P2.Y = int.Parse(Console.ReadLine());

if (P1.X > P2.X)
{
    Console.WriteLine("Point P2 is to the left of Point P1.");
}
else if (P1.X < P2.X)
{
    Console.WriteLine("Point P2 is to the right of Point P1.");
}
else
{
    Console.WriteLine("Point P2 is on the same vertical axis as Point P1.");
}

struct Point
{
    public int X;
    public int Y;
}