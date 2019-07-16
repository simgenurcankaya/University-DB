using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace University.Models
{
    public class Student
    {
        public int StudentID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public DateTime BirthDay { get; set; }

        public Teacher Advisor { get; set; }
        public ICollection<StudentCourses> Courses { get; set; }
    }
}