using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Model;
using Logic;

namespace NoSQL_Pro_ject
{
    public partial class NoDesk : Form
    {
        // Services
        private readonly AuthenticationService authenticationService;
        private readonly UserService userService;
        private readonly TicketService ticketService;

        // User Management
        private DataTable userDataTable;
        private DataView userDataView;
        private string userfilter;

        // Ticket Management
        private DataTable ticketDataTable;
        private DataView ticketDataView;
        private string ticketFilter;

        public NoDesk()
        {
            InitializeComponent();            

            // Init services
            this.authenticationService = AuthenticationService.GetInstance();
            this.userService = new UserService();
            this.ticketService = new TicketService();

            // Init login panel
            Init_Login();

            // Show login panel
            ShowPanel(PanelType.LOGIN);
        }

        #region Panels
        private void ShowPanel(PanelType type)
        {
            HidePanels();

            if (type == PanelType.LOGIN)
            {
                pnlLogin.Show();
            }
            else if (type == PanelType.FORGOT)
            {
                pnl_ForgotPassword.Show();
                FORGOT_pnlCode.Hide();
                FORGOT_pnlChange.Hide();
            }
            else if (type == PanelType.USERSETTINGS)
            {
                pnl_Menu.Show();
                pnl_UserSettings.Show();
            }
            else if (type == PanelType.DASHBOARD)
            {
                InitDashBoard();

                pnl_Menu.Show();
                pnl_Dashboard.Show();
            }
            else if (type == PanelType.USERMANAGEMENT)
            {
                // Clean or add filter text
                USER_txtFilter.Text = "Filter by choice";
                USER_txtFilter.GotFocus += new EventHandler(RemoveText);
                USER_txtFilter.LostFocus += new EventHandler(AddText);

                // Start filtering selection at 1 aka Email
                USER_cbFilter.SelectedIndex = 1;

                // Init listview
                InitUserListView();

                pnl_Menu.Show();
                pnlUser.Show();
            }
            else if (type == PanelType.INCIDENTMANAGEMENT)
            {
                // Clean or add filter text
                TICKETS_txtFilter.Text = "Filter by email";
                TICKETS_txtFilter.GotFocus += new EventHandler(RemoveTextEmail);
                TICKETS_txtFilter.LostFocus += new EventHandler(AddTextEmail);

                // Start filtering selection at 2 aka User
                TICKETS_comboFilter.SelectedIndex = 2;

                // Init listview
                InitTicketOverview();

                // Show remove button if employee level access
                if (authenticationService.GetCurrentUser().Type == UserType.Employee)
                {
                    TICKET_btnRemove.Visible = true;
                }
                else
                {
                    TICKET_btnRemove.Visible = false;
                }

                pnl_Menu.Show();
                pnlTicketOverview.Show();

            }
        }

        public void AddTextEmail(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TICKETS_txtFilter.Text))
                TICKETS_txtFilter.Text = "Filter by email";
        }

        public void RemoveTextEmail(object sender, EventArgs e)
        {
            if (TICKETS_txtFilter.Text == "Filter by email")
            {
                TICKETS_txtFilter.Text = "";
            }
        }

        public void AddText(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(USER_txtFilter.Text))
                USER_txtFilter.Text = "Filter by choice";
        }

        public void RemoveText(object sender, EventArgs e)
        {
            if (USER_txtFilter.Text == "Filter by choice")
            {
                USER_txtFilter.Text = "";
            }
        }

        public enum PanelType
        {
            LOGIN, FORGOT, DASHBOARD, USERSETTINGS, USERMANAGEMENT, INCIDENTMANAGEMENT
        }

        private void HidePanels()
        {
            foreach (Control c in this.Controls)
            {
                if (c is Panel) c.Hide();
            }
        }
        #endregion Panels

        #region Menu
        private void LogoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Remove user information
            authenticationService.Logout();

            // Show username if checkbox was selected
            Init_Login();

            // Show login and hide others
            pnl_Menu.Hide();
            menuStrip.Hide();
            ShowPanel(PanelType.LOGIN);
        }

        private void ProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowPanel(PanelType.USERSETTINGS);
        }

        private void btn_Dashboard_Click(object sender, EventArgs e)
        {
            ShowPanel(PanelType.DASHBOARD);
        }

        private void btn_UserManagement_Click(object sender, EventArgs e)
        {
            if (authenticationService.IsEmployee())
            {
                ShowPanel(PanelType.USERMANAGEMENT);
            }
            else
            {
                MessageBox.Show("Only employee can use the User Management");
            }
        }

        private void btn_IncidentManagement_Click(object sender, EventArgs e)
        {
            ShowPanel(PanelType.INCIDENTMANAGEMENT);
        }
        #endregion Menubar

        #region Login
        /// <summary>
        /// Initialize login information if user had used the remember me checkbox
        /// </summary>
        private void Init_Login()
        {
            if (Properties.Settings.Default.Username != string.Empty)
            {
                LOGIN_txtUsername.Text = Properties.Settings.Default.Username;
                LOGIN_checkRemember.Checked = true;
            }
        }

        /// <summary>
        /// Save the username and checkbox status
        /// </summary>
        private void Save_Login()
        {
            if (LOGIN_checkRemember.Checked)
            {
                Properties.Settings.Default.Username = LOGIN_txtUsername.Text.ToLower();
                Properties.Settings.Default.RememberMe = "yes";
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.Username = "";
                Properties.Settings.Default.RememberMe = "no";
                Properties.Settings.Default.Save();
            }
        }

        private void LOGIN_btnLogin_Click(object sender, EventArgs e)
        {
            string username = LOGIN_txtUsername.Text.ToLower();
            string password = LOGIN_txtPassword.Text;

            // Check if username field is filled
            if (username == String.Empty)
            {
                errorProvider.SetError(LOGIN_txtUsername, "Please fill in your username");
            }

            // Check if password field is filled
            if (password == String.Empty)
            {
                errorProvider.SetError(LOGIN_txtPassword, "Please fill in your password");
            }

            if (authenticationService.Login(username, password, out string error))
            {
                // Save login name if checkbox checked
                Save_Login();
               
                // Hide login panel and show dashboard
                pnlLogin.Hide();                
                menuStrip.Show();
                ShowPanel(PanelType.DASHBOARD);

                // Clear username/password input and errors
                LOGIN_txtUsername.Text = string.Empty;
                LOGIN_txtPassword.Text = string.Empty;
                errorProvider.SetError(LOGIN_txtUsername, "");
                errorProvider.SetError(LOGIN_txtPassword, "");
            } else
            {
                // Show errors
                errorProvider.SetError(LOGIN_txtUsername, error);
                errorProvider.SetError(LOGIN_txtPassword, "Username and password do not match, please try again or click on request login details");
            }
        }
        #endregion Login

        #region Forgot Password
        private void LOGIN_lblForgot_Click(object sender, EventArgs e)
        {
            ShowPanel(PanelType.FORGOT);
        }

        private void FORGOT_btnUsername_Click(object sender, EventArgs e)
        {
            // Check if the field is not empty
            if (FORGOT_txtUsername.Text != string.Empty)
            {
                // Check if this email exists in the database
                if (authenticationService.CheckEmailStatus(FORGOT_txtUsername.Text.ToLower()))
                {
                    // Hide the reset password username/email panel and show the insert code panel
                    FORGOT_pnlUsername.Hide();
                    FORGOT_pnlCode.Show();

                    // Send an email with a code that the user needs to fill in to request a new randomized password by email
                    authenticationService.RequestResetCode(FORGOT_txtUsername.Text.ToLower());
                }
                else
                {
                    // Error message if the email is not found
                    errorProvider.SetError(FORGOT_txtUsername, "This email address has not been registered");
                }
            }
            else
            {
                errorProvider.SetError(FORGOT_txtUsername, "Please enter your email before continuing");
            }
        }

        private void FORGOT_btnCode_Click(object sender, EventArgs e)
        {
            // Check if the field is not empty
            if (FORGOT_txtCode.Text != String.Empty)
            {
                // Verify the code and send a new randomized password to the user
                if (authenticationService.ResetPassword(FORGOT_txtUsername.Text.ToLower(), FORGOT_txtCode.Text))
                {
                    // Hide insert code panel and show password successful reset panel
                    FORGOT_pnlCode.Hide();
                    FORGOT_pnlChange.Show();

                    // Clear code input and error
                    FORGOT_txtCode.Text = string.Empty;
                    errorProvider.SetError(FORGOT_txtCode, "");
                }
                else
                {
                    // Error message if the code does not match
                    errorProvider.SetError(FORGOT_txtCode, "Code does not match to the one that we send to your email");
                }
            }
            else
            {
                errorProvider.SetError(FORGOT_txtCode, "Please enter the code before continuing");
            }
        }

        private void FORGOT_btnNewCode_Click(object sender, EventArgs e)
        {
            FORGOT_pnlUsername.Show();
            FORGOT_pnlCode.Hide();
            FORGOT_pnlChange.Hide();
        }

        private void FORGOT_btnBackFromCode_Click(object sender, EventArgs e)
        {
            ShowPanel(PanelType.LOGIN);
            FORGOT_pnlUsername.Show();
        }

        private void FORGOT_btnResetComplete_Click(object sender, EventArgs e)
        {
            ShowPanel(PanelType.LOGIN);
            FORGOT_pnlUsername.Show();
        }
        #endregion Forgot Password

        #region User Settings
        private void SET_btnSave_Click(object sender, EventArgs e)
        {

            // Validate information
            bool error = false;
            if (SET_txtNewPassword.Text != SET_txtConfrimNewPassword.Text)
            {
                errorProvider.SetError(SET_txtConfrimNewPassword, "Confirm password does not match the new password");
                error = true;
            }

            if (!userService.CheckPassword(authenticationService.GetCurrentUser().Email, SET_txtOldPassword.Text))
            {
                errorProvider.SetError(SET_txtOldPassword, "This password does not match your email");
                error = true;
            }

            if (SET_txtNewPassword.Text == String.Empty)
            {
                errorProvider.SetError(SET_txtNewPassword, "Please fill in a new password");
                error = true;
            }

            if (SET_txtConfrimNewPassword.Text == String.Empty)
            {
                errorProvider.SetError(SET_txtConfrimNewPassword, "Please repeat your new password");
                error = true;
            }

            if (SET_txtOldPassword.Text == String.Empty)
            {
                errorProvider.SetError(SET_txtOldPassword, "Please fill in your old password");
                error = true;
            }

            // Change password
            if (error == false)
            {
                if (userService.ChangePassword(authenticationService.GetCurrentUser().Email, SET_txtNewPassword.Text))
                {
                    MessageBox.Show("Your password has been changed");

                    SET_txtNewPassword.Text = string.Empty;
                    SET_txtConfrimNewPassword.Text = string.Empty;
                    SET_txtOldPassword.Text = string.Empty;

                    // Go to dashboard
                    ShowPanel(PanelType.DASHBOARD);
                }
                else
                {
                    MessageBox.Show("Failed changing your password");
                }
            }
        }
        #endregion User Settings

        #region Dashboard
        private void InitDashBoard()
        {
            List<Ticket> tickets;

            if (authenticationService.IsEmployee())
            {
                tickets = ticketService.GetTickets();
            }
            else
            {
                tickets = ticketService.GetTickets(authenticationService.GetCurrentUser().Email);
            }

            int unresolvedTickets = 0;
            int pastDeadline = 0;

            // Go through List of tickets to see how many are open/unresolved
            foreach (Ticket ticket in tickets)
            {
                if (ticket.Status == TicketStatus.Open || ticket.Status == TicketStatus.Unresolved)
                {
                    unresolvedTickets++;
                }
                if ((ticket.Status == TicketStatus.Open || ticket.Status == TicketStatus.Unresolved) && (DateTime.Now > ticket.Deadline))
                {
                    pastDeadline++;
                }
            }

            // Assign values to 'Unresolved' Circular Progress Bar
            cpb_Unresolved.Minimum = 0;
            cpb_Unresolved.Maximum = tickets.Count();
            cpb_Unresolved.Value = unresolvedTickets;
            cpb_Unresolved.Text = unresolvedTickets.ToString() + "/" + tickets.Count.ToString();

            // Assign values to 'Past Deadline' Circular Progress Bar
            cpb_PastDeadline.Minimum = 0;
            cpb_PastDeadline.Maximum = unresolvedTickets;
            cpb_PastDeadline.Value = pastDeadline;
            cpb_PastDeadline.Text = pastDeadline.ToString();
        }

        private void btn_ShowList_Click(object sender, EventArgs e)
        {
            ShowPanel(PanelType.INCIDENTMANAGEMENT);
        }
        #endregion Dashboard

        #region User Management
        private void USER_btnNewUser_Click(object sender, EventArgs e)
        {
            AddUser addUser = new AddUser();
            addUser.Show();
        }

        private void InitUserListView()
        {
            // Get users
            List<User> users = userService.GetUsers();

            // Create datatable and fill it
            userDataTable = new DataTable();
            userDataTable.Columns.Add("ID");
            userDataTable.Columns.Add("Email");
            userDataTable.Columns.Add("First_Name");
            userDataTable.Columns.Add("Last_Name");
            userDataTable.Columns.Add("# tickets");
            FillUserDataTable(users);

            // Create dataview with the datatable
            userDataView = new DataView(userDataTable);

            // Populate listview for the user
            PopulateListViewUsers(userDataView);
        }

        private void PopulateListViewUsers(DataView dv)
        {
            // Clear the previous list items
            USER_listViewUsers.Items.Clear();

            foreach (DataRow row in dv.ToTable().Rows)
            {
                USER_listViewUsers.Items.Add(new ListViewItem(new String[]
                {
                    row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString()
                }));
            }
        }

        private void FillUserDataTable(List<User> users)
        {
            if (users != null)
            {
                // Fill list with product items
                foreach (User user in users)
                {
                    userDataTable.Rows.Add(user.Id, user.Email, user.FirstName, user.LastName, user.AmountOfIncidents);
                }
            }
            else
            {
                MessageBox.Show("Users could not be retrieved from database");
            }
        }

        private void USER_txtFilter_TextChanged(object sender, EventArgs e)
        {
            if (USER_txtFilter.Text != "Filter by choice")
            {
                userDataView.RowFilter = string.Format("{0} Like '%{1}%'", userfilter, USER_txtFilter.Text);
                PopulateListViewUsers(userDataView);
            }
        }

        private void USER_cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            userfilter = USER_cbFilter.Text;
        }

        #endregion User Mangement
        
        #region Ticket Overview
        private void TICKETS_btnCreateIncident_Click(object sender, EventArgs e)
        {
            TicketForm ticketForm = new TicketForm();
            ticketForm.Show();
        }

        private void TICKETS_txtFilterEmail_TextChanged(object sender, EventArgs e)
        {
            if (TICKETS_txtFilter.Text != "Filter by email")
            {
                ticketDataView.RowFilter = string.Format("{0} Like '%{1}%'", ticketFilter, TICKETS_txtFilter.Text);
                PopulateListViewTickets(ticketDataView);
            }
        }

        private void TICKETS_comboFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            ticketFilter = TICKETS_comboFilter.Text;
        }

        private void InitTicketOverview()
        {
            List<Ticket> tickets;

            if (authenticationService.IsEmployee())
            {
                tickets = ticketService.GetTickets();
            } else
            {
                tickets = ticketService.GetTickets(authenticationService.GetCurrentUser().Email);
            }            

            ticketDataTable = new DataTable();
            ticketDataTable.Columns.Add("ID");
            ticketDataTable.Columns.Add("Subject");
            ticketDataTable.Columns.Add("User");
            ticketDataTable.Columns.Add("Date");
            ticketDataTable.Columns.Add("Status");
            FillTicketDataTable(tickets);

            ticketDataView = new DataView(ticketDataTable);

            PopulateListViewTickets(ticketDataView);
        }

        private void FillTicketDataTable(List<Ticket> tickets)
        {
            if (tickets != null)
            {
                foreach (Ticket ticket in tickets)
                {
                    ticketDataTable.Rows.Add(ticket.ID, ticket.Subject, ticket.User, ticket.Date, ticket.Status);
                }
            }
            else
            {
                MessageBox.Show("Tickets could not be retrieved from database");
            }
        }

        private void PopulateListViewTickets(DataView dataView)
        {
            TICKETS_listViewTickets.Items.Clear();

            foreach (DataRow row in dataView.ToTable().Rows)
            {
                TICKETS_listViewTickets.Items.Add(new ListViewItem(new String[]
                {
                    row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString()
                }));
            }
        }

        private void TICKET_btnDetails_Click(object sender, EventArgs e)
        {
            try
            {
                string id = TICKETS_listViewTickets.SelectedItems[0].Text;
                TicketDetail detail = new TicketDetail(id);
                detail.Show();
            }
            catch
            {
                MessageBox.Show("Select one of the incidents to view its details");
            }
        }

        private void TICKET_btnRemove_Click(object sender, EventArgs e)
        {
            try
            {                
                var confirmResult = MessageBox.Show("Are you sure you want to delete this incident?", "Confirm Delete", MessageBoxButtons.OKCancel);
                if (confirmResult == DialogResult.OK)
                {
                    // Get incident id
                    string id = TICKETS_listViewTickets.SelectedItems[0].Text;

                    // Remove ticket by id
                    ticketService.RemoveTicket(id, ticketService.GetTicket(id).User);

                    // Refresh panel
                    ShowPanel(PanelType.INCIDENTMANAGEMENT);
                }
            }
            catch
            {
                MessageBox.Show("Select one of the incidents before trying to delete");
            }
        }

        #endregion Ticket Overview

        #region Column Sorting
        private void USER_listViewUsers_ColumnClick(object sender, ColumnClickEventArgs e) => SortColumn(USER_listViewUsers, e);
        private void TICKETS_listViewTickets_ColumnClick(object sender, ColumnClickEventArgs e) => SortColumn(TICKETS_listViewTickets, e);

        // The column we are currently using for sorting.
        private ColumnHeader SortingColumn = null;

        // Method for sorting a column in a ListView //
        private void SortColumn(ListView listView, ColumnClickEventArgs e)
        {
            // Get the new sorting column.
            ColumnHeader new_sorting_column = listView.Columns[e.Column];

            // Figure out the new sorting order.
            System.Windows.Forms.SortOrder sort_order;
            if (SortingColumn == null)
            {
                // New column. Sort ascending.
                sort_order = SortOrder.Ascending;
            }
            else
            {
                // See if this is the same column.
                if (new_sorting_column == SortingColumn)
                {
                    // Same column. Switch the sort order.
                    if (SortingColumn.Text.StartsWith("> "))
                    {
                        sort_order = SortOrder.Descending;
                    }
                    else
                    {
                        sort_order = SortOrder.Ascending;
                    }
                }
                else
                {
                    // New column. Sort ascending.
                    sort_order = SortOrder.Ascending;
                }

                // Remove the old sort indicator.
                SortingColumn.Text = SortingColumn.Text.Substring(2);
            }

            // Display the new sort order.
            SortingColumn = new_sorting_column;
            if (sort_order == SortOrder.Ascending)
            {
                SortingColumn.Text = "> " + SortingColumn.Text;
            }
            else
            {
                SortingColumn.Text = "< " + SortingColumn.Text;
            }

            // Create a comparer.
            listView.ListViewItemSorter =
                new ListViewComparer(e.Column, sort_order);

            // Sort.
            listView.Sort();
        }
        #endregion Column Sorting
    }
}
