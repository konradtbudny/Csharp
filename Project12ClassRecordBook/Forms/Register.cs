using System;
using System.Windows.Forms;
using Project12ClassRecordBook.DataLayer;

namespace Project12ClassRecordBook.Forms
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
            listOfStudentsBox.DataSource = ObjectPlus.Objects[typeof(Student)];
        }
        private void listOfStudentsBox_Format(object sender, ListControlConvertEventArgs e)
        {
            Student currentStudent = (Student)e.Value;
            e.Value = currentStudent.FirstName + " " + currentStudent.LastName;
        }
        private void listOfStudentsBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            descriptionTextBox.Text = listOfStudentsBox.SelectedItem + "";
        }
        public void UpdateData()
        {
            listOfStudentsBox.DataSource = null;
            listOfStudentsBox.DataSource = ObjectPlus.Objects[typeof(Student)];
        }
        public void addStudentButton_Click(object sender, EventArgs e)
        {
            Enabled = false;
            NewStudent newStudentButton = new NewStudent(this);
            newStudentButton.Show();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
        private void Register_Load(object sender, EventArgs e)
        {
        }
    }
}
