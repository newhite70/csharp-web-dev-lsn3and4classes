using System;
using System.Collections.Generic;
using System.Text;


namespace SchoolPractice
{
    class Course
    {
        public string CourseName { get; set; }
        private List<Student1> Students = new List<Student1>();
        //private string v1;
        //private Student1 nick;
        //private Teacher john;
        //private int v2;

        public Teacher Instructor {get; set;}
        public int Credits { get; set; }

        private int NumberofStudents { get; }

        public Course(string coursename, Student1 students,
             Teacher instructor, int credits)
        {
            CourseName = coursename;
            Students.Add(students);
            Instructor = instructor;
            Credits = credits;
            NumberofStudents = Students.Count;
        }
        

        //public Course(string v1, Student1 nick, Teacher john, int v2)
        //{
        //this.v1 = v1;
        //this.nick = nick;
        //this.john = john;
        //this.v2 = v2;
        //}
    }
}
