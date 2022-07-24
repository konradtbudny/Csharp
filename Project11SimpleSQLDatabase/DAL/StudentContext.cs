using System.Data.Entity;
using Project11SimpleSQLDatabase.Models;

namespace Project11SimpleSQLDatabase.DAL
{
    public class StudentContext:DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Activity> Activities { get; set; }

        public StudentContext() : base("defConnectionString") { }
    }
}
