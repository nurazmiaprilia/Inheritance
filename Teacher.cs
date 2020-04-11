using System;

public class Teacher : Person
{
    //constructor
    public Teacher(string nama, int umur, string Ti, string s) : base(nama,umur)
    {
        TeacherId = Ti;
        Subject = s;
    }

    //properties
    public string TeacherId { get; set; }
    public string Subject { get; set; }
}