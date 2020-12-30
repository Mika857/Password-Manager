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
        public User()
        {
            InitializeComponent();

            SaveUsers dataUser = SaveLoadManager.LoadUsers();

            if(dataUser != null)
            {
                users = dataUser.userList;
            }

            textBox1.KeyDown += TextBox1_KeyDown;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                CheckUser();
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
