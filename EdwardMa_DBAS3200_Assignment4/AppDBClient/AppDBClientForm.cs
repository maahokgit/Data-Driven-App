using AppDBClient.AppDBDatalayer.Models;
using AppDBClient.Default;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace AppDBClient
{
    public partial class AppDBClientForm : Form
    {
        Container service;
        Validate validate = new Validate();

        Boolean dob, firstName, lastName, stAddy, city, IsItEmail, phNum;
        public AppDBClientForm()
        {
            InitializeComponent();
        }

        public void AppDBClientForm_Load(object sender, EventArgs e)
        {
            service = new Container(new Uri("http://appdbapi.azurewebsites.net/"));
            service.MergeOption = Microsoft.OData.Client.MergeOption.OverwriteChanges;

            var genderList = service.Genders.OrderBy(g => g.Description).ToList();
            var countryList = service.Countries.OrderBy(c => c.Name).ToList();
            var citizenshipOtherList = service.Countries.OrderBy(c => c.Name).ToList();
            var citizenshipList = service.Citizenships.OrderBy(c => c.Id).ToList();

            var programList = service.Programs.ToList();
            var campusList = service.Campuses.ToList();

            var programList2 = service.Programs.ToList();
            var campusList2 = service.Campuses.ToList();

            genderList.Insert(0,
                new Gender()
                {
                    Description = "<Select Gender>"
                }
                );
            genderComboBox.DataSource = genderList;
            genderComboBox.DisplayMember = "Description";

            countryComboBox.DataSource = countryList;
            countryComboBox.DisplayMember = "Name";
            countryComboBox.SelectedIndex = 37;

            citizenshipComboBox.DataSource = citizenshipList;
            citizenshipComboBox.DisplayMember = "Description";

            citizenshipOtherComboBox.Enabled = false;
            citizenshipOtherComboBox.DataSource = citizenshipOtherList;
            citizenshipOtherComboBox.DisplayMember = "Name";

            programList.Insert(0,
                new AppDBDatalayer.Models.Program()
                {
                    Name = "<Select Program>"
                });
            choiceOneProgramComboBox.DataSource = programList;
            choiceOneProgramComboBox.DisplayMember = "Name";

            campusList.Insert(0,
                new Campus()
                {
                    Name = "<Select Campus>"
                });
            choiceOneCampusComboBox.DataSource = campusList;
            choiceOneCampusComboBox.DisplayMember = "Name";

            programList2.Insert(0,
                new AppDBDatalayer.Models.Program()
                {
                    Name = "<Select Program>"
                });

            choiceTwoProgramComboBox.DataSource = programList2;
            choiceTwoProgramComboBox.DisplayMember = "Name";

            campusList2.Insert(0,
                new Campus()
                {
                    Name = "<Select Campus>"
                });
            choiceTwoCampusComboBox.DataSource = campusList2;
            choiceTwoCampusComboBox.DisplayMember = "Name";
        }

        private void countryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Country Select = (Country)countryComboBox.SelectedItem;
            if (Select.Code.ToString() == "CA")
            {
                provinceStateComboBox.Enabled = true;
                provinceStateOtherTextBox.Enabled = false;
                var result = service.ProvinceStates.AddQueryOption("$filter", "CountryCode eq 'CA'").OrderBy(p => p.Name).ToList();
                provinceStateComboBox.DataSource = result;
                provinceStateComboBox.DisplayMember = "Name";
            }
            else if (Select.Code.ToString() == "US")
            {
                provinceStateComboBox.Enabled = true;
                provinceStateOtherTextBox.Enabled = false;
                var result = service.ProvinceStates.AddQueryOption("$filter", "CountryCode eq 'US'").OrderBy(p => p.Name).ToList();
                provinceStateComboBox.DataSource = result;
                provinceStateComboBox.DisplayMember = "Name";
            }
            else
            {
                provinceStateOtherTextBox.Enabled = true;
                provinceStateComboBox.Enabled = false;
            }
        }

        private void dobTimePicker_Leave(object sender, EventArgs e)
        {
            int myAge = DateTime.Today.Year - dobTimePicker.Value.Year; // CurrentYear - YourBirthDate

            if (18 > myAge)
            {
                MessageBox.Show("You must be older than 18 to apply!");
            }
            else
            {
                dob = true;
            }
        }

        private void firstNameTextBox_Leave(object sender, EventArgs e)
        {
            string fName = firstNameTextBox.Text.ToString();
            if(validate.IsFullname(fName) == true)
            {
                MessageBox.Show("First name is invalid");
                firstNameTextBox.ResetText();
            }
            else
            {
                firstName = true;
            }
        }

        private void lastNameTextBox_Leave(object sender, EventArgs e)
        {
            string lName = lastNameTextBox.Text.ToString();
            if (validate.IsFullname(lName) == true)
            {
                MessageBox.Show("Last name is invalid");
                lastNameTextBox.ResetText();
            }
            else
            {
                lastName = true;
            }
        }

        private void streetAddressTextBox_Leave(object sender, EventArgs e)
        {
            string add = streetAddressTextBox.Text.ToString();
            if (validate.IsAddress(add) == true)
            {
                MessageBox.Show("Address is invalid");
                streetAddressTextBox.ResetText();
            }
            else
            {
                stAddy = true;
            }
        }

        private void cityTextBox_Leave(object sender, EventArgs e)
        {
            string citytext = cityTextBox.Text.ToString();
            if (validate.IsFullname(citytext) == true)
            {
                MessageBox.Show("City is invalid");
                cityTextBox.ResetText();
            }
            else
            {
                city = true;
            }
        }

        private void provinceStateOtherTextBox_Leave(object sender, EventArgs e)
        {
            string psText = provinceStateOtherTextBox.Text.ToString();
            if (validate.IsFullname(psText) == true)
            {
                MessageBox.Show("Province / State is invalid");
                provinceStateOtherTextBox.ResetText();
            }
        }

        private void emailTextBox_Leave(object sender, EventArgs e)
        {
            string email = emailTextBox.Text.ToString();
            if(validate.IsEmail(email) == true)
            {
                MessageBox.Show("Email is invalid");
                emailTextBox.ResetText();
            }
            else
            {
                IsItEmail = true;
            }
        }
        
        private void phoneNumberTextBox_Leave(object sender, EventArgs e)
        {
            string num = phoneNumberTextBox.Text;
            if(validate.IsPhoneNumber(num) == true)
            {
                MessageBox.Show("Phone Number is invalid");
                phoneNumberTextBox.ResetText();
            }
            else
            {
                phNum = true;
            }
        }

        private void firstLanguageOtherTextBox_Leave(object sender, EventArgs e)
        {
            string fLangOther = firstLanguageOtherTextBox.Text.ToString();
            if (validate.IsFullname(fLangOther) == true)
            {
                MessageBox.Show("Invalid Input.  You must enter with alphabet");
                firstLanguageOtherTextBox.ResetText();
            }
        }

        private void citizenshipComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Citizenship Select = (Citizenship)citizenshipComboBox.SelectedItem;
            if (Select.Description == "Other")
            {
                citizenshipOtherComboBox.Enabled = true;
            }
            else
            {
                citizenshipOtherComboBox.Enabled = false;
            }
        }

        private void choiceOneProgramComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            AppDBDatalayer.Models.Program i = (AppDBDatalayer.Models.Program)choiceOneProgramComboBox.SelectedItem;

            var programList = service.Programs.Expand(p => p.Campuses).ToList();

            choiceOneCampusComboBox.DataSource = i.Campuses;
            choiceOneCampusComboBox.DisplayMember = "Name";
        }

        private void choiceTwoProgramComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            AppDBDatalayer.Models.Program i = (AppDBDatalayer.Models.Program)choiceTwoProgramComboBox.SelectedItem;

            var programList2 = service.Programs.Expand(p => p.Campuses).ToList();

            choiceTwoCampusComboBox.DataSource = i.Campuses;
            choiceTwoCampusComboBox.DisplayMember = "Name";
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            clearForm();
        }

        private void clearForm()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else
                        func(control.Controls);
            };

            func(Controls);
            // from https://stackoverflow.com/a/4811390
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            Applicant applicant = new Applicant();
            AppDBDatalayer.Models.Application application = new AppDBDatalayer.Models.Application();
            ProgramChoice programChoice = new ProgramChoice();
            ProgramChoice programChoice2 = new ProgramChoice();
            if(dob == true && firstName == true && lastName == true && stAddy == true && city == true && IsItEmail == true && phNum == true)
            {
                // create applicant package to applicant table
                applicant.FirstName = firstNameTextBox.Text;
                applicant.LastName = lastNameTextBox.Text;
                applicant.DateOfBirth = dobTimePicker.Value;
                applicant.Gender = ((Gender)genderComboBox.SelectedItem).Code;
                applicant.CountryCode = ((Country)countryComboBox.SelectedItem).Code;
                applicant.StreetAddress1 = streetAddressTextBox.Text;
                applicant.City = cityTextBox.Text;
                applicant.ProvinceStateCode = ((ProvinceState)provinceStateComboBox.SelectedItem).Code;
                applicant.ProvinceStateOther = provinceStateOtherTextBox.Text;
                applicant.EmailAddress = emailTextBox.Text;
                applicant.Citizenship = ((Citizenship)citizenshipComboBox.SelectedItem).Id;
                applicant.CitizenshipOther = ((Country)citizenshipOtherComboBox.SelectedItem).Code;
                applicant.IsEnglishFirstLanguage = IsEnglishFirstLanguage.Checked;
                applicant.FirstLanguageOther = firstLanguageOtherTextBox.Text;
                applicant.HasCriminalRecord = hasCriminalRecordCheckBox.Checked;
                applicant.IsIndigenous = isIndigenousCheckBox.Checked;
                applicant.IsAfricanCanadian = isAfricanCanadianCheckBox.Checked;
                applicant.HasDisability = hasDisabilityCheckBox.Checked;
                applicant.PhoneHome = phoneNumberTextBox.Text;

                // sending to Applicants Table
                service.AddToApplicants(applicant);

                // commit
                service.SaveChanges();

                 // creating application package
                application.ApplicationId = applicant.Applicantid;
                application.SubmissionDate = DateTime.Now;
                application.ApplicationFee = 50;
                application.Paid = false;

                // sending to application table
                service.AddToApplications(application);

                // commit
                service.SaveChanges();

                // creating ProgramChoice Package 1
                programChoice.ApplicationId = application.ApplicationId;
                programChoice.ProgramId = ((AppDBDatalayer.Models.Program)choiceOneProgramComboBox.SelectedItem).Id;
                programChoice.CampusId = ((Campus)choiceOneCampusComboBox.SelectedItem).Id;
                programChoice.Preference = 1;

                // sending package to ProgramChoice 1
                service.AddToProgramChoices(programChoice);

                // commit
                service.SaveChanges();
                
                // creating ProgramChoice Package 2
                programChoice2.ApplicationId = application.ApplicationId;
                programChoice2.ProgramId = ((AppDBDatalayer.Models.Program)choiceTwoProgramComboBox.SelectedItem).Id;
                programChoice2.CampusId = ((Campus)choiceTwoCampusComboBox.SelectedItem).Id;
                programChoice2.Preference = 2;

                // sending package to ProgramChoice 2
                service.AddToProgramChoices(programChoice2);

                // commit
                service.SaveChanges();

                clearForm();
            }
            else
            {
                MessageBox.Show("You have invalid input in the form");
                clearForm();
            }
        }
    }
}

