using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Project13InsuranceManagement.IdentityManagement;

namespace Project13InsuranceManagement.Views
{
    public partial class UserView : UserControl, IForm
    {
        ToolTip tt;

        public UserView()
        {
            InitializeComponent();
        }

        public void Set(Object o)
        {
            if (o == null)
            {
                return;
            }
            User t = o as User;
            userNameTextBox.Text = t.UserName;
            oldPasswordPlaceHolderTextBox.Text = oldPasswordPlaceHolderTextBox.PlaceHolderText;
            newPasswordPlaceHolderTextBox1.Text = newPasswordPlaceHolderTextBox1.PlaceHolderText;
            newPasswordPlaceHolderTextBox2.Text = newPasswordPlaceHolderTextBox2.PlaceHolderText;
        }

        public List<string> ValidateForm()
        {
            List<string> validationErrors = new List<string>();
            if (string.IsNullOrWhiteSpace(userNameTextBox.Text) || userNameTextBox.IsUnchanged())
            {
                validationErrors.Add("Username is empty or a placeholder");
            }
            if (!newPasswordPlaceHolderTextBox1.Text.Equals(newPasswordPlaceHolderTextBox2.Text))
            {
                validationErrors.Add("new password mismatch");
            }
            return validationErrors;
        }

        public void Reset()
        {
            userNameTextBox.Reset();
            oldPasswordPlaceHolderTextBox.Reset();
        }

        public bool ValidateAndCreateObject()
        {
            List<string> validationErrors = ValidateForm();
            oldPasswordPlaceHolderTextBox.Text = string.Empty;
            if (!string.IsNullOrEmpty(oldPasswordPlaceHolderTextBox.Text))
            {
                validationErrors.Add("old password must be empty");
            }
            if (validationErrors.Count > 0)
                MessageBox.Show(string.Join(Environment.NewLine, validationErrors));
            if (validationErrors.Count == 0)
            {
                new User(userNameTextBox.Text, newPasswordPlaceHolderTextBox1.Text);
                return true;
            }
            return false;
        }

        public bool ValidateAndUpdateObject(Object o)
        {
            List<string> validationErrors = ValidateForm();
            IdentityManagement.User u = o as IdentityManagement.User;
            if (string.IsNullOrWhiteSpace(oldPasswordPlaceHolderTextBox.Text) || oldPasswordPlaceHolderTextBox.IsUnchanged())
            {
                validationErrors.Add("Password is empty or a placeholder");
            }
            if (!u.ValidatePassword(oldPasswordPlaceHolderTextBox.Text))
            {
                validationErrors.Add("old password is wrong");
            }
            if (validationErrors.Count == 0)
            {
                u.UserName = userNameTextBox.Text;
                u.Password = newPasswordPlaceHolderTextBox1.Text;
                return true;
            }
            if (validationErrors.Count > 0)
                MessageBox.Show(string.Join(Environment.NewLine, validationErrors));
            return false;
        }

        private void oldPasswordPlaceHolderTextBox_Leave(object sender, EventArgs e)
        {
            tt?.Dispose();
        }

        private void oldPasswordPlaceHolderTextBox_Enter(object sender, EventArgs e)
        {
            tt = new ToolTip();
            tt.InitialDelay = 0;
            tt.IsBalloon = true;
            tt.Show("Insert old password or leave empty when creating new user", oldPasswordPlaceHolderTextBox, 0);
        }

        private void newPasswordPlaceHolderTextBox1_Enter(object sender, EventArgs e)
        {
            tt = new ToolTip();
            tt.InitialDelay = 0;
            tt.IsBalloon = true;
            tt.Show("Enter new password", newPasswordPlaceHolderTextBox1, 0);
        }

        private void newPasswordPlaceHolderTextBox2_Enter(object sender, EventArgs e)
        {
            tt = new ToolTip();
            tt.InitialDelay = 0;
            tt.IsBalloon = true;
            tt.Show("Repeat new password", newPasswordPlaceHolderTextBox2, 0);
        }

        private void newPasswordPlaceHolderTextBox1_Leave(object sender, EventArgs e)
        {
            tt?.Dispose();
        }

        private void newPasswordPlaceHolderTextBox2_Leave(object sender, EventArgs e)
        {
            tt?.Dispose();
        }

        private void oldPasswordPlaceHolderTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (oldPasswordPlaceHolderTextBox.Text.Equals(oldPasswordPlaceHolderTextBox.PlaceHolderText))
            {
                oldPasswordPlaceHolderTextBox.Text = string.Empty;
            }
        }
    }
}