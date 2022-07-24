namespace Project13InsuranceManagement.Views
{
    partial class MainView
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
            this.controlPanleButton = new Project13InsuranceManagement.GradientButton();
            this.rentalButton = new Project13InsuranceManagement.GradientButton();
            this.SuspendLayout();
            // 
            // controlPanleButton
            // 
            this.controlPanleButton.C1 = System.Drawing.Color.Blue;
            this.controlPanleButton.C2 = System.Drawing.Color.Red;
            this.controlPanleButton.Location = new System.Drawing.Point(109, 61);
            this.controlPanleButton.Name = "controlPanleButton";
            this.controlPanleButton.Size = new System.Drawing.Size(167, 46);
            this.controlPanleButton.TabIndex = 0;
            this.controlPanleButton.Text = "Control Panel";
            this.controlPanleButton.UseVisualStyleBackColor = true;
            this.controlPanleButton.Click += new System.EventHandler(this.controlPanleButton_Click);
            // 
            // rentalButton
            // 
            this.rentalButton.C1 = System.Drawing.Color.Blue;
            this.rentalButton.C2 = System.Drawing.Color.Red;
            this.rentalButton.Location = new System.Drawing.Point(109, 162);
            this.rentalButton.Name = "rentalButton";
            this.rentalButton.Size = new System.Drawing.Size(167, 49);
            this.rentalButton.TabIndex = 1;
            this.rentalButton.Text = "Rental";
            this.rentalButton.UseVisualStyleBackColor = true;
            this.rentalButton.Click += new System.EventHandler(this.rentalButton_Click);
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rentalButton);
            this.Controls.Add(this.controlPanleButton);
            this.Name = "MainView";
            this.Size = new System.Drawing.Size(356, 263);
            this.ResumeLayout(false);

        }

        #endregion

        private GradientButton controlPanleButton;
        private GradientButton rentalButton;
    }
}
