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
using System.IO;

namespace HotelManagement
{
	public partial class admin_room : UserControl
	{
		private string connectionString = "Data Source=LAPTOP-CTB60L9C\\SQLEXPRESS;Initial Catalog=HotelManagement;Integrated Security=True";

		public admin_room()
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

		public bool isEmpty()
		{
			if (string.IsNullOrEmpty(txtRoomID.Text) || string.IsNullOrEmpty(txtRoomName.Text) 
				|| cboxType.SelectedIndex == -1 || string.IsNullOrEmpty(txtPrice.Text)
				|| cboxStatus.SelectedIndex == -1 || pictureBox1.Image == null)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		private void pictureBox1_Click(object sender, EventArgs e)
		{

		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			if (isEmpty())
			{
				MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				try
				{
					using (SqlConnection conn = new SqlConnection(connectionString))
					{
						conn.Open();

						string checkRoomID = "SELECT room_id FROM rooms WHERE room_id = @roomID";
						using (SqlCommand cmd = new SqlCommand(checkRoomID, conn))
						{
							cmd.Parameters.AddWithValue("@roomID", txtRoomID.Text.Trim());

							SqlDataAdapter adapter = new SqlDataAdapter(cmd);
							DataTable dt = new DataTable();

							adapter.Fill(dt);

							if (dt.Rows.Count > 0)
							{
								MessageBox.Show(txtRoomID.Text.Trim() + " is existing already", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
							}
							else
							{
								string insertData = "INSERT INTO rooms (room_id, type, room_name, price, image_path, status, date_register)" +
									"VALUES(@roomID, @type, @name, @price, @imgPath, @status, @date_reg)";

								string path = Path.Combine(@"D:\DevSWA\Project\HotelManagement\HotelManagement\img_rooms\" + txtRoomID.Text.Trim() + ".jpg");

								string dirPath = Path.GetDirectoryName(path);

								if (!Directory.Exists(dirPath))
								{
									Directory.CreateDirectory(dirPath);
								}

								File.Copy(pictureBox1.ImageLocation, path, true);

								using (SqlCommand command = new SqlCommand(insertData, conn))
								{
									command.Parameters.AddWithValue("@roomID", txtRoomID.Text.Trim());
									command.Parameters.AddWithValue("@type", cboxType.SelectedItem.ToString());
									command.Parameters.AddWithValue("@name", txtRoomName.Text.Trim());
									command.Parameters.AddWithValue("@price", txtPrice.Text.Trim());

									command.Parameters.AddWithValue("@imgPath", path);

									command.Parameters.AddWithValue("@status", cboxStatus.SelectedItem.ToString());

									DateTime today = DateTime.Today;
									command.Parameters.AddWithValue("@date_reg", today);

									command.ExecuteNonQuery();

									clearFields();
									displayData();

									MessageBox.Show("Added successfully!", "Infomation Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
								}
							}
						}
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show("Something wrong!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		private void btnImport_Click(object sender, EventArgs e)
		{
			try
			{
				OpenFileDialog dlg = new OpenFileDialog();
				string imgPath = "";

				dlg.Filter = "Image Files (*.jpg; *.png)|*.jpg; *.png";
				
				if (dlg.ShowDialog() == DialogResult.OK) 
				{ 
					imgPath = dlg.FileName; 
					pictureBox1.ImageLocation = imgPath;
				}
			}
			catch(Exception ex)
			{
				MessageBox.Show($"Error: {ex}", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			if (isEmpty())
			{
				MessageBox.Show("Please select item first", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				try
				{
					if (MessageBox.Show("Are you sure you want to UPDATE ID: " + id + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
					{
						using (SqlConnection conn = new SqlConnection(connectionString))
						{
							conn.Open();

							string updateData = "UPDATE rooms SET room_id = @roomID, type = @type, room_name = @name, price = @price" +
								", status = @status, date_update = @update WHERE id = @id";

							using (SqlCommand cmd = new SqlCommand(updateData, conn))
							{
								cmd.Parameters.AddWithValue("@roomID", txtRoomID.Text.Trim());
								cmd.Parameters.AddWithValue("@type", cboxType.SelectedItem.ToString());
								cmd.Parameters.AddWithValue("@name", txtRoomName.Text.Trim());
								cmd.Parameters.AddWithValue("@price", txtPrice.Text.Trim());
								cmd.Parameters.AddWithValue("@status", cboxStatus.SelectedItem.ToString());

								DateTime today = DateTime.Today;
								cmd.Parameters.AddWithValue("@update", today);
								cmd.Parameters.AddWithValue("@id", id);

								cmd.ExecuteNonQuery();

								clearFields();
								displayData();

								MessageBox.Show("Updated successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
							}
						}
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show("Something wrong!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		private int id;
		private void dgvRoomsData_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex != -1)
			{
				DataGridViewRow row = dgvRoomsData.Rows[e.RowIndex];

				id = (int)row.Cells[0].Value;
				txtRoomID.Text = row.Cells[1].Value.ToString();
				cboxType.Text = row.Cells[2].Value.ToString();
				txtRoomName.Text = row.Cells[3].Value.ToString();
				txtPrice.Text = row.Cells[4].Value.ToString();

				pictureBox1.ImageLocation = row.Cells[5].Value.ToString();

				cboxStatus.Text = row.Cells[6].Value.ToString();
			}
		}

		public void clearFields()
		{
			txtRoomID.Text = "";
			cboxType.SelectedIndex = -1;
			txtRoomName.Text = "";
			txtPrice.Text = "";
			pictureBox1.Image = null;
			cboxStatus.SelectedIndex = -1;
		}
		private void btnClear_Click(object sender, EventArgs e)
		{
			clearFields();
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			if (isEmpty())
			{
				MessageBox.Show("Please select item first", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				try
				{
					if (MessageBox.Show("Are you sure you want to DELETE ID: " + id + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
					{
						using (SqlConnection conn = new SqlConnection(connectionString))
						{
							conn.Open();

							string updateData = "UPDATE rooms SET date_delete = @delete WHERE id = @id";

							using (SqlCommand cmd = new SqlCommand(updateData, conn))
							{
								DateTime today = DateTime.Today;
								cmd.Parameters.AddWithValue("@delete", today);
								cmd.Parameters.AddWithValue("@id", id);

								cmd.ExecuteNonQuery();

								clearFields();
								displayData();

								MessageBox.Show("Deleted successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
							}
						}
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show("Something wrong!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}
	}
}
