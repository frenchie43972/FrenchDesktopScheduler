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
	public partial class MonthlyReport : Form
	{
		public MonthlyReport()
		{
			InitializeComponent();
			loadMonth();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			this.Hide();
			Reports toReports = new Reports();
			toReports.Show();
		}

		private void loadMonth()
		{
			string constr = ConfigurationManager.ConnectionStrings["MySqlKey"].ConnectionString;

			for (int i = 1; i <= 12; i++)
			{
				monthComboBox.Items.Add(i);
			}
		}

		private void submitButton_Click(object sender, EventArgs e)
		{
			string apptByMonth = monthComboBox.Text;
			monthlyDataGridView.Rows.Clear();

			if (monthComboBox.Text == "")
			{
				MessageBox.Show("Please select a month.", "Error!",
				MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				string constr = ConfigurationManager.ConnectionStrings["MySqlKey"].ConnectionString;
				MySqlConnection con = new MySqlConnection(constr);
				con.Open();

				string scrumApptReport = $"SELECT COUNT(*) FROM appointment WHERE type='Scrum' AND MONTH(start)={apptByMonth}";
				var scrumCountCMD = new MySqlCommand(scrumApptReport, con);
				int scrumCountIndex = Convert.ToInt32(scrumCountCMD.ExecuteScalar());
				monthlyDataGridView.Rows.Add("Scrum", scrumCountIndex);

				string intApptReport = $"SELECT COUNT(*) FROM appointment WHERE type='Interview' AND MONTH(start)={apptByMonth}";
				var intCountCMD = new MySqlCommand(intApptReport, con);
				int intCountIndex = Convert.ToInt32(intCountCMD.ExecuteScalar());
				monthlyDataGridView.Rows.Add("Interview", intCountIndex);

				string presApptReport = $"SELECT COUNT(*) FROM appointment WHERE type='Presentation' AND MONTH(start)={apptByMonth}";
				var presCountCMD = new MySqlCommand(presApptReport, con);
				int presCountIndex = Convert.ToInt32(presCountCMD.ExecuteScalar());
				monthlyDataGridView.Rows.Add("Presentation", presCountIndex);

				string lunchApptReport = $"SELECT COUNT(*) FROM appointment WHERE type='Lunch' AND MONTH(start)={apptByMonth}";
				var lunchCountCMD = new MySqlCommand(lunchApptReport, con);
				int lunchCountIndex = Convert.ToInt32(lunchCountCMD.ExecuteScalar());
				monthlyDataGridView.Rows.Add("Lunch", lunchCountIndex);

				con.Close();
			}
		}
	}
}
