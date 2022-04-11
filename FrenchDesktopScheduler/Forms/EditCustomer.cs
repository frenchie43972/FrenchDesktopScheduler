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
	public partial class EditCustomer : Form
	{
		public EditCustomer()
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

		private void editCustomerButton_Click(object sender, EventArgs e)
		{

			if (customerEditDataGridView.SelectedRows.Count > 0)
			{
				textBoxEnable();
				custEditIDTextBox.Text = customerEditDataGridView.SelectedRows[0].Cells[0].Value + string.Empty;
				custEditNameTextBox.Text = customerEditDataGridView.SelectedRows[0].Cells[1].Value + string.Empty;
				custEditAddTextBox.Text = customerEditDataGridView.SelectedRows[0].Cells[2].Value + string.Empty;
				custEditAdd2TextBox.Text = customerEditDataGridView.SelectedRows[0].Cells[3].Value + string.Empty;
				custEditPostTextBox.Text = customerEditDataGridView.SelectedRows[0].Cells[4].Value + string.Empty;
				custEditPhoneTextBox.Text = customerEditDataGridView.SelectedRows[0].Cells[5].Value + string.Empty;
				custEditCityTextBox.Text = customerEditDataGridView.SelectedRows[0].Cells[6].Value + string.Empty;
				custEditCountryTextBox.Text = customerEditDataGridView.SelectedRows[0].Cells[7].Value + string.Empty;
			}
			else
			{
				MessageBox.Show("Please Select at Least One Row.", "Null Error",
				MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void cancelButton_Click_1(object sender, EventArgs e)
		{
			textBoxClear();
			textBoxDisable();
		}

		private void saveButton_Click(object sender, EventArgs e)
		{
			if (String.IsNullOrWhiteSpace(custEditIDTextBox.Text) || !Int32.TryParse(custEditIDTextBox.Text, out _))
			{
				MessageBox.Show("Test");
			}

		}

		// Adds information from the customer table to the DGV upon the for loading
		private void dgvLoad()
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

			customerEditDataGridView.DataSource = customerDT;
			customerEditDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			customerEditDataGridView.AllowUserToAddRows = false;

			con.Close();

		}

		// Clears the selection bar upon loading and until user selects a row
		private void myBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
		{
			customerEditDataGridView.ClearSelection();
		}

		private void textBoxDisable()
		{
			custEditIDTextBox.Enabled = false;
			custEditNameTextBox.Enabled = false;
			custEditAddTextBox.Enabled = false;
			custEditAdd2TextBox.Enabled = false;
			custEditCityTextBox.Enabled = false;
			custEditCountryTextBox.Enabled = false;
			custEditPostTextBox.Enabled = false;
			custEditPhoneTextBox.Enabled = false;
		}
		private void textBoxEnable()
		{
			custEditNameTextBox.Enabled = true;
			custEditAddTextBox.Enabled = true;
			custEditAdd2TextBox.Enabled = true;
			custEditCityTextBox.Enabled = true;
			custEditCountryTextBox.Enabled = true;
			custEditPostTextBox.Enabled = true;
			custEditPhoneTextBox.Enabled = true;
		}

		private void textBoxClear()
		{
			custEditIDTextBox.Clear();
			custEditNameTextBox.Clear();
			custEditAddTextBox.Clear();
			custEditAdd2TextBox.Clear();
			custEditCityTextBox.Clear();
			custEditCountryTextBox.Clear();
			custEditPostTextBox.Clear();
			custEditPhoneTextBox.Clear();
		}


		// Requires the Post Code to be number only. Trying anything else reuslts in an error
		private void custEditPostTextBox_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
			{
				e.Handled = true;
				MessageBox.Show("Input must be and/or number only.", "Error!",
				MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		// Requires the phone number to be a number and hyphen only. Trying anything else reuslts in an error
		private void custEditPhoneTextBox_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
				(e.KeyChar != '-'))
			{
				e.Handled = true;
				MessageBox.Show("Input must be a number and/or hyphen.", "Error!",
				MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
