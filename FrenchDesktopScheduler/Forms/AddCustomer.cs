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
	public partial class AddCustomer : Form
	{
		public AddCustomer()
		{
			InitializeComponent();
		}

		private void toLandingButton_Click(object sender, EventArgs e)
		{
			this.Hide();
			LandingPage landingPage = new LandingPage();
			landingPage.Show();
		}

		private void customerCancelButton_Click(object sender, EventArgs e)
		{
			this.Hide();
			Customer toCustomer = new Customer();
			toCustomer.Show();
		}
	}
}
