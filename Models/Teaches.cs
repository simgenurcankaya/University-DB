using System;
using System.Collections.Generic;

namespace University.Models
{

    public class Teaches
    {
        public int CourseID { get; set; }
        public int TeacherID { get; set; }
        public string Semester { get; set; }
        public Course Course { get; set; }
        public Teacher Teacher { get; set; }
    }
}