using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using Logic;

namespace NoSQL_Pro_ject
{
    public partial class TicketDetail : Form
    {
        private readonly AuthenticationService authenticationService;
        private readonly TicketService ticketService;
        private readonly string id;
        private readonly Ticket ticket;

        public TicketDetail(string id)
        {
            InitializeComponent();
            pnl_AddFeedback.Hide();

            this.authenticationService = AuthenticationService.GetInstance();
            this.ticketService = new TicketService();
            this.id = id;

            // Get ticket details with the ID provided
            this.ticket = ticketService.GetTicket(id);

            if (authenticationService.GetCurrentUser().Type == UserType.Employee)
            {
                btnEditTicket.Visible = true;
            }
            else if (ticket.Status == TicketStatus.Resolved || ticket.Status == TicketStatus.Closed)
            {
                btnAddFeedback.Visible = true;
            }


            if (ticket == null)
            {
                MessageBox.Show("Could not retrieve ticket information");
                this.Close();
            } else
            {
               FillTicketDetails();
            }
        }

        private void BtnSaveChanges_Click(object sender, EventArgs e)
        {
            if (CheckFields())
            {
                DateTime deadline = dateTimeIncident.Value.Date;
                if (dropDownDeadline.Text == "7 days")
                {
                    deadline = DateTime.Today.AddDays(7);
                }
                else if (dropDownDeadline.Text == "14 days")
                {
                    deadline = DateTime.Today.AddDays(14);
                }
                else if (dropDownDeadline.Text == "28 days")
                {
                    deadline = DateTime.Today.AddDays(28);
                }
                else if (dropDownDeadline.Text == "6 months")
                {
                    deadline = DateTime.Today.AddDays(182);
                }

                Model.Ticket newTicket = new Model.Ticket
                {
                    Date = dateTimeIncident.Value.Date,
                    Subject = txtSubject.Text,
                    User = dropDownUsers.Text,
                    Priority = dropDownPriority.Text,
                    Deadline = deadline,
                    Description = txtDescription.Text,
                    Type = dropDownIncidents.Text,
                    Status = (TicketStatus)cmbStatus.SelectedIndex
                };

                ticketService.ReplaceTicket(id, newTicket);

                MessageBox.Show("Edits saved!");

                // Return form readonly state
                dateTimeIncident.Enabled = false;
                txtSubject.Enabled = false;
                dropDownUsers.Enabled = false;
                txtDescription.Enabled = false;
                dropDownIncidents.Enabled = false;
                dropDownPriority.Enabled = false;
                dropDownDeadline.Enabled = false;
                cmbStatus.Enabled = false;
                btnEditTicket.Show();
                btnSaveChanges.Hide();
                btnCancelEditTicket.Hide();
            }
        }

        private void BtnAddFeedback_Click(object sender, EventArgs e)
        {
            pnl_IncidentDetails.Hide();
            pnl_AddFeedback.Show();
            lbl_IncidentSubject.Text = ticket.Subject;
            lbl_IncidentDate.Text = ticket.Date.ToString("dddd, dd MMMM yyyy");
        }

        private void BtnEditTicket_Click(object sender, EventArgs e)
        {
            dateTimeIncident.Enabled = true;
            txtSubject.Enabled = true;
            dropDownUsers.Enabled = false; // "Reported by user" cannot be modified
            txtDescription.Enabled = true;
            dropDownIncidents.Enabled = true;
            dropDownPriority.Enabled = true;
            dropDownDeadline.Enabled = true;
            cmbStatus.Enabled = true;
            btnEditTicket.Hide();
            btnSaveChanges.Show();
            btnCancelEditTicket.Show();
        }

        private bool CheckFields()
        {
            bool noError = true;

            if (dateTimeIncident.Value.ToString() == String.Empty)
            {
                errorProvider.SetError(dateTimeIncident, "Please select the date of incident");
                noError = false;
            }
            else
            {
                errorProvider.SetError(dateTimeIncident, "");
            }

            if (txtSubject.Text == String.Empty)
            {
                errorProvider.SetError(txtSubject, "Please fill in the subject of your error");
                noError = false;
            }
            else
            {
                errorProvider.SetError(txtSubject, "");
            }

            if (dropDownUsers.Text == String.Empty)
            {
                errorProvider.SetError(dropDownUsers, "Please select a user");
                noError = false;
            }
            else
            {
                errorProvider.SetError(dropDownUsers, "");
            }

            if (dropDownPriority.Text == String.Empty)
            {
                errorProvider.SetError(dropDownPriority, "Please select a priority");
                noError = false;
            }
            else
            {
                errorProvider.SetError(dropDownPriority, "");
            }

            if (dropDownDeadline.Text == String.Empty)
            {
                errorProvider.SetError(dropDownDeadline, "Please select a deadline");
                noError = false;
            }
            else
            {
                errorProvider.SetError(dropDownDeadline, "");
            }

            if (txtDescription.Text == String.Empty)
            {
                errorProvider.SetError(txtDescription, "Please provide a description");
                noError = false;
            }
            else
            {
                errorProvider.SetError(txtDescription, "");
            }
            if (dropDownIncidents.Text == String.Empty)
            {
                errorProvider.SetError(dropDownIncidents, "Please select incident type");
                noError = false;
            }
            else
            {
                errorProvider.SetError(dropDownIncidents, "");
            }

            return noError;
        }

        private bool CheckFeedbackFields()
        {
            bool noError = true;
            if (txt_Feedback.Text == String.Empty)
            {
                errorProvider.SetError(txt_Feedback, "Feedback field can not be empty. Please write some feedback or press cancel");
                noError = false;
            }
            else
            {
                errorProvider.SetError(txt_Feedback, "");
            }
            return noError;
        }

        private void btn_CancelFeedback_Click(object sender, EventArgs e)
        {
            pnl_AddFeedback.Hide();
            pnl_IncidentDetails.Show();
        }

        private void btn_SendFeedback_Click(object sender, EventArgs e)
        {
            if (CheckFeedbackFields())
            {
                Model.Ticket newTicket = new Model.Ticket
                {
                    Date = ticket.Date,
                    Subject = ticket.Subject,
                    User = ticket.User,
                    Priority = ticket.Priority,
                    Deadline = ticket.Deadline,
                    Description = ticket.Description,
                    Type = ticket.Type,
                    Status = ticket.Status,
                    Feedback = txt_Feedback.Text
                };

                ticketService.SendFeedback(id, newTicket);

                MessageBox.Show("Feedback saved!");
                this.Close();
            }
        }

        private void btnCancelEditTicket_Click(object sender, EventArgs e)
        {
            //Refill original ticket details
            FillTicketDetails();

            // Return form readonly state
            dateTimeIncident.Enabled = false;
            txtSubject.Enabled = false;
            dropDownUsers.Enabled = false;
            txtDescription.Enabled = false;
            dropDownIncidents.Enabled = false;
            dropDownPriority.Enabled = false;
            dropDownDeadline.Enabled = false;
            cmbStatus.Enabled = false;
            btnEditTicket.Show();
            btnSaveChanges.Hide();
            btnCancelEditTicket.Hide();
        }

        private void FillTicketDetails()
        {
            // Fill ticket details
            dateTimeIncident.Value = ticket.Date;
            txtSubject.Text = ticket.Subject;
            dropDownUsers.Text = ticket.User;
            txtDescription.Text = ticket.Description;

            if (ticket.Type == "Software")
            {
                dropDownIncidents.SelectedIndex = 0;
            }
            else if (ticket.Type == "Hardware")
            {
                dropDownIncidents.SelectedIndex = 1;
            }
            else if (ticket.Type == "Service")
            {
                dropDownIncidents.SelectedIndex = 2;
            }
            else
            {
                dropDownIncidents.Text = ticket.Type;
            }

            if (ticket.Priority == "Low")
            {
                dropDownPriority.SelectedIndex = 0;
            }
            else if (ticket.Priority == "Normal")
            {
                dropDownPriority.SelectedIndex = 1;
            }
            else if (ticket.Priority == "High")
            {
                dropDownPriority.SelectedIndex = 2;
            }
            else
            {
                dropDownPriority.Text = ticket.Priority;
            }

            int days = (int)(ticket.Deadline - ticket.Date).TotalDays;
            if (days == 7)
            {
                dropDownDeadline.SelectedIndex = 0;
            }
            else if (days == 14)
            {
                dropDownDeadline.SelectedIndex = 1;
            }
            else if (days == 28)
            {
                dropDownDeadline.SelectedIndex = 2;
            }
            else
            {
                dropDownDeadline.SelectedIndex = 3;
            }

            if (ticket.Status == TicketStatus.Open)
            {
                cmbStatus.SelectedIndex = 0;
            }
            else if (ticket.Status == TicketStatus.Closed)
            {
                cmbStatus.SelectedIndex = 1;
            }
            else if (ticket.Status == TicketStatus.Resolved)
            {
                cmbStatus.SelectedIndex = 2;
            }
            else if (ticket.Status == TicketStatus.Unresolved)
            {
                cmbStatus.SelectedIndex = 3;
            }
        }
    }
}
