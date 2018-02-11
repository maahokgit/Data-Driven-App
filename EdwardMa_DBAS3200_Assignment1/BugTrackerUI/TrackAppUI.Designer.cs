namespace BugTrackerUI
{
    partial class TrackAppUI
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
            this.trackAppTabControl = new System.Windows.Forms.TabControl();
            this.identifyTabPage = new System.Windows.Forms.TabPage();
            this.userNameSubmitBtn = new System.Windows.Forms.Button();
            this.identifyTabUserNameTextBox = new System.Windows.Forms.TextBox();
            this.identifyTabUserNameLabel = new System.Windows.Forms.Label();
            this.identifyTitle = new System.Windows.Forms.Label();
            this.appTabPage = new System.Windows.Forms.TabPage();
            this.appDelBtn = new System.Windows.Forms.Button();
            this.appListBox = new System.Windows.Forms.ListBox();
            this.appSaveBtn = new System.Windows.Forms.Button();
            this.appDescTextBox = new System.Windows.Forms.TextBox();
            this.appVersionTextBox = new System.Windows.Forms.TextBox();
            this.appNameTextBox = new System.Windows.Forms.TextBox();
            this.appIDTextBox = new System.Windows.Forms.TextBox();
            this.appDescLabel = new System.Windows.Forms.Label();
            this.appVersionLabel = new System.Windows.Forms.Label();
            this.appNameLabel = new System.Windows.Forms.Label();
            this.appIDLabel = new System.Windows.Forms.Label();
            this.appTitleLabel = new System.Windows.Forms.Label();
            this.bugsTabPage = new System.Windows.Forms.TabPage();
            this.bugSaveBtn = new System.Windows.Forms.Button();
            this.updateCommenttextBox = new System.Windows.Forms.TextBox();
            this.updateCommentLabel = new System.Windows.Forms.Label();
            this.bugActivityDataGridView = new System.Windows.Forms.DataGridView();
            this.activityLabel = new System.Windows.Forms.Label();
            this.fixDateTextBox = new System.Windows.Forms.TextBox();
            this.bugIDTextBox = new System.Windows.Forms.TextBox();
            this.submitDateTextBox = new System.Windows.Forms.TextBox();
            this.fixDateLabel = new System.Windows.Forms.Label();
            this.bugStatusComboBox = new System.Windows.Forms.ComboBox();
            this.bugStatusLabel = new System.Windows.Forms.Label();
            this.repStepsTextBox = new System.Windows.Forms.TextBox();
            this.repStepsLabel = new System.Windows.Forms.Label();
            this.bugDetailTextBox = new System.Windows.Forms.TextBox();
            this.detailLabel = new System.Windows.Forms.Label();
            this.bugDescTextBox = new System.Windows.Forms.TextBox();
            this.bugDescLabel = new System.Windows.Forms.Label();
            this.submitDateLabel = new System.Windows.Forms.Label();
            this.bugIDLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.bugListBox = new System.Windows.Forms.ListBox();
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            this.bugAppComboBox = new System.Windows.Forms.ComboBox();
            this.bugListLabel = new System.Windows.Forms.Label();
            this.statusFilterLabel = new System.Windows.Forms.Label();
            this.bugAppLabel = new System.Windows.Forms.Label();
            this.usersTabPage = new System.Windows.Forms.TabPage();
            this.userDeleteBtn = new System.Windows.Forms.Button();
            this.userListBox = new System.Windows.Forms.ListBox();
            this.userSaveBtn = new System.Windows.Forms.Button();
            this.userPhoneTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.userEmailTextBox = new System.Windows.Forms.TextBox();
            this.userEmailLabel = new System.Windows.Forms.Label();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.userIDTextBox = new System.Windows.Forms.TextBox();
            this.userIDLabel = new System.Windows.Forms.Label();
            this.userTitleLabel = new System.Windows.Forms.Label();
            this.trackAppTabControl.SuspendLayout();
            this.identifyTabPage.SuspendLayout();
            this.appTabPage.SuspendLayout();
            this.bugsTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bugActivityDataGridView)).BeginInit();
            this.usersTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // trackAppTabControl
            // 
            this.trackAppTabControl.Controls.Add(this.identifyTabPage);
            this.trackAppTabControl.Controls.Add(this.appTabPage);
            this.trackAppTabControl.Controls.Add(this.bugsTabPage);
            this.trackAppTabControl.Controls.Add(this.usersTabPage);
            this.trackAppTabControl.Location = new System.Drawing.Point(12, 12);
            this.trackAppTabControl.Name = "trackAppTabControl";
            this.trackAppTabControl.SelectedIndex = 0;
            this.trackAppTabControl.Size = new System.Drawing.Size(1332, 633);
            this.trackAppTabControl.TabIndex = 0;
            // 
            // identifyTabPage
            // 
            this.identifyTabPage.Controls.Add(this.userNameSubmitBtn);
            this.identifyTabPage.Controls.Add(this.identifyTabUserNameTextBox);
            this.identifyTabPage.Controls.Add(this.identifyTabUserNameLabel);
            this.identifyTabPage.Controls.Add(this.identifyTitle);
            this.identifyTabPage.Location = new System.Drawing.Point(4, 22);
            this.identifyTabPage.Name = "identifyTabPage";
            this.identifyTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.identifyTabPage.Size = new System.Drawing.Size(1324, 607);
            this.identifyTabPage.TabIndex = 0;
            this.identifyTabPage.Text = "Identify";
            this.identifyTabPage.UseVisualStyleBackColor = true;
            // 
            // userNameSubmitBtn
            // 
            this.userNameSubmitBtn.Font = new System.Drawing.Font("Arial monospaced for SAP", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameSubmitBtn.Location = new System.Drawing.Point(474, 322);
            this.userNameSubmitBtn.Name = "userNameSubmitBtn";
            this.userNameSubmitBtn.Size = new System.Drawing.Size(371, 29);
            this.userNameSubmitBtn.TabIndex = 3;
            this.userNameSubmitBtn.Text = "Submit";
            this.userNameSubmitBtn.UseVisualStyleBackColor = true;
            this.userNameSubmitBtn.Click += new System.EventHandler(this.userNameSubmitBtn_Click);
            // 
            // identifyTabUserNameTextBox
            // 
            this.identifyTabUserNameTextBox.Font = new System.Drawing.Font("Arial monospaced for SAP", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.identifyTabUserNameTextBox.Location = new System.Drawing.Point(474, 287);
            this.identifyTabUserNameTextBox.Name = "identifyTabUserNameTextBox";
            this.identifyTabUserNameTextBox.Size = new System.Drawing.Size(371, 29);
            this.identifyTabUserNameTextBox.TabIndex = 2;
            // 
            // identifyTabUserNameLabel
            // 
            this.identifyTabUserNameLabel.AutoSize = true;
            this.identifyTabUserNameLabel.Font = new System.Drawing.Font("Arial monospaced for SAP", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.identifyTabUserNameLabel.Location = new System.Drawing.Point(592, 262);
            this.identifyTabUserNameLabel.Name = "identifyTabUserNameLabel";
            this.identifyTabUserNameLabel.Size = new System.Drawing.Size(120, 22);
            this.identifyTabUserNameLabel.TabIndex = 1;
            this.identifyTabUserNameLabel.Text = "User Name:";
            // 
            // identifyTitle
            // 
            this.identifyTitle.AutoSize = true;
            this.identifyTitle.Font = new System.Drawing.Font("Arial monospaced for SAP", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.identifyTitle.Location = new System.Drawing.Point(7, 7);
            this.identifyTitle.Name = "identifyTitle";
            this.identifyTitle.Size = new System.Drawing.Size(473, 37);
            this.identifyTitle.TabIndex = 0;
            this.identifyTitle.Text = "Please Identify Yourself";
            // 
            // appTabPage
            // 
            this.appTabPage.Controls.Add(this.appDelBtn);
            this.appTabPage.Controls.Add(this.appListBox);
            this.appTabPage.Controls.Add(this.appSaveBtn);
            this.appTabPage.Controls.Add(this.appDescTextBox);
            this.appTabPage.Controls.Add(this.appVersionTextBox);
            this.appTabPage.Controls.Add(this.appNameTextBox);
            this.appTabPage.Controls.Add(this.appIDTextBox);
            this.appTabPage.Controls.Add(this.appDescLabel);
            this.appTabPage.Controls.Add(this.appVersionLabel);
            this.appTabPage.Controls.Add(this.appNameLabel);
            this.appTabPage.Controls.Add(this.appIDLabel);
            this.appTabPage.Controls.Add(this.appTitleLabel);
            this.appTabPage.Location = new System.Drawing.Point(4, 22);
            this.appTabPage.Name = "appTabPage";
            this.appTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.appTabPage.Size = new System.Drawing.Size(1324, 607);
            this.appTabPage.TabIndex = 1;
            this.appTabPage.Text = "Applications";
            this.appTabPage.UseVisualStyleBackColor = true;
            // 
            // appDelBtn
            // 
            this.appDelBtn.Font = new System.Drawing.Font("Arial monospaced for SAP", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appDelBtn.Location = new System.Drawing.Point(646, 536);
            this.appDelBtn.Name = "appDelBtn";
            this.appDelBtn.Size = new System.Drawing.Size(672, 37);
            this.appDelBtn.TabIndex = 11;
            this.appDelBtn.Text = "Delete";
            this.appDelBtn.UseVisualStyleBackColor = true;
            this.appDelBtn.Click += new System.EventHandler(this.appDelBtn_Click);
            // 
            // appListBox
            // 
            this.appListBox.FormattingEnabled = true;
            this.appListBox.Location = new System.Drawing.Point(646, 58);
            this.appListBox.Name = "appListBox";
            this.appListBox.Size = new System.Drawing.Size(672, 472);
            this.appListBox.TabIndex = 10;
            this.appListBox.SelectedIndexChanged += new System.EventHandler(this.appListBox_SelectedIndexChanged);
            // 
            // appSaveBtn
            // 
            this.appSaveBtn.Font = new System.Drawing.Font("Arial monospaced for SAP", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appSaveBtn.Location = new System.Drawing.Point(209, 536);
            this.appSaveBtn.Name = "appSaveBtn";
            this.appSaveBtn.Size = new System.Drawing.Size(388, 37);
            this.appSaveBtn.TabIndex = 9;
            this.appSaveBtn.Text = "Save";
            this.appSaveBtn.UseVisualStyleBackColor = true;
            this.appSaveBtn.Click += new System.EventHandler(this.appSaveBtn_Click);
            // 
            // appDescTextBox
            // 
            this.appDescTextBox.Font = new System.Drawing.Font("Arial monospaced for SAP", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appDescTextBox.Location = new System.Drawing.Point(209, 163);
            this.appDescTextBox.Multiline = true;
            this.appDescTextBox.Name = "appDescTextBox";
            this.appDescTextBox.Size = new System.Drawing.Size(388, 367);
            this.appDescTextBox.TabIndex = 8;
            // 
            // appVersionTextBox
            // 
            this.appVersionTextBox.Font = new System.Drawing.Font("Arial monospaced for SAP", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appVersionTextBox.Location = new System.Drawing.Point(209, 128);
            this.appVersionTextBox.Name = "appVersionTextBox";
            this.appVersionTextBox.Size = new System.Drawing.Size(388, 29);
            this.appVersionTextBox.TabIndex = 7;
            // 
            // appNameTextBox
            // 
            this.appNameTextBox.Font = new System.Drawing.Font("Arial monospaced for SAP", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appNameTextBox.Location = new System.Drawing.Point(209, 93);
            this.appNameTextBox.Name = "appNameTextBox";
            this.appNameTextBox.Size = new System.Drawing.Size(388, 29);
            this.appNameTextBox.TabIndex = 6;
            // 
            // appIDTextBox
            // 
            this.appIDTextBox.Enabled = false;
            this.appIDTextBox.Font = new System.Drawing.Font("Arial monospaced for SAP", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appIDTextBox.Location = new System.Drawing.Point(209, 58);
            this.appIDTextBox.Name = "appIDTextBox";
            this.appIDTextBox.ReadOnly = true;
            this.appIDTextBox.Size = new System.Drawing.Size(388, 29);
            this.appIDTextBox.TabIndex = 5;
            // 
            // appDescLabel
            // 
            this.appDescLabel.AutoSize = true;
            this.appDescLabel.Font = new System.Drawing.Font("Arial monospaced for SAP", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appDescLabel.Location = new System.Drawing.Point(61, 166);
            this.appDescLabel.Name = "appDescLabel";
            this.appDescLabel.Size = new System.Drawing.Size(142, 22);
            this.appDescLabel.TabIndex = 4;
            this.appDescLabel.Text = "Description:";
            // 
            // appVersionLabel
            // 
            this.appVersionLabel.AutoSize = true;
            this.appVersionLabel.Font = new System.Drawing.Font("Arial monospaced for SAP", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appVersionLabel.Location = new System.Drawing.Point(17, 131);
            this.appVersionLabel.Name = "appVersionLabel";
            this.appVersionLabel.Size = new System.Drawing.Size(186, 22);
            this.appVersionLabel.TabIndex = 3;
            this.appVersionLabel.Text = "Current Version:";
            // 
            // appNameLabel
            // 
            this.appNameLabel.AutoSize = true;
            this.appNameLabel.Font = new System.Drawing.Font("Arial monospaced for SAP", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appNameLabel.Location = new System.Drawing.Point(6, 96);
            this.appNameLabel.Name = "appNameLabel";
            this.appNameLabel.Size = new System.Drawing.Size(197, 22);
            this.appNameLabel.TabIndex = 2;
            this.appNameLabel.Text = "Application Name:";
            // 
            // appIDLabel
            // 
            this.appIDLabel.AutoSize = true;
            this.appIDLabel.Font = new System.Drawing.Font("Arial monospaced for SAP", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appIDLabel.Location = new System.Drawing.Point(28, 61);
            this.appIDLabel.Name = "appIDLabel";
            this.appIDLabel.Size = new System.Drawing.Size(175, 22);
            this.appIDLabel.TabIndex = 1;
            this.appIDLabel.Text = "Application ID:";
            // 
            // appTitleLabel
            // 
            this.appTitleLabel.AutoSize = true;
            this.appTitleLabel.Font = new System.Drawing.Font("Arial monospaced for SAP", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appTitleLabel.Location = new System.Drawing.Point(7, 7);
            this.appTitleLabel.Name = "appTitleLabel";
            this.appTitleLabel.Size = new System.Drawing.Size(378, 37);
            this.appTitleLabel.TabIndex = 0;
            this.appTitleLabel.Text = "Application Manager";
            // 
            // bugsTabPage
            // 
            this.bugsTabPage.Controls.Add(this.bugSaveBtn);
            this.bugsTabPage.Controls.Add(this.updateCommenttextBox);
            this.bugsTabPage.Controls.Add(this.updateCommentLabel);
            this.bugsTabPage.Controls.Add(this.bugActivityDataGridView);
            this.bugsTabPage.Controls.Add(this.activityLabel);
            this.bugsTabPage.Controls.Add(this.fixDateTextBox);
            this.bugsTabPage.Controls.Add(this.bugIDTextBox);
            this.bugsTabPage.Controls.Add(this.submitDateTextBox);
            this.bugsTabPage.Controls.Add(this.fixDateLabel);
            this.bugsTabPage.Controls.Add(this.bugStatusComboBox);
            this.bugsTabPage.Controls.Add(this.bugStatusLabel);
            this.bugsTabPage.Controls.Add(this.repStepsTextBox);
            this.bugsTabPage.Controls.Add(this.repStepsLabel);
            this.bugsTabPage.Controls.Add(this.bugDetailTextBox);
            this.bugsTabPage.Controls.Add(this.detailLabel);
            this.bugsTabPage.Controls.Add(this.bugDescTextBox);
            this.bugsTabPage.Controls.Add(this.bugDescLabel);
            this.bugsTabPage.Controls.Add(this.submitDateLabel);
            this.bugsTabPage.Controls.Add(this.bugIDLabel);
            this.bugsTabPage.Controls.Add(this.button1);
            this.bugsTabPage.Controls.Add(this.bugListBox);
            this.bugsTabPage.Controls.Add(this.statusComboBox);
            this.bugsTabPage.Controls.Add(this.bugAppComboBox);
            this.bugsTabPage.Controls.Add(this.bugListLabel);
            this.bugsTabPage.Controls.Add(this.statusFilterLabel);
            this.bugsTabPage.Controls.Add(this.bugAppLabel);
            this.bugsTabPage.Location = new System.Drawing.Point(4, 22);
            this.bugsTabPage.Name = "bugsTabPage";
            this.bugsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.bugsTabPage.Size = new System.Drawing.Size(1324, 607);
            this.bugsTabPage.TabIndex = 2;
            this.bugsTabPage.Text = "Bugs";
            this.bugsTabPage.UseVisualStyleBackColor = true;
            // 
            // bugSaveBtn
            // 
            this.bugSaveBtn.Font = new System.Drawing.Font("Arial monospaced for SAP", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bugSaveBtn.Location = new System.Drawing.Point(1224, 566);
            this.bugSaveBtn.Name = "bugSaveBtn";
            this.bugSaveBtn.Size = new System.Drawing.Size(94, 28);
            this.bugSaveBtn.TabIndex = 27;
            this.bugSaveBtn.Text = "Save";
            this.bugSaveBtn.UseVisualStyleBackColor = true;
            // 
            // updateCommenttextBox
            // 
            this.updateCommenttextBox.Font = new System.Drawing.Font("Arial monospaced for SAP", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateCommenttextBox.Location = new System.Drawing.Point(844, 315);
            this.updateCommenttextBox.Multiline = true;
            this.updateCommenttextBox.Name = "updateCommenttextBox";
            this.updateCommenttextBox.Size = new System.Drawing.Size(474, 245);
            this.updateCommenttextBox.TabIndex = 26;
            // 
            // updateCommentLabel
            // 
            this.updateCommentLabel.AutoSize = true;
            this.updateCommentLabel.Font = new System.Drawing.Font("Arial monospaced for SAP", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateCommentLabel.Location = new System.Drawing.Point(841, 294);
            this.updateCommentLabel.Name = "updateCommentLabel";
            this.updateCommentLabel.Size = new System.Drawing.Size(158, 18);
            this.updateCommentLabel.TabIndex = 25;
            this.updateCommentLabel.Text = "Update Comment:";
            // 
            // bugActivityDataGridView
            // 
            this.bugActivityDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bugActivityDataGridView.Location = new System.Drawing.Point(844, 30);
            this.bugActivityDataGridView.Name = "bugActivityDataGridView";
            this.bugActivityDataGridView.Size = new System.Drawing.Size(474, 261);
            this.bugActivityDataGridView.TabIndex = 24;
            // 
            // activityLabel
            // 
            this.activityLabel.AutoSize = true;
            this.activityLabel.Font = new System.Drawing.Font("Arial monospaced for SAP", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activityLabel.Location = new System.Drawing.Point(841, 9);
            this.activityLabel.Name = "activityLabel";
            this.activityLabel.Size = new System.Drawing.Size(178, 18);
            this.activityLabel.TabIndex = 23;
            this.activityLabel.Text = "Bug Activity Log:";
            // 
            // fixDateTextBox
            // 
            this.fixDateTextBox.Font = new System.Drawing.Font("Arial monospaced for SAP", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fixDateTextBox.Location = new System.Drawing.Point(547, 534);
            this.fixDateTextBox.Name = "fixDateTextBox";
            this.fixDateTextBox.ReadOnly = true;
            this.fixDateTextBox.Size = new System.Drawing.Size(273, 26);
            this.fixDateTextBox.TabIndex = 22;
            // 
            // bugIDTextBox
            // 
            this.bugIDTextBox.Font = new System.Drawing.Font("Arial monospaced for SAP", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bugIDTextBox.Location = new System.Drawing.Point(547, 4);
            this.bugIDTextBox.Name = "bugIDTextBox";
            this.bugIDTextBox.ReadOnly = true;
            this.bugIDTextBox.Size = new System.Drawing.Size(273, 26);
            this.bugIDTextBox.TabIndex = 21;
            // 
            // submitDateTextBox
            // 
            this.submitDateTextBox.Font = new System.Drawing.Font("Arial monospaced for SAP", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitDateTextBox.Location = new System.Drawing.Point(547, 36);
            this.submitDateTextBox.Name = "submitDateTextBox";
            this.submitDateTextBox.ReadOnly = true;
            this.submitDateTextBox.Size = new System.Drawing.Size(273, 26);
            this.submitDateTextBox.TabIndex = 20;
            // 
            // fixDateLabel
            // 
            this.fixDateLabel.AutoSize = true;
            this.fixDateLabel.Font = new System.Drawing.Font("Arial monospaced for SAP", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fixDateLabel.Location = new System.Drawing.Point(443, 537);
            this.fixDateLabel.Name = "fixDateLabel";
            this.fixDateLabel.Size = new System.Drawing.Size(98, 18);
            this.fixDateLabel.TabIndex = 19;
            this.fixDateLabel.Text = "Fix Date:";
            // 
            // bugStatusComboBox
            // 
            this.bugStatusComboBox.Font = new System.Drawing.Font("Arial monospaced for SAP", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bugStatusComboBox.FormattingEnabled = true;
            this.bugStatusComboBox.Location = new System.Drawing.Point(547, 502);
            this.bugStatusComboBox.Name = "bugStatusComboBox";
            this.bugStatusComboBox.Size = new System.Drawing.Size(273, 26);
            this.bugStatusComboBox.TabIndex = 18;
            // 
            // bugStatusLabel
            // 
            this.bugStatusLabel.AutoSize = true;
            this.bugStatusLabel.Font = new System.Drawing.Font("Arial monospaced for SAP", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bugStatusLabel.Location = new System.Drawing.Point(463, 505);
            this.bugStatusLabel.Name = "bugStatusLabel";
            this.bugStatusLabel.Size = new System.Drawing.Size(78, 18);
            this.bugStatusLabel.TabIndex = 17;
            this.bugStatusLabel.Text = "Status:";
            // 
            // repStepsTextBox
            // 
            this.repStepsTextBox.Font = new System.Drawing.Font("Arial monospaced for SAP", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.repStepsTextBox.Location = new System.Drawing.Point(547, 318);
            this.repStepsTextBox.Multiline = true;
            this.repStepsTextBox.Name = "repStepsTextBox";
            this.repStepsTextBox.Size = new System.Drawing.Size(273, 178);
            this.repStepsTextBox.TabIndex = 16;
            // 
            // repStepsLabel
            // 
            this.repStepsLabel.AutoSize = true;
            this.repStepsLabel.Font = new System.Drawing.Font("Arial monospaced for SAP", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.repStepsLabel.Location = new System.Drawing.Point(433, 321);
            this.repStepsLabel.Name = "repStepsLabel";
            this.repStepsLabel.Size = new System.Drawing.Size(108, 18);
            this.repStepsLabel.TabIndex = 15;
            this.repStepsLabel.Text = "Rep Steps:";
            // 
            // bugDetailTextBox
            // 
            this.bugDetailTextBox.Font = new System.Drawing.Font("Arial monospaced for SAP", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bugDetailTextBox.Location = new System.Drawing.Point(547, 103);
            this.bugDetailTextBox.Multiline = true;
            this.bugDetailTextBox.Name = "bugDetailTextBox";
            this.bugDetailTextBox.Size = new System.Drawing.Size(273, 209);
            this.bugDetailTextBox.TabIndex = 14;
            // 
            // detailLabel
            // 
            this.detailLabel.AutoSize = true;
            this.detailLabel.Font = new System.Drawing.Font("Arial monospaced for SAP", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detailLabel.Location = new System.Drawing.Point(463, 103);
            this.detailLabel.Name = "detailLabel";
            this.detailLabel.Size = new System.Drawing.Size(78, 18);
            this.detailLabel.TabIndex = 13;
            this.detailLabel.Text = "Detail:";
            // 
            // bugDescTextBox
            // 
            this.bugDescTextBox.Font = new System.Drawing.Font("Arial monospaced for SAP", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bugDescTextBox.Location = new System.Drawing.Point(547, 68);
            this.bugDescTextBox.Name = "bugDescTextBox";
            this.bugDescTextBox.Size = new System.Drawing.Size(273, 26);
            this.bugDescTextBox.TabIndex = 12;
            // 
            // bugDescLabel
            // 
            this.bugDescLabel.AutoSize = true;
            this.bugDescLabel.Font = new System.Drawing.Font("Arial monospaced for SAP", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bugDescLabel.Location = new System.Drawing.Point(413, 71);
            this.bugDescLabel.Name = "bugDescLabel";
            this.bugDescLabel.Size = new System.Drawing.Size(128, 18);
            this.bugDescLabel.TabIndex = 11;
            this.bugDescLabel.Text = "Description:";
            // 
            // submitDateLabel
            // 
            this.submitDateLabel.AutoSize = true;
            this.submitDateLabel.Font = new System.Drawing.Font("Arial monospaced for SAP", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitDateLabel.Location = new System.Drawing.Point(413, 41);
            this.submitDateLabel.Name = "submitDateLabel";
            this.submitDateLabel.Size = new System.Drawing.Size(128, 18);
            this.submitDateLabel.TabIndex = 10;
            this.submitDateLabel.Text = "Submit Date:";
            // 
            // bugIDLabel
            // 
            this.bugIDLabel.AutoSize = true;
            this.bugIDLabel.Font = new System.Drawing.Font("Arial monospaced for SAP", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bugIDLabel.Location = new System.Drawing.Point(463, 9);
            this.bugIDLabel.Name = "bugIDLabel";
            this.bugIDLabel.Size = new System.Drawing.Size(78, 18);
            this.bugIDLabel.TabIndex = 9;
            this.bugIDLabel.Text = "Bug ID:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial monospaced for SAP", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(240, 570);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 28);
            this.button1.TabIndex = 8;
            this.button1.Text = "Delete Bug";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // bugListBox
            // 
            this.bugListBox.Font = new System.Drawing.Font("Arial monospaced for SAP", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bugListBox.FormattingEnabled = true;
            this.bugListBox.ItemHeight = 18;
            this.bugListBox.Location = new System.Drawing.Point(11, 92);
            this.bugListBox.Name = "bugListBox";
            this.bugListBox.Size = new System.Drawing.Size(362, 472);
            this.bugListBox.TabIndex = 7;
            // 
            // statusComboBox
            // 
            this.statusComboBox.Font = new System.Drawing.Font("Arial monospaced for SAP", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusComboBox.FormattingEnabled = true;
            this.statusComboBox.Location = new System.Drawing.Point(162, 38);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(211, 26);
            this.statusComboBox.TabIndex = 6;
            // 
            // bugAppComboBox
            // 
            this.bugAppComboBox.Font = new System.Drawing.Font("Arial monospaced for SAP", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bugAppComboBox.FormattingEnabled = true;
            this.bugAppComboBox.Location = new System.Drawing.Point(162, 6);
            this.bugAppComboBox.Name = "bugAppComboBox";
            this.bugAppComboBox.Size = new System.Drawing.Size(211, 26);
            this.bugAppComboBox.TabIndex = 5;
            this.bugAppComboBox.SelectedIndexChanged += new System.EventHandler(this.bugAppComboBox_SelectedIndexChanged);
            // 
            // bugListLabel
            // 
            this.bugListLabel.AutoSize = true;
            this.bugListLabel.Font = new System.Drawing.Font("Arial monospaced for SAP", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bugListLabel.Location = new System.Drawing.Point(8, 71);
            this.bugListLabel.Name = "bugListLabel";
            this.bugListLabel.Size = new System.Drawing.Size(98, 18);
            this.bugListLabel.TabIndex = 4;
            this.bugListLabel.Text = "Bug List:";
            // 
            // statusFilterLabel
            // 
            this.statusFilterLabel.AutoSize = true;
            this.statusFilterLabel.Font = new System.Drawing.Font("Arial monospaced for SAP", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusFilterLabel.Location = new System.Drawing.Point(8, 41);
            this.statusFilterLabel.Name = "statusFilterLabel";
            this.statusFilterLabel.Size = new System.Drawing.Size(148, 18);
            this.statusFilterLabel.TabIndex = 3;
            this.statusFilterLabel.Text = "Status Filter:";
            // 
            // bugAppLabel
            // 
            this.bugAppLabel.AutoSize = true;
            this.bugAppLabel.Font = new System.Drawing.Font("Arial monospaced for SAP", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bugAppLabel.Location = new System.Drawing.Point(28, 9);
            this.bugAppLabel.Name = "bugAppLabel";
            this.bugAppLabel.Size = new System.Drawing.Size(128, 18);
            this.bugAppLabel.TabIndex = 2;
            this.bugAppLabel.Text = "Application:";
            // 
            // usersTabPage
            // 
            this.usersTabPage.Controls.Add(this.userDeleteBtn);
            this.usersTabPage.Controls.Add(this.userListBox);
            this.usersTabPage.Controls.Add(this.userSaveBtn);
            this.usersTabPage.Controls.Add(this.userPhoneTextBox);
            this.usersTabPage.Controls.Add(this.label3);
            this.usersTabPage.Controls.Add(this.userEmailTextBox);
            this.usersTabPage.Controls.Add(this.userEmailLabel);
            this.usersTabPage.Controls.Add(this.userNameTextBox);
            this.usersTabPage.Controls.Add(this.userNameLabel);
            this.usersTabPage.Controls.Add(this.userIDTextBox);
            this.usersTabPage.Controls.Add(this.userIDLabel);
            this.usersTabPage.Controls.Add(this.userTitleLabel);
            this.usersTabPage.Location = new System.Drawing.Point(4, 22);
            this.usersTabPage.Name = "usersTabPage";
            this.usersTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.usersTabPage.Size = new System.Drawing.Size(1324, 607);
            this.usersTabPage.TabIndex = 3;
            this.usersTabPage.Text = "Users";
            this.usersTabPage.UseVisualStyleBackColor = true;
            // 
            // userDeleteBtn
            // 
            this.userDeleteBtn.Font = new System.Drawing.Font("Arial monospaced for SAP", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userDeleteBtn.Location = new System.Drawing.Point(646, 509);
            this.userDeleteBtn.Name = "userDeleteBtn";
            this.userDeleteBtn.Size = new System.Drawing.Size(672, 28);
            this.userDeleteBtn.TabIndex = 30;
            this.userDeleteBtn.Text = "Delete";
            this.userDeleteBtn.UseVisualStyleBackColor = true;
            this.userDeleteBtn.Click += new System.EventHandler(this.userDeleteBtn_Click);
            // 
            // userListBox
            // 
            this.userListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userListBox.FormattingEnabled = true;
            this.userListBox.ItemHeight = 24;
            this.userListBox.Location = new System.Drawing.Point(646, 43);
            this.userListBox.Name = "userListBox";
            this.userListBox.Size = new System.Drawing.Size(672, 460);
            this.userListBox.TabIndex = 29;
            this.userListBox.SelectedIndexChanged += new System.EventHandler(this.userListBox_SelectedIndexChanged);
            // 
            // userSaveBtn
            // 
            this.userSaveBtn.Font = new System.Drawing.Font("Arial monospaced for SAP", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userSaveBtn.Location = new System.Drawing.Point(271, 509);
            this.userSaveBtn.Name = "userSaveBtn";
            this.userSaveBtn.Size = new System.Drawing.Size(322, 28);
            this.userSaveBtn.TabIndex = 28;
            this.userSaveBtn.Text = "Save";
            this.userSaveBtn.UseVisualStyleBackColor = true;
            this.userSaveBtn.Click += new System.EventHandler(this.userSaveBtn_Click);
            // 
            // userPhoneTextBox
            // 
            this.userPhoneTextBox.Font = new System.Drawing.Font("Arial monospaced for SAP", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userPhoneTextBox.Location = new System.Drawing.Point(271, 148);
            this.userPhoneTextBox.Name = "userPhoneTextBox";
            this.userPhoneTextBox.Size = new System.Drawing.Size(322, 29);
            this.userPhoneTextBox.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial monospaced for SAP", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(112, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 22);
            this.label3.TabIndex = 12;
            this.label3.Text = "Phone Number:";
            // 
            // userEmailTextBox
            // 
            this.userEmailTextBox.Font = new System.Drawing.Font("Arial monospaced for SAP", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userEmailTextBox.Location = new System.Drawing.Point(271, 113);
            this.userEmailTextBox.Name = "userEmailTextBox";
            this.userEmailTextBox.Size = new System.Drawing.Size(322, 29);
            this.userEmailTextBox.TabIndex = 11;
            // 
            // userEmailLabel
            // 
            this.userEmailLabel.AutoSize = true;
            this.userEmailLabel.Font = new System.Drawing.Font("Arial monospaced for SAP", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userEmailLabel.Location = new System.Drawing.Point(189, 116);
            this.userEmailLabel.Name = "userEmailLabel";
            this.userEmailLabel.Size = new System.Drawing.Size(76, 22);
            this.userEmailLabel.TabIndex = 10;
            this.userEmailLabel.Text = "Email:";
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.Font = new System.Drawing.Font("Arial monospaced for SAP", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameTextBox.Location = new System.Drawing.Point(271, 78);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(322, 29);
            this.userNameTextBox.TabIndex = 9;
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Font = new System.Drawing.Font("Arial monospaced for SAP", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameLabel.Location = new System.Drawing.Point(145, 81);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(120, 22);
            this.userNameLabel.TabIndex = 8;
            this.userNameLabel.Text = "User Name:";
            // 
            // userIDTextBox
            // 
            this.userIDTextBox.Font = new System.Drawing.Font("Arial monospaced for SAP", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userIDTextBox.Location = new System.Drawing.Point(271, 43);
            this.userIDTextBox.Name = "userIDTextBox";
            this.userIDTextBox.ReadOnly = true;
            this.userIDTextBox.Size = new System.Drawing.Size(322, 29);
            this.userIDTextBox.TabIndex = 7;
            // 
            // userIDLabel
            // 
            this.userIDLabel.AutoSize = true;
            this.userIDLabel.Font = new System.Drawing.Font("Arial monospaced for SAP", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userIDLabel.Location = new System.Drawing.Point(167, 46);
            this.userIDLabel.Name = "userIDLabel";
            this.userIDLabel.Size = new System.Drawing.Size(98, 22);
            this.userIDLabel.TabIndex = 2;
            this.userIDLabel.Text = "User ID:";
            // 
            // userTitleLabel
            // 
            this.userTitleLabel.AutoSize = true;
            this.userTitleLabel.Font = new System.Drawing.Font("Arial monospaced for SAP", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userTitleLabel.Location = new System.Drawing.Point(6, 3);
            this.userTitleLabel.Name = "userTitleLabel";
            this.userTitleLabel.Size = new System.Drawing.Size(245, 37);
            this.userTitleLabel.TabIndex = 1;
            this.userTitleLabel.Text = "User Manager";
            // 
            // TrackAppUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1356, 657);
            this.Controls.Add(this.trackAppTabControl);
            this.Name = "TrackAppUI";
            this.Text = "Bug Tracker App";
            this.Load += new System.EventHandler(this.TrackApp_Load);
            this.trackAppTabControl.ResumeLayout(false);
            this.identifyTabPage.ResumeLayout(false);
            this.identifyTabPage.PerformLayout();
            this.appTabPage.ResumeLayout(false);
            this.appTabPage.PerformLayout();
            this.bugsTabPage.ResumeLayout(false);
            this.bugsTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bugActivityDataGridView)).EndInit();
            this.usersTabPage.ResumeLayout(false);
            this.usersTabPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl trackAppTabControl;
        private System.Windows.Forms.TabPage identifyTabPage;
        private System.Windows.Forms.Button userNameSubmitBtn;
        private System.Windows.Forms.TextBox identifyTabUserNameTextBox;
        private System.Windows.Forms.Label identifyTabUserNameLabel;
        private System.Windows.Forms.Label identifyTitle;
        private System.Windows.Forms.TabPage appTabPage;
        private System.Windows.Forms.Label appTitleLabel;
        private System.Windows.Forms.TabPage bugsTabPage;
        private System.Windows.Forms.TabPage usersTabPage;
        private System.Windows.Forms.TextBox appDescTextBox;
        private System.Windows.Forms.TextBox appVersionTextBox;
        private System.Windows.Forms.TextBox appNameTextBox;
        private System.Windows.Forms.TextBox appIDTextBox;
        private System.Windows.Forms.Label appDescLabel;
        private System.Windows.Forms.Label appVersionLabel;
        private System.Windows.Forms.Label appNameLabel;
        private System.Windows.Forms.Label appIDLabel;
        private System.Windows.Forms.Button appSaveBtn;
        private System.Windows.Forms.Button appDelBtn;
        private System.Windows.Forms.ListBox appListBox;
        private System.Windows.Forms.Label statusFilterLabel;
        private System.Windows.Forms.Label bugAppLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox bugListBox;
        private System.Windows.Forms.ComboBox statusComboBox;
        private System.Windows.Forms.ComboBox bugAppComboBox;
        private System.Windows.Forms.Label bugListLabel;
        private System.Windows.Forms.Label bugStatusLabel;
        private System.Windows.Forms.TextBox repStepsTextBox;
        private System.Windows.Forms.Label repStepsLabel;
        private System.Windows.Forms.TextBox bugDetailTextBox;
        private System.Windows.Forms.Label detailLabel;
        private System.Windows.Forms.TextBox bugDescTextBox;
        private System.Windows.Forms.Label bugDescLabel;
        private System.Windows.Forms.Label submitDateLabel;
        private System.Windows.Forms.Label bugIDLabel;
        private System.Windows.Forms.ComboBox bugStatusComboBox;
        private System.Windows.Forms.TextBox fixDateTextBox;
        private System.Windows.Forms.TextBox bugIDTextBox;
        private System.Windows.Forms.TextBox submitDateTextBox;
        private System.Windows.Forms.Label fixDateLabel;
        private System.Windows.Forms.Button bugSaveBtn;
        private System.Windows.Forms.TextBox updateCommenttextBox;
        private System.Windows.Forms.Label updateCommentLabel;
        private System.Windows.Forms.DataGridView bugActivityDataGridView;
        private System.Windows.Forms.Label activityLabel;
        private System.Windows.Forms.Label userTitleLabel;
        private System.Windows.Forms.TextBox userPhoneTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox userEmailTextBox;
        private System.Windows.Forms.Label userEmailLabel;
        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.TextBox userIDTextBox;
        private System.Windows.Forms.Label userIDLabel;
        private System.Windows.Forms.Button userSaveBtn;
        private System.Windows.Forms.Button userDeleteBtn;
        private System.Windows.Forms.ListBox userListBox;
    }
}

