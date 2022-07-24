namespace Project13InsuranceManagement.Views
{
    partial class CarView
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
            this.makeTextBox = new PlaceHolderTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.zToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modelTextBox = new PlaceHolderTextBox();
            this.priceTextBox = new PlaceHolderTextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // makeTextBox
            // 
            this.makeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.makeTextBox.Location = new System.Drawing.Point(0, 0);
            this.makeTextBox.Name = "makeTextBox";
            this.makeTextBox.Size = new System.Drawing.Size(556, 31);
            this.makeTextBox.TabIndex = 0;
            this.makeTextBox.Text = "Make";
            this.makeTextBox.PlaceHolderText = "Make";
            this.makeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(102, 40);
            // 
            // zToolStripMenuItem
            // 
            this.zToolStripMenuItem.Name = "zToolStripMenuItem";
            this.zToolStripMenuItem.Size = new System.Drawing.Size(101, 36);
            this.zToolStripMenuItem.Text = "z";
            // 
            // modelTextBox
            // 
            this.modelTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.modelTextBox.Location = new System.Drawing.Point(0, 46);
            this.modelTextBox.Name = "modelTextBox";
            this.modelTextBox.PlaceHolderText = "Model";
            this.modelTextBox.Size = new System.Drawing.Size(556, 31);
            this.modelTextBox.TabIndex = 2;
            this.modelTextBox.Text = "Model";
            this.modelTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // priceTextBox
            // 
            this.priceTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.priceTextBox.Location = new System.Drawing.Point(0, 105);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(553, 31);
            this.priceTextBox.TabIndex = 3;
            this.priceTextBox.Text = "Price";
            this.priceTextBox.PlaceHolderText = "Price";
            this.priceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(4, 163);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(549, 201);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // CarView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.modelTextBox);
            this.Controls.Add(this.makeTextBox);
            this.Name = "CarView";
            this.Size = new System.Drawing.Size(559, 367);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PlaceHolderTextBox makeTextBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem zToolStripMenuItem;
        private PlaceHolderTextBox modelTextBox;
        private PlaceHolderTextBox priceTextBox;
        private System.Windows.Forms.ListView listView1;
    }
}
