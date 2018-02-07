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
            this.applicationID = new System.Windows.Forms.Label();
            this.AppIDLabel = new System.Windows.Forms.Label();
            this.AppTabLabel = new System.Windows.Forms.Label();
            this.BugLogTab = new System.Windows.Forms.TabPage();
            this.IdentifyTab = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.appNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.currentVerTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.appSaveBtn = new System.Windows.Forms.Button();
            this.appListBox = new System.Windows.Forms.ListBox();
            this.deleteAppBtn = new System.Windows.Forms.Button();
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
            this.AppTab.Controls.Add(this.deleteAppBtn);
            this.AppTab.Controls.Add(this.appListBox);
            this.AppTab.Controls.Add(this.appSaveBtn);
            this.AppTab.Controls.Add(this.textBox1);
            this.AppTab.Controls.Add(this.label3);
            this.AppTab.Controls.Add(this.currentVerTextBox);
            this.AppTab.Controls.Add(this.label2);
            this.AppTab.Controls.Add(this.appNameTextBox);
            this.AppTab.Controls.Add(this.label1);
            this.AppTab.Controls.Add(this.applicationID);
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
            // applicationID
            // 
            this.applicationID.AutoSize = true;
            this.applicationID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.applicationID.Location = new System.Drawing.Point(178, 102);
            this.applicationID.Name = "applicationID";
            this.applicationID.Size = new System.Drawing.Size(153, 24);
            this.applicationID.TabIndex = 2;
            this.applicationID.Text = "Placeholder Text";
            // 
            // AppIDLabel
            // 
            this.AppIDLabel.AutoSize = true;
            this.AppIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppIDLabel.Location = new System.Drawing.Point(42, 102);
            this.AppIDLabel.Name = "AppIDLabel";
            this.AppIDLabel.Size = new System.Drawing.Size(130, 24);
            this.AppIDLabel.TabIndex = 1;
            this.AppIDLabel.Text = "Application ID:";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Application Name:";
            // 
            // appNameTextBox
            // 
            this.appNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appNameTextBox.Location = new System.Drawing.Point(178, 136);
            this.appNameTextBox.Name = "appNameTextBox";
            this.appNameTextBox.Size = new System.Drawing.Size(168, 29);
            this.appNameTextBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Current Version:";
            // 
            // currentVerTextBox
            // 
            this.currentVerTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentVerTextBox.Location = new System.Drawing.Point(177, 180);
            this.currentVerTextBox.Name = "currentVerTextBox";
            this.currentVerTextBox.Size = new System.Drawing.Size(169, 29);
            this.currentVerTextBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(63, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Description:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(177, 222);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(273, 250);
            this.textBox1.TabIndex = 8;
            // 
            // appSaveBtn
            // 
            this.appSaveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appSaveBtn.Location = new System.Drawing.Point(366, 478);
            this.appSaveBtn.Name = "appSaveBtn";
            this.appSaveBtn.Size = new System.Drawing.Size(84, 33);
            this.appSaveBtn.TabIndex = 9;
            this.appSaveBtn.Text = "Save";
            this.appSaveBtn.UseVisualStyleBackColor = true;
            // 
            // appListBox
            // 
            this.appListBox.FormattingEnabled = true;
            this.appListBox.Location = new System.Drawing.Point(519, 102);
            this.appListBox.Name = "appListBox";
            this.appListBox.Size = new System.Drawing.Size(383, 368);
            this.appListBox.TabIndex = 10;
            // 
            // deleteAppBtn
            // 
            this.deleteAppBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteAppBtn.Location = new System.Drawing.Point(818, 478);
            this.deleteAppBtn.Name = "deleteAppBtn";
            this.deleteAppBtn.Size = new System.Drawing.Size(84, 33);
            this.deleteAppBtn.TabIndex = 11;
            this.deleteAppBtn.Text = "Delete";
            this.deleteAppBtn.UseVisualStyleBackColor = true;
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
        private System.Windows.Forms.Label applicationID;
        private System.Windows.Forms.Label AppIDLabel;
        private System.Windows.Forms.TextBox currentVerTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox appNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button appSaveBtn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button deleteAppBtn;
        private System.Windows.Forms.ListBox appListBox;
    }
}

