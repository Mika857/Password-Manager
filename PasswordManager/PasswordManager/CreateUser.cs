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
        SaveUsers users;
        List<UserClass> userList;
        public CreateUser()
        {
            InitializeComponent();

            userList = new List<UserClass>();
            
            SaveUsers dataUser = SaveLoadManager.LoadUsers();

            if (dataUser != null)
            {
                userList = dataUser.userList;
            }

            users = new SaveUsers(userList);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(Username.Text != "" && textBox1.Text != "")
            {
                UserClass newUser = new UserClass(Username.Text,textBox1.Text);
                users.userList.Add(newUser);
                SaveLoadManager.SaveUser(users);
                Form1 form = new Form1(Username.Text);
                form.Show();
                this.Close();
            }
        }
    }
}
