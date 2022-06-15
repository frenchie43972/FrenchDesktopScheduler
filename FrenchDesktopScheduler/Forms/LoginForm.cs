using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
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

		private void apptCheck()
		{
			DateTime loginTime = DateTime.UtcNow;
			DateTime loginFifteen = loginTime.AddMinutes(15);
			string getUser = usernameTextBox.Text;

			string constr = ConfigurationManager.ConnectionStrings["MySqlKey"].ConnectionString;
			MySqlConnection con = new MySqlConnection(constr);
			con.Open();

			string userID = "SELECT userId FROM user WHERE userID = @USER";
			MySqlCommand getUserIdCmd = new MySqlCommand(userID, con);
			getUserIdCmd.Connection = con;
			getUserIdCmd.Parameters.AddWithValue("@USER", getUser);
			object obj = getUserIdCmd.ExecuteScalar();
			int userIDConvert = Convert.ToInt32(obj.ToString());

			String checkAppt = "SELECT * FROM appointment WHERE userId = @USER AND start BETWEEN @LOGINTIME AND @LOGINFIFTEEN";

			MySqlCommand cmd = new MySqlCommand(checkAppt, con);
			cmd.Parameters.AddWithValue("@USER", userIDConvert);
			cmd.Parameters.AddWithValue("@LOGINTIME", loginTime);
			cmd.Parameters.AddWithValue("@LOGINFIFTEEN", loginFifteen);

			MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
			DataTable appointmentDT = new DataTable();
			adp.Fill(appointmentDT);

			if (appointmentDT.Rows.Count > 0)
			{
				MessageBox.Show("You have an appointment soon.", "ATTENTION!", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				con.Close();
			}
		}

		// Adds and updates user login time stamps
		private void WriteLoginToLog()
		{
			var exePath = System.Reflection.Assembly.GetExecutingAssembly().Location;
			var workingDirectory = Path.GetDirectoryName(exePath);
			var fileName = workingDirectory + @"\userLogin.txt";
			var fileUpdate = " Logon at " + DateTime.Now + " for user " + usernameTextBox.Text + ".";
			File.AppendAllText(fileName, fileUpdate + Environment.NewLine);
		}

		private void loginButton_Click(object sender, EventArgs e)
		{
			TimeZone currentZone = TimeZone.CurrentTimeZone;

			var tokyoTime = "Tokyo Standard Time";

			MySqlConnection con = new MySqlConnection("server=127.0.0.1;userid=sqlUser;password=Passw0rd!;database=client_schedule");

			con.Open();
			String sqlString = "SELECT * FROM user WHERE userName = @userName AND password = @password";
			MySqlCommand cmd = new MySqlCommand(sqlString, con);
			cmd.Parameters.AddWithValue("@userName", usernameTextBox.Text);
			cmd.Parameters.AddWithValue("@password", passwordTextBox.Text);

			MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
			DataTable userDT = new DataTable();
			adp.Fill(userDT);

			// Verifies the user table to check the username/ password

			if (userDT.Rows.Count > 0)
			{
				if (currentZone.StandardName == tokyoTime)
				{
					MessageBox.Show("ログインに成功しました.", "ログインに成功しました!", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				else
				{
					MessageBox.Show("Login Successful.", "Login Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}

				con.Close();
				this.Hide();
				LandingPage landingPage = new LandingPage();
				landingPage.Show();
			}
			else
			{
				if (currentZone.StandardName == tokyoTime)
				{
					MessageBox.Show("無効なログイン資格情報.", "ログインエラー!", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				else
				{
					MessageBox.Show("Invalid Login Credentials.", "Login Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			apptCheck();
			//WriteLoginToLog();
			con.Close();
		}
	}
}
