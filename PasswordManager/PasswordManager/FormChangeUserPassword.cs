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
    public enum UserOptions { Username, Password };
    public partial class FormChangeUserPassword : Form
    {
        string currentUser;
        SaveUsers saveUsers;
        UserOptions userOption;
        Form1 form1;
        public FormChangeUserPassword(string currUser, UserOptions option, Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
            userOption = option;
            currentUser = currUser;

            saveUsers = SaveLoadManager.LoadUsers();

            if(userOption == UserOptions.Password)
            {
                string password = "";

                for (int i = 0; i < saveUsers.userList.Count; i++)
                {
                    if (saveUsers.userList[i].username == currentUser)
                    {
                        password = saveUsers.userList[i].password;
                        break;
                    }
                }

                changeBox.Text = password;

                changeBox.UseSystemPasswordChar = true;
            }
            else
            {
                changeBox.Text = currentUser;

                changeBox.UseSystemPasswordChar = false;
            }

            changeBox.KeyDown += changeBox_KeyDown;
            
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            SaveUserPassword();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            form1.Show();
        }

        private void changeBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                SaveUserPassword();
            }
        }

        private void SaveUserPassword()
        {
            for (int i = 0; i < saveUsers.userList.Count; i++)
            {
                if (saveUsers.userList[i].username == currentUser)
                {
                    if (userOption == UserOptions.Password) //change password
                    {
                        saveUsers.userList[i].password = changeBox.Text;
                    }
                    else //change username
                    {
                        bool alreadyExisting = false;

                        for (int j = 0; j < saveUsers.userList.Count; j++)
                        {
                            if (currentUser == saveUsers.userList[j].username) continue;

                            if (saveUsers.userList[j].username.ToLower() == changeBox.Text.ToLower())
                            {
                                alreadyExisting = true;
                                string message = "Username already exists! Choose another";
                                string caption = "Rename User";
                                MessageBoxButtons buttons = MessageBoxButtons.OK;

                                MessageBox.Show(message, caption, buttons);
                                break;
                            }
                        }

                        if (!alreadyExisting)
                        {
                            saveUsers.userList[i].username = changeBox.Text;
                            form1.ChangeUsername(changeBox.Text);

                            string place = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/Mika/";
                            string path = place + currentUser;
                            if (Directory.Exists(path))
                            {
                                string tempPath = path + "_temp";

                                Directory.Move(path, tempPath);

                                Directory.Move(tempPath, place + changeBox.Text);
                            }
                        }
                    }

                    break;
                }
            }

            SaveLoadManager.SaveUser(saveUsers);
            this.Close();
            form1.Show();
        }
    }
}
