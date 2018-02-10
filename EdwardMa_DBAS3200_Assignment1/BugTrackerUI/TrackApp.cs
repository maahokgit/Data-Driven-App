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

        private void appTabPage_Click(object sender, EventArgs e)
        {
            //load app list into listbox
            MessageBox.Show("Application Tab Clicked");
        }

        private void LoadAppListBox()
        {
            try
            {
                //DataLayer. employees = new DataLayer.Employees();
                DataLayer.Applications applications = new DataLayer.Applications();
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

    }
}
