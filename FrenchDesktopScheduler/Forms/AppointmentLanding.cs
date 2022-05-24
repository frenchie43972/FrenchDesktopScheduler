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
			this.Hide();
			EditAppointment editAppointment = new EditAppointment();
			editAppointment.Show();
		}
	}
}
