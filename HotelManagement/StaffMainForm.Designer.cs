namespace HotelManagement
{
	partial class StaffMainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnLogout = new System.Windows.Forms.Button();
			this.btnCustomers = new System.Windows.Forms.Button();
			this.btnBookRoom = new System.Windows.Forms.Button();
			this.btnDashboard = new System.Windows.Forms.Button();
			this.admin_customer1 = new HotelManagement.admin_customer();
			this.staff_bookRoom1 = new HotelManagement.staff_bookRoom();
			this.admin_dashboard1 = new HotelManagement.admin_dashboard();
			this.SuspendLayout();
			// 
			// btnLogout
			// 
			this.btnLogout.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnLogout.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLogout.Location = new System.Drawing.Point(32, 514);
			this.btnLogout.Name = "btnLogout";
			this.btnLogout.Size = new System.Drawing.Size(181, 53);
			this.btnLogout.TabIndex = 11;
			this.btnLogout.Text = "Logout";
			this.btnLogout.UseVisualStyleBackColor = false;
			this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
			// 
			// btnCustomers
			// 
			this.btnCustomers.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnCustomers.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCustomers.Location = new System.Drawing.Point(32, 289);
			this.btnCustomers.Name = "btnCustomers";
			this.btnCustomers.Size = new System.Drawing.Size(181, 53);
			this.btnCustomers.TabIndex = 10;
			this.btnCustomers.Text = "Customers";
			this.btnCustomers.UseVisualStyleBackColor = true;
			this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
			// 
			// btnBookRoom
			// 
			this.btnBookRoom.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnBookRoom.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBookRoom.Location = new System.Drawing.Point(32, 217);
			this.btnBookRoom.Name = "btnBookRoom";
			this.btnBookRoom.Size = new System.Drawing.Size(181, 53);
			this.btnBookRoom.TabIndex = 8;
			this.btnBookRoom.Text = "Book Room";
			this.btnBookRoom.UseVisualStyleBackColor = true;
			this.btnBookRoom.Click += new System.EventHandler(this.btnBookRoom_Click);
			// 
			// btnDashboard
			// 
			this.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnDashboard.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDashboard.Location = new System.Drawing.Point(32, 158);
			this.btnDashboard.Name = "btnDashboard";
			this.btnDashboard.Size = new System.Drawing.Size(181, 53);
			this.btnDashboard.TabIndex = 7;
			this.btnDashboard.Text = "Dashboard";
			this.btnDashboard.UseVisualStyleBackColor = true;
			this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
			// 
			// admin_customer1
			// 
			this.admin_customer1.Location = new System.Drawing.Point(219, -5);
			this.admin_customer1.Name = "admin_customer1";
			this.admin_customer1.Size = new System.Drawing.Size(932, 707);
			this.admin_customer1.TabIndex = 12;
			// 
			// staff_bookRoom1
			// 
			this.staff_bookRoom1.Location = new System.Drawing.Point(219, -5);
			this.staff_bookRoom1.Name = "staff_bookRoom1";
			this.staff_bookRoom1.Size = new System.Drawing.Size(937, 695);
			this.staff_bookRoom1.TabIndex = 13;
			// 
			// admin_dashboard1
			// 
			this.admin_dashboard1.Location = new System.Drawing.Point(219, 31);
			this.admin_dashboard1.Name = "admin_dashboard1";
			this.admin_dashboard1.Size = new System.Drawing.Size(1006, 647);
			this.admin_dashboard1.TabIndex = 14;
			// 
			// StaffMainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1153, 701);
			this.Controls.Add(this.admin_dashboard1);
			this.Controls.Add(this.staff_bookRoom1);
			this.Controls.Add(this.admin_customer1);
			this.Controls.Add(this.btnLogout);
			this.Controls.Add(this.btnCustomers);
			this.Controls.Add(this.btnBookRoom);
			this.Controls.Add(this.btnDashboard);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.Name = "StaffMainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "StaffMainForm";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnLogout;
		private System.Windows.Forms.Button btnCustomers;
		private System.Windows.Forms.Button btnBookRoom;
		private System.Windows.Forms.Button btnDashboard;
		private admin_customer admin_customer1;
		private staff_bookRoom staff_bookRoom1;
		private admin_dashboard admin_dashboard1;
	}
}