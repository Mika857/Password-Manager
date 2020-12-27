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
        List<UserClass> users = new List<UserClass>();
        public User()
        {
            InitializeComponent();

            SaveUsers dataUser = SaveLoadManager.LoadUsers();

            if(dataUser != null)
            {
                users = dataUser.userList;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreateUser form = new CreateUser();
            form.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < users.Count; i++)
            {
                if(Username.Text == users[i].username && textBox1.Text == users[i].password)
                {
                    Form1 form = new Form1(users[i].username);
                    form.Show();
                    this.Hide();
                }
                else
                {
                    if(Username.Text == users[i].username && textBox1.Text != users[i].password)
                    {
                        string message = "Wrong Passsword!";
                        string caption = "Log In Error";
                        MessageBoxButtons buttons = MessageBoxButtons.OK;

                        MessageBox.Show(message, caption, buttons);
                    }
                    else
                    {
                        string message = "Wrong User!";
                        string caption = "Log In Error";
                        MessageBoxButtons buttons = MessageBoxButtons.OK;

                        MessageBox.Show(message, caption, buttons);
                    }
                }
            }
        }
    }
}
