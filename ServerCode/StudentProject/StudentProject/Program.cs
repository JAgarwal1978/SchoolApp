// See https://aka.ms/new-console-template for more information
using Computech.Students.BO;
using Computech.Students.DTOs;

Console.WriteLine("Hello, World!");
StudentBO studentBO = new StudentBO();
List<Student> students = studentBO.GetStudents();
foreach(var student in students)
{
    Console.WriteLine($"ID :{student.StudentID} , Name: {student.FirstName}");
}

Console.WriteLine();


