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
            this.IdentifyTab = new System.Windows.Forms.TabPage();
            this.UserTab = new System.Windows.Forms.TabPage();
            this.AppTab = new System.Windows.Forms.TabPage();
            this.BugLogTab = new System.Windows.Forms.TabPage();
            
            this.bugTrackerTab.SuspendLayout();
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
            this.UserTab.Location = new System.Drawing.Point(4, 22);
            this.UserTab.Name = "UserTab";
            this.UserTab.Padding = new System.Windows.Forms.Padding(3);
            this.UserTab.Size = new System.Drawing.Size(921, 607);
            this.UserTab.TabIndex = 0;
            this.UserTab.Text = "User";
            this.UserTab.UseVisualStyleBackColor = true;
            // 
            // AppTab
            // 
            this.AppTab.Location = new System.Drawing.Point(4, 22);
            this.AppTab.Name = "AppTab";
            this.AppTab.Padding = new System.Windows.Forms.Padding(3);
            this.AppTab.Size = new System.Drawing.Size(921, 607);
            this.AppTab.TabIndex = 1;
            this.AppTab.Text = "Application";
            this.AppTab.UseVisualStyleBackColor = true;
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
            // tabPage1
            // 
            this.IdentifyTab.Location = new System.Drawing.Point(4, 22);
            this.IdentifyTab.Name = "IdentifyTab";
            this.IdentifyTab.Padding = new System.Windows.Forms.Padding(3);
            this.IdentifyTab.Size = new System.Drawing.Size(921, 607);
            this.IdentifyTab.TabIndex = 3;
            this.IdentifyTab.Text = "Identify";
            this.IdentifyTab.UseVisualStyleBackColor = true;
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl bugTrackerTab;
        private System.Windows.Forms.TabPage UserTab;
        private System.Windows.Forms.TabPage AppTab;
        private System.Windows.Forms.TabPage BugLogTab;
        private System.Windows.Forms.TabPage IdentifyTab;
    }
}

