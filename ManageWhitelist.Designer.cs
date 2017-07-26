namespace SafeKeeper
{
    partial class ManageWhitelist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageWhitelist));
            this.ipList = new System.Windows.Forms.ListBox();
            this.ipListAddButton = new System.Windows.Forms.Button();
            this.ipListRemoveButton = new System.Windows.Forms.Button();
            this.ipListAddAddress = new System.Windows.Forms.TextBox();
            this.doneButton = new System.Windows.Forms.Button();
            this.ipListAddName = new System.Windows.Forms.TextBox();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ipList
            // 
            this.ipList.FormattingEnabled = true;
            this.ipList.Location = new System.Drawing.Point(12, 12);
            this.ipList.Name = "ipList";
            this.ipList.ScrollAlwaysVisible = true;
            this.ipList.Size = new System.Drawing.Size(315, 95);
            this.ipList.TabIndex = 27;
            // 
            // ipListAddButton
            // 
            this.ipListAddButton.Location = new System.Drawing.Point(252, 150);
            this.ipListAddButton.Name = "ipListAddButton";
            this.ipListAddButton.Size = new System.Drawing.Size(75, 20);
            this.ipListAddButton.TabIndex = 1;
            this.ipListAddButton.Text = "Add";
            this.ipListAddButton.UseVisualStyleBackColor = true;
            this.ipListAddButton.Click += new System.EventHandler(this.ipListAddButton_Click);
            // 
            // ipListRemoveButton
            // 
            this.ipListRemoveButton.Location = new System.Drawing.Point(12, 176);
            this.ipListRemoveButton.Name = "ipListRemoveButton";
            this.ipListRemoveButton.Size = new System.Drawing.Size(234, 23);
            this.ipListRemoveButton.TabIndex = 2;
            this.ipListRemoveButton.Text = "Remove";
            this.ipListRemoveButton.UseVisualStyleBackColor = true;
            this.ipListRemoveButton.Click += new System.EventHandler(this.ipListRemoveButton_Click);
            // 
            // ipListAddAddress
            // 
            this.ipListAddAddress.Location = new System.Drawing.Point(12, 150);
            this.ipListAddAddress.Name = "ipListAddAddress";
            this.ipListAddAddress.Size = new System.Drawing.Size(134, 20);
            this.ipListAddAddress.TabIndex = 3;
            // 
            // doneButton
            // 
            this.doneButton.Location = new System.Drawing.Point(252, 176);
            this.doneButton.Name = "doneButton";
            this.doneButton.Size = new System.Drawing.Size(75, 23);
            this.doneButton.TabIndex = 4;
            this.doneButton.Text = "Done";
            this.doneButton.UseVisualStyleBackColor = true;
            this.doneButton.Click += new System.EventHandler(this.doneButton_Click);
            // 
            // ipListAddName
            // 
            this.ipListAddName.Location = new System.Drawing.Point(152, 150);
            this.ipListAddName.Name = "ipListAddName";
            this.ipListAddName.Size = new System.Drawing.Size(94, 20);
            this.ipListAddName.TabIndex = 5;
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(13, 131);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(58, 13);
            this.labelAddress.TabIndex = 6;
            this.labelAddress.Text = "IP Address";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(149, 131);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 7;
            this.labelName.Text = "Name";
            // 
            // ManageWhitelist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(339, 211);
            this.ControlBox = false;
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.ipListAddName);
            this.Controls.Add(this.doneButton);
            this.Controls.Add(this.ipListAddAddress);
            this.Controls.Add(this.ipListRemoveButton);
            this.Controls.Add(this.ipListAddButton);
            this.Controls.Add(this.ipList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(355, 250);
            this.MinimumSize = new System.Drawing.Size(355, 250);
            this.Name = "ManageWhitelist";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Whitelist";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ipList;
        private System.Windows.Forms.Button ipListAddButton;
        private System.Windows.Forms.Button ipListRemoveButton;
        private System.Windows.Forms.TextBox ipListAddAddress;
        private System.Windows.Forms.Button doneButton;
        private System.Windows.Forms.TextBox ipListAddName;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelName;
    }
}