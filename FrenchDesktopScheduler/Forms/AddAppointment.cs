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
	public partial class AddAppointment : Form
	{
		public AddAppointment()
		{
			InitializeComponent();
			LoadCustomer();
			LoadAppointment();
		}

		private void toLandingButton_Click(object sender, EventArgs e)
		{
			this.Hide();
			AppointmentLanding toAppomintment = new AppointmentLanding();
			toAppomintment.Show();
		}

		private void apptCancelButton_Click(object sender, EventArgs e)
		{
			this.Hide();
			AddAppointment addAppointment = new AddAppointment();
			addAppointment.Show();
		}

		private void addApptSaveButton_Click(object sender, EventArgs e)
		{
			// Exception control to ensure all fields are filled out
			bool blankComboBox = this.Controls.OfType<ComboBox>().Any(tb => string.IsNullOrEmpty(tb.Text));
			if (blankComboBox)
			{
				MessageBox.Show("All fields are required to be filled out.", "Error!",
				MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			if (addApptEndDateTimePicker.Value < addApptStartDateTimePicker.Value)
			{
				MessageBox.Show("End date cannot be greater than Start date.", "Error!",
				MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				string constr = ConfigurationManager.ConnectionStrings["MySqlKey"].ConnectionString;
				MySqlConnection con = new MySqlConnection(constr);
				con.Open();

				String addAppointment = @"INSERT INTO appointment(customerId, userId, title, description, location, contact, type, url, 
																  start, end, createDate, createdBy, lastUpdate, lastUpdateBy) 
										VALUES(@CUSTOMER, '1', 'not needed', 'not needed', 'not needed', 'not needed',
												@TYPE, 'not needed', @START, @END, NOW(), 'test', NOW(), 'test')";
				MySqlCommand appointmentAdd = new MySqlCommand(addAppointment, con);
				appointmentAdd.Parameters.AddWithValue("@CUSTOMER", addApptCustComboBox.Text);
				appointmentAdd.Parameters.AddWithValue("@TYPE", addApptComboBox.Text);
				appointmentAdd.Parameters.AddWithValue("@START", addApptStartDateTimePicker.Value);
				appointmentAdd.Parameters.AddWithValue("@END", addApptEndDateTimePicker.Value);
				appointmentAdd.ExecuteNonQuery();
				int appointmentID = (int)appointmentAdd.LastInsertedId;

				con.Close();
				this.Hide();
				AddAppointment saveAppointment = new AddAppointment();
				saveAppointment.Show();
			}
		}

		private void LoadCustomer()
		{
			string constr = ConfigurationManager.ConnectionStrings["MySqlKey"].ConnectionString;

			try
			{
				MySqlConnection con = new MySqlConnection(constr);
				con.Open();

				String sqlString = @"
								SELECT customerId, customerName
								FROM customer";
				MySqlCommand cmd = new MySqlCommand(sqlString, con);
				MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
				DataSet dataSet = new DataSet();
				adp.Fill(dataSet);

				using (var reader = cmd.ExecuteReader())
				{
					while (reader.Read())
					{
						addApptCustComboBox.Items.Add(reader.GetString("customerId"));
					}
				}
				con.Close();
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void LoadAppointment()
		{
			string constr = ConfigurationManager.ConnectionStrings["MySqlKey"].ConnectionString;

			try
			{
				MySqlConnection con = new MySqlConnection(constr);
				con.Open();

				String sqlString = @"
								SELECT type
								FROM appointment";
				MySqlCommand cmd = new MySqlCommand(sqlString, con);
				MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
				DataSet dataSet = new DataSet();
				adp.Fill(dataSet);

				using (var reader = cmd.ExecuteReader())
				{
					while (reader.Read())
					{
						addApptComboBox.Items.Add(reader.GetString("type"));
					}
				}
				con.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}

		}
	}
}
