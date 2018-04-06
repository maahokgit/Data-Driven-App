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
            service = new Container(new Uri("http://localhost:49962/"));

            var genderList = service.Genders.OrderBy(g => g.Description).ToList();
            var countryList = service.Countries.OrderBy(c => c.Name).ToList();
            var provinceStateList = service.ProvinceStates.OrderBy(p => p.Name).ToList();

            genderList.Insert(0,
                new AppDBDatalayer.Models.Gender()
                {
                    Description = "<Select Gender>"
                }
                );
            genderComboBox.DataSource = genderList;
            genderComboBox.DisplayMember = "Description";

            countryList.Insert(0,
                new AppDBDatalayer.Models.Country()
                {
                    Name = "Canada"
                }
                );
            countryComboBox.DataSource = countryList;
            countryComboBox.DisplayMember = "Name";

            provinceStateComboBox.DataSource = provinceStateList;
            provinceStateComboBox.DisplayMember = "Name";
        }
    }
}
