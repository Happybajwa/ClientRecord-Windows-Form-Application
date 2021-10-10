using ClientRecord.Models;
using ClientRecord.Forms;
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
    public partial class mainForm : Form
    {

        private Form activeForm;
        
        public mainForm()
        {
            InitializeComponent();
        }
        private void OpenChildForm(Form childForm, object btnsender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopPane.Controls.Add(childForm);
            this.panelDesktopPane.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                this.Hide();
                 mainForm form = new();
                form.ShowDialog();
                
            }
        }

    

        private void addClientButton_Click(object sender, EventArgs e)
        {
            movingPanel.Height = addClientButton.Height;
            movingPanel.Top = addClientButton.Top;
            OpenChildForm(new Forms.addClientForm(), sender);
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            movingPanel.Height = homeButton.Height;
            movingPanel.Top = homeButton.Top;
            OpenChildForm(new Forms.homeForm(), sender);
        }

        private void updateClientButton_Click(object sender, EventArgs e)
        {
            movingPanel.Height = updateClientButton.Height;
            movingPanel.Top = updateClientButton.Top;
            OpenChildForm(new Forms.updateClient(), sender);
        }

        private void deleteClientButton_Click(object sender, EventArgs e)
        {
            movingPanel.Height = deleteClientButton.Height;
            movingPanel.Top = deleteClientButton.Top;
            OpenChildForm(new Forms.deleteClientForm(), sender);
        }

        private void viewAllButton_Click(object sender, EventArgs e)
        {
            movingPanel.Height = viewAllButton.Height;
            movingPanel.Top = viewAllButton.Top;
            OpenChildForm(new Forms.viewAllClientForm(), sender);
        }

        private void addUserButton_Click(object sender, EventArgs e)
        {
            movingPanel.Height = addUserButton.Height;
            movingPanel.Top = addUserButton.Top;
            OpenChildForm(new Forms.addUserForm(), sender);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Do you want to SignOut","Signout", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
                LoginForm form = new();
                form.ShowDialog();
            }
           
        }

        private void button6_Click(object sender, EventArgs e)
        {
            movingPanel.Height = addUserButton.Height;
            movingPanel.Top = addUserButton.Top;
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ApplicationDbContext model = new();
            int count = model.Clients.Where(c => c.Type.Equals("Parmanent")).ToList().Count;
            textBox1.Text = count.ToString();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            ApplicationDbContext model = new();
            int count = model.Clients.Where(c => c.Type.Equals("Parmanent")).ToList().Count;
            textBox1.Text = count.ToString();
        }
    }
}
