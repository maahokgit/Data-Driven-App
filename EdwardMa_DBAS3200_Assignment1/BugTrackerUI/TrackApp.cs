using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Configuration;
using DataLayer;

namespace BugTrackerUI
{
    public partial class TrackApp : Form
    {
        public TrackApp()
        {
            InitializeComponent();
        }

        private void TrackApp_Load(object sender, EventArgs e)
        {
            try
            {
                //point the value of |DataDirectory| at our database in the datalayer
                string dataDirectory = ConfigurationManager.ConnectionStrings.ToString();
                string absoluteDataDirectory = Path.GetFullPath(dataDirectory);
                AppDomain.CurrentDomain.SetData("DataDirectory", absoluteDataDirectory);

                
                //set application name
                //applicationName = ConfigurationManager.AppSettings["ApplicationName"].ToString();

                //set connection settings
                //DataLayer.DB.ApplicationName = applicationName;
                DataLayer.DB.ConnectionTimeout = 30;

                //load employees into listbox
                //LoadEmployeesList();
                LoadAppListBox();

                //load any existing application log entries
                //DataTable logTable = DataLayer.ApplicationLog.GetLog(applicationName);
                //dataGridViewApplicationLog.DataSource = logTable;
            }
            catch (SqlException sqlex)
            {
                //connection error...
                DisplayErrorMessage(sqlex.Message);
            }
        }

        private void LoadAppListBox()
        {
            try
            {
                //DataLayer. employees = new DataLayer.Employees();
                Applications applications = new Applications();
                //listBoxEmployees.DataSource = employees.GetList();
                appListBox.DataSource = applications.GetAppList();
                //listBoxEmployees.DisplayMember = "FullName";
                appListBox.DisplayMember = "AppName";
            }
            catch (SqlException sqlex)
            {
                //connection error...
                DisplayErrorMessage(sqlex.Message);
            }
        }

        private void DisplayErrorMessage(string message)
        {
            MessageBox.Show(this,
                message,
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }

        private void appListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Applications.Application selectApp = (Applications.Application)appListBox.SelectedValue;

            appIDTextBox.Text = selectApp.AppID.ToString();
            appNameTextBox.Text = selectApp.AppName.ToString();
            appVersionTextBox.Text = selectApp.AppVersion.ToString();
            appDescTextBox.Text = selectApp.AppDesc.ToString();
        }
    }
}
