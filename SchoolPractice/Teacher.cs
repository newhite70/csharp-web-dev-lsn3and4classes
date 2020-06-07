using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolPractice
{
    class Teacher
    {
        public string FirstName { get; set; }
        public string LastName { get; set;}
        public string Subject { get; set; }
        public int YearsTeaching { get; set; }

        public Teacher(string fname, string lname, string subject, int yearsteaching)
        {
            FirstName = fname;
            LastName = lname;
            Subject = subject;
            YearsTeaching = yearsteaching;
        }
        Teacher John = new Teacher("John", "Ham", "Code", 12);

    }
}
