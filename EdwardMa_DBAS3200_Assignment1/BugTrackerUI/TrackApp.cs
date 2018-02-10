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
        Applications applications = new Applications();
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
            else
            {
                appIDTextBox.Text = null;
                appNameTextBox.Text = null;
                appVersionTextBox.Text = null;
                appDescTextBox.Text = null;
            }
        }

        private void appDelBtn_Click(object sender, EventArgs e)
        {
            //if it's not add new... 
            //then run delete app procedure
            //side note: i should probably log this....
        }

        private void appSaveBtn_Click(object sender, EventArgs e)
        {
            //if add new then run insert app procedure
            if (appListBox.SelectedIndex == 0)
            {
                applications.InsertApp(appNameTextBox.Text, appVersionTextBox.Text, appDescTextBox.Text);
                MessageBox.Show("Application Added!");
            }
            else //else run update app procedure
            {
                applications.UpdateApp(appNameTextBox.Text, appVersionTextBox.Text, appDescTextBox.Text);
                MessageBox.Show("Application updated!");
            }
            
        }
    }
}
