using ClientRecord.Models;
using Microsoft.Data.SqlClient;
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
    public partial class deleteClientForm : Form
    {
        public deleteClientForm()
        {
            InitializeComponent();
        }
        private void dataGrid_CellMouseDoubleClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(MessageBox.Show("Do you want to delete this client.", "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                ApplicationDbContext context = new();
                int clientId = Convert.ToInt32(dataGrid.Rows[e.RowIndex].Cells["ClientId"].Value);
                context.Clients.Remove(context.Clients.Find(clientId));
                MessageBox.Show("Client has been Deleted Successfully", "Sucess");
                context.SaveChanges();
                dataGrid.Refresh();
                var clients = context.Clients.ToList();
                dataGrid.DataSource = clients;
                }
        }

        private void deleteClientTextBox_TextChanged_1(object sender, EventArgs e)
        {
            string searchtext = deleteClientTextBox.Text;
            var context = new ApplicationDbContext();
            var customers = context.Clients.Where(c => c.FirstName.Contains(searchtext) || c.LastName.Contains(searchtext) || c.EmailId.Contains(searchtext)).ToList();
            dataGrid.DataSource = customers;
        }
    }
}
