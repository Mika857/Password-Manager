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
    public partial class User : Form
    {
        //public event System.Windows.Forms.KeyPressEventHandler KeyPress;
        List<UserClass> users = new List<UserClass>();
        string lastUser = "";
        public User()
        {
            InitializeComponent();

            UserData dataUser = SaveLoadManager.Load();

            if(dataUser != null)
            {
                users = dataUser.userList;
                lastUser = dataUser.lastUser;
            }

            textBox1.KeyDown += TextBox1_KeyDown;
            Username.Text = lastUser;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                CheckUser();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreateUser form = new CreateUser();
            form.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CheckUser();
        }

        private void CheckUser()
        {
            for (int i = 0; i < users.Count; i++)
            {
                if (Username.Text == users[i].username && textBox1.Text == users[i].password)
                {
                    Form1 form = new Form1(users[i].username);
                    UserData userClass = new UserData(users, Username.Text);
                    SaveLoadManager.Save(userClass);
                    form.Show();
                    this.Hide();
                    return;
                }
                else
                {
                    if (Username.Text == users[i].username && textBox1.Text != users[i].password)
                    {
                        string msg = "Wrong Passsword!";
                        string cap = "Log In Error";
                        MessageBoxButtons but = MessageBoxButtons.OK;

                        MessageBox.Show(msg, cap, but);
                        return;
                    }
                }

            }

            string message = "Wrong User!";
            string caption = "Log In Error";
            MessageBoxButtons buttons = MessageBoxButtons.OK;

            MessageBox.Show(message, caption, buttons);
        }
    }
}
