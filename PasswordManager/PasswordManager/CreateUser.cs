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
    public partial class CreateUser : Form
    {
        UserData users;
        public CreateUser()
        {
            InitializeComponent();

            users = new UserData(new List<UserClass>(), "");
            
            UserData dataUser = SaveLoadManager.Load();

            if (dataUser != null)
            {
                users = dataUser;
            }

          
            textBox2.KeyDown += textBox2_KeyDown;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreateNewUser();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
            User form = new User();
            form.Show();
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                CreateNewUser();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void CreateNewUser()
        {
            bool alreadyUsed = false;

            for (int i = 0; i < users.userList.Count; i++)
            {
                if (Username.Text == users.userList[i].username)
                {
                    alreadyUsed = true;
                    break;
                }
            }

            if (alreadyUsed)
            {
                string msg = "User already exists!";
                string cap = "Create User";
                MessageBoxButtons but = MessageBoxButtons.OK;

                MessageBox.Show(msg, cap, but);
            }
            else if (Username.Text != "" && textBox1.Text != "" && textBox2.Text == textBox1.Text)
            {
                UserClass newUser = new UserClass(Username.Text, textBox1.Text);
                users.userList.Add(newUser);
                users.lastUser = Username.Text;
                SaveLoadManager.Save(users);

                Form1 form = new Form1(Username.Text);

                form.Show();
                this.Close();
            }
        }
    }
}
