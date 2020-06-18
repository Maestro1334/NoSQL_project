namespace NoSQL_Pro_ject
{
    partial class TicketDetail
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
            this.pnl_IncidentDetails = new System.Windows.Forms.Panel();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.dropDownUsers = new System.Windows.Forms.ComboBox();
            this.NEWUSER_lblTitle = new System.Windows.Forms.Label();
            this.dropDownPriority = new System.Windows.Forms.ComboBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.dropDownDeadline = new System.Windows.Forms.ComboBox();
            this.lblDateReported = new System.Windows.Forms.Label();
            this.dropDownIncidents = new System.Windows.Forms.ComboBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblDeadline = new System.Windows.Forms.Label();
            this.lblPriority = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.lblType = new System.Windows.Forms.Label();
            this.dateTimeIncident = new System.Windows.Forms.DateTimePicker();
            this.lblSubject = new System.Windows.Forms.Label();
            this.btnEditTicket = new System.Windows.Forms.Button();
            this.btnAddFeedback = new System.Windows.Forms.Button();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnl_AddFeedback = new System.Windows.Forms.Panel();
            this.btn_CancelFeedback = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFeedback = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.lbl_IncidentDate = new System.Windows.Forms.Label();
            this.labelSubject = new System.Windows.Forms.Label();
            this.txt_Feedback = new System.Windows.Forms.TextBox();
            this.btn_SendFeedback = new System.Windows.Forms.Button();
            this.lbl_IncidentSubject = new System.Windows.Forms.Label();
            this.btnCancelEditTicket = new System.Windows.Forms.Button();
            this.pnl_IncidentDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.pnl_AddFeedback.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_IncidentDetails
            // 
            this.pnl_IncidentDetails.Controls.Add(this.btnCancelEditTicket);
            this.pnl_IncidentDetails.Controls.Add(this.cmbStatus);
            this.pnl_IncidentDetails.Controls.Add(this.lblStatus);
            this.pnl_IncidentDetails.Controls.Add(this.dropDownUsers);
            this.pnl_IncidentDetails.Controls.Add(this.NEWUSER_lblTitle);
            this.pnl_IncidentDetails.Controls.Add(this.dropDownPriority);
            this.pnl_IncidentDetails.Controls.Add(this.txtDescription);
            this.pnl_IncidentDetails.Controls.Add(this.dropDownDeadline);
            this.pnl_IncidentDetails.Controls.Add(this.lblDateReported);
            this.pnl_IncidentDetails.Controls.Add(this.dropDownIncidents);
            this.pnl_IncidentDetails.Controls.Add(this.lblDescription);
            this.pnl_IncidentDetails.Controls.Add(this.lblDeadline);
            this.pnl_IncidentDetails.Controls.Add(this.lblPriority);
            this.pnl_IncidentDetails.Controls.Add(this.lblUser);
            this.pnl_IncidentDetails.Controls.Add(this.txtSubject);
            this.pnl_IncidentDetails.Controls.Add(this.lblType);
            this.pnl_IncidentDetails.Controls.Add(this.dateTimeIncident);
            this.pnl_IncidentDetails.Controls.Add(this.lblSubject);
            this.pnl_IncidentDetails.Controls.Add(this.btnEditTicket);
            this.pnl_IncidentDetails.Controls.Add(this.btnAddFeedback);
            this.pnl_IncidentDetails.Controls.Add(this.btnSaveChanges);
            this.pnl_IncidentDetails.Location = new System.Drawing.Point(0, 0);
            this.pnl_IncidentDetails.Name = "pnl_IncidentDetails";
            this.pnl_IncidentDetails.Size = new System.Drawing.Size(497, 568);
            this.pnl_IncidentDetails.TabIndex = 29;
            // 
            // cmbStatus
            // 
            this.cmbStatus.AutoCompleteCustomSource.AddRange(new string[] {
            "Open",
            "Closed",
            "Resolved",
            "Unresolved"});
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.Enabled = false;
            this.cmbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "Open",
            "Closed",
            "Resolved",
            "Unresolved"});
            this.cmbStatus.Location = new System.Drawing.Point(184, 478);
            this.cmbStatus.Margin = new System.Windows.Forms.Padding(2);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(277, 28);
            this.cmbStatus.TabIndex = 31;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(31, 481);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(60, 20);
            this.lblStatus.TabIndex = 30;
            this.lblStatus.Text = "Status:";
            // 
            // dropDownUsers
            // 
            this.dropDownUsers.Enabled = false;
            this.dropDownUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dropDownUsers.FormattingEnabled = true;
            this.dropDownUsers.Location = new System.Drawing.Point(184, 153);
            this.dropDownUsers.Margin = new System.Windows.Forms.Padding(2);
            this.dropDownUsers.Name = "dropDownUsers";
            this.dropDownUsers.Size = new System.Drawing.Size(277, 28);
            this.dropDownUsers.TabIndex = 27;
            // 
            // NEWUSER_lblTitle
            // 
            this.NEWUSER_lblTitle.AutoSize = true;
            this.NEWUSER_lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NEWUSER_lblTitle.Location = new System.Drawing.Point(28, 14);
            this.NEWUSER_lblTitle.Name = "NEWUSER_lblTitle";
            this.NEWUSER_lblTitle.Size = new System.Drawing.Size(231, 33);
            this.NEWUSER_lblTitle.TabIndex = 0;
            this.NEWUSER_lblTitle.Text = "Incident Details";
            // 
            // dropDownPriority
            // 
            this.dropDownPriority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropDownPriority.Enabled = false;
            this.dropDownPriority.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dropDownPriority.FormattingEnabled = true;
            this.dropDownPriority.Items.AddRange(new object[] {
            "Low",
            "Normal",
            "High"});
            this.dropDownPriority.Location = new System.Drawing.Point(184, 187);
            this.dropDownPriority.Margin = new System.Windows.Forms.Padding(2);
            this.dropDownPriority.Name = "dropDownPriority";
            this.dropDownPriority.Size = new System.Drawing.Size(277, 28);
            this.dropDownPriority.TabIndex = 26;
            // 
            // txtDescription
            // 
            this.txtDescription.Enabled = false;
            this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(184, 265);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(277, 200);
            this.txtDescription.TabIndex = 21;
            // 
            // dropDownDeadline
            // 
            this.dropDownDeadline.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropDownDeadline.Enabled = false;
            this.dropDownDeadline.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dropDownDeadline.FormattingEnabled = true;
            this.dropDownDeadline.Items.AddRange(new object[] {
            "7 days",
            "14 days",
            "28 days",
            "6 months"});
            this.dropDownDeadline.Location = new System.Drawing.Point(184, 224);
            this.dropDownDeadline.Margin = new System.Windows.Forms.Padding(2);
            this.dropDownDeadline.Name = "dropDownDeadline";
            this.dropDownDeadline.Size = new System.Drawing.Size(277, 28);
            this.dropDownDeadline.TabIndex = 25;
            // 
            // lblDateReported
            // 
            this.lblDateReported.AutoSize = true;
            this.lblDateReported.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateReported.Location = new System.Drawing.Point(31, 56);
            this.lblDateReported.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDateReported.Name = "lblDateReported";
            this.lblDateReported.Size = new System.Drawing.Size(150, 20);
            this.lblDateReported.TabIndex = 11;
            this.lblDateReported.Text = "Date/Time reported:";
            // 
            // dropDownIncidents
            // 
            this.dropDownIncidents.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropDownIncidents.Enabled = false;
            this.dropDownIncidents.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dropDownIncidents.FormattingEnabled = true;
            this.dropDownIncidents.Items.AddRange(new object[] {
            "Software",
            "Hardware",
            "Service"});
            this.dropDownIncidents.Location = new System.Drawing.Point(184, 121);
            this.dropDownIncidents.Margin = new System.Windows.Forms.Padding(2);
            this.dropDownIncidents.Name = "dropDownIncidents";
            this.dropDownIncidents.Size = new System.Drawing.Size(277, 28);
            this.dropDownIncidents.TabIndex = 24;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(31, 263);
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
            this.lblDeadline.Location = new System.Drawing.Point(31, 226);
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
            this.lblPriority.Location = new System.Drawing.Point(31, 189);
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
            this.lblUser.Location = new System.Drawing.Point(31, 154);
            this.lblUser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(139, 20);
            this.lblUser.TabIndex = 15;
            this.lblUser.Text = "Reported by user: ";
            // 
            // txtSubject
            // 
            this.txtSubject.Enabled = false;
            this.txtSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubject.Location = new System.Drawing.Point(184, 87);
            this.txtSubject.Margin = new System.Windows.Forms.Padding(2);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(277, 26);
            this.txtSubject.TabIndex = 20;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.Location = new System.Drawing.Point(31, 123);
            this.lblType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(128, 20);
            this.lblType.TabIndex = 16;
            this.lblType.Text = "Type of incident: ";
            // 
            // dateTimeIncident
            // 
            this.dateTimeIncident.Enabled = false;
            this.dateTimeIncident.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeIncident.Location = new System.Drawing.Point(184, 54);
            this.dateTimeIncident.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimeIncident.Name = "dateTimeIncident";
            this.dateTimeIncident.Size = new System.Drawing.Size(277, 26);
            this.dateTimeIncident.TabIndex = 19;
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubject.Location = new System.Drawing.Point(31, 88);
            this.lblSubject.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(144, 20);
            this.lblSubject.TabIndex = 17;
            this.lblSubject.Text = "Subject of incident:";
            // 
            // btnEditTicket
            // 
            this.btnEditTicket.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnEditTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditTicket.ForeColor = System.Drawing.SystemColors.Window;
            this.btnEditTicket.Location = new System.Drawing.Point(321, 515);
            this.btnEditTicket.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditTicket.Name = "btnEditTicket";
            this.btnEditTicket.Size = new System.Drawing.Size(140, 42);
            this.btnEditTicket.TabIndex = 28;
            this.btnEditTicket.Text = "Edit Ticket";
            this.btnEditTicket.UseVisualStyleBackColor = false;
            this.btnEditTicket.Visible = false;
            this.btnEditTicket.Click += new System.EventHandler(this.BtnEditTicket_Click);
            // 
            // btnAddFeedback
            // 
            this.btnAddFeedback.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAddFeedback.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFeedback.ForeColor = System.Drawing.SystemColors.Window;
            this.btnAddFeedback.Location = new System.Drawing.Point(321, 515);
            this.btnAddFeedback.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddFeedback.Name = "btnAddFeedback";
            this.btnAddFeedback.Size = new System.Drawing.Size(140, 42);
            this.btnAddFeedback.TabIndex = 22;
            this.btnAddFeedback.Text = "Send Feedback";
            this.btnAddFeedback.UseVisualStyleBackColor = false;
            this.btnAddFeedback.Visible = false;
            this.btnAddFeedback.Click += new System.EventHandler(this.BtnAddFeedback_Click);
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnSaveChanges.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveChanges.ForeColor = System.Drawing.SystemColors.Window;
            this.btnSaveChanges.Location = new System.Drawing.Point(321, 515);
            this.btnSaveChanges.Margin = new System.Windows.Forms.Padding(2);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(140, 42);
            this.btnSaveChanges.TabIndex = 29;
            this.btnSaveChanges.Text = "Save Changes";
            this.btnSaveChanges.UseVisualStyleBackColor = false;
            this.btnSaveChanges.Visible = false;
            this.btnSaveChanges.Click += new System.EventHandler(this.BtnSaveChanges_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // pnl_AddFeedback
            // 
            this.pnl_AddFeedback.Controls.Add(this.btn_CancelFeedback);
            this.pnl_AddFeedback.Controls.Add(this.label1);
            this.pnl_AddFeedback.Controls.Add(this.lblFeedback);
            this.pnl_AddFeedback.Controls.Add(this.labelDate);
            this.pnl_AddFeedback.Controls.Add(this.lbl_IncidentDate);
            this.pnl_AddFeedback.Controls.Add(this.labelSubject);
            this.pnl_AddFeedback.Controls.Add(this.txt_Feedback);
            this.pnl_AddFeedback.Controls.Add(this.btn_SendFeedback);
            this.pnl_AddFeedback.Controls.Add(this.lbl_IncidentSubject);
            this.pnl_AddFeedback.Location = new System.Drawing.Point(6, 12);
            this.pnl_AddFeedback.Name = "pnl_AddFeedback";
            this.pnl_AddFeedback.Size = new System.Drawing.Size(497, 557);
            this.pnl_AddFeedback.TabIndex = 30;
            // 
            // btn_CancelFeedback
            // 
            this.btn_CancelFeedback.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CancelFeedback.Location = new System.Drawing.Point(294, 400);
            this.btn_CancelFeedback.Name = "btn_CancelFeedback";
            this.btn_CancelFeedback.Size = new System.Drawing.Size(128, 54);
            this.btn_CancelFeedback.TabIndex = 8;
            this.btn_CancelFeedback.Text = "&Cancel";
            this.btn_CancelFeedback.UseVisualStyleBackColor = true;
            this.btn_CancelFeedback.Click += new System.EventHandler(this.btn_CancelFeedback_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 33);
            this.label1.TabIndex = 7;
            this.label1.Text = "Feedback";
            // 
            // lblFeedback
            // 
            this.lblFeedback.AutoSize = true;
            this.lblFeedback.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFeedback.Location = new System.Drawing.Point(56, 181);
            this.lblFeedback.Name = "lblFeedback";
            this.lblFeedback.Size = new System.Drawing.Size(186, 20);
            this.lblFeedback.TabIndex = 6;
            this.lblFeedback.Text = "Write your feedback here";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.Location = new System.Drawing.Point(45, 99);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(106, 20);
            this.labelDate.TabIndex = 4;
            this.labelDate.Text = "Incident date:";
            // 
            // lbl_IncidentDate
            // 
            this.lbl_IncidentDate.AutoSize = true;
            this.lbl_IncidentDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_IncidentDate.Location = new System.Drawing.Point(182, 99);
            this.lbl_IncidentDate.Name = "lbl_IncidentDate";
            this.lbl_IncidentDate.Size = new System.Drawing.Size(0, 20);
            this.lbl_IncidentDate.TabIndex = 5;
            // 
            // labelSubject
            // 
            this.labelSubject.AutoSize = true;
            this.labelSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSubject.Location = new System.Drawing.Point(45, 64);
            this.labelSubject.Name = "labelSubject";
            this.labelSubject.Size = new System.Drawing.Size(125, 20);
            this.labelSubject.TabIndex = 0;
            this.labelSubject.Text = "Incident subject:";
            // 
            // txt_Feedback
            // 
            this.txt_Feedback.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Feedback.Location = new System.Drawing.Point(54, 213);
            this.txt_Feedback.Multiline = true;
            this.txt_Feedback.Name = "txt_Feedback";
            this.txt_Feedback.Size = new System.Drawing.Size(368, 155);
            this.txt_Feedback.TabIndex = 2;
            // 
            // btn_SendFeedback
            // 
            this.btn_SendFeedback.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SendFeedback.Location = new System.Drawing.Point(54, 400);
            this.btn_SendFeedback.Name = "btn_SendFeedback";
            this.btn_SendFeedback.Size = new System.Drawing.Size(136, 54);
            this.btn_SendFeedback.TabIndex = 3;
            this.btn_SendFeedback.Text = "&Send feedback";
            this.btn_SendFeedback.UseVisualStyleBackColor = true;
            this.btn_SendFeedback.Click += new System.EventHandler(this.btn_SendFeedback_Click);
            // 
            // lbl_IncidentSubject
            // 
            this.lbl_IncidentSubject.AutoSize = true;
            this.lbl_IncidentSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_IncidentSubject.Location = new System.Drawing.Point(182, 64);
            this.lbl_IncidentSubject.Name = "lbl_IncidentSubject";
            this.lbl_IncidentSubject.Size = new System.Drawing.Size(0, 20);
            this.lbl_IncidentSubject.TabIndex = 1;
            // 
            // btnCancelEditTicket
            // 
            this.btnCancelEditTicket.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnCancelEditTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnCancelEditTicket.ForeColor = System.Drawing.SystemColors.Window;
            this.btnCancelEditTicket.Location = new System.Drawing.Point(176, 515);
            this.btnCancelEditTicket.Name = "btnCancelEditTicket";
            this.btnCancelEditTicket.Size = new System.Drawing.Size(140, 42);
            this.btnCancelEditTicket.TabIndex = 32;
            this.btnCancelEditTicket.Text = "Cancel";
            this.btnCancelEditTicket.UseVisualStyleBackColor = false;
            this.btnCancelEditTicket.Visible = false;
            this.btnCancelEditTicket.Click += new System.EventHandler(this.btnCancelEditTicket_Click);
            // 
            // TicketDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 575);
            this.Controls.Add(this.pnl_IncidentDetails);
            this.Controls.Add(this.pnl_AddFeedback);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TicketDetail";
            this.Text = "TicketDetail";
            this.pnl_IncidentDetails.ResumeLayout(false);
            this.pnl_IncidentDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.pnl_AddFeedback.ResumeLayout(false);
            this.pnl_AddFeedback.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_IncidentDetails;
        private System.Windows.Forms.ComboBox dropDownUsers;
        private System.Windows.Forms.Label NEWUSER_lblTitle;
        private System.Windows.Forms.ComboBox dropDownPriority;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.ComboBox dropDownDeadline;
        private System.Windows.Forms.Label lblDateReported;
        private System.Windows.Forms.ComboBox dropDownIncidents;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblDeadline;
        private System.Windows.Forms.Button btnAddFeedback;
        private System.Windows.Forms.Label lblPriority;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.DateTimePicker dateTimeIncident;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.Button btnEditTicket;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Panel pnl_AddFeedback;
        private System.Windows.Forms.Button btn_CancelFeedback;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFeedback;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label lbl_IncidentDate;
        private System.Windows.Forms.Label labelSubject;
        private System.Windows.Forms.TextBox txt_Feedback;
        private System.Windows.Forms.Button btn_SendFeedback;
        private System.Windows.Forms.Label lbl_IncidentSubject;
        private System.Windows.Forms.Button btnCancelEditTicket;
    }
}