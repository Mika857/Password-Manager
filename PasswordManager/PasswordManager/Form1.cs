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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 newForm = new Form2(currentUser);

            newForm.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //load all passwords
            data = SaveLoadManager.Load(currentUser);

            if (data != null)
            {
                for (int i = 0; i < data.passwords.Length; i++)
                {
                    ListItem litem = new ListItem(currentUser);
                    litem.Email = data.passwords[i].email;
                    litem.Password = data.passwords[i].password;
                    litem.NameApp = data.passwords[i].name;
                    litem.Username = data.passwords[i].username;
                    litem.PasswordClass = data.passwords[i];
                    litem.LinkForm1 = this;
                    litem.PasswordNumber = i;
                    passwordContainer.Controls.Add(litem);
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(!passwordsShown) //show passwords
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

        private void logOutButton_Click(object sender, EventArgs e)
        {
            User form = new User();
            form.Show();
            this.Close();
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
                SaveUsers users = SaveLoadManager.LoadUsers();

                if (users != null)
                {
                    for (int i = 0; i < users.userList.Count; i++)
                    {
                        if (users.userList[i].username == currentUser)
                        {
                            users.userList.RemoveAt(i);
                        }
                    }

                    SaveLoadManager.SaveUser(users);

                    string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/Mika/" + currentUser;
                    if (Directory.Exists(path))
                    {
                        Directory.Delete(path, true);
                    }


                    logOutButton_Click(sender, e);
                }
            }

            
            
        }
    }
}
