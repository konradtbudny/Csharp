using System;

namespace Project13InsuranceManagement.Views
{
    public partial class LoginView : NavigableUserControl
    {
        public LoginView()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (!usernameBox.Text.Equals(null) && !passwordBox.Text.Equals(null))
            {
                if (Session.SessionManagerService.Instance.LogIn(usernameBox.Text, passwordBox.Text))
                {
                    Owner.SetView(new MainView());
                }
                else
                {
                    errorLabel.Text = "Wrong username or password";
                }
            }
        }

        private void passwordBox_TextChanged(object sender, EventArgs e)
        {
            if (!passwordBox.Text.Equals(passwordBox.PlaceHolderText))
            {
                passwordBox.PasswordChar = '*';
            }
            else
            {
                passwordBox.PasswordChar = '\0';
            }
        }
    }
}