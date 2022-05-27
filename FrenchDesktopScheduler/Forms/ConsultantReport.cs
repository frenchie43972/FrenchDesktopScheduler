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
	public partial class ConsultantReport : Form
	{
		public ConsultantReport()
		{
			InitializeComponent();
			userLoad();
		}

		private void backButton_Click(object sender, EventArgs e)
		{
			this.Hide();
			Reports toReports = new Reports();
			toReports.Show();
		}

		private void userLoad()
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
						userComboBox.Items.Add(reader.GetString("userId"));
					}
				}
				con.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void submitButton_Click(object sender, EventArgs e)
		{
			string userSelect = userComboBox.Text;

			if (userComboBox.Text == "")
			{
				MessageBox.Show("Please select a user ID.", "Error!",
				MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				string constr = ConfigurationManager.ConnectionStrings["MySqlKey"].ConnectionString;
				MySqlConnection con = new MySqlConnection(constr);
				con.Open();

				String sqlString = $"SELECT userId, type, start	FROM appointment WHERE userId = {userSelect}";

				MySqlCommand cmd = new MySqlCommand(sqlString, con);
				MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
				DataTable appointmentDT = new DataTable();
				adp.Fill(appointmentDT);

				userDataGridView.DataSource = appointmentDT;
				userDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
				userDataGridView.AllowUserToAddRows = false;

				con.Close();
			}
		}
	}
}
