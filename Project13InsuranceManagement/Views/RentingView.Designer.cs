namespace Project13InsuranceManagement.Views
{
    partial class RentingView
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.availableCarsLabel = new System.Windows.Forms.Label();
            this.clientsLabel = new System.Windows.Forms.Label();
            this.listOfClientsBox = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.acceptButton = new Project13InsuranceManagement.GradientButton();
            this.label1 = new System.Windows.Forms.Label();
            this.fromDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.toDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ocCheckBox = new System.Windows.Forms.CheckBox();
            this.acCheckBox = new System.Windows.Forms.CheckBox();
            this.nnwCheckBox = new System.Windows.Forms.CheckBox();
            this.priceLabel = new System.Windows.Forms.Label();
            this.listOfAvailableCarsBox = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.Controls.Add(this.availableCarsLabel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.clientsLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.listOfClientsBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.listOfAvailableCarsBox, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.68493F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89.31507F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1119, 682);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // availableCarsLabel
            // 
            this.availableCarsLabel.AutoSize = true;
            this.availableCarsLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.availableCarsLabel.Location = new System.Drawing.Point(337, 0);
            this.availableCarsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.availableCarsLabel.Name = "availableCarsLabel";
            this.availableCarsLabel.Size = new System.Drawing.Size(331, 72);
            this.availableCarsLabel.TabIndex = 1;
            this.availableCarsLabel.Text = "Available Cars:";
            this.availableCarsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // clientsLabel
            // 
            this.clientsLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.clientsLabel.AutoSize = true;
            this.clientsLabel.Location = new System.Drawing.Point(137, 26);
            this.clientsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.clientsLabel.Name = "clientsLabel";
            this.clientsLabel.Size = new System.Drawing.Size(61, 20);
            this.clientsLabel.TabIndex = 0;
            this.clientsLabel.Text = "Clients:";
            // 
            // listOfClientsBox
            // 
            this.listOfClientsBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listOfClientsBox.FormattingEnabled = true;
            this.listOfClientsBox.ItemHeight = 20;
            this.listOfClientsBox.Location = new System.Drawing.Point(30, 104);
            this.listOfClientsBox.Margin = new System.Windows.Forms.Padding(30, 32, 30, 32);
            this.listOfClientsBox.Name = "listOfClientsBox";
            this.listOfClientsBox.Size = new System.Drawing.Size(275, 546);
            this.listOfClientsBox.TabIndex = 2;
            this.listOfClientsBox.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.listOfClientsBox_Format);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.32432F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.67567F));
            this.tableLayoutPanel2.Controls.Add(this.acceptButton, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.fromDateTimePicker, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.toDateTimePicker, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.ocCheckBox, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.acCheckBox, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.nnwCheckBox, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.priceLabel, 0, 5);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(672, 2);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 7;
            this.tableLayoutPanel1.SetRowSpan(this.tableLayoutPanel2, 2);
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.16181F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.83819F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 98F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 69F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(445, 678);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // acceptButton
            // 
            this.acceptButton.C1 = System.Drawing.Color.Blue;
            this.acceptButton.C2 = System.Drawing.Color.Red;
            this.tableLayoutPanel2.SetColumnSpan(this.acceptButton, 2);
            this.acceptButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.acceptButton.Location = new System.Drawing.Point(2, 610);
            this.acceptButton.Margin = new System.Windows.Forms.Padding(2);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(441, 66);
            this.acceptButton.TabIndex = 1;
            this.acceptButton.Text = "Accept";
            this.acceptButton.UseVisualStyleBackColor = true;
            this.acceptButton.Click += new System.EventHandler(this.acceptButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(2, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 181);
            this.label1.TabIndex = 2;
            this.label1.Text = "From:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // fromDateTimePicker
            // 
            this.fromDateTimePicker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fromDateTimePicker.Location = new System.Drawing.Point(110, 2);
            this.fromDateTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.fromDateTimePicker.Name = "fromDateTimePicker";
            this.fromDateTimePicker.Size = new System.Drawing.Size(333, 26);
            this.fromDateTimePicker.TabIndex = 3;
            this.fromDateTimePicker.ValueChanged += new System.EventHandler(this.fromDateTimePicker_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(2, 181);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 179);
            this.label2.TabIndex = 6;
            this.label2.Text = "To:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // toDateTimePicker
            // 
            this.toDateTimePicker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toDateTimePicker.Location = new System.Drawing.Point(110, 183);
            this.toDateTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.toDateTimePicker.Name = "toDateTimePicker";
            this.toDateTimePicker.Size = new System.Drawing.Size(333, 26);
            this.toDateTimePicker.TabIndex = 5;
            this.toDateTimePicker.ValueChanged += new System.EventHandler(this.toDateTimePicker_ValueChanged);
            // 
            // ocCheckBox
            // 
            this.ocCheckBox.AutoSize = true;
            this.ocCheckBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.ocCheckBox.Location = new System.Drawing.Point(2, 362);
            this.ocCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.ocCheckBox.Name = "ocCheckBox";
            this.ocCheckBox.Size = new System.Drawing.Size(58, 38);
            this.ocCheckBox.TabIndex = 7;
            this.ocCheckBox.Text = "OC";
            this.ocCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ocCheckBox.UseVisualStyleBackColor = true;
            this.ocCheckBox.CheckedChanged += new System.EventHandler(this.ocCheckBox_CheckedChanged);
            // 
            // acCheckBox
            // 
            this.acCheckBox.AutoSize = true;
            this.acCheckBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.acCheckBox.Location = new System.Drawing.Point(2, 404);
            this.acCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.acCheckBox.Name = "acCheckBox";
            this.acCheckBox.Size = new System.Drawing.Size(57, 94);
            this.acCheckBox.TabIndex = 8;
            this.acCheckBox.Text = "AC";
            this.acCheckBox.UseVisualStyleBackColor = true;
            this.acCheckBox.CheckedChanged += new System.EventHandler(this.acCheckBox_CheckedChanged);
            // 
            // nnwCheckBox
            // 
            this.nnwCheckBox.AutoSize = true;
            this.nnwCheckBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.nnwCheckBox.Location = new System.Drawing.Point(2, 502);
            this.nnwCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.nnwCheckBox.Name = "nnwCheckBox";
            this.nnwCheckBox.Size = new System.Drawing.Size(72, 50);
            this.nnwCheckBox.TabIndex = 9;
            this.nnwCheckBox.Text = "NNW";
            this.nnwCheckBox.UseVisualStyleBackColor = true;
            this.nnwCheckBox.CheckedChanged += new System.EventHandler(this.nnwCheckBox_CheckedChanged);
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.priceLabel, 2);
            this.priceLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.priceLabel.Location = new System.Drawing.Point(2, 554);
            this.priceLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(441, 54);
            this.priceLabel.TabIndex = 10;
            this.priceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listOfAvailableCarsBox
            // 
            this.listOfAvailableCarsBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listOfAvailableCarsBox.FormattingEnabled = true;
            this.listOfAvailableCarsBox.ItemHeight = 20;
            this.listOfAvailableCarsBox.Location = new System.Drawing.Point(365, 104);
            this.listOfAvailableCarsBox.Margin = new System.Windows.Forms.Padding(30, 32, 30, 32);
            this.listOfAvailableCarsBox.Name = "listOfAvailableCarsBox";
            this.listOfAvailableCarsBox.Size = new System.Drawing.Size(275, 546);
            this.listOfAvailableCarsBox.TabIndex = 4;
            this.listOfAvailableCarsBox.SelectedIndexChanged += new System.EventHandler(this.listOfAvailableCarsBox_SelectedIndexChanged);
            this.listOfAvailableCarsBox.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.listOfAvailableCarsBox_Format);
            // 
            // RentingView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "RentingView";
            this.Size = new System.Drawing.Size(1119, 682);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label availableCarsLabel;
        private System.Windows.Forms.Label clientsLabel;
        private System.Windows.Forms.ListBox listOfClientsBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ListBox listOfAvailableCarsBox;
        private GradientButton acceptButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker fromDateTimePicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker toDateTimePicker;
        private System.Windows.Forms.CheckBox ocCheckBox;
        private System.Windows.Forms.CheckBox acCheckBox;
        private System.Windows.Forms.CheckBox nnwCheckBox;
        private System.Windows.Forms.Label priceLabel;
    }
}
