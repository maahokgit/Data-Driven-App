using AppDBClient.Default;
using System;
using System.Linq;
using System.Windows.Forms;

namespace AppDBClient
{
    public partial class AppDBClientForm : Form
    {
        Container service;
        public AppDBClientForm()
        {
            InitializeComponent();
        }

        private void AppDBClientForm_Load(object sender, EventArgs e)
        {
            service = new Container(new Uri("http://appdbapi.azurewebsites.net/"));

            var genderList = service.Genders.OrderBy(g => g.Description).ToList();
            var countryList = service.Countries.OrderBy(c => c.Name).ToList();
            var citizenshipOtherList = service.Countries.OrderBy(c => c.Name).ToList();
            var citizenshipList = service.Citizenships.OrderBy(c => c.Id).ToList();
            var programList = service.Programs.OrderBy(p => p.Name).ToList();
            var campusList = service.Campuses.OrderBy(c => c.Name).ToList();
         
            genderList.Insert(0,
                new AppDBDatalayer.Models.Gender()
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

            choiceOneProgramComboBox.DataSource = programList;
            choiceOneProgramComboBox.DisplayMember = "Name";

            choiceOneCampusComboBox.DataSource = campusList;
            choiceOneCampusComboBox.DisplayMember = "Name";

            choiceTwoProgramComboBox.DataSource = programList;
            choiceTwoProgramComboBox.DisplayMember = "Name";

            choiceTwoCampusComboBox.DataSource = campusList;
            choiceTwoCampusComboBox.DisplayMember = "Name";
        }

        private void countryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            AppDBDatalayer.Models.Country Select = (AppDBDatalayer.Models.Country)countryComboBox.SelectedItem;
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

        private void citizenshipComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int Select = citizenshipComboBox.SelectedIndex;
            if (Select == 3)
            {
                citizenshipOtherComboBox.Enabled = true;
            }
        }
    }
}
