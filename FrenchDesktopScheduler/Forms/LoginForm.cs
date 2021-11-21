using System;
using System.Collections.Generic;
using System.ComponentModel;
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
			//MySqlConnection con = new MySqlConnection("server=127.0.0.1;userid=sqlUser;password=Passw0rd!;database=client_schedule");
			//con.Open();
			//String sqlString = "SELECT * FROM user";
			//MySqlCommand cmd = new MySqlCommand(sqlString, con);
			//MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
			//DataTable dt = new DataTable();
			//adp.Fill(dt);

			//for (int i = 0; i < dt.Rows.Count; i++ )
			//{
			//	MessageBox.Show(dt.Rows[i]["userName"] as string);
			//}
			//con.Close();
		}

		private void cancelButton_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
			
		private void loginButton_Click(object sender, EventArgs e)
		{
			if (usernameTextBox.Text != string.Empty || passwordTextBox.Text != string.Empty)
			{
				MySqlConnection con = new MySqlConnection("server=127.0.0.1;userid=sqlUser;password=Passw0rd!;database=client_schedule");
				con.Open();
				String sqlString = "SELECT * FROM user where userName = @userName AND password = @password";
				MySqlCommand cmd = new MySqlCommand(sqlString, con);
				cmd.Parameters.AddWithValue("@userName", usernameTextBox.Text);
				cmd.Parameters.AddWithValue("@password", passwordTextBox.Text);

				MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
				DataTable dt = new DataTable();
				adp.Fill(dt);
				
				//if (dt.Rows.Count > 0)
				//{
				//	MessageBox.Show("Invalid Login."); // Fix the warning box
				//}

				con.Close();
			}


			this.Hide();
			LandingPage landingPage = new LandingPage();
			landingPage.Show();
		}
	}
}
