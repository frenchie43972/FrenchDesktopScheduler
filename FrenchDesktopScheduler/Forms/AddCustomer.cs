using FrenchDesktopScheduler.Database_Objects;
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
using System.Data.SqlClient;

namespace FrenchDesktopScheduler.Forms
{
	public partial class AddCustomer : Form
	{
		public AddCustomer()
		{
			InitializeComponent();
			dgvLoad();
			textBoxDisable();

			MessageBox.Show("All fields are required. If there is no Address 2, please type 'N/A' into the field.", "ATTENTION!",
				MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

		// Adds information from the customer table to the DGV upon the for loading
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

			customerAddDataGridView.DataSource = customerDT;
			customerAddDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			customerAddDataGridView.AllowUserToAddRows = false;
		}

		// Clears the selection bar upon loading and until user selects a row
		
		private void myBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
		{
			customerAddDataGridView.ClearSelection();
		}

		private void addCustomerButton_Click(object sender, EventArgs e)
		{
			textBoxEnable();
			textBoxClear();
		}

		private void saveButton_Click(object sender, EventArgs e)
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

				/*              This section adds user inputs into the appropriate DB tables                    */
				String addCountry = @"INSERT INTO country(country, createDate, createdBy, lastUpdateBy) 
								VALUES(@COUNTRY, NOW(), 'test', 'test')";
				MySqlCommand countryAdd = new MySqlCommand(addCountry, con);
				countryAdd.Parameters.AddWithValue("@COUNTRY", custCountryTextBox.Text);
				countryAdd.ExecuteNonQuery();
				int countryID = (int)countryAdd.LastInsertedId;

				String addCity = @"INSERT INTO city(city, countryId, createDate, createdBy, lastUpdateBy) 
							 VALUES(@CITY, @COUNTRYID, NOW(), 'test', 'test')";
				MySqlCommand cityAdd = new MySqlCommand(addCity, con);
				cityAdd.Parameters.AddWithValue("@CITY", custCityTextBox.Text);
				cityAdd.Parameters.AddWithValue("@COUNTRYID", countryID);
				cityAdd.ExecuteNonQuery();
				int cityID = (int)cityAdd.LastInsertedId;

				String addAddress = @"INSERT INTO address(address, address2, cityId, postalCode, phone, createDate, createdBy, lastUpdateBy)
								VALUES(@ADDRESS, @ADDRESS2, @CITYID, @POSTCODE, @PHONE, NOW(), 'test', 'test')";
				MySqlCommand addressAdd = new MySqlCommand(addAddress, con);
				addressAdd.Parameters.AddWithValue("@ADDRESS", custAddTextBox.Text);
				addressAdd.Parameters.AddWithValue("@ADDRESS2", custAdd2TextBox.Text);
				addressAdd.Parameters.AddWithValue("@POSTCODE", custPostTextBox.Text);
				addressAdd.Parameters.AddWithValue("@PHONE", custPhoneTextBox.Text);
				addressAdd.Parameters.AddWithValue("@CITYID", cityID);
				addressAdd.ExecuteNonQuery();
				int addressID = (int)addressAdd.LastInsertedId;

				String addCustomer = @"INSERT INTO customer(customerName, addressId, active, createDate, createdBy, lastUpdateBy) 
								 VALUES(@CUSTOMER, @ADDRESS, '1', NOW(), 'test', 'test')";
				MySqlCommand customerAdd = new MySqlCommand(addCustomer, con);
				customerAdd.Parameters.AddWithValue("@CUSTOMER", custNameTextBox.Text);
				customerAdd.Parameters.AddWithValue("@ADDRESS", addressID);
				customerAdd.ExecuteNonQuery();
				int customerID = (int)customerAdd.LastInsertedId;

				con.Close();
				textBoxClear();
				textBoxDisable();
				dgvLoad();
				/* -----------------------------------------------END SECTION----------------------------------------------- */
			}
		}

		private void textBoxDisable()
		{
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

		private void textBoxClear()
		{
			custNameTextBox.Clear();
			custAddTextBox.Clear();
			custAdd2TextBox.Clear();
			custCityTextBox.Clear();
			custCountryTextBox.Clear();
			custPostTextBox.Clear();
			custPhoneTextBox.Clear();
		}

		// Requires the Post Code to be number only. Trying anything else reuslts in an error
		private void custPostTextBox_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
			{
				e.Handled = true;
				MessageBox.Show("Input must be a number only.", "Error!",
				MessageBoxButtons.OK, MessageBoxIcon.Error);
			}			
		}

		// Requires the phone number to be a number and hyphen only. Trying anything else reuslts in an error
		private void custPhoneTextBox_KeyPress(object sender, KeyPressEventArgs e)
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
