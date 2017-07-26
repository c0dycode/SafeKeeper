namespace SafeKeeper
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.soloEnable = new System.Windows.Forms.Button();
            this.soloDisable = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DigitalArcLogo = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.labelVersion = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.whitelistDisable = new System.Windows.Forms.Button();
            this.whitelistEnable = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.manageButton = new System.Windows.Forms.Button();
            this.creditsButton = new System.Windows.Forms.LinkLabel();
            this.statusBar = new System.Windows.Forms.ProgressBar();
            this.newSessionButton = new System.Windows.Forms.Button();
            this.kickNonWhitelistButton = new System.Windows.Forms.Button();
            this.labelInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DigitalArcLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // soloEnable
            // 
            this.soloEnable.Location = new System.Drawing.Point(112, 34);
            this.soloEnable.Name = "soloEnable";
            this.soloEnable.Size = new System.Drawing.Size(75, 23);
            this.soloEnable.TabIndex = 0;
            this.soloEnable.Text = "Enable";
            this.soloEnable.UseVisualStyleBackColor = true;
            this.soloEnable.Click += new System.EventHandler(this.soloEnable_Click);
            // 
            // soloDisable
            // 
            this.soloDisable.Enabled = false;
            this.soloDisable.Location = new System.Drawing.Point(193, 34);
            this.soloDisable.Name = "soloDisable";
            this.soloDisable.Size = new System.Drawing.Size(75, 23);
            this.soloDisable.TabIndex = 1;
            this.soloDisable.Text = "Disable";
            this.soloDisable.UseVisualStyleBackColor = true;
            this.soloDisable.Click += new System.EventHandler(this.soloDisable_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Solo Lobby";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(181, 291);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "© DigitalArc";
            // 
            // DigitalArcLogo
            // 
            this.DigitalArcLogo.Image = global::SafeKeeper.Properties.Resources.dashboardlogo;
            this.DigitalArcLogo.Location = new System.Drawing.Point(252, 289);
            this.DigitalArcLogo.MaximumSize = new System.Drawing.Size(20, 20);
            this.DigitalArcLogo.MinimumSize = new System.Drawing.Size(20, 20);
            this.DigitalArcLogo.Name = "DigitalArcLogo";
            this.DigitalArcLogo.Size = new System.Drawing.Size(20, 20);
            this.DigitalArcLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DigitalArcLogo.TabIndex = 9;
            this.DigitalArcLogo.TabStop = false;
            this.DigitalArcLogo.WaitOnLoad = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Whitelist";
            // 
            // labelVersion
            // 
            this.labelVersion.AutoSize = true;
            this.labelVersion.Location = new System.Drawing.Point(222, 9);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(50, 13);
            this.labelVersion.TabIndex = 11;
            this.labelVersion.Text = "v version";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(12, 237);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(82, 13);
            this.labelStatus.TabIndex = 12;
            this.labelStatus.Text = "Status: disabled";
            // 
            // whitelistDisable
            // 
            this.whitelistDisable.Enabled = false;
            this.whitelistDisable.Location = new System.Drawing.Point(193, 63);
            this.whitelistDisable.Name = "whitelistDisable";
            this.whitelistDisable.Size = new System.Drawing.Size(75, 23);
            this.whitelistDisable.TabIndex = 16;
            this.whitelistDisable.Text = "Disable";
            this.whitelistDisable.UseVisualStyleBackColor = true;
            this.whitelistDisable.Click += new System.EventHandler(this.whitelistDisable_Click);
            // 
            // whitelistEnable
            // 
            this.whitelistEnable.Location = new System.Drawing.Point(112, 63);
            this.whitelistEnable.Name = "whitelistEnable";
            this.whitelistEnable.Size = new System.Drawing.Size(75, 23);
            this.whitelistEnable.TabIndex = 15;
            this.whitelistEnable.Text = "Enable";
            this.whitelistEnable.UseVisualStyleBackColor = true;
            this.whitelistEnable.Click += new System.EventHandler(this.whitelistEnable_Click);
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(13, 92);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(149, 42);
            this.label8.TabIndex = 19;
            this.label8.Text = "Whitelist allows your friends to join you, click manage to add your friends.";
            // 
            // manageButton
            // 
            this.manageButton.Location = new System.Drawing.Point(193, 92);
            this.manageButton.Name = "manageButton";
            this.manageButton.Size = new System.Drawing.Size(75, 23);
            this.manageButton.TabIndex = 21;
            this.manageButton.Text = "Manage";
            this.manageButton.UseVisualStyleBackColor = true;
            this.manageButton.Click += new System.EventHandler(this.manageButton_Click);
            // 
            // creditsButton
            // 
            this.creditsButton.AutoSize = true;
            this.creditsButton.Location = new System.Drawing.Point(12, 289);
            this.creditsButton.Name = "creditsButton";
            this.creditsButton.Size = new System.Drawing.Size(38, 13);
            this.creditsButton.TabIndex = 22;
            this.creditsButton.TabStop = true;
            this.creditsButton.Text = "credits";
            this.creditsButton.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.creditsButton_LinkClicked);
            // 
            // statusBar
            // 
            this.statusBar.Location = new System.Drawing.Point(12, 254);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(260, 23);
            this.statusBar.TabIndex = 24;
            // 
            // newSessionButton
            // 
            this.newSessionButton.Location = new System.Drawing.Point(12, 152);
            this.newSessionButton.Name = "newSessionButton";
            this.newSessionButton.Size = new System.Drawing.Size(121, 23);
            this.newSessionButton.TabIndex = 25;
            this.newSessionButton.Text = "New session";
            this.newSessionButton.UseVisualStyleBackColor = true;
            this.newSessionButton.Click += new System.EventHandler(this.newSessionButton_Click);
            // 
            // kickNonWhitelistButton
            // 
            this.kickNonWhitelistButton.Location = new System.Drawing.Point(147, 152);
            this.kickNonWhitelistButton.Name = "kickNonWhitelistButton";
            this.kickNonWhitelistButton.Size = new System.Drawing.Size(121, 23);
            this.kickNonWhitelistButton.TabIndex = 26;
            this.kickNonWhitelistButton.Text = "Kick unknowns";
            this.kickNonWhitelistButton.UseVisualStyleBackColor = true;
            this.kickNonWhitelistButton.Click += new System.EventHandler(this.kickNonWhitelistButton_Click);
            // 
            // labelInfo
            // 
            this.labelInfo.Location = new System.Drawing.Point(9, 178);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(259, 53);
            this.labelInfo.TabIndex = 27;
            this.labelInfo.Text = "New session will kick all and leave you as the host of the new session. Kick unkn" +
    "owns will kick all non whitelisted as long as you are the host.";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 311);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.kickNonWhitelistButton);
            this.Controls.Add(this.newSessionButton);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.creditsButton);
            this.Controls.Add(this.manageButton);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.whitelistDisable);
            this.Controls.Add(this.whitelistEnable);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.labelVersion);
            this.Controls.Add(this.DigitalArcLogo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.soloDisable);
            this.Controls.Add(this.soloEnable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(300, 350);
            this.MinimumSize = new System.Drawing.Size(300, 350);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SafeKeeper";
            ((System.ComponentModel.ISupportInitialize)(this.DigitalArcLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button soloEnable;
        private System.Windows.Forms.Button soloDisable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox DigitalArcLogo;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button whitelistDisable;
        private System.Windows.Forms.Button whitelistEnable;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button manageButton;
        private System.Windows.Forms.LinkLabel creditsButton;
        private System.Windows.Forms.ProgressBar statusBar;
        private System.Windows.Forms.Button newSessionButton;
        private System.Windows.Forms.Button kickNonWhitelistButton;
        private System.Windows.Forms.Label labelInfo;
    }
}

