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
        Container service1, service2, serviceChoiceOne, serviceChoiceTwo;
        private List<Campus> compusesWithProgramList;
        private List<Campus> compusesWithProgramList2;
        Validate validate = new Validate();
        public AppDBClientForm()
        {
            InitializeComponent();
        }

        public void AppDBClientForm_Load(object sender, EventArgs e)
        {
            service1 = new Container(new Uri("http://appdbapi.azurewebsites.net/"));
            service2 = new Container(new Uri("http://appdbapi.azurewebsites.net/"));
            serviceChoiceOne = new Container(new Uri("http://appdbapi.azurewebsites.net/"));
            serviceChoiceTwo = new Container(new Uri("http://appdbapi.azurewebsites.net/"));
            var genderList = service1.Genders.OrderBy(g => g.Description).ToList();
            var countryList = service1.Countries.OrderBy(c => c.Name).ToList();
            var citizenshipOtherList = service1.Countries.OrderBy(c => c.Name).ToList();
            var citizenshipList = service1.Citizenships.OrderBy(c => c.Id).ToList();

            var programList = service1.Programs.ToList();
            var campusList = service1.Campuses.ToList();

            var programList2 = service2.Programs.ToList();
            var campusList2 = service2.Campuses.ToList();
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
                var result = service1.ProvinceStates.AddQueryOption("$filter", "CountryCode eq 'CA'").OrderBy(p => p.Name).ToList();
                provinceStateComboBox.DataSource = result;
                provinceStateComboBox.DisplayMember = "Name";
            }
            else if (Select.Code.ToString() == "US")
            {
                provinceStateComboBox.Enabled = true;
                provinceStateOtherTextBox.Enabled = false;
                var result = service1.ProvinceStates.AddQueryOption("$filter", "CountryCode eq 'US'").OrderBy(p => p.Name).ToList();
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
            if(validate.isFullname(fName) == true)
            {
                MessageBox.Show("Name is invalid");
                firstNameTextBox.ResetText();
            }
            //MessageBox.Show(validate.isFullname(fName).ToString());
        }

        private void lastNameTextBox_Leave(object sender, EventArgs e)
        {
            string lName = lastNameTextBox.Text.ToString();
            if (validate.isFullname(lName) == true)
            {
                MessageBox.Show("Name is invalid");
                lastNameTextBox.ResetText();
            }
        }

        private void streetAddressTextBox_Leave(object sender, EventArgs e)
        {
            string add = streetAddressTextBox.Text.ToString();
            if (validate.isAddress(add) == true)
            {
                MessageBox.Show("Name is invalid");
                streetAddressTextBox.ResetText();
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

            var programList = serviceChoiceOne.Programs.Expand(p => p.Campuses).ToList();
            compusesWithProgramList = (programList[i.Id].Campuses.OrderBy(p => p.Name)).ToList();

            choiceOneCampusComboBox.DataSource = compusesWithProgramList;
            choiceOneCampusComboBox.DisplayMember = "Name";
            choiceOneProgramComboBox.SelectedItem = i.Name;
        }

        private void choiceTwoProgramComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            AppDBDatalayer.Models.Program i = (AppDBDatalayer.Models.Program)choiceTwoProgramComboBox.SelectedItem;

            var programList2 = serviceChoiceTwo.Programs.Expand(p => p.Campuses).ToList();
            compusesWithProgramList2 = (programList2[i.Id].Campuses.OrderBy(p => p.Name)).ToList();

            choiceTwoCampusComboBox.DataSource = compusesWithProgramList2;
            choiceTwoCampusComboBox.DisplayMember = "Name";
            choiceTwoProgramComboBox.SelectedItem = i.Name;
        }
    }
}

