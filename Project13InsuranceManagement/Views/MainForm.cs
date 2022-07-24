namespace Project13InsuranceManagement.Views
{
    public partial class MainForm : ToolbarForm
    {
        public MainForm()
        {
            InitializeComponent();
            SetView(new LoginView());
        }
    }
}