using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement
{
	internal class CustomersData
	{
		private string connectionString = "Data Source=LAPTOP-CTB60L9C\\SQLEXPRESS;Initial Catalog=HotelManagement;Integrated Security=True";

		public int ID { get; set; }
		public string BookID { get; set; }
		public string FullName { get; set; }
		public string Email { get; set; }
		public string PhoneNumber { get; set; }
		public string Gender { get; set; }
		public string Address { get; set; }
		public string RoomID { get; set; }
		public string Price { get; set; }
		public string StatusPayment { get; set; }
		public string Status { get; set; }
		public string CheckIn { get; set; }
		public string CheckOut { get; set; }
		public string BookDate { get; set; }

		public List<CustomersData> listCustomersData()
		{
			List<CustomersData> listData = new List<CustomersData>();

			using (SqlConnection conn = new SqlConnection(connectionString))
			{
				conn.Open();

				string selectData = "SELECT * FROM Customers";

				using (SqlCommand cmd = new SqlCommand(selectData, conn))
				{
					SqlDataReader reader = cmd.ExecuteReader();

					while (reader.Read())
					{
						CustomersData cData = new CustomersData();

						cData.ID = (int)reader["id"];
						cData.BookID = reader["book_id"].ToString();
						cData.FullName = reader["full_name"].ToString();
						cData.Email = reader["email"].ToString();
						cData.PhoneNumber = reader["phone_number"].ToString();
						cData.Gender = reader["gender"].ToString();
						cData.Address = reader["address"].ToString();
						cData.RoomID = reader["room_id"].ToString();
						cData.Price = reader["price"].ToString();
						cData.StatusPayment = reader["status_payment"].ToString();
						cData.Status = reader["status"].ToString();
						cData.CheckIn = reader["date_from"].ToString();
						cData.CheckOut = reader["date_to"].ToString();
						cData.BookDate = reader["date_book"].ToString();

						listData.Add(cData);
					}
				}
			}

			return listData;
		}
	}
}
