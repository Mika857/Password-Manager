
namespace PasswordManager
{
    partial class ChangeGroup
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
            System.Windows.Forms.Button sortButton;
            System.Windows.Forms.Button button1;
            this.groupBox = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            sortButton = new System.Windows.Forms.Button();
            button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sortButton
            // 
            sortButton.BackColor = System.Drawing.Color.Black;
            sortButton.Dock = System.Windows.Forms.DockStyle.Top;
            sortButton.FlatAppearance.BorderSize = 0;
            sortButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            sortButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            sortButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            sortButton.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sortButton.ForeColor = System.Drawing.Color.Gainsboro;
            sortButton.Location = new System.Drawing.Point(0, 0);
            sortButton.Name = "sortButton";
            sortButton.Size = new System.Drawing.Size(200, 31);
            sortButton.TabIndex = 14;
            sortButton.Text = "Save";
            sortButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            sortButton.UseVisualStyleBackColor = false;
            sortButton.Click += new System.EventHandler(this.sortButton_Click);
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.Color.Black;
            button1.Dock = System.Windows.Forms.DockStyle.Top;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            button1.ForeColor = System.Drawing.Color.Gainsboro;
            button1.Location = new System.Drawing.Point(0, 31);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(200, 31);
            button1.TabIndex = 13;
            button1.Text = "Close";
            button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = false;
            button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox
            // 
            this.groupBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.groupBox.FormattingEnabled = true;
            this.groupBox.Location = new System.Drawing.Point(219, 12);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(313, 21);
            this.groupBox.TabIndex = 15;
            this.groupBox.SelectedIndexChanged += new System.EventHandler(this.groupBox_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(button1);
            this.panel1.Controls.Add(sortButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 63);
            this.panel1.TabIndex = 17;
            // 
            // ChangeGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(544, 63);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ChangeGroup";
            this.Text = "Change Group";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox groupBox;
        private System.Windows.Forms.Panel panel1;
    }
}