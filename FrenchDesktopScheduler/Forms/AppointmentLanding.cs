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
								SELECT appointment.appointmentId, customer.customerName, type, start, end
								FROM customer, appointment
								WHERE appointment.customerId = customer.customerId";

			MySqlCommand cmd = new MySqlCommand(sqlString, con);
			MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
			DataTable appointmentDT = new DataTable();
			adp.Fill(appointmentDT);

			appointmentDataGridView.DataSource = appointmentDT;
			appointmentDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			appointmentDataGridView.AllowUserToAddRows = false;

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

			bool overlap = selectedStart.ToUniversalTime().

			// Ensures all boxes are filled
			bool isBlank = this.Controls.OfType<TextBox>().Any(tb => string.IsNullOrEmpty(tb.Text));
			if (isBlank)
			{
				MessageBox.Show("All fields are required to be filled out.", "Error!",
				MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			if (editApptEndDateTimePicker.Value < editApptStartDateTimePicker.Value)
			{
				MessageBox.Show("End date/time cannot be greater than Start date/time.", "Error!",
				MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			if ((selectedStart.TimeOfDay < businessStart) || (selectedStart.TimeOfDay > businessEnd) || (selectedEnd.TimeOfDay < businessStart) || (selectedEnd.TimeOfDay > businessEnd))
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
				customerUpdate.Parameters.AddWithValue("@END", editApptEndDateTimePicker.Value);
				customerUpdate.Parameters.AddWithValue("@START", editApptStartDateTimePicker.Value);
				customerUpdate.ExecuteNonQuery();

				con.Close();
				textBoxClear();
				textBoxDisable();
				dgvLoad();
			}
		}

		private void textBoxDisable()
		{
			apptIDTextBox.Enabled = false;
			ApptTypeTextBox.Enabled = false;
			editApptStartDateTimePicker.Enabled = false;
			editApptEndDateTimePicker.Enabled = false;
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
	}
}
