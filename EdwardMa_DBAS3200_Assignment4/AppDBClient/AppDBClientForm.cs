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
        Container service, service2;
        private List<Campus> compusesWithProgramList;
        private List<AppDBDatalayer.Models.Program> programsOnCampusList;

        public AppDBClientForm()
        {
            InitializeComponent();
        }

        private void AppDBClientForm_Load(object sender, EventArgs e)
        {
            service = new Container(new Uri("http://appdbapi.azurewebsites.net/"));
            service2 = new Container(new Uri("http://appdbapi.azurewebsites.net/"));
            var genderList = service.Genders.OrderBy(g => g.Description).ToList();
            var countryList = service.Countries.OrderBy(c => c.Name).ToList();
            var citizenshipOtherList = service.Countries.OrderBy(c => c.Name).ToList();
            var citizenshipList = service.Citizenships.OrderBy(c => c.Id).ToList();

            var programList = service2.Programs.Expand(p => p.Campuses).ToList();
            //compusesWithProgramList = (programList[0].Campuses).ToList();

            var campusList = (service.Campuses.Expand(c => c.Programs)).ToList();
            //programsOnCampusList = (campusList[0].Programs).ToList();
            // (new System.Collections.Generic.Mscorlib_CollectionDebugView<AppDBClient.AppDBDatalayer.Models.Campus>(campusList).Items[0]).Programs
            // (new System.Collections.Generic.Mscorlib_CollectionDebugView<AppDBClient.AppDBDatalayer.Models.Program>((new System.Collections.Generic.Mscorlib_CollectionDebugView<AppDBClient.AppDBDatalayer.Models.Campus>(campusList).Items[0]).Programs).Items[1]).Name


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
            choiceOneProgramComboBox.DataSource = programList;
            choiceOneProgramComboBox.DisplayMember = "Name";

            choiceOneCampusComboBox.DataSource = campusList;
            choiceOneCampusComboBox.DisplayMember = "Name";

            //choiceTwoProgramComboBox.DataSource = programList;
            //choiceTwoProgramComboBox.DisplayMember = "Name";

            //choiceTwoCampusComboBox.DataSource = campusList;
            //choiceTwoCampusComboBox.DisplayMember = "Name";
        }

        //private void LoadchoiceOneCampusComboBox()
        //{
        //    var campusList = (service.Campuses.Expand(c => c.Programs)).ToList();
        //    choiceOneCampusComboBox.DataSource = campusList;
        //    choiceOneCampusComboBox.DisplayMember = "Name";
        //}

        //private void LoadchoiceOneProgramComboBox()
        //{
        //    var programList = service.Programs.Expand(p => p.Campuses).ToList();
        //    choiceOneProgramComboBox.DataSource = programList;
        //    choiceOneProgramComboBox.DisplayMember = "Name";
        //}

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

        private void citizenshipComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int Select = citizenshipComboBox.SelectedIndex;
            if (Select == 3)
            {
                citizenshipOtherComboBox.Enabled = true;
            }
        }

        private void choiceOneProgramComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //int i = choiceOneProgramComboBox.SelectedIndex;
            //var programList = service2.Programs.Expand(p => p.Campuses).ToList();
            //if (i > -1)
            //{
            //    compusesWithProgramList = (programList[i].Campuses).ToList();

            //    choiceOneCampusComboBox.DataSource = compusesWithProgramList;
            //    choiceOneCampusComboBox.DisplayMember = "Name";
            //}
        }

        private void choiceOneCampusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = choiceOneCampusComboBox.SelectedIndex;
            var campusList = service.Campuses.Expand(c => c.Programs).ToList();
            if (i > -1)
            {
                programsOnCampusList = (campusList[i].Programs).ToList();
               
                choiceOneProgramComboBox.DataSource = programsOnCampusList;
                choiceOneProgramComboBox.DisplayMember = "Name";
            }
        }
    }
}
