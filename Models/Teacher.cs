using System;
using System.Collections.Generic;

namespace University.Models
{
    public class Teacher
    {
        public int TeacherID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public DateTime BirthDate { get; set; }

        public virtual ICollection<Teaches> Teaches { get; set; }
        public virtual ICollection<Advisor> Advisors { get; set; }
    }
}