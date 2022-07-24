namespace Project13InsuranceManagement.Views
{
    partial class LoginView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.loginButton = new Project13InsuranceManagement.GradientButton();
            this.errorLabel = new System.Windows.Forms.Label();
            this.usernameBox = new Project13InsuranceManagement.PlaceHolderTextBox();
            this.passwordBox = new Project13InsuranceManagement.PlaceHolderTextBox();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // loginButton
            // 
            this.loginButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.loginButton.C1 = System.Drawing.Color.Blue;
            this.loginButton.C2 = System.Drawing.Color.Red;
            this.loginButton.Location = new System.Drawing.Point(439, 94);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(101, 38);
            this.loginButton.TabIndex = 3;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Location = new System.Drawing.Point(21, 198);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 25);
            this.errorLabel.TabIndex = 5;
            // 
            // usernameBox
            // 
            this.usernameBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.usernameBox.Location = new System.Drawing.Point(26, 57);
            this.usernameBox.Multiline = true;
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.PlaceHolderText = "userame";
            this.usernameBox.ShortcutsEnabled = false;
            this.usernameBox.Size = new System.Drawing.Size(353, 31);
            this.usernameBox.TabIndex = 6;
            this.usernameBox.Text = "Konrad Budny";
            this.usernameBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // passwordBox
            // 
            this.passwordBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passwordBox.Location = new System.Drawing.Point(26, 166);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.PlaceHolderText = "password";
            this.passwordBox.Size = new System.Drawing.Size(353, 31);
            this.passwordBox.TabIndex = 7;
            this.passwordBox.Text = "Jasło";
            this.passwordBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.passwordBox.TextChanged += new System.EventHandler(this.passwordBox_TextChanged);
            // 
            // LoginView
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.usernameBox);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.loginButton);
            this.Name = "LoginView";
            this.Size = new System.Drawing.Size(578, 223);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private GradientButton loginButton;
        private System.Windows.Forms.Label errorLabel;
        private PlaceHolderTextBox usernameBox;
        private PlaceHolderTextBox passwordBox;
    }
}