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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            ApplicationDbContext context = new();
            var user = context.Users.Where(u => u.EmailId.Equals(usernameTextBox.Text)).FirstOrDefault();
            if (user != null)
            {
                if(user.Password.Equals(passwordTextBox.Text))
                {
                    mainForm form = new mainForm();
                    form.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Sorry user or passsword did not match");
                }
            }
            else
            {
                MessageBox.Show("Sorry user or passsword did not match");
            }
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            registerUserForm form = new();
            this.Hide();
            form.ShowDialog();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
