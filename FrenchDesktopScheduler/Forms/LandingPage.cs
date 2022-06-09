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
	public partial class LandingPage : Form
	{
		public LandingPage()
		{
			InitializeComponent();
			//apptCheck();
		}

		private void loginBackButton_Click(object sender, EventArgs e)
		{
			this.Hide();
			LoginForm backToLogin = new LoginForm();
			backToLogin.Show();
		}

		private void customerButton_Click(object sender, EventArgs e)
		{
			this.Hide();
			CustomerLanding toCustomer = new CustomerLanding();
			toCustomer.Show();
		}

		private void appointmentButton_Click(object sender, EventArgs e)
		{
			this.Hide();
			AppointmentLanding toAppomintment = new AppointmentLanding();
			toAppomintment.Show();
		}

		private void reportsButton_Click(object sender, EventArgs e)
		{
			this.Hide();
			Reports toReports = new Reports();
			toReports.Show();
		}

		//private void apptCheck()
		//{
		//	string constr = ConfigurationManager.ConnectionStrings["MySqlKey"].ConnectionString;
		//	MySqlConnection con = new MySqlConnection(constr);
		//	con.Open();

		//	//String checkAppt = @"SELECT start FROM appointment";
		//	String checkAppt = @"SELECT start FROM appointment WHERE start > NOW() - INTERVAL 15 MINUTE";

		//	MySqlCommand cmd = new MySqlCommand(checkAppt, con);
		//	MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
		//	DataTable appointmentDT = new DataTable();
		//	adp.Fill(appointmentDT);

		//	if (appointmentDT.Rows.Count > 0)
		//	{
		//		MessageBox.Show("You have an appointment soon.", "ATTENTION!", MessageBoxButtons.OK, MessageBoxIcon.Information);
		//	}
		//	else
		//	{
		//		con.Close();
		//	}
		//}
	}
}
