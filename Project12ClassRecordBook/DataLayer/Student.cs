using System;
using System.Collections.Generic;

namespace Project12ClassRecordBook.DataLayer
{
    class Student : ObjectPlus
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<Statistics> Statistics { get; private set; } = new List<Statistics>();
        public Student(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
        public void AddStatistics(Statistics statistics)
        {
            if (!Statistics.Contains(statistics))
            {
                Statistics.Add(statistics);
                statistics.SetStudent(this);
            }
        }
        public override string ToString()
        {
            string result = "\n" + FirstName + " " + LastName + "\n";
            result += string.Join("\n", Statistics);
            return result;
        }

    }
}
