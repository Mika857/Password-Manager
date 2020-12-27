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
    public partial class Form2 : Form
    {
        private static Random ran = new Random();
        string currentUser;
        public Form2(string curUser)
        {
            InitializeComponent();
            currentUser = curUser;
        }

        string[] passwordAvailable = { "ABCDEFGHIJKLMNOPQRSTUVWXYZ", "abcdefghijklmnopqrstuvwxyz", "1234567890", "_/()=?"};

        

        private void button1_Click(object sender, EventArgs e)
        {
            string finalPassword = "";

            for(int i = 0;i < numericUpDown1.Value;i++)
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
            //Save new password to existing passwords

            Data data = SaveLoadManager.Load(currentUser);
            List<Password> existingList = new List<Password>();
            

            if(data != null)
            {
                for(int i = 0; i < data.passwords.Length;i++)
                {
                    existingList.Add(data.passwords[i]);
                }
            }

            //create new password 
            Password newPassword = new Password(AppName.Text, Email.Text, Username.Text, Password.Text);

            existingList.Add(newPassword);

            Password[] newArr = new Password[existingList.Count];

            for (int i = 0; i < existingList.Count; i++)
            {
                newArr[i] = existingList[i];
            }

            Data newData = new Data(newArr);

            SaveLoadManager.Save(newData,currentUser);

            this.Hide();

            Form1 newForm = new Form1(currentUser);

            newForm.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form1 newForm = new Form1(currentUser);

            newForm.Show();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
