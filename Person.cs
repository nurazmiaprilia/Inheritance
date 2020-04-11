using System;

public class Person
{
    //constructor
    public Person(string nama, int umur)
    {
        Name = nama;
        Age = umur;
    }

    //properties
    public string Name { get; set; }
    public int Age { get; set; }

    public void GetNameAndAge()
    {
        Console.WriteLine("The person has name: {0} and age: {1}", Name, Age);
    }
}