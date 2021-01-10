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
        public ListItem(string currUser, Password password, Form1 form1, int passwordNumber)
        {
            InitializeComponent();
            //BackColor = Color.White;
            editing = false;
            toolTip2.Active = false;
            pictureBox6.Visible = false;
            currentUser = currUser;

            this.passwordClass = password;
            this.NameApp = password.name;
            this.Email = password.email;
            this.Username = password.username;
            this.Password = password.password;
            this.GroupName = password.groupName;
            this.form1 = form1;
            this.passwordNumber = passwordNumber;

            label1.MouseEnter += new System.EventHandler(label1_MouseHover);
            label2.MouseEnter += new System.EventHandler(label2_MouseHover);
            label3.MouseEnter += new System.EventHandler(label3_MouseHover);
            label4.MouseEnter += new System.EventHandler(label4_MouseHover);
            groupLabel.MouseEnter += new System.EventHandler(groupLabel_MouseHover);


            label1.MouseLeave += new System.EventHandler(label1_MouseLeave);
            label2.MouseLeave += new System.EventHandler(label2_MouseLeave);
            label3.MouseLeave += new System.EventHandler(label3_MouseLeave);
            label4.MouseLeave += new System.EventHandler(label4_MouseLeave);
            groupLabel.MouseLeave += new System.EventHandler(groupLabel_MouseLeave);
        }

        #region Properties
        //set by "propfull"
        private string nameApp;

        [Category("Custom Props")]
        public string NameApp
        {
            get { return nameApp; }
            set 
            { 
                nameApp = value; 

                label1.Text = value; 

                if(value == "")
                {
                    label1.Text = "Name";
                }
            }
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

        private string groupName;

        public string GroupName
        {
            get { return groupName; }
            set 
            { 
                groupName = value;
                string currName = "-None-";

                if(value != "")
                {
                    currName = value;
                }

                groupLabel.Text = "Group: " + currName;  
            }
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
                form1.Hide();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            if(editing)
            {
                FormChangeProp newForm = new FormChangeProp(form1, passwordNumber, "username", username, currentUser);
                newForm.Text = "Change Username";
                newForm.Show();
                form1.Hide();
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
                form1.Hide();
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
                form1.Hide();
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
                form1.data.passwords.Remove(PasswordClass);
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
            if (passwordNumber < form1.data.passwords.Count-1 && !editing)
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

        #region Edit Mode
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
        #endregion

        #region Underline labels by hovering over them
        private void label1_MouseHover(object sender, System.EventArgs e)
        {
            if(editing)
            {
                label1.Font = new Font(label1.Font, FontStyle.Underline | FontStyle.Bold);
            }
        }

        private void label2_MouseHover(object sender, System.EventArgs e)
        {
            label2.Font = new Font(label2.Font,FontStyle.Underline);
        }

        private void label3_MouseHover(object sender, System.EventArgs e)
        {
            label3.Font = new Font(label3.Font, FontStyle.Underline);
        }

        private void label4_MouseHover(object sender, System.EventArgs e)
        {
            label4.Font = new Font(label4.Font, FontStyle.Underline);
        }

        private void groupLabel_MouseHover(object sender, EventArgs e)
        {

            if(editing) groupLabel.Font = new Font(groupLabel.Font, FontStyle.Underline | FontStyle.Bold);
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.Font = new Font(label1.Font, FontStyle.Bold);
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.Font = new Font(label2.Font, FontStyle.Regular);
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            label3.Font = new Font(label3.Font, FontStyle.Regular);
        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            label4.Font = new Font(label4.Font, FontStyle.Regular);
        }

        private void groupLabel_MouseLeave(object sender, EventArgs e)
        {
            groupLabel.Font = new Font(groupLabel.Font, FontStyle.Bold);
        }
        #endregion

        private void groupLabel_Click(object sender, EventArgs e)
        {
            if(editing)
            {
               

                //if form is not yet opened
                foreach(Form form in Application.OpenForms)
                {
                    if(form.Name == "ChangeGroup")
                    {
                        form.Show();
                        return;
                    }
                }

                ChangeGroup fm = new ChangeGroup(PasswordClass,passwordNumber,currentUser,form1);
                fm.Show();
            }
        }
    }
}
