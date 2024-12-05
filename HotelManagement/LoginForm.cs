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
	public partial class LoginForm : Form
	{
		private string connectionString = "Data Source=LAPTOP-CTB60L9C\\SQLEXPRESS;Initial Catalog=HotelManagement;Integrated Security=True";

		public LoginForm()
		{
			InitializeComponent();

		}

		private void close_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void btn_Register_Click(object sender, EventArgs e)
		{
			RegistrationForm regForm = new RegistrationForm();
			regForm.Show();

			this.Hide();
		}

		private void btn_Login_Click(object sender, EventArgs e)
		{
			if (txtUsername.Text == "" || txtPassword.Text == "")
			{
				MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				using(SqlConnection connection = new SqlConnection(connectionString))
				{
					connection.Open();

					string selectData = "SELECT * FROM Users WHERE (username = @usern AND password = @pass) AND status = @status";

					using(SqlCommand command = new SqlCommand(selectData, connection))
					{
						command.Parameters.AddWithValue("@usern", txtUsername.Text.Trim());
						command.Parameters.AddWithValue("@pass", txtPassword.Text.Trim());
						command.Parameters.AddWithValue("@status", "Active");

						SqlDataAdapter adapter = new SqlDataAdapter(command);
						DataTable dt = new DataTable();

						adapter.Fill(dt);

						if (dt.Rows.Count != 0)
						{
							MessageBox.Show("Login successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

							string selectRole = "SELECT role FROM Users WHERE username = @usern AND password = @pass";

							using (SqlCommand getRole = new SqlCommand(selectRole, connection))
							{
								getRole.Parameters.AddWithValue("@usern", txtUsername.Text.Trim());
								getRole.Parameters.AddWithValue("@pass", txtPassword.Text.Trim());

								string userRole = getRole.ExecuteScalar() as string;

								if (userRole == "Admin")
								{
									AdminMainForm adminMainForm = new AdminMainForm();
									adminMainForm.Show();

									this.Hide();
								}
								else if (userRole == "Staff")
								{
									StaffMainForm staffMainForm = new StaffMainForm();
									staffMainForm.Show();
									this.Hide();
								}
							}
						}
						else
						{
							MessageBox.Show("Incorrect username/password", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
						}
					}
				}
			}
		}

		private void cbox_showPass_CheckedChanged(object sender, EventArgs e)
		{
			txtPassword.PasswordChar = cbox_showPass.Checked ? '\0' : '*';
		}

		private void LoginForm_Load(object sender, EventArgs e)
		{

		}

		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void txtUsername_TextChanged(object sender, EventArgs e)
		{

		}

		private void label4_Click(object sender, EventArgs e)
		{

		}

		private void txtPassword_TextChanged(object sender, EventArgs e)
		{

		}

		private void label2_Click(object sender, EventArgs e)
		{

		}
	}
}
