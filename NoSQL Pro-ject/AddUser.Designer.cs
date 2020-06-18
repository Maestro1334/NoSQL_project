namespace NoSQL_Pro_ject
{
    partial class AddUser
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
            this.components = new System.ComponentModel.Container();
            this.pnl_newUser = new System.Windows.Forms.Panel();
            this.NEWUSER_btnCreate = new System.Windows.Forms.Button();
            this.NEWUSER_btnCancel = new System.Windows.Forms.Button();
            this.NEWUSER_comboBoxType = new System.Windows.Forms.ComboBox();
            this.NEWUSER_comboBoxLocation = new System.Windows.Forms.ComboBox();
            this.NEWUSER_checkboxPassword = new System.Windows.Forms.CheckBox();
            this.NEWUSER_txtLastName = new System.Windows.Forms.TextBox();
            this.NEWUSER_txtEmail = new System.Windows.Forms.TextBox();
            this.NEWUSER_txtPhone = new System.Windows.Forms.TextBox();
            this.NEWUSER_txtFirstName = new System.Windows.Forms.TextBox();
            this.NEWUSER_lblSendPassword = new System.Windows.Forms.Label();
            this.NEWUSER_lblLocation = new System.Windows.Forms.Label();
            this.NEWUSER_lblPhone = new System.Windows.Forms.Label();
            this.NEWUSER_lblEmail = new System.Windows.Forms.Label();
            this.NEWUSER_lblType = new System.Windows.Forms.Label();
            this.NEWUSER_lblLastName = new System.Windows.Forms.Label();
            this.NEWUSER_lblFirstName = new System.Windows.Forms.Label();
            this.NEWUSER_lblTitle = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnl_newUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_newUser
            // 
            this.pnl_newUser.Controls.Add(this.NEWUSER_btnCreate);
            this.pnl_newUser.Controls.Add(this.NEWUSER_btnCancel);
            this.pnl_newUser.Controls.Add(this.NEWUSER_comboBoxType);
            this.pnl_newUser.Controls.Add(this.NEWUSER_comboBoxLocation);
            this.pnl_newUser.Controls.Add(this.NEWUSER_checkboxPassword);
            this.pnl_newUser.Controls.Add(this.NEWUSER_txtLastName);
            this.pnl_newUser.Controls.Add(this.NEWUSER_txtEmail);
            this.pnl_newUser.Controls.Add(this.NEWUSER_txtPhone);
            this.pnl_newUser.Controls.Add(this.NEWUSER_txtFirstName);
            this.pnl_newUser.Controls.Add(this.NEWUSER_lblSendPassword);
            this.pnl_newUser.Controls.Add(this.NEWUSER_lblLocation);
            this.pnl_newUser.Controls.Add(this.NEWUSER_lblPhone);
            this.pnl_newUser.Controls.Add(this.NEWUSER_lblEmail);
            this.pnl_newUser.Controls.Add(this.NEWUSER_lblType);
            this.pnl_newUser.Controls.Add(this.NEWUSER_lblLastName);
            this.pnl_newUser.Controls.Add(this.NEWUSER_lblFirstName);
            this.pnl_newUser.Controls.Add(this.NEWUSER_lblTitle);
            this.pnl_newUser.Location = new System.Drawing.Point(12, 12);
            this.pnl_newUser.Name = "pnl_newUser";
            this.pnl_newUser.Size = new System.Drawing.Size(495, 345);
            this.pnl_newUser.TabIndex = 0;
            // 
            // NEWUSER_btnCreate
            // 
            this.NEWUSER_btnCreate.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.NEWUSER_btnCreate.ForeColor = System.Drawing.Color.White;
            this.NEWUSER_btnCreate.Location = new System.Drawing.Point(323, 282);
            this.NEWUSER_btnCreate.Name = "NEWUSER_btnCreate";
            this.NEWUSER_btnCreate.Size = new System.Drawing.Size(110, 39);
            this.NEWUSER_btnCreate.TabIndex = 18;
            this.NEWUSER_btnCreate.Text = "ADD USER";
            this.NEWUSER_btnCreate.UseVisualStyleBackColor = false;
            this.NEWUSER_btnCreate.Click += new System.EventHandler(this.NEWUSER_btnCreate_Click);
            // 
            // NEWUSER_btnCancel
            // 
            this.NEWUSER_btnCancel.BackColor = System.Drawing.Color.White;
            this.NEWUSER_btnCancel.Location = new System.Drawing.Point(197, 282);
            this.NEWUSER_btnCancel.Name = "NEWUSER_btnCancel";
            this.NEWUSER_btnCancel.Size = new System.Drawing.Size(110, 39);
            this.NEWUSER_btnCancel.TabIndex = 17;
            this.NEWUSER_btnCancel.Text = "CANCEL";
            this.NEWUSER_btnCancel.UseVisualStyleBackColor = false;
            this.NEWUSER_btnCancel.Click += new System.EventHandler(this.NEWUSER_btnCancel_Click);
            // 
            // NEWUSER_comboBoxType
            // 
            this.NEWUSER_comboBoxType.BackColor = System.Drawing.Color.White;
            this.NEWUSER_comboBoxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.NEWUSER_comboBoxType.FormattingEnabled = true;
            this.NEWUSER_comboBoxType.Location = new System.Drawing.Point(197, 137);
            this.NEWUSER_comboBoxType.Name = "NEWUSER_comboBoxType";
            this.NEWUSER_comboBoxType.Size = new System.Drawing.Size(236, 21);
            this.NEWUSER_comboBoxType.TabIndex = 16;
            // 
            // NEWUSER_comboBoxLocation
            // 
            this.NEWUSER_comboBoxLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.NEWUSER_comboBoxLocation.FormattingEnabled = true;
            this.NEWUSER_comboBoxLocation.Location = new System.Drawing.Point(197, 218);
            this.NEWUSER_comboBoxLocation.Name = "NEWUSER_comboBoxLocation";
            this.NEWUSER_comboBoxLocation.Size = new System.Drawing.Size(236, 21);
            this.NEWUSER_comboBoxLocation.TabIndex = 15;
            // 
            // NEWUSER_checkboxPassword
            // 
            this.NEWUSER_checkboxPassword.AutoSize = true;
            this.NEWUSER_checkboxPassword.Location = new System.Drawing.Point(197, 247);
            this.NEWUSER_checkboxPassword.Name = "NEWUSER_checkboxPassword";
            this.NEWUSER_checkboxPassword.Size = new System.Drawing.Size(245, 17);
            this.NEWUSER_checkboxPassword.TabIndex = 14;
            this.NEWUSER_checkboxPassword.Text = "Yes, a password e-mail will be send to the user";
            this.NEWUSER_checkboxPassword.UseVisualStyleBackColor = true;
            // 
            // NEWUSER_txtLastName
            // 
            this.NEWUSER_txtLastName.Location = new System.Drawing.Point(197, 110);
            this.NEWUSER_txtLastName.MaxLength = 50;
            this.NEWUSER_txtLastName.Name = "NEWUSER_txtLastName";
            this.NEWUSER_txtLastName.Size = new System.Drawing.Size(236, 20);
            this.NEWUSER_txtLastName.TabIndex = 13;
            // 
            // NEWUSER_txtEmail
            // 
            this.NEWUSER_txtEmail.Location = new System.Drawing.Point(197, 164);
            this.NEWUSER_txtEmail.MaxLength = 50;
            this.NEWUSER_txtEmail.Name = "NEWUSER_txtEmail";
            this.NEWUSER_txtEmail.Size = new System.Drawing.Size(236, 20);
            this.NEWUSER_txtEmail.TabIndex = 11;
            // 
            // NEWUSER_txtPhone
            // 
            this.NEWUSER_txtPhone.Location = new System.Drawing.Point(197, 191);
            this.NEWUSER_txtPhone.MaxLength = 15;
            this.NEWUSER_txtPhone.Name = "NEWUSER_txtPhone";
            this.NEWUSER_txtPhone.Size = new System.Drawing.Size(236, 20);
            this.NEWUSER_txtPhone.TabIndex = 10;
            // 
            // NEWUSER_txtFirstName
            // 
            this.NEWUSER_txtFirstName.Location = new System.Drawing.Point(197, 83);
            this.NEWUSER_txtFirstName.MaxLength = 50;
            this.NEWUSER_txtFirstName.Name = "NEWUSER_txtFirstName";
            this.NEWUSER_txtFirstName.Size = new System.Drawing.Size(236, 20);
            this.NEWUSER_txtFirstName.TabIndex = 8;
            // 
            // NEWUSER_lblSendPassword
            // 
            this.NEWUSER_lblSendPassword.AutoSize = true;
            this.NEWUSER_lblSendPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NEWUSER_lblSendPassword.Location = new System.Drawing.Point(49, 244);
            this.NEWUSER_lblSendPassword.Name = "NEWUSER_lblSendPassword";
            this.NEWUSER_lblSendPassword.Size = new System.Drawing.Size(119, 18);
            this.NEWUSER_lblSendPassword.TabIndex = 7;
            this.NEWUSER_lblSendPassword.Text = "Send password?";
            // 
            // NEWUSER_lblLocation
            // 
            this.NEWUSER_lblLocation.AutoSize = true;
            this.NEWUSER_lblLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NEWUSER_lblLocation.Location = new System.Drawing.Point(49, 217);
            this.NEWUSER_lblLocation.Name = "NEWUSER_lblLocation";
            this.NEWUSER_lblLocation.Size = new System.Drawing.Size(114, 18);
            this.NEWUSER_lblLocation.TabIndex = 6;
            this.NEWUSER_lblLocation.Text = "Location/branch";
            // 
            // NEWUSER_lblPhone
            // 
            this.NEWUSER_lblPhone.AutoSize = true;
            this.NEWUSER_lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NEWUSER_lblPhone.Location = new System.Drawing.Point(49, 190);
            this.NEWUSER_lblPhone.Name = "NEWUSER_lblPhone";
            this.NEWUSER_lblPhone.Size = new System.Drawing.Size(109, 18);
            this.NEWUSER_lblPhone.TabIndex = 5;
            this.NEWUSER_lblPhone.Text = "Phone number:";
            // 
            // NEWUSER_lblEmail
            // 
            this.NEWUSER_lblEmail.AutoSize = true;
            this.NEWUSER_lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NEWUSER_lblEmail.Location = new System.Drawing.Point(49, 163);
            this.NEWUSER_lblEmail.Name = "NEWUSER_lblEmail";
            this.NEWUSER_lblEmail.Size = new System.Drawing.Size(111, 18);
            this.NEWUSER_lblEmail.TabIndex = 4;
            this.NEWUSER_lblEmail.Text = "E-mail address:";
            // 
            // NEWUSER_lblType
            // 
            this.NEWUSER_lblType.AutoSize = true;
            this.NEWUSER_lblType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NEWUSER_lblType.Location = new System.Drawing.Point(49, 136);
            this.NEWUSER_lblType.Name = "NEWUSER_lblType";
            this.NEWUSER_lblType.Size = new System.Drawing.Size(94, 18);
            this.NEWUSER_lblType.TabIndex = 3;
            this.NEWUSER_lblType.Text = "Type of user:";
            // 
            // NEWUSER_lblLastName
            // 
            this.NEWUSER_lblLastName.AutoSize = true;
            this.NEWUSER_lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NEWUSER_lblLastName.Location = new System.Drawing.Point(49, 109);
            this.NEWUSER_lblLastName.Name = "NEWUSER_lblLastName";
            this.NEWUSER_lblLastName.Size = new System.Drawing.Size(81, 18);
            this.NEWUSER_lblLastName.TabIndex = 2;
            this.NEWUSER_lblLastName.Text = "Last name:";
            // 
            // NEWUSER_lblFirstName
            // 
            this.NEWUSER_lblFirstName.AutoSize = true;
            this.NEWUSER_lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NEWUSER_lblFirstName.Location = new System.Drawing.Point(48, 82);
            this.NEWUSER_lblFirstName.Name = "NEWUSER_lblFirstName";
            this.NEWUSER_lblFirstName.Size = new System.Drawing.Size(82, 18);
            this.NEWUSER_lblFirstName.TabIndex = 1;
            this.NEWUSER_lblFirstName.Text = "First name:";
            // 
            // NEWUSER_lblTitle
            // 
            this.NEWUSER_lblTitle.AutoSize = true;
            this.NEWUSER_lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NEWUSER_lblTitle.Location = new System.Drawing.Point(46, 34);
            this.NEWUSER_lblTitle.Name = "NEWUSER_lblTitle";
            this.NEWUSER_lblTitle.Size = new System.Drawing.Size(243, 33);
            this.NEWUSER_lblTitle.TabIndex = 0;
            this.NEWUSER_lblTitle.Text = "Create new user";
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 370);
            this.Controls.Add(this.pnl_newUser);
            this.Name = "AddUser";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddUser";
            this.pnl_newUser.ResumeLayout(false);
            this.pnl_newUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_newUser;
        private System.Windows.Forms.CheckBox NEWUSER_checkboxPassword;
        private System.Windows.Forms.TextBox NEWUSER_txtLastName;
        private System.Windows.Forms.TextBox NEWUSER_txtEmail;
        private System.Windows.Forms.TextBox NEWUSER_txtPhone;
        private System.Windows.Forms.TextBox NEWUSER_txtFirstName;
        private System.Windows.Forms.Label NEWUSER_lblSendPassword;
        private System.Windows.Forms.Label NEWUSER_lblLocation;
        private System.Windows.Forms.Label NEWUSER_lblPhone;
        private System.Windows.Forms.Label NEWUSER_lblEmail;
        private System.Windows.Forms.Label NEWUSER_lblType;
        private System.Windows.Forms.Label NEWUSER_lblLastName;
        private System.Windows.Forms.Label NEWUSER_lblFirstName;
        private System.Windows.Forms.Label NEWUSER_lblTitle;
        private System.Windows.Forms.Button NEWUSER_btnCreate;
        private System.Windows.Forms.Button NEWUSER_btnCancel;
        private System.Windows.Forms.ComboBox NEWUSER_comboBoxType;
        private System.Windows.Forms.ComboBox NEWUSER_comboBoxLocation;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}