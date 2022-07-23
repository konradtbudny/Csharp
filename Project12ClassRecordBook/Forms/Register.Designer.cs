namespace Project12ClassRecordBook.Forms
{
    partial class Register
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
            this.listOfStudentsBox = new System.Windows.Forms.ListBox();
            this.addStudentButton = new System.Windows.Forms.Button();
            this.descriptionTextBox = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listOfStudentsBox
            // 
            this.listOfStudentsBox.FormattingEnabled = true;
            this.listOfStudentsBox.Location = new System.Drawing.Point(12, 13);
            this.listOfStudentsBox.Name = "listOfStudentsBox";
            this.listOfStudentsBox.ScrollAlwaysVisible = true;
            this.listOfStudentsBox.Size = new System.Drawing.Size(356, 342);
            this.listOfStudentsBox.TabIndex = 0;
            this.listOfStudentsBox.SelectedIndexChanged += new System.EventHandler(this.listOfStudentsBox_SelectedIndexChanged);
            this.listOfStudentsBox.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.listOfStudentsBox_Format);
            // 
            // addStudentButton
            // 
            this.addStudentButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.addStudentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addStudentButton.Location = new System.Drawing.Point(0, 361);
            this.addStudentButton.Name = "addStudentButton";
            this.addStudentButton.Size = new System.Drawing.Size(788, 88);
            this.addStudentButton.TabIndex = 3;
            this.addStudentButton.Text = "Add student";
            this.addStudentButton.UseVisualStyleBackColor = false;
            this.addStudentButton.Click += new System.EventHandler(this.addStudentButton_Click);
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(374, 13);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(414, 342);
            this.descriptionTextBox.TabIndex = 5;
            this.descriptionTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.addStudentButton);
            this.Controls.Add(this.listOfStudentsBox);
            this.Name = "Register";
            this.Text = "Register";
            this.Load += new System.EventHandler(this.Register_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listOfStudentsBox;
        private System.Windows.Forms.Button addStudentButton;
        private System.Windows.Forms.Label descriptionTextBox;
    }
}