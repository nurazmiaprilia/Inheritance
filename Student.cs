using System;

public class Student : Person
{
    //constructor
    public Student(string nama, int umur, string Si, string mail) : base(nama,umur)
    {
        StudentId = Si;
        Email = mail;
    }

    //properties
    public string StudentId { get; set; }
    public string Email {get; set; }
}