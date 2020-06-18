namespace NoSQL_Pro_ject
{
    partial class TicketForm
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
            this.lblDateReported = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblDeadline = new System.Windows.Forms.Label();
            this.lblPriority = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblSubject = new System.Windows.Forms.Label();
            this.dateTimeIncident = new System.Windows.Forms.DateTimePicker();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.dropDownIncidents = new System.Windows.Forms.ComboBox();
            this.dropDownDeadline = new System.Windows.Forms.ComboBox();
            this.dropDownPriority = new System.Windows.Forms.ComboBox();
            this.dropDownUsers = new System.Windows.Forms.ComboBox();
            this.pnl_newUser = new System.Windows.Forms.Panel();
            this.NEWUSER_lblTitle = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSubmitTicket = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnl_newUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDateReported
            // 
            this.lblDateReported.AutoSize = true;
            this.lblDateReported.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateReported.Location = new System.Drawing.Point(35, 91);
            this.lblDateReported.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDateReported.Name = "lblDateReported";
            this.lblDateReported.Size = new System.Drawing.Size(150, 20);
            this.lblDateReported.TabIndex = 11;
            this.lblDateReported.Text = "Date/Time reported:";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(35, 298);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(93, 20);
            this.lblDescription.TabIndex = 12;
            this.lblDescription.Text = "Description:";
            // 
            // lblDeadline
            // 
            this.lblDeadline.AutoSize = true;
            this.lblDeadline.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeadline.Location = new System.Drawing.Point(35, 261);
            this.lblDeadline.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDeadline.Name = "lblDeadline";
            this.lblDeadline.Size = new System.Drawing.Size(146, 20);
            this.lblDeadline.TabIndex = 13;
            this.lblDeadline.Text = "Deadline/follow up: ";
            // 
            // lblPriority
            // 
            this.lblPriority.AutoSize = true;
            this.lblPriority.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPriority.Location = new System.Drawing.Point(35, 224);
            this.lblPriority.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPriority.Name = "lblPriority";
            this.lblPriority.Size = new System.Drawing.Size(64, 20);
            this.lblPriority.TabIndex = 14;
            this.lblPriority.Text = "Priority: ";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(35, 189);
            this.lblUser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(139, 20);
            this.lblUser.TabIndex = 15;
            this.lblUser.Text = "Reported by user: ";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.Location = new System.Drawing.Point(35, 158);
            this.lblType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(128, 20);
            this.lblType.TabIndex = 16;
            this.lblType.Text = "Type of incident: ";
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubject.Location = new System.Drawing.Point(35, 123);
            this.lblSubject.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(144, 20);
            this.lblSubject.TabIndex = 17;
            this.lblSubject.Text = "Subject of incident:";
            // 
            // dateTimeIncident
            // 
            this.dateTimeIncident.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeIncident.Location = new System.Drawing.Point(188, 89);
            this.dateTimeIncident.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimeIncident.Name = "dateTimeIncident";
            this.dateTimeIncident.Size = new System.Drawing.Size(277, 26);
            this.dateTimeIncident.TabIndex = 19;
            // 
            // txtSubject
            // 
            this.txtSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubject.Location = new System.Drawing.Point(188, 122);
            this.txtSubject.Margin = new System.Windows.Forms.Padding(2);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(277, 26);
            this.txtSubject.TabIndex = 20;
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(188, 300);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(277, 200);
            this.txtDescription.TabIndex = 21;
            // 
            // dropDownIncidents
            // 
            this.dropDownIncidents.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropDownIncidents.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dropDownIncidents.FormattingEnabled = true;
            this.dropDownIncidents.Items.AddRange(new object[] {
            "Software",
            "Hardware",
            "Service"});
            this.dropDownIncidents.Location = new System.Drawing.Point(188, 156);
            this.dropDownIncidents.Margin = new System.Windows.Forms.Padding(2);
            this.dropDownIncidents.Name = "dropDownIncidents";
            this.dropDownIncidents.Size = new System.Drawing.Size(277, 28);
            this.dropDownIncidents.TabIndex = 24;
            // 
            // dropDownDeadline
            // 
            this.dropDownDeadline.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropDownDeadline.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dropDownDeadline.FormattingEnabled = true;
            this.dropDownDeadline.Items.AddRange(new object[] {
            "7 days",
            "14 days",
            "28 days",
            "6 months"});
            this.dropDownDeadline.Location = new System.Drawing.Point(188, 259);
            this.dropDownDeadline.Margin = new System.Windows.Forms.Padding(2);
            this.dropDownDeadline.Name = "dropDownDeadline";
            this.dropDownDeadline.Size = new System.Drawing.Size(277, 28);
            this.dropDownDeadline.TabIndex = 25;
            // 
            // dropDownPriority
            // 
            this.dropDownPriority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropDownPriority.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dropDownPriority.FormattingEnabled = true;
            this.dropDownPriority.Items.AddRange(new object[] {
            "Low",
            "Normal",
            "High"});
            this.dropDownPriority.Location = new System.Drawing.Point(188, 222);
            this.dropDownPriority.Margin = new System.Windows.Forms.Padding(2);
            this.dropDownPriority.Name = "dropDownPriority";
            this.dropDownPriority.Size = new System.Drawing.Size(277, 28);
            this.dropDownPriority.TabIndex = 26;
            // 
            // dropDownUsers
            // 
            this.dropDownUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dropDownUsers.FormattingEnabled = true;
            this.dropDownUsers.Location = new System.Drawing.Point(188, 188);
            this.dropDownUsers.Margin = new System.Windows.Forms.Padding(2);
            this.dropDownUsers.Name = "dropDownUsers";
            this.dropDownUsers.Size = new System.Drawing.Size(277, 28);
            this.dropDownUsers.TabIndex = 27;
            // 
            // pnl_newUser
            // 
            this.pnl_newUser.Controls.Add(this.dropDownUsers);
            this.pnl_newUser.Controls.Add(this.NEWUSER_lblTitle);
            this.pnl_newUser.Controls.Add(this.dropDownPriority);
            this.pnl_newUser.Controls.Add(this.txtDescription);
            this.pnl_newUser.Controls.Add(this.dropDownDeadline);
            this.pnl_newUser.Controls.Add(this.lblDateReported);
            this.pnl_newUser.Controls.Add(this.dropDownIncidents);
            this.pnl_newUser.Controls.Add(this.lblDescription);
            this.pnl_newUser.Controls.Add(this.btnCancel);
            this.pnl_newUser.Controls.Add(this.lblDeadline);
            this.pnl_newUser.Controls.Add(this.btnSubmitTicket);
            this.pnl_newUser.Controls.Add(this.lblPriority);
            this.pnl_newUser.Controls.Add(this.lblUser);
            this.pnl_newUser.Controls.Add(this.txtSubject);
            this.pnl_newUser.Controls.Add(this.lblType);
            this.pnl_newUser.Controls.Add(this.dateTimeIncident);
            this.pnl_newUser.Controls.Add(this.lblSubject);
            this.pnl_newUser.Location = new System.Drawing.Point(12, 12);
            this.pnl_newUser.Name = "pnl_newUser";
            this.pnl_newUser.Size = new System.Drawing.Size(495, 568);
            this.pnl_newUser.TabIndex = 28;
            // 
            // NEWUSER_lblTitle
            // 
            this.NEWUSER_lblTitle.AutoSize = true;
            this.NEWUSER_lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NEWUSER_lblTitle.Location = new System.Drawing.Point(46, 34);
            this.NEWUSER_lblTitle.Name = "NEWUSER_lblTitle";
            this.NEWUSER_lblTitle.Size = new System.Drawing.Size(401, 33);
            this.NEWUSER_lblTitle.TabIndex = 0;
            this.NEWUSER_lblTitle.Text = "Create a new incident ticket";
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(188, 513);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(132, 42);
            this.btnCancel.TabIndex = 23;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSubmitTicket
            // 
            this.btnSubmitTicket.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSubmitTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitTicket.ForeColor = System.Drawing.SystemColors.Window;
            this.btnSubmitTicket.Location = new System.Drawing.Point(333, 513);
            this.btnSubmitTicket.Margin = new System.Windows.Forms.Padding(2);
            this.btnSubmitTicket.Name = "btnSubmitTicket";
            this.btnSubmitTicket.Size = new System.Drawing.Size(130, 42);
            this.btnSubmitTicket.TabIndex = 22;
            this.btnSubmitTicket.Text = "SUBMIT";
            this.btnSubmitTicket.UseVisualStyleBackColor = false;
            this.btnSubmitTicket.Click += new System.EventHandler(this.btnSubmitTicket_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // TicketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 575);
            this.Controls.Add(this.pnl_newUser);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TicketForm";
            this.Text = "TicketForm";
            this.pnl_newUser.ResumeLayout(false);
            this.pnl_newUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblDateReported;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblDeadline;
        private System.Windows.Forms.Label lblPriority;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.DateTimePicker dateTimeIncident;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.ComboBox dropDownIncidents;
        private System.Windows.Forms.ComboBox dropDownDeadline;
        private System.Windows.Forms.ComboBox dropDownPriority;
        private System.Windows.Forms.ComboBox dropDownUsers;
        private System.Windows.Forms.Panel pnl_newUser;
        private System.Windows.Forms.Label NEWUSER_lblTitle;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSubmitTicket;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}