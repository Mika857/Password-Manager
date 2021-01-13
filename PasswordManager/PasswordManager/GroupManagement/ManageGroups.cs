using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordManager.GroupManagement
{
    public partial class ManageGroups : Form
    {
        GroupData gData;
        string currentUser;

        Action action;
        public ManageGroups(string currentUser, Action action)
        {
            InitializeComponent();
            this.currentUser = currentUser;
            this.action = action;
            gData = SaveLoadManager.LoadGroups();

            if(gData == null)
            {
                gData = new GroupData(new List<GroupClass>());
            }

            newPasswordInput.SelectionAlignment = HorizontalAlignment.Center;

            panelRemoveGroup.Hide();
            renamePanel.Hide();

            ReloadRemoveBox();
            ReloadRenameBox();
        }

        private void ReloadRemoveBox()
        {
            if(gData != null)
            {
                removeBox.Items.Clear();
                foreach (GroupClass item in gData.groupList)
                {
                    removeBox.Items.Add(item.GroupName);
                }
            }
            
        }

        private void ReloadRenameBox()
        {
            if(gData != null)
            {
                renameBox.Items.Clear();
                foreach (GroupClass item in gData.groupList)
                {
                    renameBox.Items.Add(item.GroupName);
                }
            }
            
        }

        private void ManageGroups_Load(object sender, EventArgs e)
        {

        }

        private void saveNewGroup_Click(object sender, EventArgs e)
        {
            if(newPasswordInput.Text != "")
            {
                foreach(GroupClass item in gData.groupList)
                {
                    if(item.GroupName == newPasswordInput.Text)
                    {
                        string message = "this group already exists!";
                        string caption = "New Group";
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        MessageBox.Show(message, caption, buttons);
                        return;
                    }
                }
                

                GroupClass newClass = new GroupClass(newPasswordInput.Text);
                gData.groupList.Add(newClass);
                SaveLoadManager.Save(gData);
                ReloadRemoveBox();
                newPasswordInput.Text = "";
                action();
                ReloadRenameBox();
            }
        }

        private void addGroupButton_Click(object sender, EventArgs e)
        {
            panel2.Show();
            panel2.BringToFront();
            panelRemoveGroup.Hide();
            renamePanel.Hide();
        }

        private void removeGroupButton_Click(object sender, EventArgs e)
        {
            panel2.Hide();
            panelRemoveGroup.Show();
            panelRemoveGroup.BringToFront();
            renamePanel.Hide();
        }

        private void removeGroup_Click(object sender, EventArgs e)
        {
            {
                Data data = SaveLoadManager.Load(currentUser);

                if(data != null)
                {
                    foreach(Password password in data.passwords)
                    {
                        if(password.groupName == removeBox.Text)
                        {
                            password.groupName = "";
                        }
                    }
                }

                foreach (GroupClass item in gData.groupList)
                {
                    if(item.GroupName == removeBox.Text)
                    {
                        gData.groupList.Remove(item);
                        break;
                    }
                }
                SaveLoadManager.Save(gData);
                SaveLoadManager.Save(data, currentUser);
                ReloadRemoveBox();
                ReloadRenameBox();
                action();
            }
            
            
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void renameGroupButton_Click(object sender, EventArgs e)
        {
            panel2.Hide();
            panelRemoveGroup.Hide();
            renamePanel.Show();
            renamePanel.BringToFront();
        }

        private void renameButton_Click(object sender, EventArgs e)
        {
            if(renameTextBox.Text != "")
            {
                foreach (GroupClass item in gData.groupList)
                {
                    if (item.GroupName == renameTextBox.Text)
                    {
                        string message = "this group already exists!";
                        string caption = "Rename Group";
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        MessageBox.Show(message, caption, buttons);
                        renameTextBox.Text = "";
                        return;
                    }
                }

                Data data = SaveLoadManager.Load(currentUser);

                if (data != null)
                {
                    foreach (Password password in data.passwords)
                    {
                        if (password.groupName == renameBox.Text)
                        {
                            password.groupName = renameTextBox.Text;
                        }
                    }
                }

                for (int i = 0; i < gData.groupList.Count; i++)
                {
                    if(gData.groupList[i].GroupName == renameBox.Text)
                    {
                        gData.groupList[i].GroupName = renameTextBox.Text;
                        break;
                    }
                }


                SaveLoadManager.Save(gData);
                SaveLoadManager.Save(data, currentUser);
                ReloadRemoveBox();
                ReloadRenameBox();
                action();
                renameTextBox.Text = "";
            }
            
        }

       
    }
}
