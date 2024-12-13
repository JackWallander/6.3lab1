using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._3lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Student student1 = new Student("Jimmy", 21, 123456);
            Student student2 = new Student("Timmy", 20, 123455);
            Student student3 = new Student("Bobby", 19, 123454);
            Teacher teacher1 = new Teacher("Bill", 33, "English");
            Teacher teacher2 = new Teacher("Billy", 32, "Math");
            Teacher teacher3 = new Teacher("Joe", 31, "Science");
            Person[] people = { student1, student2, student3, teacher1, teacher2, teacher3 };
            for (int i = 0; i < people.Length; i++)
            {
                people[i].DisplayDetails();
            }
        }
    }
    abstract class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public abstract void DisplayDetails();

    }
    class Student : Person
    {
        int StudentID;
        public Student(string name, int age, int studentID) : base(name, age)
        {
            StudentID = studentID;
        }
        public override void DisplayDetails()
        {
            Console.WriteLine($"Student ID: {StudentID}\n" +
                              $"Name: {Name}\n" +
                              $"Age: {Age}\n");
        }
    }
    class Teacher : Person
    {
        string Subject;
        public Teacher(string name, int age, string subject) : base(name, age)
        {
            Subject = subject;
        }
        public override void DisplayDetails()
        {
            Console.WriteLine($"Subject: {Subject}\n" +
                              $"Name: {Name}\n" +
                              $"Age: {Age}\n");
        }
    }
}
