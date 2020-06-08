using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolPractice
{
    class Teacher
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        private string Subject { get; set; }
        private int YearsTeaching { get; set; }

        public Teacher(string firstName, string lastName, string subject, int yearsTeaching)
        {
            FirstName = firstName;
            LastName = lastName;
            Subject = subject;
            YearsTeaching = yearsTeaching;
        }
    }
}
