using System;
using System.Windows.Forms;

namespace Project13InsuranceManagement.Views
{
    public partial class ToolbarForm : Form
    {
        public NavigableUserControl currentView { get; set; }

        public ToolbarForm()
        {
            InitializeComponent();
        }

        public void SetView(NavigableUserControl view)
        {
            if (currentView != null)
            {
                tableLayoutPanel.Controls.Remove(currentView);
            }
            tableLayoutPanel.Controls.Add(view, 0, 0);
            view.Previous = currentView;
            currentView = view;
            currentView.Owner = this;
            currentView.Dock = DockStyle.Fill;
            if (Session.SessionManagerService.Instance.isLoggedIn())
            {
                usernameLabel.Text = Session.SessionManagerService.Instance.CurrentUser.UserName;
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            if (currentView?.Previous != null)
            {
                tableLayoutPanel.Controls.Remove(currentView);
                currentView = currentView.Previous as NavigableUserControl;
                tableLayoutPanel.Controls.Add(currentView, 0, 0);
            }
            if (currentView is LoginView)
            {
                Session.SessionManagerService.Instance.LogOut();
                tableLayoutPanel.Controls.Remove(currentView);
                currentView.Previous = null;
                currentView.Owner.SetView(new LoginView());
                usernameLabel.Text = string.Empty;
                currentView.Previous = null;
            }
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            Session.SessionManagerService.Instance.LogOut();
            tableLayoutPanel.Controls.Remove(currentView);
            currentView.Previous = null;
            currentView.Owner.SetView(new LoginView());
            usernameLabel.Text = string.Empty;
            currentView.Previous = null;
        }
    }
}