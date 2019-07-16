using System;
using System.Collections.Generic;

namespace University.Models
{

    public class StudentCourses
    {
        public int CourseID { get; set; }
        public int StudentID { get; set; }
        public DateTime BirthDate { get; set; }

        public Student Student { get; set; }
        public Course Course { get; set; }

    }
}