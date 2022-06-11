namespace CS_CLUB_NEW
{
    partial class memberprofile
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.add_event = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.password = new System.Windows.Forms.Label();
            this.change_password = new System.Windows.Forms.Button();
            this.l = new System.Windows.Forms.Label();
            this.password2 = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.Label();
            this.email2 = new System.Windows.Forms.TextBox();
            this.Username = new System.Windows.Forms.TextBox();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Controls.Add(this.add_event);
            this.groupBox2.Location = new System.Drawing.Point(457, 79);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(388, 352);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Registered event";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(31, 49);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(321, 174);
            this.dataGridView1.TabIndex = 25;
            // 
            // add_event
            // 
            this.add_event.BackColor = System.Drawing.Color.White;
            this.add_event.Font = new System.Drawing.Font("Microsoft Uighur", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_event.Location = new System.Drawing.Point(125, 263);
            this.add_event.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.add_event.Name = "add_event";
            this.add_event.Size = new System.Drawing.Size(157, 63);
            this.add_event.TabIndex = 24;
            this.add_event.Text = "View event";
            this.add_event.UseVisualStyleBackColor = false;
            this.add_event.Click += new System.EventHandler(this.add_event_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.password);
            this.groupBox1.Controls.Add(this.change_password);
            this.groupBox1.Controls.Add(this.l);
            this.groupBox1.Controls.Add(this.password2);
            this.groupBox1.Controls.Add(this.email);
            this.groupBox1.Controls.Add(this.email2);
            this.groupBox1.Controls.Add(this.Username);
            this.groupBox1.Location = new System.Drawing.Point(32, 79);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(368, 352);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "My account ";
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Font = new System.Drawing.Font("Microsoft Uighur", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(48, 175);
            this.password.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(77, 32);
            this.password.TabIndex = 27;
            this.password.Text = "Password";
            // 
            // change_password
            // 
            this.change_password.BackColor = System.Drawing.Color.White;
            this.change_password.Font = new System.Drawing.Font("Microsoft Uighur", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.change_password.Location = new System.Drawing.Point(73, 263);
            this.change_password.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.change_password.Name = "change_password";
            this.change_password.Size = new System.Drawing.Size(201, 63);
            this.change_password.TabIndex = 31;
            this.change_password.Text = "change password";
            this.change_password.UseVisualStyleBackColor = false;
            this.change_password.Click += new System.EventHandler(this.change_password_Click);
            // 
            // l
            // 
            this.l.AutoSize = true;
            this.l.Font = new System.Drawing.Font("Microsoft Uighur", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l.Location = new System.Drawing.Point(46, 48);
            this.l.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.l.Name = "l";
            this.l.Size = new System.Drawing.Size(82, 32);
            this.l.TabIndex = 25;
            this.l.Text = "Username";
            // 
            // password2
            // 
            this.password2.Location = new System.Drawing.Point(146, 182);
            this.password2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.password2.Name = "password2";
            this.password2.PasswordChar = '*';
            this.password2.Size = new System.Drawing.Size(184, 26);
            this.password2.TabIndex = 30;
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Font = new System.Drawing.Font("Microsoft Uighur", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.Location = new System.Drawing.Point(48, 112);
            this.email.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(53, 32);
            this.email.TabIndex = 26;
            this.email.Text = "Email";
            // 
            // email2
            // 
            this.email2.Enabled = false;
            this.email2.Location = new System.Drawing.Point(146, 112);
            this.email2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.email2.Name = "email2";
            this.email2.Size = new System.Drawing.Size(184, 26);
            this.email2.TabIndex = 29;
            // 
            // Username
            // 
            this.Username.Enabled = false;
            this.Username.Location = new System.Drawing.Point(146, 49);
            this.Username.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(184, 26);
            this.Username.TabIndex = 28;
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Font = new System.Drawing.Font("Microsoft Uighur", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel3.Location = new System.Drawing.Point(149, 18);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(75, 31);
            this.linkLabel3.TabIndex = 57;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "Log Out";
            this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Microsoft Uighur", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel2.Location = new System.Drawing.Point(87, 18);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(56, 31);
            this.linkLabel2.TabIndex = 56;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Event";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Uighur", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(17, 18);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(64, 31);
            this.linkLabel1.TabIndex = 55;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Profile";
            // 
            // memberprofile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(890, 510);
            this.Controls.Add(this.linkLabel3);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "memberprofile";
            this.Text = "memberprofile";
            this.Load += new System.EventHandler(this.memberprofile_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button add_event;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Button change_password;
        private System.Windows.Forms.Label l;
        private System.Windows.Forms.TextBox password2;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.TextBox email2;
        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel1;

    }
}