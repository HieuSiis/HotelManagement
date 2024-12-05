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
	public partial class staff_bookRoom : UserControl
	{
		public staff_bookRoom()
		{
			InitializeComponent();
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

			displayData();
		}

		public void displayData()
		{
			RoomsData roomsData = new RoomsData();
			dgvRoomsData.DataSource = roomsData.listRoomsData();
		}

		private int getID = 0;

		private decimal getPrice = 0;
		private void dgvRoomsData_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex != -1)
			{
				DataGridViewRow row = dgvRoomsData.Rows[e.RowIndex];

				getID = (int)row.Cells[0].Value;
				lblRoomID.Text = row.Cells[1].Value.ToString();
				lblRoomType.Text = row.Cells[2].Value.ToString();
				lblRoomName.Text = row.Cells[3].Value.ToString();
				lblPrice.Text = (Convert.ToInt32(row.Cells[4].Value)).ToString("0.00");

				getPrice = Convert.ToDecimal(row.Cells[4].Value);

				imgView.ImageLocation = row.Cells[5].Value.ToString();

				lblStatus.Text = row.Cells[6].Value.ToString();
			}
		}

		private void btnSchedule_Click(object sender, EventArgs e)
		{
			DateTime fromDate = dtpFrom.Value;
			DateTime toDate = dtpTo.Value;

			TimeSpan countDays = toDate - fromDate;

			int days = countDays.Days;

			decimal totalPrice = days * getPrice;

			if (totalPrice < 0)
			{
				MessageBox.Show("Something wrong", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

				lblTotal.Text = "0.00";
			}
			else if (totalPrice == 0)
			{
				lblTotal.Text = getPrice.ToString("0.00");
			}
			else
			{
				lblTotal.Text = (days * getPrice).ToString("0.00");
			}
		}

		private void btnBook_Click(object sender, EventArgs e)
		{
			if(getPrice == 0 || lblTotal.Text == "0.00")
			{
				MessageBox.Show("Please fill all info correctly", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else if(lblStatus.Text != "Active")
			{
				MessageBox.Show("The room is unavailable", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				BooksData.roomID = lblRoomID.Text;
				BooksData.fromDate = dtpFrom.Value;
				BooksData.toDate = dtpTo.Value;
				BooksData.price = lblTotal.Text;

				Form formbg = new Form();

				try
				{
					using (ClientInfoForm clientInfoForm = new ClientInfoForm())
					{
						clientInfoForm.Owner = formbg;
						clientInfoForm.ShowDialog();

						formbg.Dispose();
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show("Error: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				finally
				{
					formbg.Dispose();
				}
			}
		}

		public void clearFields()
		{
			lblRoomID.Text = "------------";
			lblRoomType.Text = "------------";
			lblRoomName.Text = "------------";
			lblStatus.Text = "------------";
			lblTotal.Text = "0.00";
			lblPrice.Text = "0.00";

			imgView.Image = null;
		}
		private void btnClear_Click(object sender, EventArgs e)
		{
			clearFields();
		}
	}
}
