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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

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

            };
            if (!passTextBox.Text.Equals(confirmPassTextBox.Text))
            {
                MessageBox.Show("Password didnt mmmmatch. Please Check Again. \nThankyou");
            }else
            {
                await clientContext.Users.AddAsync(user);
                await clientContext.SaveChangesAsync();
                MessageBox.Show("User has been Added to System Successfully", "Sucess");
            }
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form = new();
            this.Hide();
            form.ShowDialog();
        }
    }
}
