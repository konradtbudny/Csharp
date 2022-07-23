using Project12ClassRecordBook.DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Project12ClassRecordBook.Forms
{
    public partial class NewStudent : Form
    {
        public Form Parent { get; set; }
        public NewStudent(Form parent)
        {
            InitializeComponent();
            Parent = parent;
        }
        private void NewStudent_FormClosed(object sender, FormClosedEventArgs e)
        {
            Parent.Enabled = true;
            ((Register)Parent).UpdateData();
        }
        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public bool IsValid()
        {
            string checker = "([a-z]{0,}:([1-6],){0,}[1-6];){1,}";
            return Regex.IsMatch(courseTextBox.Text, checker);
        }
        private void OKButton_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                string[] info = Regex.Split(courseTextBox.Text, ";\\s*").Where(s => !string.IsNullOrEmpty(s)).ToArray();
                List<Statistics> statisticsList = new List<Statistics>();
                foreach (var element in info)
                {
                    statisticsList.Add(new Statistics(element));
                }
                Student newStudent = new Student(firstNameTextBox.Text, lastNameTextBox.Text);
                statisticsList.ForEach(s => newStudent.AddStatistics(s));
                Close();
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {
        }
    }
}
