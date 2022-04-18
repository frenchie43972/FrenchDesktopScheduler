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
using FrenchDesktopScheduler.Forms;
using MySql.Data.MySqlClient;

namespace FrenchDesktopScheduler
{
	public partial class LoginForm : Form
	{
		public LoginForm()
		{
			InitializeComponent();
		}

		private void cancelButton_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
			
		private void loginButton_Click(object sender, EventArgs e)
		{
			MySqlConnection con = new MySqlConnection("server=127.0.0.1;userid=sqlUser;password=Passw0rd!;database=client_schedule");

			con.Open();
			String sqlString = "SELECT * FROM user where userName = @userName AND password = @password";
			MySqlCommand cmd = new MySqlCommand(sqlString, con);
			cmd.Parameters.AddWithValue("@userName", usernameTextBox.Text);
			cmd.Parameters.AddWithValue("@password", passwordTextBox.Text);

			MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
			DataTable userDT = new DataTable();
			adp.Fill(userDT);

			// Verifies the user table to check the username/password
			//if (userDT.Rows.Count > 0)
			//{
			//	MessageBox.Show("Login Successful.", "Login Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);

				con.Close();
				this.Hide();
				LandingPage landingPage = new LandingPage();
				landingPage.Show();
			//}
			//else
			//{
			//	MessageBox.Show("Invalid Login Credentials.", "Login Error!", MessageBoxButtons.OK, MessageBoxIcon.Error );
			//}
		}
	}
}
