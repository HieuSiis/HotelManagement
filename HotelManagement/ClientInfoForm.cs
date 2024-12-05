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
	public partial class ClientInfoForm : Form
	{
		private string connectionString = "Data Source=LAPTOP-CTB60L9C\\SQLEXPRESS;Initial Catalog=HotelManagement;Integrated Security=True";
		public ClientInfoForm()
		{
			InitializeComponent();
			displayBookID();
		}

		private void textBox4_TextChanged(object sender, EventArgs e)
		{

		}

		public void displayBookID()
		{
			using(SqlConnection conn = new SqlConnection(connectionString))
			{
				conn.Open();

				int getBookID = 0;

				string selectBID = "SELECT COUNT(id) FROM Customers";

				using(SqlCommand cmd = new SqlCommand(selectBID, conn))
				{
					getBookID = Convert.ToInt32(cmd.ExecuteScalar());

					if (getBookID == 0)
					{
						getBookID += 1;
					}
					else
					{
						getBookID += 1;
					}
				}

				lblBookID.Text = $"BID-{getBookID}";
			}
		}
		private void btnDone_Click(object sender, EventArgs e)
		{
			if(MessageBox.Show("Are you sure you want to book now?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				if (txtFullName.Text == "" || cboxGender.SelectedIndex == -1 || txtAddress.Text == ""
				|| txtEmail.Text == "" || txtPhoneNumber.Text == "" || BooksData.roomID == "")
				{
					MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				else
				{
					using (SqlConnection conn = new SqlConnection(connectionString))
					{
						conn.Open();

						string insertData = "INSERT INTO Customers (book_id, full_name, email, phone_number, gender, address, room_id, price, status_payment, status, date_from, date_to, date_book) VALUES(@bookID, @fullname, @email, @phoneNumber, @gender, @address, @roomID, @price, @statusP, @status, @dateFrom, @dateTo, @dateBook)";

						using (SqlCommand cmd = new SqlCommand(insertData, conn))
						{
							cmd.Parameters.AddWithValue("@bookID", lblBookID.Text);
							cmd.Parameters.AddWithValue("@fullname", txtFullName.Text);
							cmd.Parameters.AddWithValue("@email", txtEmail.Text);
							cmd.Parameters.AddWithValue("@phoneNumber", txtPhoneNumber.Text);
							cmd.Parameters.AddWithValue("@gender", cboxGender.SelectedItem.ToString());
							cmd.Parameters.AddWithValue("@address", txtAddress.Text);
							cmd.Parameters.AddWithValue("@roomID", BooksData.roomID);
							cmd.Parameters.AddWithValue("@price", BooksData.price);
							cmd.Parameters.AddWithValue("@statusP", "Paid");
							cmd.Parameters.AddWithValue("@status", "Check In");
							cmd.Parameters.AddWithValue("@dateFrom", BooksData.fromDate);
							cmd.Parameters.AddWithValue("@dateTo", BooksData.toDate);

							DateTime today = DateTime.Today;

							cmd.Parameters.AddWithValue("@dateBook", today);

							cmd.ExecuteNonQuery();

							updateRoomStatus();

							MessageBox.Show("Booked succesfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

							this.Hide();
						}
					}
				}
			}
		}

		public void updateRoomStatus()
		{
			using(SqlConnection conn = new SqlConnection(connectionString))
			{
				conn.Open();

				string updateStatus = "UPDATE Rooms SET status = @status WHERE room_id = @roomID";

				using(SqlCommand cmd = new SqlCommand(updateStatus, conn))
				{
					cmd.Parameters.AddWithValue("@status", "Unavailable");
					cmd.Parameters.AddWithValue("@roomID", BooksData.roomID);

					cmd.ExecuteNonQuery();
				}
			}
		}

		private void btnClear_Click(object sender, EventArgs e)
		{
			txtFullName.Text = "";
			txtEmail.Text = "";
			txtPhoneNumber.Text = "";
			cboxGender.SelectedIndex = -1;
			txtAddress.Text = "";
		}
	}
}
