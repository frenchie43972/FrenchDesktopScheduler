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
			string constr = ConfigurationManager.ConnectionStrings["MySqlKey"].ConnectionString;
			MySqlConnection con = new MySqlConnection(constr);
			con.Open();

			// Exception controls to ensure all fields are filled out, business hours are adhered to,
			// times to not overlap and users are not double booked (overlapped)
			bool blankComboBox = this.Controls.OfType<ComboBox>().Any(tb => string.IsNullOrEmpty(tb.Text)); // Checksif text boxes are empty
			int selectedCustomerId = Convert.ToInt32(addApptCustComboBox.SelectedValue);
			//string selectedType = addApptComboBox.SelectedValue.ToString();

			DateTime now = DateTime.Now;
			TimeSpan businessStart = new DateTime(now.Year, now.Month, now.Day, 8, 0, 0).TimeOfDay;
			TimeSpan businessEnd = new DateTime(now.Year, now.Month, now.Day, 17, 0, 0).TimeOfDay;
			DateTime selectedStart = addApptStartDateTimePicker.Value;
			DateTime selectedEnd = addApptEndDateTimePicker.Value;

			// TODO select all records from appt table where userid = @user and start between @start and @end
			// create dt to hold results of sql statement 
			// if row count for dt > 0 = overlap
			
			if (blankComboBox)
			{
				MessageBox.Show("All fields are required to be filled out.", "Error!",
				MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			if (addApptEndDateTimePicker.Value < addApptStartDateTimePicker.Value)
			{
				MessageBox.Show("End date/time cannot be greater than Start date/time.", "Error!",
				MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
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
