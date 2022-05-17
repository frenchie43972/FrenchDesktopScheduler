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

		private void cancelButton_Click(object sender, EventArgs e)
		{
			textBoxClear();
			textBoxDisable();
		}

		private void saveEditButton_Click(object sender, EventArgs e)
		{
			// Exception control to ensure all fields are filled out
			bool isBlank = this.Controls.OfType<TextBox>().Any(tb => string.IsNullOrEmpty(tb.Text));
			if (isBlank)
			{
				MessageBox.Show("All fields are required to be filled out.", "Error!",
				MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				string constr = ConfigurationManager.ConnectionStrings["MySqlKey"].ConnectionString;
				MySqlConnection con = new MySqlConnection(constr);
				con.Open();

				String updateCustomer = @"UPDATE customer SET customerName = @CUSTOMER WHERE customerId = @CUSTOMERID";
				MySqlCommand customerUpdate = new MySqlCommand(updateCustomer, con);
				customerUpdate.Parameters.AddWithValue("@CUSTOMER", custEditNameTextBox.Text);
				customerUpdate.Parameters.AddWithValue("@CUSTOMERID", custEditIDTextBox.Text);
				customerUpdate.ExecuteNonQuery();

				String updateAddress = @"UPDATE address SET address = @ADDRESS, 
															address2 = @ADDRESS2,
															postalCode = @POST,
															phone = @PHONE 
														WHERE addressId = @ADDRESSID";
				MySqlCommand addressUpdate = new MySqlCommand(updateAddress, con);
				addressUpdate.Parameters.AddWithValue("@ADDRESS", custEditAddTextBox.Text);
				addressUpdate.Parameters.AddWithValue("@ADDRESS2", custEditAdd2TextBox.Text);
				addressUpdate.Parameters.AddWithValue("@POST", custEditPostTextBox.Text);
				addressUpdate.Parameters.AddWithValue("@PHONE", custEditPhoneTextBox.Text);
				addressUpdate.Parameters.AddWithValue("@ADDRESSID", textBox1.Text);
				addressUpdate.ExecuteNonQuery();

				String updateCity = @"UPDATE city SET city = @CITY WHERE cityId = @CITYID";
				MySqlCommand cityUpdate = new MySqlCommand(updateCity, con);
				cityUpdate.Parameters.AddWithValue("@CITY", custEditCityTextBox.Text);
				cityUpdate.Parameters.AddWithValue("@CITYID", textBox2.Text);
				cityUpdate.ExecuteNonQuery();

				String updateCountry = @"UPDATE country SET country = @COUNTRY WHERE countryId = @COUNTRYID";
				MySqlCommand countryUpdate = new MySqlCommand(updateCountry, con);
				countryUpdate.Parameters.AddWithValue("@COUNTRY", custEditCountryTextBox.Text);
				countryUpdate.Parameters.AddWithValue("@COUNTRYID", textBox3.Text);
				countryUpdate.ExecuteNonQuery();

				con.Close();
				textBoxClear();
				textBoxDisable();
				dgvLoad();
			}
		}

		// Populates the text boxes with the information from the DGV for editing
		private void editCustomerButton_Click(object sender, EventArgs e)
		{
			if (customerEditDataGridView.SelectedRows.Count > 0)
			{
				textBoxEnable();
				custEditIDTextBox.Text = customerEditDataGridView.SelectedRows[0].Cells[0].Value + string.Empty;
				custEditNameTextBox.Text = customerEditDataGridView.SelectedRows[0].Cells[1].Value + string.Empty;
				custEditAddTextBox.Text = customerEditDataGridView.SelectedRows[0].Cells[3].Value + string.Empty;
				custEditAdd2TextBox.Text = customerEditDataGridView.SelectedRows[0].Cells[4].Value + string.Empty;
				custEditPostTextBox.Text = customerEditDataGridView.SelectedRows[0].Cells[5].Value + string.Empty;
				custEditPhoneTextBox.Text = customerEditDataGridView.SelectedRows[0].Cells[6].Value + string.Empty;
				custEditCityTextBox.Text = customerEditDataGridView.SelectedRows[0].Cells[8].Value + string.Empty;
				custEditCountryTextBox.Text = customerEditDataGridView.SelectedRows[0].Cells[10].Value + string.Empty;
				textBox1.Text = customerEditDataGridView.SelectedRows[0].Cells[2].Value + string.Empty;
				textBox2.Text = customerEditDataGridView.SelectedRows[0].Cells[7].Value + string.Empty;
				textBox3.Text = customerEditDataGridView.SelectedRows[0].Cells[9].Value + string.Empty;
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
								address.addressId, address.address, address2, postalCode, phone,
								city.cityId, city.city, country.countryId, country.country
								FROM country, city, address, customer
								WHERE customer.addressId = address.addressId 
								AND address.cityID = city.cityID 
								AND city.countryId = country.countryId";
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
				MessageBox.Show("Input must be a number only.", "Error!",
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

		private void customerEditDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			
		}
	}
}
