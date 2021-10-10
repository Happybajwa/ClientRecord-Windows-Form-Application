using ClientRecord.Models;
using Microsoft.EntityFrameworkCore;
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
    public partial class updateClient : Form
    {
        public updateClient()
        {
            InitializeComponent();
        }
        ApplicationDbContext datalist = new();
       
        private void searchClientTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            string searchtext = searchClientTextBox.Text;
            var context = new ApplicationDbContext();
            var clients = context.Clients.Where(c => c.FirstName.Contains(searchtext) || c.LastName.Contains(searchtext) || c.EmailId.Contains(searchtext)).ToList();
            dataGrid.DataSource = clients;
        }

        private void updateClient_Load(object sender, EventArgs e)
        {

        }

        private void clearlink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            dataGrid.Rows.Clear();
            dataGrid.Refresh();
        }
    }
}
