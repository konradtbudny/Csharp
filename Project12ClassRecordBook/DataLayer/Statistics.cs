using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Project12ClassRecordBook.DataLayer
{
    class Statistics : ObjectPlus
    {
        public List<int> grades { get; private set; } = new List<int>();
        public Course Course { get; private set; }
        public Student Student { get; set; }
        public Statistics(Course course, Student student)
        {
            SetCourse(course);
            SetStudent(student);
        }
        public Statistics(string data)
        {
            string[] part1 = Regex.Split(data, "\\s*:\\s*");//Regular Expression
            string[] grades = Regex.Split(part1[1], "\\s*,\\s*");
            SetCourse(Course.ForName(part1[0]));
            foreach (string grade in grades)
            {
                AddGrade(int.Parse(grade));
            }
        }
        public void SetStudent(Student student)
        {
            if (Student == null)
            {
                Student = student;
                student.AddStatistics(this);
            }
        }
        public void SetCourse(Course course)
        {
            if (Course == null)
            {
                Course = course;
                course.AddStatistic(this);
            }
        }
        public void AddGrades(params int[] grades)
        {
            this.grades.AddRange(grades);
        }
        public void AddGrade(int grade)
        {
            grades.Add(grade);
        }
        public override string ToString()
        {
            string result = Environment.NewLine + Course.Name + ": ";
            result += string.Join(",", grades);
            return result;
        }
    }
}
