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
			textBoxDisable();
		}

		private void toLandingButton_Click(object sender, EventArgs e)
		{
			this.Hide();
			LandingPage landingPage = new LandingPage();
			landingPage.Show();
		}

		private void addCustomerButton_Click(object sender, EventArgs e)
		{
			textBoxEnable();
		}

		private void editCustomerButton_Click(object sender, EventArgs e)
		{

			if (customerDataGridView.SelectedRows.Count > 0)
			{
				textBoxEnable();
				custIDTextBox.Text = customerDataGridView.SelectedRows[0].Cells[0].Value + string.Empty;
				custNameTextBox.Text = customerDataGridView.SelectedRows[0].Cells[1].Value + string.Empty;
				custAddTextBox.Text = customerDataGridView.SelectedRows[0].Cells[2].Value + string.Empty;
				custAdd2TextBox.Text = customerDataGridView.SelectedRows[0].Cells[3].Value + string.Empty;
				custPostTextBox.Text = customerDataGridView.SelectedRows[0].Cells[4].Value + string.Empty;
				custPhoneTextBox.Text = customerDataGridView.SelectedRows[0].Cells[5].Value + string.Empty;
				custCityTextBox.Text = customerDataGridView.SelectedRows[0].Cells[6].Value + string.Empty;
				custCountryTextBox.Text = customerDataGridView.SelectedRows[0].Cells[7].Value + string.Empty;
			}
			else
			{
				MessageBox.Show("Please Select at Least One Row.", "Null Error",
				MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void saveButton_Click(object sender, EventArgs e)
		{
			if (String.IsNullOrWhiteSpace(custIDTextBox.Text) || !Int32.TryParse(custIDTextBox.Text, out _))
			{

			}

		}

		// Adds information from the customer table to the DGV upon the for loading
		private void dgvLoad ()
		{
			MySqlConnection con = new MySqlConnection("server=127.0.0.1;userid=sqlUser;password=Passw0rd!;database=client_schedule");
			con.Open();
			String sqlString = @"
								SELECT customer.customerID, customer.customerName,
								address.address, address.address2, address.postalCode, address.phone,
								city.city, country.country
								FROM customer
								JOIN address ON customer.customerID = address.addressID
								JOIN city ON address.addressID = city.cityID
								JOIN country ON city.cityID = country.countryID";
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

		private void textBoxDisable()
		{
			custIDTextBox.Enabled = false;
			custNameTextBox.Enabled = false;
			custAddTextBox.Enabled = false;
			custAdd2TextBox.Enabled = false;
			custCityTextBox.Enabled = false;
			custCountryTextBox.Enabled = false;
			custPostTextBox.Enabled = false;
			custPhoneTextBox.Enabled = false;
		}
		private void textBoxEnable()
		{
			custNameTextBox.Enabled = true;
			custAddTextBox.Enabled = true;
			custAdd2TextBox.Enabled = true;
			custCityTextBox.Enabled = true;
			custCountryTextBox.Enabled = true;
			custPostTextBox.Enabled = true;
			custPhoneTextBox.Enabled = true;
		}

		
	}
}
