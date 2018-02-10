using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Configuration;
using DataLayer;
using System.Collections.Generic;

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
                DB.ConnectionTimeout = 30;

                //load Application list into listbox
                LoadAppListBox();

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
                Applications applications = new Applications();
                List<Applications.Application> myAppList = applications.GetAppList();

                myAppList.Insert(0,
                    new Applications.Application()
                    {
                        AppName = "<Add New>"
                    }
                );
                appListBox.DataSource = myAppList;
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
            if (selectApp.AppID != 0)
            {
                appIDTextBox.Text = selectApp.AppID.ToString();
                appNameTextBox.Text = selectApp.AppName.ToString();
                appVersionTextBox.Text = selectApp.AppVersion.ToString();
                appDescTextBox.Text = selectApp.AppDesc.ToString();
            }
        }
    }
}
