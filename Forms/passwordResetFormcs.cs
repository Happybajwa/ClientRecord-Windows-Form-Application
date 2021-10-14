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
    public partial class passwordResetFormcs : Form
    {
        public passwordResetFormcs()
        {
            InitializeComponent();
            resetPanel.Hide();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            ApplicationDbContext context = new();
            var email = emailTextBox.Text;
            var user = context.Users.Where(u => u.EmailId.Equals(email)).FirstOrDefault();
            if(user != null)
            {
                securityQuestionLable.Text = user.SecurityQuestion;
            }
            else
            {
                MessageBox.Show("User with given Email not Found");
                emailTextBox.Text = "";
            }
        }

        private void submitButton_Click(object sender, EventArgs e)
        {

            ApplicationDbContext context = new();
            var email = emailTextBox.Text;
            var user = context.Users.Where(u => u.EmailId.Equals(email)).FirstOrDefault();
            var answer = answerTextBox.Text;
            var dob = resetDatePicker.Value.Date;
           

            if (answer.Equals(user.SecurityAnswer.FirstOrDefault()) && (dob.Equals(user.DateOfBirth)))
             {
                resetPanel.Show();
             }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            var pass = passtextBox.Text;
            var confrimPass = confirmPassTextBox.Text;

            ApplicationDbContext context = new();
            var email = emailTextBox.Text;
            var user = context.Users.Where(u => u.EmailId.Equals(email)).FirstOrDefault();
            if (pass.Equals(confrimPass))
            {
                user.Password = pass;
                context.Users.Update(user);
                if(MessageBox.Show("Your Password has been reset Successfully.\nPress Yes to go to login Page", "Password reset",MessageBoxButtons.YesNo) == (DialogResult.Yes))
                {
                    this.Hide();
                    LoginForm form = new();
                    form.Show();
                }else
                {
                    passtextBox.Text = "";
                    confirmPassTextBox.Text = "";
                    answerTextBox.Text = "";
                    emailTextBox.Text = "";
                }
              

            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm form = new();
            form.Show();
        }
    }
}
