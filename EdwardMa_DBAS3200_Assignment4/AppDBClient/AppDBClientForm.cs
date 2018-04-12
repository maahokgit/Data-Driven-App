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
        private List<Campus> compusesWithProgramList;
        private List<Campus> compusesWithProgramList2;
        Validate validate = new Validate();
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

            //LoadchoiceOneProgramComboBox();
            //LoadchoiceOneCampusComboBox();
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

        private void dobTimePicker_ValueChanged(object sender, EventArgs e)
        {
            MessageBox.Show(dobTimePicker.Value.ToString("yyyy-MM-dd"));
        }

        private void firstNameTextBox_Leave(object sender, EventArgs e)
        {
            string fName = firstNameTextBox.Text.ToString();
            if(validate.IsFullname(fName) == true)
            {
                MessageBox.Show("First name is invalid");
                firstNameTextBox.ResetText();
            }
            //MessageBox.Show(validate.isFullname(fName).ToString());
        }

        private void lastNameTextBox_Leave(object sender, EventArgs e)
        {
            string lName = lastNameTextBox.Text.ToString();
            if (validate.IsFullname(lName) == true)
            {
                MessageBox.Show("Last name is invalid");
                lastNameTextBox.ResetText();
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
        }

        private void cityTextBox_Leave(object sender, EventArgs e)
        {
            string citytext = cityTextBox.Text.ToString();
            if (validate.IsFullname(citytext) == true)
            {
                MessageBox.Show("City is invalid");
                cityTextBox.ResetText();
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
            //compusesWithProgramList = (programList[i.Id].Campuses.OrderBy(p => p.Name)).ToList();

            choiceOneCampusComboBox.DataSource = i.Campuses;
            choiceOneCampusComboBox.DisplayMember = "Name";
            //choiceOneProgramComboBox.SelectedItem = i.Name;
        }

        private void choiceTwoProgramComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            AppDBDatalayer.Models.Program i = (AppDBDatalayer.Models.Program)choiceTwoProgramComboBox.SelectedItem;

            var programList2 = service.Programs.Expand(p => p.Campuses).ToList();
            //compusesWithProgramList2 = (programList2[i.Id].Campuses.OrderBy(p => p.Name)).ToList();

            choiceTwoCampusComboBox.DataSource = i.Campuses;
            choiceTwoCampusComboBox.DisplayMember = "Name";
            //choiceTwoProgramComboBox.SelectedItem = i.Name;
        }
    }
}

