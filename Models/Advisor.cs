using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace University.Models
{

    public class Advisor
    {   [Key]
        public int StudentID { get; set; }
        public int TeacherID { get; set; }
        public string Semester { get; set; }

       public Teacher Teacher { get; set; }
       public Student Student { get; set; }
    }
}