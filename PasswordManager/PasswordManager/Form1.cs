using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using PasswordManager.GroupManagement;

namespace PasswordManager
{
    public partial class Form1 : Form
    {
        public Data data;

        private bool passwordsShown;

        public string currentUser;

       // public List<ListItem> listItems = new List<ListItem>();
        public Form1(string currentUser)
        {
            InitializeComponent();

            passwordsShown = true;
            this.currentUser = currentUser;
            userLabel.Text = "User: " + currentUser;

            data = SaveLoadManager.Load(currentUser);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //load all passwords
            data = SaveLoadManager.Load(currentUser);

            if (data != null)
            {
                for (int i = 0; i < data.passwords.Count; i++)
                {
                    ListItem litem = new ListItem(currentUser,data.passwords[i],this,i);

                    Console.WriteLine(litem.GroupName);

                    passwordContainer.Controls.Add(litem);
                    litem.Show();
                    //listItems.Add(litem);
                }
            }


        }

        

        

        public void ReloadForm(object sender, EventArgs e)
        {
            passwordContainer.Controls.Clear();
            //InitializeComponent();
            Form1_Load(sender, e);
        }

        public void ReloadForm()
        {
            object sender = new object();
            EventArgs e = new EventArgs();

            passwordContainer.Controls.Clear();
            Form1_Load(sender, e);
        }

        public void ReloadForm(string groupName)
        {
            passwordContainer.Controls.Clear();

            if(data != null)
            {
                for (int i = 0; i < data.passwords.Count; i++)
                {
                    Password password = data.passwords[i];
                    if (password.groupName == groupName)
                    {
                        ListItem litem = new ListItem(currentUser, password, this, i);
                        passwordContainer.Controls.Add(litem);
                        litem.Show();
                    }
                }
            }

            
        }

      

      
        private void logOutButton_Click(object sender, EventArgs e)
        {

            User form = new User();
            form.Show();

            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {
                if (Application.OpenForms[i].Name != form.Name) Application.OpenForms[i].Close();
            }


            //bud but easy fix
            //Application.Restart();
        }

        private void deletUserButton_Click(object sender, EventArgs e)
        {
            string message = "Would you like to delete the user: " + currentUser;
            string caption = "Delete User";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;
            result = MessageBox.Show(message, caption, buttons);

            if(result == DialogResult.Yes)
            {
                UserData users = SaveLoadManager.Load();

                if (users != null)
                {
                    for (int i = 0; i < users.userList.Count; i++)
                    {
                        if (users.userList[i].username == currentUser)
                        {
                            users.userList.RemoveAt(i);
                        }
                    }

                    SaveLoadManager.Save(users);

                    string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/Mika/" + currentUser;
                    if (Directory.Exists(path))
                    {
                        Directory.Delete(path, true);
                    }


                    logOutButton_Click(sender, e);
                }
            }

            
            
        }

        #region Change Password
        private void changePasswordButton_Click(object sender, EventArgs e)
        {
            FormChangeUserPassword form = new FormChangeUserPassword(currentUser,UserOptions.Password,this);
            form.Show();
            this.Hide();
        }
        #endregion

        #region Change Username
        private void changeUsernameButton_Click(object sender, EventArgs e)
        {
            FormChangeUserPassword form = new FormChangeUserPassword(currentUser, UserOptions.Username, this);
            form.Show();
            this.Hide();
        }
        #endregion

        public void ChangeUsername(string username)
        {
            currentUser = username;
            userLabel.Text = "User: " + currentUser;
        }

        private void alphabetSortButton_Click(object sender, EventArgs e)
        {
            //sort list by alphabet | x - 'A': number starting with 0 

     

            if(data.passwords.Count > 1)
            {
                for (int i = 1; i < data.passwords.Count; i++)
                {
                    for (int j = 0; j < data.passwords.Count - (i); j++)
                    {
                        char firstLetter1 = data.passwords[j].name.ToLower()[0];
                        char firstLetter2 = data.passwords[j + 1].name.ToLower()[0];

                        int num1 = firstLetter1 - 'A';
                        int num2 = firstLetter2 - 'A';

                        if (num1 > num2) //change position
                        {
                            Password rePassword = data.passwords[j];
                            data.passwords[j] = data.passwords[j + 1];
                            data.passwords[j + 1] = rePassword;
                        }
                    }
                }

                SaveLoadManager.Save(data, currentUser);

                ReloadForm();
            }
        }

        

        private void manageGroupsButton_Click(object sender, EventArgs e)
        {
            foreach(Form form in Application.OpenForms)
            {
                if (form.Name == "ManageGroup") return;
            }

            ManageGroups fm = new ManageGroups(currentUser, ReloadForm);

            fm.Show();
        }

        private void newpasswordButton_Click(object sender, EventArgs e)
        {
            Form2 newForm = new Form2(currentUser, this);

            newForm.Show();
            this.Hide();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

     
        private void hideShowButton_Click(object sender, EventArgs e)
        {
            if (!passwordsShown) //show passwords
            {
                passwordContainer.Show();
                passwordsShown = !passwordsShown;
                hideShowButton.Text = "Hide Passwords";
            }
            else // hide passwords
            {
                passwordContainer.Hide();
                passwordsShown = !passwordsShown;
                hideShowButton.Text = "Show Passwords";
            }
        }

        private void sortGroupsButton_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.Name == "SortGroups")
                {
                    form.Show();
                    return;
                }
            }

            SortGroups groups = new SortGroups(this);
            groups.Show();
        }
    }
}
