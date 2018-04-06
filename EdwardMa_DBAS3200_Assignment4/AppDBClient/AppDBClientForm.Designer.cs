﻿namespace AppDBClient
{
    partial class AppDBClientForm
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
            this.AppDBClient_tabControl = new System.Windows.Forms.TabControl();
            this.ApplicationForm = new System.Windows.Forms.TabPage();
            this.countryComboBox = new System.Windows.Forms.ComboBox();
            this.countryLabel = new System.Windows.Forms.Label();
            this.genderComboBox = new System.Windows.Forms.ComboBox();
            this.genderLabel = new System.Windows.Forms.Label();
            this.dobTimePicker = new System.Windows.Forms.DateTimePicker();
            this.DOBLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.middleNameLabel = new System.Windows.Forms.Label();
            this.middleNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.AppTitle_Label = new System.Windows.Forms.Label();
            this.SubmittedApplicant = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.streetAddressTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.provinceStateComboBox = new System.Windows.Forms.ComboBox();
            this.provinceStateLabel = new System.Windows.Forms.Label();
            this.AppDBClient_tabControl.SuspendLayout();
            this.ApplicationForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // AppDBClient_tabControl
            // 
            this.AppDBClient_tabControl.Controls.Add(this.ApplicationForm);
            this.AppDBClient_tabControl.Controls.Add(this.SubmittedApplicant);
            this.AppDBClient_tabControl.Location = new System.Drawing.Point(12, 12);
            this.AppDBClient_tabControl.Name = "AppDBClient_tabControl";
            this.AppDBClient_tabControl.SelectedIndex = 0;
            this.AppDBClient_tabControl.Size = new System.Drawing.Size(669, 641);
            this.AppDBClient_tabControl.TabIndex = 0;
            // 
            // ApplicationForm
            // 
            this.ApplicationForm.Controls.Add(this.provinceStateComboBox);
            this.ApplicationForm.Controls.Add(this.provinceStateLabel);
            this.ApplicationForm.Controls.Add(this.label2);
            this.ApplicationForm.Controls.Add(this.cityTextBox);
            this.ApplicationForm.Controls.Add(this.label1);
            this.ApplicationForm.Controls.Add(this.countryComboBox);
            this.ApplicationForm.Controls.Add(this.streetAddressTextBox);
            this.ApplicationForm.Controls.Add(this.countryLabel);
            this.ApplicationForm.Controls.Add(this.genderComboBox);
            this.ApplicationForm.Controls.Add(this.genderLabel);
            this.ApplicationForm.Controls.Add(this.dobTimePicker);
            this.ApplicationForm.Controls.Add(this.DOBLabel);
            this.ApplicationForm.Controls.Add(this.lastNameLabel);
            this.ApplicationForm.Controls.Add(this.lastNameTextBox);
            this.ApplicationForm.Controls.Add(this.middleNameLabel);
            this.ApplicationForm.Controls.Add(this.middleNameTextBox);
            this.ApplicationForm.Controls.Add(this.firstNameLabel);
            this.ApplicationForm.Controls.Add(this.firstNameTextBox);
            this.ApplicationForm.Controls.Add(this.AppTitle_Label);
            this.ApplicationForm.Location = new System.Drawing.Point(4, 22);
            this.ApplicationForm.Name = "ApplicationForm";
            this.ApplicationForm.Padding = new System.Windows.Forms.Padding(3);
            this.ApplicationForm.Size = new System.Drawing.Size(661, 615);
            this.ApplicationForm.TabIndex = 0;
            this.ApplicationForm.Text = "Application Form";
            this.ApplicationForm.UseVisualStyleBackColor = true;
            // 
            // countryComboBox
            // 
            this.countryComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countryComboBox.FormattingEnabled = true;
            this.countryComboBox.Location = new System.Drawing.Point(196, 260);
            this.countryComboBox.Name = "countryComboBox";
            this.countryComboBox.Size = new System.Drawing.Size(248, 33);
            this.countryComboBox.TabIndex = 13;
            // 
            // countryLabel
            // 
            this.countryLabel.AutoSize = true;
            this.countryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countryLabel.Location = new System.Drawing.Point(89, 263);
            this.countryLabel.Name = "countryLabel";
            this.countryLabel.Size = new System.Drawing.Size(101, 25);
            this.countryLabel.TabIndex = 12;
            this.countryLabel.Text = "Country:";
            // 
            // genderComboBox
            // 
            this.genderComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderComboBox.FormattingEnabled = true;
            this.genderComboBox.Location = new System.Drawing.Point(196, 221);
            this.genderComboBox.Name = "genderComboBox";
            this.genderComboBox.Size = new System.Drawing.Size(248, 33);
            this.genderComboBox.TabIndex = 11;
            // 
            // genderLabel
            // 
            this.genderLabel.AutoSize = true;
            this.genderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderLabel.Location = new System.Drawing.Point(94, 224);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(96, 25);
            this.genderLabel.TabIndex = 10;
            this.genderLabel.Text = "Gender:";
            // 
            // dobTimePicker
            // 
            this.dobTimePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dobTimePicker.Location = new System.Drawing.Point(196, 191);
            this.dobTimePicker.Name = "dobTimePicker";
            this.dobTimePicker.Size = new System.Drawing.Size(248, 20);
            this.dobTimePicker.TabIndex = 9;
            // 
            // DOBLabel
            // 
            this.DOBLabel.AutoSize = true;
            this.DOBLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DOBLabel.Location = new System.Drawing.Point(39, 188);
            this.DOBLabel.Name = "DOBLabel";
            this.DOBLabel.Size = new System.Drawing.Size(151, 25);
            this.DOBLabel.TabIndex = 8;
            this.DOBLabel.Text = "Date of Birth:";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameLabel.Location = new System.Drawing.Point(59, 151);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(131, 25);
            this.lastNameLabel.TabIndex = 6;
            this.lastNameLabel.Text = "Last Name:";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameTextBox.Location = new System.Drawing.Point(196, 148);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(248, 31);
            this.lastNameTextBox.TabIndex = 5;
            // 
            // middleNameLabel
            // 
            this.middleNameLabel.AutoSize = true;
            this.middleNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.middleNameLabel.Location = new System.Drawing.Point(34, 114);
            this.middleNameLabel.Name = "middleNameLabel";
            this.middleNameLabel.Size = new System.Drawing.Size(156, 25);
            this.middleNameLabel.TabIndex = 4;
            this.middleNameLabel.Text = "Middle Name:";
            // 
            // middleNameTextBox
            // 
            this.middleNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.middleNameTextBox.Location = new System.Drawing.Point(196, 111);
            this.middleNameTextBox.Name = "middleNameTextBox";
            this.middleNameTextBox.Size = new System.Drawing.Size(248, 31);
            this.middleNameTextBox.TabIndex = 3;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameLabel.Location = new System.Drawing.Point(57, 77);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(133, 25);
            this.firstNameLabel.TabIndex = 2;
            this.firstNameLabel.Text = "First Name:";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameTextBox.Location = new System.Drawing.Point(196, 74);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(248, 31);
            this.firstNameTextBox.TabIndex = 1;
            // 
            // AppTitle_Label
            // 
            this.AppTitle_Label.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppTitle_Label.Location = new System.Drawing.Point(3, 3);
            this.AppTitle_Label.Name = "AppTitle_Label";
            this.AppTitle_Label.Size = new System.Drawing.Size(523, 46);
            this.AppTitle_Label.TabIndex = 0;
            this.AppTitle_Label.Text = "NSCC Application Form";
            // 
            // SubmittedApplicant
            // 
            this.SubmittedApplicant.Location = new System.Drawing.Point(4, 22);
            this.SubmittedApplicant.Name = "SubmittedApplicant";
            this.SubmittedApplicant.Padding = new System.Windows.Forms.Padding(3);
            this.SubmittedApplicant.Size = new System.Drawing.Size(661, 615);
            this.SubmittedApplicant.TabIndex = 1;
            this.SubmittedApplicant.Text = "Submitted Applicant";
            this.SubmittedApplicant.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 302);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Street Address:";
            // 
            // streetAddressTextBox
            // 
            this.streetAddressTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.streetAddressTextBox.Location = new System.Drawing.Point(196, 299);
            this.streetAddressTextBox.Name = "streetAddressTextBox";
            this.streetAddressTextBox.Size = new System.Drawing.Size(248, 31);
            this.streetAddressTextBox.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(130, 339);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 25);
            this.label2.TabIndex = 15;
            this.label2.Text = "City:";
            // 
            // cityTextBox
            // 
            this.cityTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityTextBox.Location = new System.Drawing.Point(196, 336);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(248, 31);
            this.cityTextBox.TabIndex = 14;
            // 
            // provinceStateComboBox
            // 
            this.provinceStateComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.provinceStateComboBox.FormattingEnabled = true;
            this.provinceStateComboBox.Location = new System.Drawing.Point(196, 373);
            this.provinceStateComboBox.Name = "provinceStateComboBox";
            this.provinceStateComboBox.Size = new System.Drawing.Size(248, 33);
            this.provinceStateComboBox.TabIndex = 17;
            // 
            // provinceStateLabel
            // 
            this.provinceStateLabel.AutoSize = true;
            this.provinceStateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.provinceStateLabel.Location = new System.Drawing.Point(3, 376);
            this.provinceStateLabel.Name = "provinceStateLabel";
            this.provinceStateLabel.Size = new System.Drawing.Size(187, 25);
            this.provinceStateLabel.TabIndex = 16;
            this.provinceStateLabel.Text = "Province / State:";
            // 
            // AppDBClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 665);
            this.Controls.Add(this.AppDBClient_tabControl);
            this.Name = "AppDBClientForm";
            this.Text = "AppDB Client";
            this.Load += new System.EventHandler(this.AppDBClientForm_Load);
            this.AppDBClient_tabControl.ResumeLayout(false);
            this.ApplicationForm.ResumeLayout(false);
            this.ApplicationForm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl AppDBClient_tabControl;
        private System.Windows.Forms.TabPage ApplicationForm;
        private System.Windows.Forms.TabPage SubmittedApplicant;
        private System.Windows.Forms.Label AppTitle_Label;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.Label middleNameLabel;
        private System.Windows.Forms.TextBox middleNameTextBox;
        private System.Windows.Forms.Label DOBLabel;
        private System.Windows.Forms.DateTimePicker dobTimePicker;
        private System.Windows.Forms.ComboBox genderComboBox;
        private System.Windows.Forms.Label genderLabel;
        private System.Windows.Forms.ComboBox countryComboBox;
        private System.Windows.Forms.Label countryLabel;
        private System.Windows.Forms.ComboBox provinceStateComboBox;
        private System.Windows.Forms.Label provinceStateLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox streetAddressTextBox;
    }
}

