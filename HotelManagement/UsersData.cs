using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement
{
	internal class UsersData
	{
		private string connectionString = "Data Source=LAPTOP-CTB60L9C\\SQLEXPRESS;Initial Catalog=HotelManagement;Integrated Security=True";

		public int ID { get; set; }
		public string Username { get; set; }
		public string Password { get; set; }
		public string Role { get; set; }
		public string Status { get; set; }
		public string RegDate { get; set; }

		public List<UsersData> listUsersData()
		{
			List<UsersData> listData = new List<UsersData>();

			using(SqlConnection conn = new SqlConnection(connectionString))
			{
				conn.Open();

				string selectData = "SELECT * FROM Users";

				using ( SqlCommand cmd = new SqlCommand(selectData, conn))
				{
					SqlDataReader reader = cmd.ExecuteReader();

					while (reader.Read())
					{
						UsersData usersData = new UsersData();

						usersData.ID = (int)reader["id"];
						usersData.Username = reader["username"].ToString();
						usersData.Password = reader["password"].ToString();
						usersData.Role = reader["role"].ToString();
						usersData.Status = reader["status"].ToString();
						usersData.RegDate = reader["date_register"].ToString();

						listData.Add(usersData);
					}
				}
			}

			return listData;
		}
	}
}
