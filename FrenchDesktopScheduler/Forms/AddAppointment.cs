﻿using MySql.Data.MySqlClient;
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
			LoadUser();
			
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
			bool blankComboBox = this.Controls.OfType<ComboBox>().Any(tb => string.IsNullOrEmpty(tb.Text)); // Lambda checks if text boxes are empty
			int selectedCustomerId = Convert.ToInt32(addApptCustComboBox.SelectedValue);

			DateTime now = DateTime.Now;
			TimeSpan businessStart = new DateTime(now.Year, now.Month, now.Day, 8, 0, 0).TimeOfDay;
			TimeSpan businessEnd = new DateTime(now.Year, now.Month, now.Day, 17, 0, 0).TimeOfDay;

			int userID = Convert.ToInt32(userIDComboBox.Text);
			
			if (OverlapCheck(userID, addApptStartDateTimePicker.Value, addApptEndDateTimePicker.Value))
			{
				MessageBox.Show("Overlapped Appointment.", "Error!",
				MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;

			}
			else if (blankComboBox)
			{
				MessageBox.Show("All fields are required to be filled out.", "Error!",
				MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else if (addApptEndDateTimePicker.Value < addApptStartDateTimePicker.Value)
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

				DateTime addStart = TimeZoneInfo.ConvertTimeToUtc(addApptStartDateTimePicker.Value);
				DateTime addEnd = TimeZoneInfo.ConvertTimeToUtc(addApptEndDateTimePicker.Value);

				appointmentAdd.Parameters.AddWithValue("@CUSTOMER", addApptCustComboBox.Text);
				appointmentAdd.Parameters.AddWithValue("@TYPE", addApptComboBox.Text);
				appointmentAdd.Parameters.AddWithValue("@START", addStart);
				appointmentAdd.Parameters.AddWithValue("@END", addEnd);
				appointmentAdd.ExecuteNonQuery();
				int appointmentID = (int)appointmentAdd.LastInsertedId;

				con.Close();
				this.Hide();
				AddAppointment saveAppointment = new AddAppointment();
				saveAppointment.Show();
			}
		}

		private void LoadUser()
		{
			string constr = ConfigurationManager.ConnectionStrings["MySqlKey"].ConnectionString;

			try
			{
				MySqlConnection con = new MySqlConnection(constr);
				con.Open();

				String sqlString = @"
								SELECT userId
								FROM user";
				MySqlCommand cmd = new MySqlCommand(sqlString, con);
				MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
				DataSet dataSet = new DataSet();
				adp.Fill(dataSet);

				using (var reader = cmd.ExecuteReader())
				{
					while (reader.Read())
					{
						userIDComboBox.Items.Add(reader.GetString("userId"));
					}
				}
				con.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
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
		private bool OverlapCheck(int userID, DateTime startTime, DateTime endTime)
		{

			bool results = false;

			string constr = ConfigurationManager.ConnectionStrings["MySqlKey"].ConnectionString;
			MySqlConnection con = new MySqlConnection(constr);
			con.Open();

			startTime = TimeZoneInfo.ConvertTimeToUtc(addApptStartDateTimePicker.Value);
			endTime = TimeZoneInfo.ConvertTimeToUtc(addApptEndDateTimePicker.Value);
			userID = Convert.ToInt32(userIDComboBox.Text);
			
			string overlapCheck = "SELECT * FROM appointment WHERE userId = @USER AND start BETWEEN @START AND @END";

			MySqlCommand checkOverlap = new MySqlCommand(overlapCheck, con);

			checkOverlap.Parameters.AddWithValue("@START", startTime);
			checkOverlap.Parameters.AddWithValue("@END", endTime);
			checkOverlap.Parameters.AddWithValue("@USER", userID);
			MySqlDataAdapter adp = new MySqlDataAdapter(checkOverlap);
			DataTable overlapDT = new DataTable();
			adp.Fill(overlapDT);

			if (overlapDT.Rows.Count > 0)
			{
				results = true;
			}
			else
			{
				results = false;
			}

			return results;
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
