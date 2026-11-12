/*
Write a class: “Student” with private data members: 
StudentId ( int), StudentFname (string), StudentLname (string ), 
StudentGrade ( char ) and public properties for each data member. 

Instantiate the class and assign data to properties. 
Display the data back on console.
*/

using System;
class Student
{
    private int studentId;  // field
    private string studentFname ="";
    private string studentLname ="";
    private char studentGrade;
        
    public int StudentId    // property, PascalCase
    {
        get { return studentId; }   // get method
        set { studentId = value; }  // set method
    }

    public string StudentFname
    {
        get { return studentFname; }
        set { studentFname = value; }
    }

    public string StudentLname
    {
        get { return studentLname; }
        set { studentLname = value; }
    }

    public char StudentGrade
    {
        get { return studentGrade; }
        set { studentGrade = value; }
    }
}

class Program
{                               
    static void Main()
    {
        Student student = new();    // instantiate

        Console.WriteLine($"What is your student ID?");
        int inputStudentID = int.Parse(Console.ReadLine());
        student.StudentId = inputStudentID;
        Console.WriteLine($"What is your first name?");

        string inputStudentFname = Console.ReadLine();
        student.StudentFname = inputStudentFname;

        Console.WriteLine($"What is your last name?");
        string inputStudentLname = Console.ReadLine();
        student.StudentLname = inputStudentLname;

        Console.WriteLine($"What is your grade?");
        char inputStudentGrade = char.Parse(Console.ReadLine());
        student.StudentGrade = inputStudentGrade;

        Console.WriteLine($"Student ID: {student.StudentId}");
        Console.WriteLine($"Student First Name: {student.StudentFname}");
        Console.WriteLine($"Student Last Name: {student.StudentLname}");
        Console.WriteLine($"Student Grade: {student.StudentGrade}");
    }
}

