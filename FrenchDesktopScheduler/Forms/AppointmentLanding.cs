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
	public partial class AppointmentLanding : Form
	{
		public AppointmentLanding()
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

		private void dgvLoad()
		{
			string constr = ConfigurationManager.ConnectionStrings["MySqlKey"].ConnectionString;
			MySqlConnection con = new MySqlConnection(constr);
			con.Open();

			String sqlString = @"
								SELECT appointment.appointmentId, customer.customerName, type, start, end, appointment.userId
								FROM customer, appointment
								WHERE appointment.customerId = customer.customerId";

			MySqlCommand cmd = new MySqlCommand(sqlString, con);
			MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
			DataTable appointmentDT = new DataTable();
			adp.Fill(appointmentDT);
			
			appointmentDataGridView.DataSource = appointmentDT;
			appointmentDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			appointmentDataGridView.AllowUserToAddRows = false;

			for (int i = 0; i < appointmentDT.Rows.Count; i++)
			{
				appointmentDT.Rows[i]["start"] = TimeZoneInfo.ConvertTimeFromUtc((DateTime)appointmentDT.Rows[i]["start"], TimeZoneInfo.Local).ToString();
				appointmentDT.Rows[i]["end"] = TimeZoneInfo.ConvertTimeFromUtc((DateTime)appointmentDT.Rows[i]["end"], TimeZoneInfo.Local).ToString();
			}

			con.Close();
		}

		private void btnAddAppt_Click(object sender, EventArgs e)
		{
			this.Hide();
			AddAppointment addAppointment = new AddAppointment();
			addAppointment.Show();
		}

		private void btnEditAppt_Click(object sender, EventArgs e)
		{

			try
			{
				if (appointmentDataGridView.SelectedRows.Count > 0)
				{
					textBoxEnable();
					apptIDTextBox.Text = appointmentDataGridView.SelectedRows[0].Cells[0].Value + string.Empty;
					ApptTypeTextBox.Text = appointmentDataGridView.SelectedRows[0].Cells[2].Value + string.Empty;
					editApptStartDateTimePicker.Text = appointmentDataGridView.SelectedRows[0].Cells[3].Value + string.Empty;
					editApptEndDateTimePicker.Text = appointmentDataGridView.SelectedRows[0].Cells[4].Value + string.Empty;
					editUserIDTextBox.Text = appointmentDataGridView.SelectedRows[0].Cells[5].Value + string.Empty;
				}
			}
			catch
			{
				MessageBox.Show("Please Select at Least One Row.", "Null Error",
				MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}

		private void btnSaveEdit_Click(object sender, EventArgs e)
		{
			DateTime now = DateTime.Now;
			TimeSpan businessStart = new DateTime(now.Year, now.Month, now.Day, 8, 0, 0).TimeOfDay;
			TimeSpan businessEnd = new DateTime(now.Year, now.Month, now.Day, 17, 0, 0).TimeOfDay;

			DateTime selectedStart = editApptStartDateTimePicker.Value;
			DateTime selectedEnd = editApptEndDateTimePicker.Value;

			// Ensures all boxes are filled
			int userID = Convert.ToInt32(editUserIDTextBox.Text);
			bool isBlank = this.Controls.OfType<TextBox>().Any(tb => string.IsNullOrEmpty(tb.Text));

			if (OverlapCheck(userID, editApptStartDateTimePicker.Value, editApptEndDateTimePicker.Value))
			{
				MessageBox.Show("Overlapped Appointment.", "Error!",
				MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;

			}
			else if (isBlank)
			{
				MessageBox.Show("All fields are required to be filled out.", "Error!",
				MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else if (editApptEndDateTimePicker.Value < editApptStartDateTimePicker.Value)
			{
				MessageBox.Show("End date/time cannot be greater than Start date/time.", "Error!",
				MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else if ((selectedStart.TimeOfDay < businessStart) || (selectedStart.TimeOfDay > businessEnd) || (selectedEnd.TimeOfDay < businessStart) || (selectedEnd.TimeOfDay > businessEnd))
			{
				MessageBox.Show("You cannot schedule an appointment outside of business hours.", "Null Error",
				MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				string constr = ConfigurationManager.ConnectionStrings["MySqlKey"].ConnectionString;
				MySqlConnection con = new MySqlConnection(constr);
				con.Open();

				String updateCustomer = @"UPDATE appointment SET type = @TYPE, start = @START, end = @END WHERE appointmentId = @APPTID";
				MySqlCommand customerUpdate = new MySqlCommand(updateCustomer, con);
				customerUpdate.Parameters.AddWithValue("@TYPE", ApptTypeTextBox.Text);
				customerUpdate.Parameters.AddWithValue("@APPTID", apptIDTextBox.Text);
				customerUpdate.Parameters.AddWithValue("@END", TimeZoneInfo.ConvertTimeToUtc(editApptEndDateTimePicker.Value));
				customerUpdate.Parameters.AddWithValue("@START", TimeZoneInfo.ConvertTimeToUtc(editApptStartDateTimePicker.Value));
				customerUpdate.ExecuteNonQuery();

				con.Close();
				textBoxClear();
				textBoxDisable();
				dgvLoad();
			}
		}

		private void btnDeleteAppt_Click(object sender, EventArgs e)
		{
			if (appointmentDataGridView.SelectedRows.Count > 0)
			{
				DialogResult result = MessageBox.Show("Are you sure you want to permanently delete this record?", "Delete Item?",
				MessageBoxButtons.YesNo);
				if (result == DialogResult.Yes)
				{
					string constr = ConfigurationManager.ConnectionStrings["MySqlKey"].ConnectionString;
					MySqlConnection con = new MySqlConnection(constr);
					con.Open();

					int apptID = (int)appointmentDataGridView.SelectedRows[0].Cells[0].Value;
					string deleteAppt = $"DELETE FROM appointment WHERE appointmentId = {apptID}";
					MySqlCommand appointmentDelete = new MySqlCommand(deleteAppt, con);
					appointmentDelete.Prepare();
					appointmentDelete.ExecuteNonQuery();

					con.Close();
					dgvLoad();
				}
				else
				{
					MessageBox.Show("Process Canceled.", "Canceled!");

					dgvLoad();
				}
				
			}
			else
			{
				MessageBox.Show("Please Select at Least One Row.", "Null Error",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void textBoxDisable()
		{
			apptIDTextBox.Enabled = false;
			ApptTypeTextBox.Enabled = false;
			editApptStartDateTimePicker.Enabled = false;
			editApptEndDateTimePicker.Enabled = false;
			editUserIDTextBox.Enabled = false;
		}

		private void textBoxEnable()
		{
			apptIDTextBox.Enabled = false;
			ApptTypeTextBox.Enabled = true;
			editApptStartDateTimePicker.Enabled = true;
			editApptEndDateTimePicker.Enabled = true;
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.Hide();
			AppointmentLanding editAppointment = new AppointmentLanding();
			editAppointment.Show();
		}
		private void textBoxClear()
		{
			ApptTypeTextBox.Clear();
		}

		private void filterWeekRadio_CheckedChanged(object sender, EventArgs e)
		{
			string constr = ConfigurationManager.ConnectionStrings["MySqlKey"].ConnectionString;
			MySqlConnection con = new MySqlConnection(constr);
			con.Open();

			string weekFilter= "SELECT * FROM appointment WHERE WEEK(appointment.start)=WEEK(NOW())";
			MySqlCommand cmd = new MySqlCommand(weekFilter, con);
			MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
			DataTable weekFilterDT = new DataTable();
			adp.Fill(weekFilterDT);

			appointmentDataGridView.DataSource = weekFilterDT;
			appointmentDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			appointmentDataGridView.AllowUserToAddRows = false;

			con.Close();
		}

		private bool OverlapCheck(int userID, DateTime startTime, DateTime endTime)
		{

			bool results = false;

			string constr = ConfigurationManager.ConnectionStrings["MySqlKey"].ConnectionString;
			MySqlConnection con = new MySqlConnection(constr);
			con.Open();

			startTime = editApptStartDateTimePicker.Value;
			endTime = editApptEndDateTimePicker.Value;
			userID = Convert.ToInt32(editUserIDTextBox.Text);

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

		private void filterMonthRadio_CheckedChanged(object sender, EventArgs e)
		{
			string constr = ConfigurationManager.ConnectionStrings["MySqlKey"].ConnectionString;
			MySqlConnection con = new MySqlConnection(constr);
			con.Open();

			string monthFilter = "SELECT * FROM appointment WHERE MONTH(appointment.start)=MONTH(NOW())";
			MySqlCommand cmd = new MySqlCommand(monthFilter, con);
			MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
			DataTable monthFilterDT = new DataTable();
			adp.Fill(monthFilterDT);

			appointmentDataGridView.DataSource = monthFilterDT;
			appointmentDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			appointmentDataGridView.AllowUserToAddRows = false;

			con.Close();
		}

		private void searchBtn_Click(object sender, EventArgs e)
		{
			string constr = ConfigurationManager.ConnectionStrings["MySqlKey"].ConnectionString;
			MySqlConnection con = new MySqlConnection(constr);
			con.Open();

			string customerFilter = "SELECT * FROM customer WHERE customerName LIKE '%" + searchAppt.Text + "%' ";
			MySqlCommand cmd = new MySqlCommand(customerFilter, con);
			MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
			DataTable monthFilterDT = new DataTable();
			adp.Fill(monthFilterDT);

			appointmentDataGridView.DataSource = monthFilterDT;
			appointmentDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			appointmentDataGridView.AllowUserToAddRows = false;

			con.Close();
		}
	}
}
