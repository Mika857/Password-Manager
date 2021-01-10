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
    public partial class Form2 : Form
    {
        private static Random ran = new Random();
        string currentUser;
        Form lastForm;

        GroupData groupData;
        public Form2(string curUser, Form lastForm)
        {
            InitializeComponent();
            currentUser = curUser;
            Password.KeyDown += Password_KeyDown;
            this.lastForm = lastForm;

            groupData = SaveLoadManager.LoadGroups();

            if(groupData != null)
            {
                for (int i = 0; i < groupData.groupList.Count; i++)
                {
                    comboBox1.Items.Add(groupData.groupList[i].GroupName);
                }
            }
            else
            {
                groupData = new GroupData(new List<GroupClass>());
            }
        }

        string[] passwordAvailable = { "ABCDEFGHIJKLMNOPQRSTUVWXYZ", "abcdefghijklmnopqrstuvwxyz", "1234567890", "_/()=?"};

        

        private void button1_Click(object sender, EventArgs e)
        {
            string finalPassword = "";

            for (int i = 0; i < numericUpDown1.Value; i++)
            {
                int chapter = RandomInt(passwordAvailable.Length);
                string passSplit = passwordAvailable[chapter];
                int sign = RandomInt(passSplit.Length);

                finalPassword += passSplit[sign];
            }

            Password.Text = finalPassword;
        }

        private int RandomInt(int length)
        {
            int number = ran.Next(length);
            return number;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveNewPassword();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();

            lastForm.Show();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Password_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                SaveNewPassword();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void SaveNewPassword()
        {
            //Save new password to existing passwords

            Data data = SaveLoadManager.Load(currentUser);

            string groupName = "";

            int index = 0;
            bool exists = GroupExists(comboBox1.Text, ref index);

            if (!exists)
            {
                groupName = comboBox1.Text;
                GroupClass newGroup = new GroupClass(groupName);
                groupData.groupList.Add(newGroup);
                SaveLoadManager.Save(groupData);
            }
            else
            {
                groupName = comboBox1.Text;
            }

            Password newPassword = new Password(AppName.Text, Email.Text, Username.Text, Password.Text, groupName);

            if (data != null)
            {
                data.passwords.Add(newPassword);
            }
            else
            {
                List<Password> list = new List<Password>();
                list.Add(newPassword);
                data = new Data(list);
            }

            

            //create new password 
           

            SaveLoadManager.Save(data, currentUser);

            this.Close();

            lastForm.Show();
            Form1 lastForm1 = (Form1)lastForm;
            lastForm1.ReloadForm();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private bool GroupExists(string groupName, ref int index)
        {
            if(groupData != null)
            {
                for (int i = 0; i < groupData.groupList.Count; i++)
                {
                    if(groupData.groupList[i].GroupName == groupName)
                    {
                        index = i;
                        return true;
                    }
                }
            }

            return false;
        }

        private void ReloadForm()
        {
            groupData = SaveLoadManager.LoadGroups();
            comboBox1.Items.Clear();
            if(groupData != null)
            {
                foreach(GroupClass groupClass in groupData.groupList)
                {
                    comboBox1.Items.Add(groupClass.GroupName);
                }
            }
        }

        private void managaGroupsButton_Click(object sender, EventArgs e)
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
