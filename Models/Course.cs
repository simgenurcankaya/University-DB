﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace University.Models
{
    public class Course
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CourseID { get; set; }
        public string Title { get; set; }

        public virtual ICollection<StudentCourses> StudentCourses { get; set; }
        public virtual ICollection<Teaches> Teaches { get; set; }
    }
}