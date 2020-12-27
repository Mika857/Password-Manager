using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordManager
{
    public partial class ListItem : UserControl
    {
        bool editing;
        string currentUser;
        public ListItem(string currUser)
        {
            InitializeComponent();
            //BackColor = Color.White;
            editing = false;
            toolTip2.Active = false;
            pictureBox6.Visible = false;
            currentUser = currUser;
        }

        #region Properties

        private string nameApp;

        [Category("Custom Props")]
        public string NameApp
        {
            get { return nameApp; }
            set { nameApp = value; label1.Text = value; }
        }

        private string email;

        [Category("Custom Props")]
        public string Email
        {
            get { return email; }
            set { email = value; label3.Text = "E-mail: " + value; }
        }

        private string username;

        [Category("Custom Props")]
        public string Username
        {
            get { return username; }
            set { username = value; label2.Text = "Username: " + value; }
        }

        private string password;

        [Category("Custom Props")]
        public string Password
        {
            get { return password; }
            set { password = value; label4.Text = "Password: " + value; }
        }

        private Password passwordClass;

   
        public Password PasswordClass
        {
            get { return passwordClass; }
            set { passwordClass = value; }
        }

        //vorrübergehend - muss bessere lösung gefunden werden

        private Form1 form1;

        public Form1 LinkForm1
        {
            get { return form1; }
            set { form1 = value; }
        }

        private int passwordNumber;

        public int PasswordNumber
        {
            get { return passwordNumber; }
            set { passwordNumber = value; }
        }



        #endregion

        private void ListItem_Load(object sender, EventArgs e)
        {
            //BackColor = Color.White;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if(editing)
            {
                FormChangeProp newForm = new FormChangeProp(form1,passwordNumber,"name",nameApp, currentUser);
                newForm.Text = "Change Name";
                newForm.Show();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            if(editing)
            {
                FormChangeProp newForm = new FormChangeProp(form1, passwordNumber, "username", username, currentUser);
                newForm.Text = "Change Username";
                newForm.Show();
            }
            else
            {
                if (username != "")
                {
                    Clipboard.SetText(username);
                }
            }
            
                
        }

        private void label3_Click(object sender, EventArgs e)
        {
            if (editing)
            {
                FormChangeProp newForm = new FormChangeProp(form1, passwordNumber, "email", email, currentUser);
                newForm.Text = "Change Email";
                newForm.Show();
            }
            else
            {
                if (email != "")
                {
                    Clipboard.SetText(email);
                }
            }
            
        }

        private void label4_Click(object sender, EventArgs e)
        {
            if(editing)
            {
                FormChangeProp newForm = new FormChangeProp(form1, passwordNumber, "password",password,currentUser);
                newForm.Text = "Change Password";
                newForm.Show();
            }
            else
            {
                if(password != "")
                {
                    Clipboard.SetText(password);
                } 
            }
             
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        #region RemoveItem
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if(!editing)
            {
                form1.data.Remove(passwordNumber);
                this.Hide();
                SaveLoadManager.Save(form1.data,currentUser);
                form1.ReloadForm(sender, e);
            }
        }
        #endregion

        #region moveItemUp
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //move up in array
            if(passwordNumber > 0 && !editing)
            {
                Password oldPa = form1.data.passwords[passwordNumber - 1];
                form1.data.passwords[passwordNumber - 1] = form1.data.passwords[passwordNumber];
                form1.data.passwords[passwordNumber] = oldPa;
                passwordNumber--;
                SaveLoadManager.Save(form1.data,currentUser);

                form1.ReloadForm(sender, e);
            }
        }
        #endregion

        #region moveItemDown
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            //move up in array
            if (passwordNumber < form1.data.passwords.Length-1 && !editing)
            {
                int oldNumber = PasswordNumber + 1;
                //Data update
                Password oldPa = form1.data.passwords[oldNumber];
                form1.data.passwords[oldNumber] = form1.data.passwords[passwordNumber];
                form1.data.passwords[passwordNumber] = oldPa;
                passwordNumber++;
                SaveLoadManager.Save(form1.data,currentUser);

                //Update form
                //ListItem oldItem = form1.listItems[oldNumber];
                //form1.listItems[oldNumber] = form1.listItems[passwordNumber];
                //form1.listItems[passwordNumber] = oldItem;

                form1.ReloadForm(sender, e);
            }
        }
        #endregion

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (!editing) //edit mode
            {
                editing = !editing;
                toolTip2.Active = true;
                toolTip1.Active = false;
                pictureBox6.Visible = true;
                pictureBox5.Visible = false;

            }
            else//non edit mode
            {
                editing = !editing;
                toolTip1.Active = true;
                toolTip2.Active = false;
                pictureBox6.Visible = false;
                pictureBox5.Visible = true;
            }
        }
    }
}
