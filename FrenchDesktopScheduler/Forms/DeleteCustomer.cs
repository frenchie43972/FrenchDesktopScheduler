using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrenchDesktopScheduler.Forms
{
	public partial class DeleteCustomer : Form
	{
		public DeleteCustomer()
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

		private void deleteCustomerButton_Click(object sender, EventArgs e)
		{
			if (customerDeleteDataGridView.SelectedRows.Count > 0)
			{
				DialogResult result = MessageBox.Show("Are you sure you want to permanently delete this item?", "Delete Item?",
				MessageBoxButtons.YesNo);
				if (result == DialogResult.Yes)
				{
					string constr = ConfigurationManager.ConnectionStrings["MySqlKey"].ConnectionString;
					MySqlConnection con = new MySqlConnection(constr);
					con.Open();

					String deleteCustomer = @" DELETE FROM customer 
											   WHERE cusomterId = @CUSTOMERID";
					MySqlCommand customerDelete = new MySqlCommand(deleteCustomer, con);
					customerDelete.Parameters.AddWithValue("@CUSTOMERID", customerDeleteDataGridView.SelectedRows);
					customerDelete.ExecuteNonQuery();
					con.Close();
					dgvLoad();

					MessageBox.Show("Customer Delteted", "Complete!");
				}
				else
				{
					MessageBox.Show("Process Canceled.", "Canceled!");
				}
			}						
			else
			{
				MessageBox.Show("Please Select at Least One Row.", "Null Error",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		
		// Adds information from the database to the DGV upon loading
		private void dgvLoad()
		{
			string constr = ConfigurationManager.ConnectionStrings["MySqlKey"].ConnectionString;
			MySqlConnection con = new MySqlConnection(constr);
			con.Open();

			String sqlString = @"
								SELECT customer.customerID, customerName,
								address.address, address2, postalCode, phone,
								city.city, country.country
								FROM country, city, address, customer
								WHERE customer.addressId = address.addressId 
								AND address.cityID = city.cityID 
								AND city.countryId = country.countryId";
			MySqlCommand cmd = new MySqlCommand(sqlString, con);
			MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
			DataTable customerDT = new DataTable();
			adp.Fill(customerDT);

			customerDeleteDataGridView.DataSource = customerDT;
			customerDeleteDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			customerDeleteDataGridView.AllowUserToAddRows = false;

			con.Close();
		}

		// Clears the selection bar upon loading and until user selects a row
		private void myBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
		{
			customerDeleteDataGridView.ClearSelection();
		}
	}
}
