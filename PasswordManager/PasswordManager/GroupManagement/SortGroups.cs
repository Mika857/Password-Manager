using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordManager
{
    public partial class SortGroups : Form
    {
        Form lastForm;

        GroupData data;

        public SortGroups(Form lastForm)
        {
            InitializeComponent();

            this.lastForm = lastForm;

            data = SaveLoadManager.LoadGroups();

            groupBox.Items.Add("- All Groups -");

            if (data != null)
            {
                foreach(GroupClass item in data.groupList)
                {
                    groupBox.Items.Add(item.GroupName);
                }
            }

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            lastForm.Show();
        }

        private void sortButton_Click(object sender, EventArgs e)
        {
            Form1 form1 = (Form1)lastForm;
            if (groupBox.SelectedItem != null && data != null && groupBox.Text != "- All Groups -")
            {
                foreach (GroupClass item in data.groupList)
                {
                    if(item.GroupName == groupBox.Text)
                    {
                        form1.ReloadForm(item.GroupName);
                        return;
                    }
                }
            }
            else
            {
                form1.ReloadForm();
            }
        }
    }
}
