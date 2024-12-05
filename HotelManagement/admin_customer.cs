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
	public partial class admin_customer : UserControl
	{
		public admin_customer()
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
			CustomersData roomsData = new CustomersData();
			dgvCustomersData.DataSource = roomsData.listCustomersData();
		}
	}
}
