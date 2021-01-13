
namespace PasswordManager.GroupManagement
{
    partial class ManageGroups
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.closeButton = new System.Windows.Forms.Button();
            this.removeGroupButton = new System.Windows.Forms.Button();
            this.renameGroupButton = new System.Windows.Forms.Button();
            this.addGroupButton = new System.Windows.Forms.Button();
            this.addGroupPanel = new System.Windows.Forms.Panel();
            this.saveNewGroup = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.newPasswordInput = new System.Windows.Forms.RichTextBox();
            this.panelRemoveGroup = new System.Windows.Forms.Panel();
            this.removeGroup = new System.Windows.Forms.Button();
            this.removeBox = new System.Windows.Forms.ComboBox();
            this.renamePanel = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.renameTextBox = new System.Windows.Forms.RichTextBox();
            this.renameButton = new System.Windows.Forms.Button();
            this.renameBox = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.addGroupPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelRemoveGroup.SuspendLayout();
            this.renamePanel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.closeButton);
            this.panel1.Controls.Add(this.removeGroupButton);
            this.panel1.Controls.Add(this.renameGroupButton);
            this.panel1.Controls.Add(this.addGroupButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(170, 234);
            this.panel1.TabIndex = 0;
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.Black;
            this.closeButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.closeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.closeButton.Location = new System.Drawing.Point(0, 189);
            this.closeButton.Margin = new System.Windows.Forms.Padding(0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(170, 45);
            this.closeButton.TabIndex = 5;
            this.closeButton.Text = "Close";
            this.closeButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // removeGroupButton
            // 
            this.removeGroupButton.BackColor = System.Drawing.Color.Black;
            this.removeGroupButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.removeGroupButton.FlatAppearance.BorderSize = 0;
            this.removeGroupButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.removeGroupButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.removeGroupButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeGroupButton.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeGroupButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.removeGroupButton.Location = new System.Drawing.Point(0, 90);
            this.removeGroupButton.Margin = new System.Windows.Forms.Padding(0);
            this.removeGroupButton.Name = "removeGroupButton";
            this.removeGroupButton.Size = new System.Drawing.Size(170, 45);
            this.removeGroupButton.TabIndex = 4;
            this.removeGroupButton.Text = "Remove Group";
            this.removeGroupButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.removeGroupButton.UseVisualStyleBackColor = false;
            this.removeGroupButton.Click += new System.EventHandler(this.removeGroupButton_Click);
            // 
            // renameGroupButton
            // 
            this.renameGroupButton.BackColor = System.Drawing.Color.Black;
            this.renameGroupButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.renameGroupButton.FlatAppearance.BorderSize = 0;
            this.renameGroupButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.renameGroupButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.renameGroupButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.renameGroupButton.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.renameGroupButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.renameGroupButton.Location = new System.Drawing.Point(0, 45);
            this.renameGroupButton.Margin = new System.Windows.Forms.Padding(0);
            this.renameGroupButton.Name = "renameGroupButton";
            this.renameGroupButton.Size = new System.Drawing.Size(170, 45);
            this.renameGroupButton.TabIndex = 6;
            this.renameGroupButton.Text = "Rename Group";
            this.renameGroupButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.renameGroupButton.UseVisualStyleBackColor = false;
            this.renameGroupButton.Click += new System.EventHandler(this.renameGroupButton_Click);
            // 
            // addGroupButton
            // 
            this.addGroupButton.BackColor = System.Drawing.Color.Black;
            this.addGroupButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.addGroupButton.FlatAppearance.BorderSize = 0;
            this.addGroupButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.addGroupButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.addGroupButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addGroupButton.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addGroupButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.addGroupButton.Location = new System.Drawing.Point(0, 0);
            this.addGroupButton.Margin = new System.Windows.Forms.Padding(0);
            this.addGroupButton.Name = "addGroupButton";
            this.addGroupButton.Size = new System.Drawing.Size(170, 45);
            this.addGroupButton.TabIndex = 3;
            this.addGroupButton.Text = "Add Group";
            this.addGroupButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addGroupButton.UseVisualStyleBackColor = false;
            this.addGroupButton.Click += new System.EventHandler(this.addGroupButton_Click);
            // 
            // addGroupPanel
            // 
            this.addGroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.addGroupPanel.Controls.Add(this.saveNewGroup);
            this.addGroupPanel.Controls.Add(this.panel2);
            this.addGroupPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addGroupPanel.Location = new System.Drawing.Point(170, 0);
            this.addGroupPanel.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.addGroupPanel.Name = "addGroupPanel";
            this.addGroupPanel.Size = new System.Drawing.Size(667, 234);
            this.addGroupPanel.TabIndex = 1;
            // 
            // saveNewGroup
            // 
            this.saveNewGroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.saveNewGroup.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.saveNewGroup.FlatAppearance.BorderSize = 0;
            this.saveNewGroup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.saveNewGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveNewGroup.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveNewGroup.ForeColor = System.Drawing.Color.Gainsboro;
            this.saveNewGroup.Location = new System.Drawing.Point(0, 189);
            this.saveNewGroup.Name = "saveNewGroup";
            this.saveNewGroup.Size = new System.Drawing.Size(667, 45);
            this.saveNewGroup.TabIndex = 2;
            this.saveNewGroup.Text = "Add";
            this.saveNewGroup.UseVisualStyleBackColor = false;
            this.saveNewGroup.Click += new System.EventHandler(this.saveNewGroup_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkGray;
            this.panel2.Controls.Add(this.newPasswordInput);
            this.panel2.Location = new System.Drawing.Point(199, 45);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10);
            this.panel2.Size = new System.Drawing.Size(281, 40);
            this.panel2.TabIndex = 1;
            // 
            // newPasswordInput
            // 
            this.newPasswordInput.BackColor = System.Drawing.Color.Silver;
            this.newPasswordInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.newPasswordInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.newPasswordInput.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPasswordInput.Location = new System.Drawing.Point(10, 10);
            this.newPasswordInput.Margin = new System.Windows.Forms.Padding(20);
            this.newPasswordInput.Multiline = false;
            this.newPasswordInput.Name = "newPasswordInput";
            this.newPasswordInput.Size = new System.Drawing.Size(261, 20);
            this.newPasswordInput.TabIndex = 0;
            this.newPasswordInput.Text = "";
            // 
            // panelRemoveGroup
            // 
            this.panelRemoveGroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.panelRemoveGroup.Controls.Add(this.removeGroup);
            this.panelRemoveGroup.Controls.Add(this.removeBox);
            this.panelRemoveGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRemoveGroup.Location = new System.Drawing.Point(170, 0);
            this.panelRemoveGroup.Name = "panelRemoveGroup";
            this.panelRemoveGroup.Size = new System.Drawing.Size(667, 234);
            this.panelRemoveGroup.TabIndex = 3;
            // 
            // removeGroup
            // 
            this.removeGroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.removeGroup.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.removeGroup.FlatAppearance.BorderSize = 0;
            this.removeGroup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.removeGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeGroup.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeGroup.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.removeGroup.Location = new System.Drawing.Point(0, 189);
            this.removeGroup.Name = "removeGroup";
            this.removeGroup.Size = new System.Drawing.Size(667, 45);
            this.removeGroup.TabIndex = 1;
            this.removeGroup.Text = "Remove";
            this.removeGroup.UseVisualStyleBackColor = false;
            this.removeGroup.Click += new System.EventHandler(this.removeGroup_Click);
            // 
            // removeBox
            // 
            this.removeBox.BackColor = System.Drawing.Color.Silver;
            this.removeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.removeBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeBox.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeBox.FormattingEnabled = true;
            this.removeBox.Location = new System.Drawing.Point(227, 45);
            this.removeBox.Name = "removeBox";
            this.removeBox.Size = new System.Drawing.Size(228, 23);
            this.removeBox.TabIndex = 0;
            // 
            // renamePanel
            // 
            this.renamePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.renamePanel.Controls.Add(this.panel3);
            this.renamePanel.Controls.Add(this.renameButton);
            this.renamePanel.Controls.Add(this.renameBox);
            this.renamePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.renamePanel.Location = new System.Drawing.Point(170, 0);
            this.renamePanel.Name = "renamePanel";
            this.renamePanel.Size = new System.Drawing.Size(667, 234);
            this.renamePanel.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkGray;
            this.panel3.Controls.Add(this.renameTextBox);
            this.panel3.Location = new System.Drawing.Point(199, 90);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(10);
            this.panel3.Size = new System.Drawing.Size(281, 40);
            this.panel3.TabIndex = 2;
            // 
            // renameTextBox
            // 
            this.renameTextBox.BackColor = System.Drawing.Color.Silver;
            this.renameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.renameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.renameTextBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.renameTextBox.Location = new System.Drawing.Point(10, 10);
            this.renameTextBox.Margin = new System.Windows.Forms.Padding(20);
            this.renameTextBox.Multiline = false;
            this.renameTextBox.Name = "renameTextBox";
            this.renameTextBox.Size = new System.Drawing.Size(261, 20);
            this.renameTextBox.TabIndex = 0;
            this.renameTextBox.Text = "";
            // 
            // renameButton
            // 
            this.renameButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.renameButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.renameButton.FlatAppearance.BorderSize = 0;
            this.renameButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.renameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.renameButton.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.renameButton.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.renameButton.Location = new System.Drawing.Point(0, 189);
            this.renameButton.Name = "renameButton";
            this.renameButton.Size = new System.Drawing.Size(667, 45);
            this.renameButton.TabIndex = 1;
            this.renameButton.Text = "Rename";
            this.renameButton.UseVisualStyleBackColor = false;
            this.renameButton.Click += new System.EventHandler(this.renameButton_Click);
            // 
            // renameBox
            // 
            this.renameBox.BackColor = System.Drawing.Color.Silver;
            this.renameBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.renameBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.renameBox.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.renameBox.FormattingEnabled = true;
            this.renameBox.Location = new System.Drawing.Point(227, 45);
            this.renameBox.Name = "renameBox";
            this.renameBox.Size = new System.Drawing.Size(228, 23);
            this.renameBox.TabIndex = 0;
            // 
            // ManageGroups
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(837, 234);
            this.Controls.Add(this.renamePanel);
            this.Controls.Add(this.addGroupPanel);
            this.Controls.Add(this.panelRemoveGroup);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ManageGroups";
            this.Text = "Manage Groups";
            this.Load += new System.EventHandler(this.ManageGroups_Load);
            this.panel1.ResumeLayout(false);
            this.addGroupPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panelRemoveGroup.ResumeLayout(false);
            this.renamePanel.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button removeGroupButton;
        private System.Windows.Forms.Button addGroupButton;
        private System.Windows.Forms.Panel addGroupPanel;
        private System.Windows.Forms.RichTextBox newPasswordInput;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button saveNewGroup;
        private System.Windows.Forms.Panel panelRemoveGroup;
        private System.Windows.Forms.Button removeGroup;
        private System.Windows.Forms.ComboBox removeBox;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button renameGroupButton;
        private System.Windows.Forms.Panel renamePanel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RichTextBox renameTextBox;
        private System.Windows.Forms.Button renameButton;
        private System.Windows.Forms.ComboBox renameBox;
    }
}