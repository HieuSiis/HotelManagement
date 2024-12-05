using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagement
{
	public partial class StaffMainForm : Form
	{
		public StaffMainForm()
		{
			InitializeComponent();
		}

		private void btnLogout_Click(object sender, EventArgs e)
		{
			if(MessageBox.Show("Are you sure you want to Confirmation?", "Error Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				LoginForm loginForm = new LoginForm();
				loginForm.Show();

				this.Hide();
			}
		}

		private void btnDashboard_Click(object sender, EventArgs e)
		{
			admin_dashboard1.Visible = true;
			staff_bookRoom1.Visible = false;
			admin_customer1.Visible = false;

			admin_dashboard adDashboard = admin_dashboard1 as admin_dashboard;

			if(adDashboard != null)
			{
				adDashboard.refreshData();
			}
		}

		private void btnBookRoom_Click(object sender, EventArgs e)
		{
			admin_dashboard1.Visible = false;
			staff_bookRoom1.Visible = true;
			admin_customer1.Visible = false;

			staff_bookRoom staffBR = staff_bookRoom1 as staff_bookRoom;

			if (staffBR != null)
			{
				staffBR.refreshData();
			}
		}

		private void btnCustomers_Click(object sender, EventArgs e)
		{
			admin_dashboard1.Visible = false;
			staff_bookRoom1.Visible = false;
			admin_customer1.Visible = true;

			admin_customer adCustomer = admin_customer1 as admin_customer;

			if (adCustomer != null)
			{
				adCustomer.refreshData();
			}
		}
	}
}
