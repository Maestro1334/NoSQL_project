using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Logic;
using System.ComponentModel.DataAnnotations;

namespace NoSQL_Pro_ject
{
    public partial class TicketForm : Form
    {
        private readonly TicketService ticketService;
        private readonly UserService userService;
        private List<Model.User> users;
        private AuthenticationService authenticationService;

        public TicketForm()
        {
            InitializeComponent();

            this.ticketService = new Logic.TicketService();
            this.authenticationService = AuthenticationService.GetInstance();
            this.userService = new Logic.UserService();
            InitializeForm();
        }

        public void InitializeForm()
        {            
            dropDownUsers.Text = authenticationService.GetCurrentUser().Email;
            users = userService.GetUsers();

            foreach (Model.User user in users)
            {
                string name = user.Email;
                dropDownUsers.Items.Add(name);
            }

        }

        private void btnSubmitTicket_Click(object sender, EventArgs e)
        {
            if(CheckFields())
            {
                DateTime deadline = DateTime.Now;
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
                    Type = dropDownIncidents.Text
                };

                ticketService.AddTicket(newTicket);

                MessageBox.Show("Ticket sent!");
                this.Close();
            }
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
