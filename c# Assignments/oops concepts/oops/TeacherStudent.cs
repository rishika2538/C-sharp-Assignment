﻿public class TeacherStudent
{
    public string Name { get; set; }
    public int Age { get; set; }

    public TeacherStudent(string name, int age)
    {
        Name = name;
        Age = age;
    }

    // Virtual method
    public virtual void GetDetails()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}");
    }
}

public class Student1 : TeacherStudent
{
    public string StudentID { get; set; }

    public Student1(string name, int age, string studentID) : base(name, age)
    {
        StudentID = studentID;
    }

    public override void GetDetails()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}, Student ID: {StudentID}");
    }
}
public class Teacher : TeacherStudent
{
    public string Subject { get; set; }

    public Teacher(string name, int age, string subject) : base(name, age)
    {
        Subject = subject;
    }

    public override void GetDetails()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}, Subject: {Subject}");
    }
}