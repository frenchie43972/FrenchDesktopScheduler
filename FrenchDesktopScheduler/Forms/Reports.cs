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
	public partial class Reports : Form
	{

		public Reports()
		{
			InitializeComponent();
		}

		private void toLandingButton_Click(object sender, EventArgs e)
		{
			this.Hide();
			LandingPage landingPage = new LandingPage();
			landingPage.Show();
		}

		private void monthNumApptButton_Click(object sender, EventArgs e)
		{
			this.Hide();
			MonthlyReport toMonthlyReports = new MonthlyReport();
			toMonthlyReports.Show();
		}

		private void consultantApptButton_Click(object sender, EventArgs e)
		{
			this.Hide();
			ConsultantReport toConsultantReports = new ConsultantReport();
			toConsultantReports.Show();
		}

		private void apptCountButton_Click(object sender, EventArgs e)
		{
			this.Hide();
			ApptCountReport toApptReports = new ApptCountReport();
			toApptReports.Show();			
		}
	}
}
