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
            //var provinceStateList = service.ProvinceStates.OrderBy(p => p.Name).ToList();
            var result = service.ProvinceStates.AddQueryOption("$filter", "CountryCode eq 'CA'").OrderBy(p => p.Name).ToList();

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

            //provinceStateComboBox.DataSource = provinceStateList;
            provinceStateComboBox.DataSource = result;
            provinceStateComboBox.DisplayMember = "Name";
        }
    }
}
