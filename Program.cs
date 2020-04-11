using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Aprilia", 20);
            person.GetNameAndAge();

            Teacher teacher = new Teacher("Risma", 35, "190302", "Math");
            teacher.GetNameAndAge();

            Student student = new Student("Sara", 19, "10506", "sara1234@amikom.ac.id");
            student.GetNameAndAge();

            Console.ReadKey();
        }
    }
}
