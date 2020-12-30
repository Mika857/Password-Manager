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
    public partial class FormChangeProp : Form
    {
        Form1 form;
        int index;
        string change,currentUser;
        public FormChangeProp(Form1 form1,int index,string change,string currentInput,string currUser)
        {
            InitializeComponent();
            form = form1;
            this.index = index;
            this.change = change;
            changeBox.Text = currentInput;
            currentUser = currUser;

            changeBox.KeyDown += changeBox_KeyDown;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            SaveNewProps(sender, e);   
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
            form.Show();
        }

        private void changeBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                SaveNewProps(sender, e);
            }   
        }

        private void SaveNewProps(object sender, EventArgs e)
        {
            switch (change)
            {
                case "name":
                    form.data.passwords[index].name = changeBox.Text;
                    break;

                case "username":
                    form.data.passwords[index].username = changeBox.Text;
                    break;

                case "email":
                    form.data.passwords[index].email = changeBox.Text;
                    break;

                case "password":
                    form.data.passwords[index].password = changeBox.Text;
                    break;
            }

            SaveLoadManager.Save(form.data, currentUser);
            form.ReloadForm(sender, e);
            this.Close();
            form.Show();
        }
    }
}
