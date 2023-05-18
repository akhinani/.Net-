
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
namespace Write_and_read
{ 
public class Program
{
    static void Main(string[] args)
    {
        List<Student> students1 = new List<Student>()

 {
   new Student{Id=101,Name="Alok"},
    new Student{Id=102,Name="Ramesh"},
    new Student{Id=103,Name="Shubha"}

 };
        List<Student> str = students1;
        ExcelMapper mapper = new ExcelMapper();
        string newfile = @"d:\Student.xlsx";
        mapper.Save(newfile, str, "StudData", true);
        List<Student> students = mapper.Fetch<Student>("StudData").ToList();
        Console.WriteLine("StudData List");
        foreach (Student student in students)

        {
            Console.WriteLine(student.Id + "\t" + student.Name);
                
        }
        Console.WriteLine();
    }
}
public class Student
{
    public int Id { get; set; }
    public string Name { get; set; }

}
}


