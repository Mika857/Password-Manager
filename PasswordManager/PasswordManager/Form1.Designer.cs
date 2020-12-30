﻿namespace PasswordManager
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
            this.newpasswordButton = new System.Windows.Forms.Button();
            this.passwordContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.closeButton = new System.Windows.Forms.Button();
            this.hideShowButton = new System.Windows.Forms.Button();
            this.logOutButton = new System.Windows.Forms.Button();
            this.deletUserButton = new System.Windows.Forms.Button();
            this.userLabel = new System.Windows.Forms.Label();
            this.changePasswordButton = new System.Windows.Forms.Button();
            this.changeUsernameButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // newpasswordButton
            // 
            this.newpasswordButton.AutoEllipsis = true;
            this.newpasswordButton.BackColor = System.Drawing.Color.Teal;
            this.newpasswordButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.newpasswordButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.newpasswordButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.newpasswordButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newpasswordButton.ForeColor = System.Drawing.Color.Black;
            this.newpasswordButton.Location = new System.Drawing.Point(44, 65);
            this.newpasswordButton.Name = "newpasswordButton";
            this.newpasswordButton.Size = new System.Drawing.Size(130, 34);
            this.newpasswordButton.TabIndex = 0;
            this.newpasswordButton.Text = "New Password";
            this.newpasswordButton.UseVisualStyleBackColor = false;
            this.newpasswordButton.Click += new System.EventHandler(this.button1_Click);
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
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.Teal;
            this.closeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.closeButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.closeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Location = new System.Drawing.Point(44, 606);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(130, 34);
            this.closeButton.TabIndex = 6;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // hideShowButton
            // 
            this.hideShowButton.BackColor = System.Drawing.Color.Teal;
            this.hideShowButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.hideShowButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.hideShowButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.hideShowButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hideShowButton.Location = new System.Drawing.Point(44, 105);
            this.hideShowButton.Name = "hideShowButton";
            this.hideShowButton.Size = new System.Drawing.Size(130, 34);
            this.hideShowButton.TabIndex = 1;
            this.hideShowButton.Text = "Hide Passwords";
            this.hideShowButton.UseVisualStyleBackColor = false;
            this.hideShowButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // logOutButton
            // 
            this.logOutButton.BackColor = System.Drawing.Color.Teal;
            this.logOutButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.logOutButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.logOutButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.logOutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logOutButton.Location = new System.Drawing.Point(44, 566);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(130, 34);
            this.logOutButton.TabIndex = 5;
            this.logOutButton.Text = "Log Out";
            this.logOutButton.UseVisualStyleBackColor = false;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // deletUserButton
            // 
            this.deletUserButton.BackColor = System.Drawing.Color.Teal;
            this.deletUserButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.deletUserButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.deletUserButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.deletUserButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deletUserButton.Location = new System.Drawing.Point(44, 500);
            this.deletUserButton.Name = "deletUserButton";
            this.deletUserButton.Size = new System.Drawing.Size(130, 34);
            this.deletUserButton.TabIndex = 4;
            this.deletUserButton.Text = "Delete This User";
            this.deletUserButton.UseVisualStyleBackColor = false;
            this.deletUserButton.Click += new System.EventHandler(this.deletUserButton_Click);
            // 
            // userLabel
            // 
            this.userLabel.AllowDrop = true;
            this.userLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.userLabel.AutoSize = true;
            this.userLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.userLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userLabel.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userLabel.Location = new System.Drawing.Point(17, 12);
            this.userLabel.Margin = new System.Windows.Forms.Padding(3);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(59, 31);
            this.userLabel.TabIndex = 7;
            this.userLabel.Text = "User";
            this.userLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // changePasswordButton
            // 
            this.changePasswordButton.BackColor = System.Drawing.Color.Teal;
            this.changePasswordButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.changePasswordButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.changePasswordButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.changePasswordButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changePasswordButton.Location = new System.Drawing.Point(44, 460);
            this.changePasswordButton.Name = "changePasswordButton";
            this.changePasswordButton.Size = new System.Drawing.Size(130, 34);
            this.changePasswordButton.TabIndex = 3;
            this.changePasswordButton.Text = "Change Password";
            this.changePasswordButton.UseVisualStyleBackColor = false;
            this.changePasswordButton.Click += new System.EventHandler(this.changePasswordButton_Click);
            // 
            // changeUsernameButton
            // 
            this.changeUsernameButton.BackColor = System.Drawing.Color.Teal;
            this.changeUsernameButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.changeUsernameButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.changeUsernameButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.changeUsernameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeUsernameButton.Location = new System.Drawing.Point(44, 420);
            this.changeUsernameButton.Name = "changeUsernameButton";
            this.changeUsernameButton.Size = new System.Drawing.Size(130, 34);
            this.changeUsernameButton.TabIndex = 2;
            this.changeUsernameButton.Text = "Change Username";
            this.changeUsernameButton.UseVisualStyleBackColor = false;
            this.changeUsernameButton.Click += new System.EventHandler(this.changeUsernameButton_Click);
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.userLabel);
            this.panel1.Controls.Add(this.newpasswordButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(221, 652);
            this.panel1.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(792, 652);
            this.Controls.Add(this.changeUsernameButton);
            this.Controls.Add(this.changePasswordButton);
            this.Controls.Add(this.deletUserButton);
            this.Controls.Add(this.logOutButton);
            this.Controls.Add(this.hideShowButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.passwordContainer);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Password Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button newpasswordButton;
        private System.Windows.Forms.FlowLayoutPanel passwordContainer;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button hideShowButton;
        private System.Windows.Forms.Button logOutButton;
        private System.Windows.Forms.Button deletUserButton;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.Button changePasswordButton;
        private System.Windows.Forms.Button changeUsernameButton;
        private System.Windows.Forms.Panel panel1;
    }
}

