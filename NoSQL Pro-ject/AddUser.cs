using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Logic;
using System.ComponentModel.DataAnnotations;

namespace NoSQL_Pro_ject
{
    public partial class AddUser : Form
    {
        private readonly UserService userService;

        public AddUser()
        {
            InitializeComponent();

            // Get the dropdownlist values
            InitializeForm();

            // Init userService
            this.userService = new Logic.UserService();
        }

        public void InitializeForm()
        {
            // Get all user types and add them to the dropdown
            var types = Enum.GetValues(typeof(Model.UserType));
            foreach (Model.UserType type in types)
            {
                NEWUSER_comboBoxType.Items.Add(type);
            }

            // Get all locations and add them to the dropdown
            var locations = Enum.GetValues(typeof(Model.LocationEnum));
            foreach (Model.LocationEnum location in locations)
            {
                NEWUSER_comboBoxLocation.Items.Add(location);
            }
        }

        private void NEWUSER_btnCreate_Click(object sender, EventArgs e)
        {
            // Validate the account information
            if (ValidateUser())
            {
                // Check if the email already has an account attached to it
                if (!userService.IsRegistered(NEWUSER_txtEmail.Text))
                {
                    // Get all user information from form
                    Model.User user = new Model.User
                    {
                        FirstName = NEWUSER_txtFirstName.Text,
                        LastName = NEWUSER_txtLastName.Text,
                        Type = (Model.UserType)NEWUSER_comboBoxType.SelectedIndex + 1,
                        Email = NEWUSER_txtEmail.Text.ToLower(),
                        PhoneNumber = NEWUSER_txtPhone.Text,
                        Location = NEWUSER_comboBoxLocation.Text,
                    };

                    // Add user to the database
                    userService.AddUser(user, NEWUSER_checkboxPassword.Checked);

                    MessageBox.Show("User added!");
                    this.Close();
                }
                else
                {
                    errorProvider.SetError(NEWUSER_txtEmail, "Email already has an account attached to it");
                }
            } 
        }

        private bool ValidateUser()
        {
            bool noError = true;

            if (NEWUSER_txtFirstName.Text == String.Empty)
            {
                errorProvider.SetError(NEWUSER_txtFirstName, "Please fill in the first name");
                noError = false;
            }
            else
            {
                errorProvider.SetError(NEWUSER_txtFirstName, "");
            }

            if (NEWUSER_txtLastName.Text == String.Empty)
            {
                errorProvider.SetError(NEWUSER_txtLastName, "Please fill in the last name");
                noError = false;
            }
            else
            {
                errorProvider.SetError(NEWUSER_txtLastName, "");
            }

            if (NEWUSER_txtEmail.Text == String.Empty)
            {
                errorProvider.SetError(NEWUSER_txtEmail, "Please fill in the email");
                noError = false;
            } else if (!new EmailAddressAttribute().IsValid(NEWUSER_txtEmail.Text))
            {
                errorProvider.SetError(NEWUSER_txtEmail, "Please fill in a valid email");
                noError = false;
            }
            else
            {
                errorProvider.SetError(NEWUSER_txtEmail, "");
            }

            if (NEWUSER_txtPhone.Text == String.Empty)
            {
                errorProvider.SetError(NEWUSER_txtPhone, "Please fill in the phone number");
                noError = false;
            } else if (!Regex.Match(NEWUSER_txtPhone.Text, @"^[0-9]+$").Success)
            {
                errorProvider.SetError(NEWUSER_txtPhone, "The phone number can only contain numbers");
                noError = false;
            }
            else
            {
                errorProvider.SetError(NEWUSER_txtPhone, "");
            }

            if (NEWUSER_comboBoxType.Text == String.Empty)
            {
                errorProvider.SetError(NEWUSER_comboBoxType, "Please select the user type");
                noError = false;
            }
            else
            {
                errorProvider.SetError(NEWUSER_comboBoxType, "");
            }

            if (NEWUSER_comboBoxLocation.Text == String.Empty)
            {
                errorProvider.SetError(NEWUSER_comboBoxLocation, "Please select the location");
                noError = false;
            }
            else
            {
                errorProvider.SetError(NEWUSER_comboBoxLocation, "");
            }

            return noError;
        }

        private void NEWUSER_btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
