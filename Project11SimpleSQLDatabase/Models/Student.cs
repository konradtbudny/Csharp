using System;
using System.Collections.Generic;

namespace Project11SimpleSQLDatabase.Models
{
    public class Student
    {
        public Guid StudentId { get; set; }
        public string Name { get; set; }
        public virtual List<Activity> Activities { get; set; }
    }
}
