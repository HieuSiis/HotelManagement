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
	public partial class admin_addUser : UserControl
	{
		private string connectionString = "Data Source=LAPTOP-CTB60L9C\\SQLEXPRESS;Initial Catalog=HotelManagement;Integrated Security=True";
		
		private int getID;

		public admin_addUser()
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
			UsersData usersData = new UsersData();
			dgvUsersData.DataSource = usersData.listUsersData();
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			if (txtUsername.Text == "" || txtPassword.Text == ""
				|| cbBoxRole.SelectedIndex == -1 || cbBoxStatus.SelectedIndex == -1)
			{
				MessageBox.Show("Plese fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				using(SqlConnection con = new SqlConnection(connectionString))
				{
					con.Open();

					string checkUsern = "SELECT username FROM Users WHERE username = @usern";

					using (SqlCommand cmdCheckUser = new SqlCommand(checkUsern, con))
					{
						cmdCheckUser.Parameters.AddWithValue("@usern", txtUsername.Text.Trim());

						SqlDataAdapter adapter = new SqlDataAdapter(cmdCheckUser);
						DataTable dt = new DataTable();
						adapter.Fill(dt);

						if (dt.Rows.Count > 0)
						{
							string tempUsen = txtUsername.Text.Substring(0, 1).ToUpper() + txtUsername.Text.Substring(1);
							MessageBox.Show($"{tempUsen} is existing already", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
						}
						else if (txtPassword.Text.Length < 6)
						{
							MessageBox.Show("Invalid password", " Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
						}
						else
						{
							string insertData = "INSERT INTO Users (username, password, role, status, date_register)" + 
								" VALUES (@usern, @pass, @role, @status, @date)";

							using(SqlCommand cmd = new SqlCommand(insertData, con))
							{
								cmd.Parameters.AddWithValue("@usern", txtUsername.Text.Trim());
								cmd.Parameters.AddWithValue("@pass", txtPassword.Text.Trim());
								cmd.Parameters.AddWithValue("@role", cbBoxRole.SelectedItem.ToString());
								cmd.Parameters.AddWithValue("@status", cbBoxStatus.SelectedItem.ToString());

								DateTime today = DateTime.Today;

								cmd.Parameters.AddWithValue("@date", today);

								cmd.ExecuteNonQuery();
								clearFields();

								MessageBox.Show("Added successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
							}
						}
					}
				}
			}
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			if (txtUsername.Text == "" || txtPassword.Text == ""
				|| cbBoxRole.SelectedIndex == -1 || cbBoxStatus.SelectedIndex == -1)
			{
				MessageBox.Show("Plese fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				if (MessageBox.Show("Are you sure you want to update ID: " + getID + "?", "Conformation Message",
					MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					using (SqlConnection connection = new SqlConnection(connectionString))
					{
						connection.Open();

						string updateData = "UPDATE Users SET password = @pass, role = @role, status = @status WHERE username = @usern";

						using (SqlCommand command = new SqlCommand(updateData, connection))
						{
							command.Parameters.AddWithValue("@pass", txtPassword.Text.Trim());
							command.Parameters.AddWithValue("@role", cbBoxRole.Text.ToString());
							command.Parameters.AddWithValue("@status", cbBoxStatus.Text.ToString());
							command.Parameters.AddWithValue("@usern", txtUsername.Text.Trim());

							command.ExecuteNonQuery();

							displayData();

							MessageBox.Show("Updated successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

						}
					}
				}

			}
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			if (txtUsername.Text == "" || txtPassword.Text == ""
				|| cbBoxRole.SelectedIndex == -1 || cbBoxStatus.SelectedIndex == -1)
			{
				MessageBox.Show("Plese fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				if (MessageBox.Show("Are you sure you want to delete ID: " + getID + "?", "Conformation Message",
					MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					using (SqlConnection connection = new SqlConnection(connectionString))
					{
						connection.Open();

						string updateData = "DELETE FROM Users WHERE username = @usern";

						using (SqlCommand command = new SqlCommand(updateData, connection))
						{
							command.Parameters.AddWithValue("@usern", txtUsername.Text.Trim());

							command.ExecuteNonQuery();

							displayData();

							MessageBox.Show("Deleted successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

						}
					}
				}

			}
		}

		private void btnClear_Click(object sender, EventArgs e)
		{
			clearFields();
		}
		
		public void clearFields()
		{
			txtUsername.Text = "";
			txtPassword.Text = "";
			cbBoxRole.SelectedIndex = -1;
			cbBoxStatus.SelectedIndex = -1;
		}
		
		private void dgvUsersData_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if(e.RowIndex != -1)
			{
				DataGridViewRow row = dgvUsersData.Rows[e.RowIndex];

				getID = (int)row.Cells[0].Value;
				txtUsername.Text = row.Cells[1].Value.ToString();
				txtPassword.Text = row.Cells[2].Value.ToString();
				cbBoxRole.Text = row.Cells[3].Value.ToString();
				cbBoxStatus.Text = row.Cells[4].Value.ToString();


			}
		}

	}
}
