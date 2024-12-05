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
	public partial class AdminMainForm : Form
	{
		public AdminMainForm()
		{
			InitializeComponent();
		}

	/*	private void close_Click(object sender, EventArgs e)
		{
			if(MessageBox.Show("Are you sure you want to exit?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				Application.Exit();
			}
		}*/

		private void btnLogout_Click(object sender, EventArgs e)
		{
			if(MessageBox.Show("Are you sure you want to logout?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				LoginForm loginForm = new LoginForm();
				loginForm.Show();

				this.Hide();
			}
		}

		private void admin_addUser1_Load(object sender, EventArgs e)
		{

		}

		private void admin_room1_Load(object sender, EventArgs e)
		{

		}

		private void btnDashboard_Click(object sender, EventArgs e)
		{
			admin_dashboard1.Visible = true;
			admin_addUser1.Visible = false;
			admin_room1.Visible = false;
			admin_customer1.Visible = false;

			admin_dashboard adDashboard = admin_dashboard1 as admin_dashboard;

			if(adDashboard != null)
			{
				adDashboard.refreshData();
			}
		}

		private void btnAddUser_Click(object sender, EventArgs e)
		{
			admin_dashboard1.Visible = false;
			admin_addUser1.Visible = true;
			admin_room1.Visible = false;
			admin_customer1.Visible = false;

			admin_addUser adAddUser = admin_addUser1 as admin_addUser;

			if (adAddUser != null)
			{
				adAddUser.refreshData();
			}
		}

		private void btnRooms_Click(object sender, EventArgs e)
		{
			admin_dashboard1.Visible = false;
			admin_addUser1.Visible = false;
			admin_room1.Visible = true;
			admin_customer1.Visible = false;

			admin_room adRoom = admin_room1 as admin_room;

			if (adRoom != null)
			{
				adRoom.refreshData();
			}
		}

		private void btnCustomers_Click(object sender, EventArgs e)
		{
			admin_dashboard1.Visible = false;
			admin_addUser1.Visible = false;
			admin_room1.Visible = false;
			admin_customer1.Visible = true;

			admin_customer adCustomer = admin_customer1 as admin_customer;

			if (adCustomer != null)
			{
				adCustomer.refreshData();
			}
		}

		private void label2_Click(object sender, EventArgs e)
		{

		}
	}
}
