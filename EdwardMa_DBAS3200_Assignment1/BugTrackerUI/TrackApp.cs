using System;
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
        Users users = new Users();

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

                //load User list into Listbox
                LoadUserListBox();

            }
            catch (SqlException sqlex)
            {
                //connection error...
                DisplayErrorMessage(sqlex.Message);
            }
        }

        //method to load list of user into ListBox
        private void LoadUserListBox()
        {
            try
            {
                List<Users.User> myUserList = users.GetUserList();

                myUserList.Insert(0,
                    new Users.User()
                    {
                        UserName = "<Add New>"
                    }
                );
                userListBox.DataSource = myUserList;
                userListBox.DisplayMember = "UserName";
            }
            catch (SqlException sqlex)
            {
                //connection error...
                DisplayErrorMessage(sqlex.Message);
            }
        }

        //method to load list of application into Listbox
        private void LoadAppListBox()
        {
            try
            {
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

        /// <summary>
        /// Method that when end-user select a user, it will populate 
        /// the information in the field
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void userListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Users.User selectUser = (Users.User)userListBox.SelectedValue;
            //if it's not Add New Users.. then
            //if it's not <Add New> then...do that
            if (selectUser.UserID != 0)
            {
                userIDTextBox.Text = selectUser.UserID.ToString();
                userNameTextBox.Text = selectUser.UserName.ToString();
                userEmailTextBox.Text = selectUser.UserEmail.ToString();
                userPhoneTextBox.Text = selectUser.UserTel.ToString();
            }
            //if it is... null everything!
            else
            {
                userIDTextBox.Text = null;
                userNameTextBox.Text = null;
                userEmailTextBox.Text = null;
                userPhoneTextBox.Text = null;
            }
        }

        private void userSaveBtn_Click(object sender, EventArgs e)
        {
            //if it's not add new... 
            if (userListBox.SelectedIndex != 0)
            {
                users.DeleteUser(userNameTextBox.Text);
                MessageBox.Show("Deleted Application");
            }
            //then run delete app procedure
            else
            {
                MessageBox.Show("Please Select a User to Delete!");
            }
            //side note: i should probably log this....
        }

        private void userDeleteBtn_Click(object sender, EventArgs e)
        {
            //if add new then run insert app procedure
            if (userListBox.SelectedIndex == 0)
            {
                users.InsertUser(userNameTextBox.Text, userEmailTextBox.Text, userPhoneTextBox.Text);
                MessageBox.Show("Added User!");
            }
            //else run update app procedure
            else
            {
                users.UpdateUser(userNameTextBox.Text, userEmailTextBox.Text, userPhoneTextBox.Text);
                MessageBox.Show("Updated User!");
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

        /// <summary>
        /// Method that when end-user select an item from ListBox, it will show details
        /// in other fields.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void appListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Applications.Application selectApp = (Applications.Application)appListBox.SelectedValue;
            //if it's not <Add New> then...do that
            if (selectApp.AppID != 0)
            {
                appIDTextBox.Text = selectApp.AppID.ToString();
                appNameTextBox.Text = selectApp.AppName.ToString();
                appVersionTextBox.Text = selectApp.AppVersion.ToString();
                appDescTextBox.Text = selectApp.AppDesc.ToString();
            }
            //if it is... null everything!
            else
            {
                appIDTextBox.Text = null;
                appNameTextBox.Text = null;
                appVersionTextBox.Text = null;
                appDescTextBox.Text = null;
            }
        }

        //method for delete button in Application Tab
        private void appDelBtn_Click(object sender, EventArgs e)
        {
            //if it's not add new... 
            if (appListBox.SelectedIndex != 0)
            {
                applications.DeleteApp(appNameTextBox.Text);
                MessageBox.Show("Deleted Application");
            }
            //then run delete app procedure
            else
            {
                MessageBox.Show("Please Select an Application to Delete!");
            }
            //side note: i should probably log this....
        }

        //method for save or update button in Application Tab
        private void appSaveBtn_Click(object sender, EventArgs e)
        {
            //if add new then run insert app procedure
            if (appListBox.SelectedIndex == 0)
            {
                applications.InsertApp(appNameTextBox.Text, appVersionTextBox.Text, appDescTextBox.Text);
                MessageBox.Show("Added Application!");
            }
            //else run update app procedure
            else 
            {
                applications.UpdateApp(appNameTextBox.Text, appVersionTextBox.Text, appDescTextBox.Text);
                MessageBox.Show("Updated Application!");
            }
        }
    }
}
