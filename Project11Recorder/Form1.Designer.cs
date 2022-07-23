namespace Project11Recorder
{
    partial class Form1
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
            this.startRecordingButton = new System.Windows.Forms.Button();
            this.finishRecordingButton = new System.Windows.Forms.Button();
            this.infoBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // startRecordingButton
            // 
            this.startRecordingButton.Location = new System.Drawing.Point(73, 275);
            this.startRecordingButton.Name = "startRecordingButton";
            this.startRecordingButton.Size = new System.Drawing.Size(275, 84);
            this.startRecordingButton.TabIndex = 0;
            this.startRecordingButton.Text = "Start";
            this.startRecordingButton.UseVisualStyleBackColor = true;
            this.startRecordingButton.Click += new System.EventHandler(this.startRecordingButton_Click);
            // 
            // finishRecordingButton
            // 
            this.finishRecordingButton.Location = new System.Drawing.Point(390, 275);
            this.finishRecordingButton.Name = "finishRecordingButton";
            this.finishRecordingButton.Size = new System.Drawing.Size(275, 84);
            this.finishRecordingButton.TabIndex = 2;
            this.finishRecordingButton.Text = "Finish";
            this.finishRecordingButton.UseVisualStyleBackColor = true;
            this.finishRecordingButton.Click += new System.EventHandler(this.FinishRecordingButton_Click);
            // 
            // infoBox
            // 
            this.infoBox.Location = new System.Drawing.Point(73, 172);
            this.infoBox.Name = "infoBox";
            this.infoBox.Size = new System.Drawing.Size(592, 20);
            this.infoBox.TabIndex = 3;
            this.infoBox.Text = "Press Start to start a recording";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.infoBox);
            this.Controls.Add(this.finishRecordingButton);
            this.Controls.Add(this.startRecordingButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startRecordingButton;
        private System.Windows.Forms.Button finishRecordingButton;
        private System.Windows.Forms.TextBox infoBox;
    }
}