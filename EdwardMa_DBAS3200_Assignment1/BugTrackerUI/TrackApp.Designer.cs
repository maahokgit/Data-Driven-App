namespace BugTrackerUI
{
    partial class TrackApp
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
            this.bugTrackerTab = new System.Windows.Forms.TabControl();
            this.UserTab = new System.Windows.Forms.TabPage();
            this.UserSubmitBtn = new System.Windows.Forms.Button();
            this.UserNameInput = new System.Windows.Forms.TextBox();
            this.UserTabLabel = new System.Windows.Forms.Label();
            this.AppTab = new System.Windows.Forms.TabPage();
            this.AppTabLabel = new System.Windows.Forms.Label();
            this.BugLogTab = new System.Windows.Forms.TabPage();
            this.IdentifyTab = new System.Windows.Forms.TabPage();
            this.AppIDLabel = new System.Windows.Forms.Label();
            this.ApplicationID = new System.Windows.Forms.Label();
            this.bugTrackerTab.SuspendLayout();
            this.UserTab.SuspendLayout();
            this.AppTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // bugTrackerTab
            // 
            this.bugTrackerTab.Controls.Add(this.UserTab);
            this.bugTrackerTab.Controls.Add(this.AppTab);
            this.bugTrackerTab.Controls.Add(this.BugLogTab);
            this.bugTrackerTab.Controls.Add(this.IdentifyTab);
            this.bugTrackerTab.Location = new System.Drawing.Point(12, 12);
            this.bugTrackerTab.Name = "bugTrackerTab";
            this.bugTrackerTab.SelectedIndex = 0;
            this.bugTrackerTab.Size = new System.Drawing.Size(929, 633);
            this.bugTrackerTab.TabIndex = 0;
            // 
            // UserTab
            // 
            this.UserTab.Controls.Add(this.UserSubmitBtn);
            this.UserTab.Controls.Add(this.UserNameInput);
            this.UserTab.Controls.Add(this.UserTabLabel);
            this.UserTab.Location = new System.Drawing.Point(4, 22);
            this.UserTab.Name = "UserTab";
            this.UserTab.Padding = new System.Windows.Forms.Padding(3);
            this.UserTab.Size = new System.Drawing.Size(921, 607);
            this.UserTab.TabIndex = 0;
            this.UserTab.Text = "User";
            this.UserTab.UseVisualStyleBackColor = true;
            // 
            // UserSubmitBtn
            // 
            this.UserSubmitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserSubmitBtn.Location = new System.Drawing.Point(597, 281);
            this.UserSubmitBtn.Name = "UserSubmitBtn";
            this.UserSubmitBtn.Size = new System.Drawing.Size(95, 32);
            this.UserSubmitBtn.TabIndex = 2;
            this.UserSubmitBtn.Text = "Go";
            this.UserSubmitBtn.UseVisualStyleBackColor = true;
            // 
            // UserNameInput
            // 
            this.UserNameInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameInput.Location = new System.Drawing.Point(205, 281);
            this.UserNameInput.Name = "UserNameInput";
            this.UserNameInput.Size = new System.Drawing.Size(386, 32);
            this.UserNameInput.TabIndex = 1;
            // 
            // UserTabLabel
            // 
            this.UserTabLabel.AutoSize = true;
            this.UserTabLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserTabLabel.Location = new System.Drawing.Point(17, 18);
            this.UserTabLabel.Name = "UserTabLabel";
            this.UserTabLabel.Size = new System.Drawing.Size(381, 39);
            this.UserTabLabel.TabIndex = 0;
            this.UserTabLabel.Text = "Please Identify Yourself";
            // 
            // AppTab
            // 
            this.AppTab.Controls.Add(this.ApplicationID);
            this.AppTab.Controls.Add(this.AppIDLabel);
            this.AppTab.Controls.Add(this.AppTabLabel);
            this.AppTab.Location = new System.Drawing.Point(4, 22);
            this.AppTab.Name = "AppTab";
            this.AppTab.Padding = new System.Windows.Forms.Padding(3);
            this.AppTab.Size = new System.Drawing.Size(921, 607);
            this.AppTab.TabIndex = 1;
            this.AppTab.Text = "Application";
            this.AppTab.UseVisualStyleBackColor = true;
            // 
            // AppTabLabel
            // 
            this.AppTabLabel.AutoSize = true;
            this.AppTabLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppTabLabel.Location = new System.Drawing.Point(17, 18);
            this.AppTabLabel.Name = "AppTabLabel";
            this.AppTabLabel.Size = new System.Drawing.Size(332, 39);
            this.AppTabLabel.TabIndex = 0;
            this.AppTabLabel.Text = "Application Manager";
            // 
            // BugLogTab
            // 
            this.BugLogTab.Location = new System.Drawing.Point(4, 22);
            this.BugLogTab.Name = "BugLogTab";
            this.BugLogTab.Padding = new System.Windows.Forms.Padding(3);
            this.BugLogTab.Size = new System.Drawing.Size(921, 607);
            this.BugLogTab.TabIndex = 2;
            this.BugLogTab.Text = "Bug Log";
            this.BugLogTab.UseVisualStyleBackColor = true;
            // 
            // IdentifyTab
            // 
            this.IdentifyTab.Location = new System.Drawing.Point(4, 22);
            this.IdentifyTab.Name = "IdentifyTab";
            this.IdentifyTab.Padding = new System.Windows.Forms.Padding(3);
            this.IdentifyTab.Size = new System.Drawing.Size(921, 607);
            this.IdentifyTab.TabIndex = 3;
            this.IdentifyTab.Text = "Identify";
            this.IdentifyTab.UseVisualStyleBackColor = true;
            // 
            // AppIDLabel
            // 
            this.AppIDLabel.AutoSize = true;
            this.AppIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppIDLabel.Location = new System.Drawing.Point(98, 221);
            this.AppIDLabel.Name = "AppIDLabel";
            this.AppIDLabel.Size = new System.Drawing.Size(150, 25);
            this.AppIDLabel.TabIndex = 1;
            this.AppIDLabel.Text = "Application ID:";
            // 
            // ApplicationID
            // 
            this.ApplicationID.AutoSize = true;
            this.ApplicationID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApplicationID.Location = new System.Drawing.Point(255, 221);
            this.ApplicationID.Name = "ApplicationID";
            this.ApplicationID.Size = new System.Drawing.Size(70, 25);
            this.ApplicationID.TabIndex = 2;
            this.ApplicationID.Text = "label1";
            // 
            // TrackApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 657);
            this.Controls.Add(this.bugTrackerTab);
            this.Name = "TrackApp";
            this.Text = "Bug Tracker";
            this.Load += new System.EventHandler(this.TrackApp_Load);
            this.bugTrackerTab.ResumeLayout(false);
            this.UserTab.ResumeLayout(false);
            this.UserTab.PerformLayout();
            this.AppTab.ResumeLayout(false);
            this.AppTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl bugTrackerTab;
        private System.Windows.Forms.TabPage UserTab;
        private System.Windows.Forms.TabPage AppTab;
        private System.Windows.Forms.TabPage BugLogTab;
        private System.Windows.Forms.TabPage IdentifyTab;
        private System.Windows.Forms.Button UserSubmitBtn;
        private System.Windows.Forms.TextBox UserNameInput;
        private System.Windows.Forms.Label UserTabLabel;
        private System.Windows.Forms.Label AppTabLabel;
        private System.Windows.Forms.Label ApplicationID;
        private System.Windows.Forms.Label AppIDLabel;
    }
}

