namespace PasswordManager
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.passwordContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.userLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.logOutButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.manageGroupsButton = new System.Windows.Forms.Button();
            this.deletUserButton = new System.Windows.Forms.Button();
            this.changePasswordButton = new System.Windows.Forms.Button();
            this.changeUsernameButton = new System.Windows.Forms.Button();
            this.sortGroupsButton = new System.Windows.Forms.Button();
            this.alphabetSortButton = new System.Windows.Forms.Button();
            this.hideShowButton = new System.Windows.Forms.Button();
            this.newpasswordButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // passwordContainer
            // 
            this.passwordContainer.AutoScroll = true;
            this.passwordContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.passwordContainer.Dock = System.Windows.Forms.DockStyle.Right;
            this.passwordContainer.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.passwordContainer.Location = new System.Drawing.Point(218, 0);
            this.passwordContainer.Name = "passwordContainer";
            this.passwordContainer.Size = new System.Drawing.Size(574, 652);
            this.passwordContainer.TabIndex = 1;
            this.passwordContainer.WrapContents = false;
            // 
            // userLabel
            // 
            this.userLabel.AllowDrop = true;
            this.userLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.userLabel.AutoSize = true;
            this.userLabel.BackColor = System.Drawing.Color.SeaGreen;
            this.userLabel.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userLabel.Location = new System.Drawing.Point(12, 12);
            this.userLabel.Margin = new System.Windows.Forms.Padding(3);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(57, 29);
            this.userLabel.TabIndex = 7;
            this.userLabel.Text = "User";
            this.userLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(219, 652);
            this.panel1.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.logOutButton);
            this.panel3.Controls.Add(this.closeButton);
            this.panel3.Controls.Add(this.manageGroupsButton);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.deletUserButton);
            this.panel3.Controls.Add(this.changePasswordButton);
            this.panel3.Controls.Add(this.changeUsernameButton);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.sortGroupsButton);
            this.panel3.Controls.Add(this.alphabetSortButton);
            this.panel3.Controls.Add(this.hideShowButton);
            this.panel3.Controls.Add(this.newpasswordButton);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 59);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(219, 593);
            this.panel3.TabIndex = 0;
            // 
            // logOutButton
            // 
            this.logOutButton.BackColor = System.Drawing.Color.Black;
            this.logOutButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.logOutButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.logOutButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.logOutButton.FlatAppearance.BorderSize = 0;
            this.logOutButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.logOutButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.logOutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logOutButton.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOutButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.logOutButton.Location = new System.Drawing.Point(0, 503);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(219, 45);
            this.logOutButton.TabIndex = 16;
            this.logOutButton.Text = "Log Out";
            this.logOutButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logOutButton.UseVisualStyleBackColor = false;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.Black;
            this.closeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.closeButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.closeButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.closeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.closeButton.Location = new System.Drawing.Point(0, 548);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(219, 45);
            this.closeButton.TabIndex = 18;
            this.closeButton.Text = "Close";
            this.closeButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // manageGroupsButton
            // 
            this.manageGroupsButton.BackColor = System.Drawing.Color.Black;
            this.manageGroupsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.manageGroupsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.manageGroupsButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.manageGroupsButton.FlatAppearance.BorderSize = 0;
            this.manageGroupsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.manageGroupsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.manageGroupsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.manageGroupsButton.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageGroupsButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.manageGroupsButton.Location = new System.Drawing.Point(0, 355);
            this.manageGroupsButton.Name = "manageGroupsButton";
            this.manageGroupsButton.Size = new System.Drawing.Size(219, 45);
            this.manageGroupsButton.TabIndex = 17;
            this.manageGroupsButton.Text = "Manage Groups";
            this.manageGroupsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.manageGroupsButton.UseVisualStyleBackColor = false;
            this.manageGroupsButton.Click += new System.EventHandler(this.manageGroupsButton_Click);
            // 
            // deletUserButton
            // 
            this.deletUserButton.BackColor = System.Drawing.Color.Black;
            this.deletUserButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.deletUserButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.deletUserButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.deletUserButton.FlatAppearance.BorderSize = 0;
            this.deletUserButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.deletUserButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.deletUserButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deletUserButton.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletUserButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.deletUserButton.Location = new System.Drawing.Point(0, 290);
            this.deletUserButton.Name = "deletUserButton";
            this.deletUserButton.Size = new System.Drawing.Size(219, 45);
            this.deletUserButton.TabIndex = 15;
            this.deletUserButton.Text = "Delete This User";
            this.deletUserButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deletUserButton.UseVisualStyleBackColor = false;
            this.deletUserButton.Click += new System.EventHandler(this.deletUserButton_Click);
            // 
            // changePasswordButton
            // 
            this.changePasswordButton.BackColor = System.Drawing.Color.Black;
            this.changePasswordButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.changePasswordButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.changePasswordButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.changePasswordButton.FlatAppearance.BorderSize = 0;
            this.changePasswordButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.changePasswordButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.changePasswordButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changePasswordButton.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changePasswordButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.changePasswordButton.Location = new System.Drawing.Point(0, 245);
            this.changePasswordButton.Name = "changePasswordButton";
            this.changePasswordButton.Size = new System.Drawing.Size(219, 45);
            this.changePasswordButton.TabIndex = 14;
            this.changePasswordButton.Text = "Change Password";
            this.changePasswordButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.changePasswordButton.UseVisualStyleBackColor = false;
            this.changePasswordButton.Click += new System.EventHandler(this.changePasswordButton_Click);
            // 
            // changeUsernameButton
            // 
            this.changeUsernameButton.BackColor = System.Drawing.Color.Black;
            this.changeUsernameButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.changeUsernameButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.changeUsernameButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.changeUsernameButton.FlatAppearance.BorderSize = 0;
            this.changeUsernameButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.changeUsernameButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.changeUsernameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeUsernameButton.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeUsernameButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.changeUsernameButton.Location = new System.Drawing.Point(0, 200);
            this.changeUsernameButton.Name = "changeUsernameButton";
            this.changeUsernameButton.Size = new System.Drawing.Size(219, 45);
            this.changeUsernameButton.TabIndex = 13;
            this.changeUsernameButton.Text = "Change Username";
            this.changeUsernameButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.changeUsernameButton.UseVisualStyleBackColor = false;
            this.changeUsernameButton.Click += new System.EventHandler(this.changeUsernameButton_Click);
            // 
            // sortGroupsButton
            // 
            this.sortGroupsButton.BackColor = System.Drawing.Color.Black;
            this.sortGroupsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.sortGroupsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.sortGroupsButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.sortGroupsButton.FlatAppearance.BorderSize = 0;
            this.sortGroupsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.sortGroupsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.sortGroupsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sortGroupsButton.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortGroupsButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.sortGroupsButton.Location = new System.Drawing.Point(0, 135);
            this.sortGroupsButton.Name = "sortGroupsButton";
            this.sortGroupsButton.Size = new System.Drawing.Size(219, 45);
            this.sortGroupsButton.TabIndex = 12;
            this.sortGroupsButton.Text = "Sort By Groups";
            this.sortGroupsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sortGroupsButton.UseVisualStyleBackColor = false;
            this.sortGroupsButton.Click += new System.EventHandler(this.sortGroupsButton_Click);
            // 
            // alphabetSortButton
            // 
            this.alphabetSortButton.BackColor = System.Drawing.Color.Black;
            this.alphabetSortButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.alphabetSortButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.alphabetSortButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.alphabetSortButton.FlatAppearance.BorderSize = 0;
            this.alphabetSortButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.alphabetSortButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.alphabetSortButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.alphabetSortButton.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alphabetSortButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.alphabetSortButton.Location = new System.Drawing.Point(0, 90);
            this.alphabetSortButton.Name = "alphabetSortButton";
            this.alphabetSortButton.Size = new System.Drawing.Size(219, 45);
            this.alphabetSortButton.TabIndex = 11;
            this.alphabetSortButton.Text = "Sort By Alphabet";
            this.alphabetSortButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.alphabetSortButton.UseVisualStyleBackColor = false;
            this.alphabetSortButton.Click += new System.EventHandler(this.alphabetSortButton_Click);
            // 
            // hideShowButton
            // 
            this.hideShowButton.BackColor = System.Drawing.Color.Black;
            this.hideShowButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.hideShowButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.hideShowButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.hideShowButton.FlatAppearance.BorderSize = 0;
            this.hideShowButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.hideShowButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.hideShowButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hideShowButton.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hideShowButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.hideShowButton.Location = new System.Drawing.Point(0, 45);
            this.hideShowButton.Name = "hideShowButton";
            this.hideShowButton.Size = new System.Drawing.Size(219, 45);
            this.hideShowButton.TabIndex = 10;
            this.hideShowButton.Text = "Hide Passwords";
            this.hideShowButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.hideShowButton.UseVisualStyleBackColor = false;
            this.hideShowButton.Click += new System.EventHandler(this.hideShowButton_Click);
            // 
            // newpasswordButton
            // 
            this.newpasswordButton.AutoEllipsis = true;
            this.newpasswordButton.BackColor = System.Drawing.Color.Black;
            this.newpasswordButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.newpasswordButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.newpasswordButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.newpasswordButton.FlatAppearance.BorderSize = 0;
            this.newpasswordButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.newpasswordButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.newpasswordButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newpasswordButton.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newpasswordButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.newpasswordButton.Location = new System.Drawing.Point(0, 0);
            this.newpasswordButton.Name = "newpasswordButton";
            this.newpasswordButton.Size = new System.Drawing.Size(219, 45);
            this.newpasswordButton.TabIndex = 9;
            this.newpasswordButton.Text = "New Password";
            this.newpasswordButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.newpasswordButton.UseVisualStyleBackColor = false;
            this.newpasswordButton.Click += new System.EventHandler(this.newpasswordButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SeaGreen;
            this.panel2.Controls.Add(this.userLabel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(219, 59);
            this.panel2.TabIndex = 9;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 335);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(219, 20);
            this.panel4.TabIndex = 19;
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 180);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(219, 20);
            this.panel5.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(792, 652);
            this.Controls.Add(this.passwordContainer);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Password Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel passwordContainer;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button logOutButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button manageGroupsButton;
        private System.Windows.Forms.Button deletUserButton;
        private System.Windows.Forms.Button changePasswordButton;
        private System.Windows.Forms.Button changeUsernameButton;
        private System.Windows.Forms.Button sortGroupsButton;
        private System.Windows.Forms.Button alphabetSortButton;
        private System.Windows.Forms.Button hideShowButton;
        private System.Windows.Forms.Button newpasswordButton;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
    }
}

