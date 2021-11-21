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
	public partial class Customer : Form
	{
		public Customer()
		{
			InitializeComponent();
		}

		private void toLandingButton_Click(object sender, EventArgs e)
		{
			this.Hide();
			LandingPage landingPage = new LandingPage();
			landingPage.Show();
		}

		private void addCustomerButton_Click(object sender, EventArgs e)
		{
			this.Hide();
			AddCustomer toAddCustomer = new AddCustomer();
			toAddCustomer.Show();
		}

		private void editCustomerButton_Click(object sender, EventArgs e)
		{
			this.Hide();
			EditCustomer toEditCustomer = new EditCustomer();
			toEditCustomer.Show();
		}
	}
}
