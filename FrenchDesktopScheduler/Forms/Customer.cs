using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrenchDesktopScheduler.Forms
{
	public partial class Customer : Form
	{
		public Customer()
		{
			InitializeComponent();
			dgvLoad();
		}

		private void toLandingButton_Click(object sender, EventArgs e)
		{
			this.Hide();
			LandingPage landingPage = new LandingPage();
			landingPage.Show();
		}

		// Opens the AddCustomer Form
		private void addCustomerButton_Click(object sender, EventArgs e)
		{
			this.Hide();
			AddCustomer toAddCustomer = new AddCustomer();
			toAddCustomer.Show();
		}

		// Opens the EditCustomer Form
		private void editCustomerButton_Click(object sender, EventArgs e)
		{
			if (customerDataGridView.SelectedRows.Count == 1)
			{
				this.Hide();
				EditCustomer toEditCustomer = new EditCustomer();
				toEditCustomer.Show();
			}
			else
			{
				MessageBox.Show("Please Select at Least One Row.", "Null Error",
				MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		// Adds information from the customer table to the DGV upon the for loading
		private void dgvLoad ()
		{
			MySqlConnection con = new MySqlConnection("server=127.0.0.1;userid=sqlUser;password=Passw0rd!;database=client_schedule");
			con.Open();
			String sqlString = "SELECT * FROM customer";
			MySqlCommand cmd = new MySqlCommand(sqlString, con);
			MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
			DataTable customerDT = new DataTable();
			adp.Fill(customerDT);

			customerDataGridView.DataSource = customerDT;
			customerDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			customerDataGridView.AllowUserToAddRows = false;
			
		}

		// Clears the selection bar upon loading and until user selects a row
		private void myBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
		{
			customerDataGridView.ClearSelection();
		}
	}
}
