using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagement
{
	public partial class admin_dashboard : UserControl
	{
		private string connectionString = "Data Source=LAPTOP-CTB60L9C\\SQLEXPRESS;Initial Catalog=HotelManagement;Integrated Security=True";
		public admin_dashboard()
		{
			InitializeComponent();

			displayTotalStaff();
			displayAvailableRooms();
			displayProfitToday();
			displayProfitTotal();

			displayData();
		}

		public void refreshData()
		{
			if (InvokeRequired)
			{
				// Invoke(new MethodInvoker(refreshData));
				Invoke((MethodInvoker)refreshData);
				return;
			}

			displayTotalStaff();
			displayAvailableRooms();
			displayProfitToday();
			displayProfitTotal();

			displayData();
		}

		public void displayData()
		{
			RoomsData roomsData = new RoomsData();
			dgvRoomsData.DataSource = roomsData.listRoomsData();
		}

		public void displayTotalStaff()
		{
			using(SqlConnection conn = new SqlConnection(connectionString))
			{
				conn.Open();

				string selectData = "SELECT COUNT(id) FROM Users WHERE role = 'Staff'";

				using(SqlCommand cmd = new SqlCommand(selectData, conn))
				{
					object result = cmd.ExecuteScalar();

					if (result != DBNull.Value)
					{
						lblStaffTotal.Text = result.ToString();
					}
				}
			}
		}

		public void displayAvailableRooms()
		{
			using (SqlConnection conn = new SqlConnection(connectionString))
			{
				conn.Open();

				string selectData = "SELECT COUNT(id) FROM Rooms WHERE status = 'Active' OR status = 'Available'";

				using (SqlCommand cmd = new SqlCommand(selectData, conn))
				{
					object result = cmd.ExecuteScalar();

					if (result != DBNull.Value)
					{
						lblAvaiRooms.Text = result.ToString();
					}
				}
			}
		}
		public void displayProfitToday()
		{
			using (SqlConnection conn = new SqlConnection(connectionString))
			{
				conn.Open();

				string selectData = "SELECT SUM(price) FROM Customers WHERE date_book = @dbook";

				using (SqlCommand cmd = new SqlCommand(selectData, conn))
				{
					DateTime today = DateTime.Today;
					cmd.Parameters.AddWithValue("@dbook", today);

					object result = cmd.ExecuteScalar();

					if (result != DBNull.Value)
					{
						lblProfitDay.Text = result.ToString();
					}
				}
			}
		}

		public void displayProfitTotal()
		{
			using (SqlConnection conn = new SqlConnection(connectionString))
			{
				conn.Open();

				string selectData = "SELECT SUM(price) FROM Customers";

				using (SqlCommand cmd = new SqlCommand(selectData, conn))
				{
					object result = cmd.ExecuteScalar();

					if (result != DBNull.Value)
					{
						lblProfitTotal.Text = result.ToString() + "vnd";
					}
				}
			}
		}
	}
}
