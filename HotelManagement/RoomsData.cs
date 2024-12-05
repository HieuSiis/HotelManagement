using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement
{
	internal class RoomsData
	{
		private string connectionString = "Data Source=LAPTOP-CTB60L9C\\SQLEXPRESS;Initial Catalog=HotelManagement;Integrated Security=True";

		public int ID { get; set; }
		public string RoomeID { get; set; }
		public string RoomType { get; set; }
		public string RoomName { get; set; }
		public string Price { get; set; }
		public string Image { get; set; }
		public string Status { get; set; }
		public string Date { get; set; }


		public List<RoomsData> listRoomsData()
		{
			List<RoomsData> listData = new List<RoomsData>();

			using (SqlConnection conn = new SqlConnection(connectionString))
			{
				conn.Open();

				string selectData = "SELECT * FROM Rooms WHERE date_delete IS NULL";

				using (SqlCommand cmd = new SqlCommand(selectData, conn))
				{
					SqlDataReader reader = cmd.ExecuteReader();

					while (reader.Read())
					{
						RoomsData roomsData = new RoomsData();

						roomsData.ID = (int)reader["id"];
						roomsData.RoomeID = reader["room_id"].ToString();
						roomsData.RoomType = reader["type"].ToString();
						roomsData.RoomName = reader["room_name"].ToString();
						roomsData.Price = reader["price"].ToString();
						roomsData.Image = reader["image_path"].ToString();
						roomsData.Status = reader["status"].ToString();
						roomsData.Date = reader["date_register"].ToString();

						listData.Add(roomsData);
					}
				}
			}

			return listData;
		}
	}
}
