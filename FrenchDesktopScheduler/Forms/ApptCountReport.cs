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
	public partial class ApptCountReport : Form
	{
		public ApptCountReport()
		{
			InitializeComponent();
			dgvLoad();
		}

		private void backButton_Click(object sender, EventArgs e)
		{
			this.Hide();
			Reports toReports = new Reports();
			toReports.Show();
		}

		private void dgvLoad()
		{
			string constr = ConfigurationManager.ConnectionStrings["MySqlKey"].ConnectionString;
			MySqlConnection con = new MySqlConnection(constr);
			con.Open();

			string totalApptReport = @"SELECT COUNT(*) FROM appointment";
			var totalApptCMD = new MySqlCommand(totalApptReport, con);
			int totalApptIndex = Convert.ToInt32(totalApptCMD.ExecuteScalar());
			apptTotalDataGridView.Rows.Add("Appointments", totalApptIndex);

			con.Close();
		}
	}
}
