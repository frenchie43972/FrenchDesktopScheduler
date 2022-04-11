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
	public partial class CustomerLanding : Form
	{
		public CustomerLanding()
		{
			InitializeComponent();
		}

		private void toLandingButton_Click(object sender, EventArgs e)
		{
			this.Hide();
			LandingPage landingPage = new LandingPage();
			landingPage.Show();
		}

		private void btnAddCustomer_Click(object sender, EventArgs e)
		{
			this.Hide();
			AddCustomer toCustomer = new AddCustomer();
			toCustomer.Show();
		}

		private void btnEditCustomer_Click(object sender, EventArgs e)
		{
			this.Hide();
			EditCustomer toCustomer = new EditCustomer();
			toCustomer.Show();
		}
	}
}
