using ClientRecord.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientRecord.Forms
{
    public partial class addUserForm : Form
    {
        public addUserForm()
        {
            InitializeComponent();
        }

        private async void addUserButton_Click(object sender, EventArgs e)
        {
            ApplicationDbContext clientContext = new();

            var user = new User()
            {
                EmailId = emailTextBox.Text,
                FirstName = firstNameTextBox.Text,
                LastName = lastNameTextBox.Text,
                Password = passTextBox.Text,
                Gender = genderComboBox.Text,
                DateOfBirth = dateTimePicker.Value,
                SecurityQuestion = securityQuestionTextBox.Text,
                SecurityAnswer = securityAnserTextBox.Text
            };
            if (!passTextBox.Text.Equals(confirmPassTextBox.Text))
            {
                MessageBox.Show("Password didnt mmmmatch. Please Check Again. \nThankyou");
            }
            else
            {
                await clientContext.Users.AddAsync(user);
                await clientContext.SaveChangesAsync();
                MessageBox.Show("User has been Added to System Successfully", "Sucess");
            }
        }
    }
}
