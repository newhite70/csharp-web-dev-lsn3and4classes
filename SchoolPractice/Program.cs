using System;

namespace SchoolPractice
{
    class Program
    {
        public static void Main(string[] args)
        {
            Student Nick = new Student("Nick", 1,64,3.50);
            Nick.AddGrade(6,3);
            Nick.AddGrade(2, 4);

            Console.WriteLine(Nick.GetGradeLevel());


            Teacher John = new Teacher("John", "Ham", "Math", 16);
            Course Math = new Course("Math 101", John);

            Console.WriteLine(Math.Instructor);
        }
    }
}