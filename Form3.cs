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
    public partial class Form3 : Form
    {
        public Form3()
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
                    Form1 form = new Form1();
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
            Form2 form = new();
            this.Hide();
            form.ShowDialog();
        }
    }
}
