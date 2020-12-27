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
            this.newpasswordButton = new System.Windows.Forms.Button();
            this.passwordContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.closeButton = new System.Windows.Forms.Button();
            this.hideShowButton = new System.Windows.Forms.Button();
            this.logOutButton = new System.Windows.Forms.Button();
            this.deletUserButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // newpasswordButton
            // 
            this.newpasswordButton.BackColor = System.Drawing.Color.Teal;
            this.newpasswordButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.newpasswordButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.newpasswordButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.newpasswordButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newpasswordButton.Location = new System.Drawing.Point(44, 24);
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
            this.passwordContainer.Location = new System.Drawing.Point(216, 0);
            this.passwordContainer.Name = "passwordContainer";
            this.passwordContainer.Size = new System.Drawing.Size(559, 652);
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
            this.closeButton.TabIndex = 4;
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
            this.hideShowButton.Location = new System.Drawing.Point(44, 64);
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
            this.logOutButton.TabIndex = 3;
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
            this.deletUserButton.Location = new System.Drawing.Point(44, 526);
            this.deletUserButton.Name = "deletUserButton";
            this.deletUserButton.Size = new System.Drawing.Size(130, 34);
            this.deletUserButton.TabIndex = 2;
            this.deletUserButton.Text = "Delete This User";
            this.deletUserButton.UseVisualStyleBackColor = false;
            this.deletUserButton.Click += new System.EventHandler(this.deletUserButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(775, 652);
            this.Controls.Add(this.deletUserButton);
            this.Controls.Add(this.logOutButton);
            this.Controls.Add(this.hideShowButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.passwordContainer);
            this.Controls.Add(this.newpasswordButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Password Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button newpasswordButton;
        private System.Windows.Forms.FlowLayoutPanel passwordContainer;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button hideShowButton;
        private System.Windows.Forms.Button logOutButton;
        private System.Windows.Forms.Button deletUserButton;
    }
}

