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
	public partial class LandingPage : Form
	{
		public LandingPage()
		{
			InitializeComponent();
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
	}
}
