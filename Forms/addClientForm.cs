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
    public partial class addClientForm : Form
    {
        public addClientForm()
        {
            InitializeComponent();
        }
        private async void addButton_Click(object sender, EventArgs e)
        {
            ApplicationDbContext clientContext = new();

            var client = new Client()
            {
                EmailId = emailTextBox.Text,
                FirstName = firstNameTextBox.Text,
                LastName = lastNameTextBox.Text,
                DateOfBirth = dateTimePicker.Value,
                Gender = genderComboBox.Text,
                Phone = contactTextBox.Text,
                Type = clientComboBox.Text,
                Address = addressTextBox.Text,
            };

            await clientContext.Clients.AddAsync(client);
            await clientContext.SaveChangesAsync();
            MessageBox.Show("Client has been Added successfully", "Sucess");
        }
    }
}
