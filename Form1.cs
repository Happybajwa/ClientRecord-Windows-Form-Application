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

namespace ClientRecord
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
  
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                this.Hide();
                 Form1 form = new();
                form.ShowDialog();
                
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

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
                Gender  = genderComboBox.Text,
                Phone = contactTextBox.Text,
                Type = clientComboBox.Text,
                Address = addressTextBox.Text,
            };

                await clientContext.Clients.AddAsync(client);
                await clientContext.SaveChangesAsync();
            MessageBox.Show("Client Added", "Sucess");

        }

        private void firstNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void lastNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void genderComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void contactTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void clientComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void addressTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void proofTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
