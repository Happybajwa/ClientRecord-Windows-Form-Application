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
    public partial class viewAllClientForm : Form
    {
        public viewAllClientForm()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ApplicationDbContext context = new();
            var clients = context.Clients.ToList();
            dataGrid.DataSource = clients;
        }
    }
}
