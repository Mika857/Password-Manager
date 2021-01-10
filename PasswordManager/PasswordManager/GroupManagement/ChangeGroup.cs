using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PasswordManager.GroupManagement;

namespace PasswordManager
{
    public partial class ChangeGroup : Form
    {
        GroupData gData;
        Data data;
        int index;
        string currentUser;

        Form1 form1;
        public ChangeGroup(Password password, int index, string currentUser, Form1 form1)
        {
            InitializeComponent();
            this.index = index;
            this.currentUser = currentUser;
            this.form1 = form1;

            gData = SaveLoadManager.LoadGroups();
            data = SaveLoadManager.Load(currentUser);
            
            if(data != null)
            {
                foreach(GroupClass gClass in gData.groupList)
                {
                    groupBox.Items.Add(gClass.GroupName);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sortButton_Click(object sender, EventArgs e)
        {
            if (!GroupExists(groupBox.Text))
            {
                GroupClass newGClass = new GroupClass(groupBox.Text);
                gData.groupList.Add(newGClass);
            }

            data.passwords[index].groupName = groupBox.Text;

            SaveLoadManager.Save(data, currentUser);
            SaveLoadManager.Save(gData);

            form1.ReloadForm();
            this.Close();
        }

        private bool GroupExists(string name)
        {
            foreach (GroupClass gClass in gData.groupList)
            {
                if(gClass.GroupName == name)
                {
                    return true;
                }
            }

            return false;
        }

        private void groupBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ReloadForm()
        {
            gData = SaveLoadManager.LoadGroups();
            groupBox.Items.Clear();
            if(gData != null)
            {
                foreach(GroupClass name in gData.groupList)
                {
                    groupBox.Items.Add(name.GroupName);
                }
            }
        }

        private void manageGroupButton_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.Name == "ManageGroup") return;
            }

            ManageGroups fm = new ManageGroups(currentUser, ReloadForm);

            fm.Show();
        }
    }
}
