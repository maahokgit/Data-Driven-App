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
            var citizenshipList = service.Citizenships.OrderBy(c => c.Id).ToList();

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
        }

        private void countryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            AppDBDatalayer.Models.Country Select = (AppDBDatalayer.Models.Country)countryComboBox.SelectedItem;
            if (Select.Code.ToString() == "CA")
            {
                var result = service.ProvinceStates.AddQueryOption("$filter", "CountryCode eq 'CA'").OrderBy(p => p.Name).ToList();
                provinceStateComboBox.DataSource = result;
                provinceStateComboBox.DisplayMember = "Name";
            }
            else if (Select.Code.ToString() == "US")
            {
                var result = service.ProvinceStates.AddQueryOption("$filter", "CountryCode eq 'US'").OrderBy(p => p.Name).ToList();
                provinceStateComboBox.DataSource = result;
                provinceStateComboBox.DisplayMember = "Name";
            }
        }

        private void dobTimePicker_ValueChanged(object sender, EventArgs e)
        {
            MessageBox.Show(dobTimePicker.Value.ToString("yyyy-MM-dd"));
        }
    }
}
