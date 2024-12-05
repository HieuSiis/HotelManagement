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
	public partial class RegistrationForm : Form
	{
		private string connectionString = "Data Source=LAPTOP-CTB60L9C\\SQLEXPRESS;Initial Catalog=HotelManagement;Integrated Security=True";

		public RegistrationForm()
		{
			InitializeComponent();
		}

		private void btnSignIn_Click(object sender, EventArgs e)
		{
			LoginForm loginForm = new LoginForm();
			loginForm.Show();

			this.Hide();
		}

		private void cboxShowPass_CheckedChanged(object sender, EventArgs e)
		{
			txtPassword.PasswordChar = cboxShowPass.Checked ? '\0' : '*';
			txtConfirmPassword.PasswordChar = cboxShowPass.Checked ? '\0' : '*';
		}

		private void btnSignup_Click(object sender, EventArgs e)
		{
			if(txtUsername.Text == "" ||  txtPassword.Text == "" || txtConfirmPassword.Text == "")
			{
				MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				using (SqlConnection connection = new SqlConnection(connectionString))
				{
					connection.Open();

					string checkUsername = "SELECT username FROM Users Where username = @usern";

					using (SqlCommand command = new SqlCommand(checkUsername, connection))
					{
						command.Parameters.AddWithValue("@usern", txtUsername.Text.Trim());

						SqlDataAdapter adapter = new SqlDataAdapter(command);
						DataTable dt = new DataTable();
						adapter.Fill(dt);

						if (dt.Rows.Count > 0)
						{
							string tempUsern = txtUsername.Text.Substring(0, 1).ToUpper() + txtUsername.Text.Substring(1);
							MessageBox.Show($"{tempUsern} is existing already", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
						}
						else if (txtPassword.Text.Length < 6)
						{
							MessageBox.Show("Invalid password", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
						}
						else if (txtPassword.Text != txtConfirmPassword.Text)
						{
							MessageBox.Show("Password does not match", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
						}
						else 
						{
							string query = "INSERT INTO Users (username, password, role, status, date_register)" +
								"VALUES(@usern, @pass, @role, @status, @regDate)";
							using(SqlCommand cmd = new SqlCommand(query, connection))
							{
								cmd.Parameters.AddWithValue("@usern", txtUsername.Text.Trim());
								cmd.Parameters.AddWithValue("@pass", txtPassword.Text.Trim());
								cmd.Parameters.AddWithValue("@role", "Staff");
								cmd.Parameters.AddWithValue("@status", "Active");

								DateTime today = DateTime.Today;
								cmd.Parameters.AddWithValue("@regDate", today);

								cmd.ExecuteNonQuery();

								MessageBox.Show("Registered successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
							
								LoginForm loginForm = new LoginForm();
								loginForm.Show();

								this.Hide();
							}
						}
					}
				}
			}
		}

		private void close_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}
