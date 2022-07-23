using Project12ClassRecordBook.DataLayer;
using Project12ClassRecordBook.Forms;
using System;
using System.Windows.Forms;

namespace Project12ClassRecordBook
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Student s1 = new Student("Bonifacy", "Kowalski");
            Student s2 = new Student("Jan", "Nowicki");
            Student s3 = new Student("Agnieszka", "Walska");
            Course c1 = new Course("Mathematics");
            Course c2 = new Course("Chemistry");
            Course c3 = new Course("Physics");
            Statistics sts1 = new Statistics(c1, s1);
            new Statistics(c2, s1);
            Statistics sts2 = new Statistics(c2, s2);
            Statistics sts3 = new Statistics(c3, s3);
            sts1.AddGrades(2, 5, 4, 2);
            sts2.AddGrades(4, 3, 5, 4);
            sts3.AddGrades(2, 3, 1, 4);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Register());
        }
    }
}
