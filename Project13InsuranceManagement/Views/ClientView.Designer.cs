namespace Project13InsuranceManagement.Views
{
    partial class ClientView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.firstNameTextBox = new PlaceHolderTextBox();
            this.lastNameTextBox = new PlaceHolderTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.peselTextBox = new PlaceHolderTextBox();
            this.discountTextBox = new PlaceHolderTextBox();
            this.infoListView = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(27, 4);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(351, 31);
            this.firstNameTextBox.TabIndex = 0;
            this.firstNameTextBox.PlaceHolderText = "First name";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(27, 58);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(351, 31);
            this.lastNameTextBox.TabIndex = 1;
            this.lastNameTextBox.PlaceHolderText = "Last name";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // peselTextBox
            // 
            this.peselTextBox.Location = new System.Drawing.Point(27, 112);
            this.peselTextBox.Name = "peselTextBox";
            this.peselTextBox.Size = new System.Drawing.Size(351, 31);
            this.peselTextBox.TabIndex = 3;
            this.peselTextBox.PlaceHolderText = "Pesel";
            // 
            // discountTextBox
            // 
            this.discountTextBox.Location = new System.Drawing.Point(27, 175);
            this.discountTextBox.Name = "discountTextBox";
            this.discountTextBox.Size = new System.Drawing.Size(351, 31);
            this.discountTextBox.TabIndex = 4;
            this.discountTextBox.PlaceHolderText = "Discount";
            // 
            // infoListView
            // 
            this.infoListView.Location = new System.Drawing.Point(27, 223);
            this.infoListView.Name = "infoListView";
            this.infoListView.Size = new System.Drawing.Size(351, 97);
            this.infoListView.TabIndex = 5;
            this.infoListView.UseCompatibleStateImageBehavior = false;
            // 
            // ClientView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.infoListView);
            this.Controls.Add(this.discountTextBox);
            this.Controls.Add(this.peselTextBox);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.firstNameTextBox);
            this.Name = "ClientView";
            this.Size = new System.Drawing.Size(398, 329);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PlaceHolderTextBox firstNameTextBox;
        private PlaceHolderTextBox lastNameTextBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private PlaceHolderTextBox peselTextBox;
        private PlaceHolderTextBox discountTextBox;
        private System.Windows.Forms.ListView infoListView;
    }
}
