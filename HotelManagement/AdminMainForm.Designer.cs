namespace HotelManagement
{
	partial class AdminMainForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminMainForm));
			this.admin_customer1 = new HotelManagement.admin_customer();
			this.admin_room1 = new HotelManagement.admin_room();
			this.admin_addUser1 = new HotelManagement.admin_addUser();
			this.admin_dashboard1 = new HotelManagement.admin_dashboard();
			this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.label3 = new System.Windows.Forms.Label();
			this.btnDashboard = new System.Windows.Forms.Button();
			this.btnAddUser = new System.Windows.Forms.Button();
			this.btnRooms = new System.Windows.Forms.Button();
			this.btnCustomers = new System.Windows.Forms.Button();
			this.btnLogout = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.panel4 = new System.Windows.Forms.Panel();
			this.panel5 = new System.Windows.Forms.Panel();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.flowLayoutPanel1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel4.SuspendLayout();
			this.panel5.SuspendLayout();
			this.SuspendLayout();
			// 
			// admin_customer1
			// 
			this.admin_customer1.Location = new System.Drawing.Point(708, 89);
			this.admin_customer1.Name = "admin_customer1";
			this.admin_customer1.Size = new System.Drawing.Size(932, 707);
			this.admin_customer1.TabIndex = 2;
			// 
			// admin_room1
			// 
			this.admin_room1.Location = new System.Drawing.Point(682, 64);
			this.admin_room1.Name = "admin_room1";
			this.admin_room1.Size = new System.Drawing.Size(1026, 732);
			this.admin_room1.TabIndex = 3;
			// 
			// admin_addUser1
			// 
			this.admin_addUser1.Location = new System.Drawing.Point(682, 137);
			this.admin_addUser1.Name = "admin_addUser1";
			this.admin_addUser1.Size = new System.Drawing.Size(1006, 647);
			this.admin_addUser1.TabIndex = 4;
			// 
			// admin_dashboard1
			// 
			this.admin_dashboard1.Location = new System.Drawing.Point(181, -269);
			this.admin_dashboard1.Name = "admin_dashboard1";
			this.admin_dashboard1.Size = new System.Drawing.Size(1006, 647);
			this.admin_dashboard1.TabIndex = 7;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(470, 49);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(90, 76);
			this.pictureBox2.TabIndex = 2;
			this.pictureBox2.TabStop = false;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(439, 139);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(135, 21);
			this.label3.TabIndex = 2;
			this.label3.Text = "Welcom, User";
			// 
			// btnDashboard
			// 
			this.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnDashboard.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDashboard.Image = ((System.Drawing.Image)(resources.GetObject("btnDashboard.Image")));
			this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnDashboard.Location = new System.Drawing.Point(3, 3);
			this.btnDashboard.Name = "btnDashboard";
			this.btnDashboard.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
			this.btnDashboard.Size = new System.Drawing.Size(205, 56);
			this.btnDashboard.TabIndex = 2;
			this.btnDashboard.Text = "Dashboard";
			this.btnDashboard.UseVisualStyleBackColor = true;
			this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
			// 
			// btnAddUser
			// 
			this.btnAddUser.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnAddUser.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAddUser.Image = ((System.Drawing.Image)(resources.GetObject("btnAddUser.Image")));
			this.btnAddUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnAddUser.Location = new System.Drawing.Point(3, 3);
			this.btnAddUser.Name = "btnAddUser";
			this.btnAddUser.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
			this.btnAddUser.Size = new System.Drawing.Size(205, 56);
			this.btnAddUser.TabIndex = 3;
			this.btnAddUser.Text = "Add User";
			this.btnAddUser.UseVisualStyleBackColor = true;
			this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
			// 
			// btnRooms
			// 
			this.btnRooms.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnRooms.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRooms.Image = ((System.Drawing.Image)(resources.GetObject("btnRooms.Image")));
			this.btnRooms.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnRooms.Location = new System.Drawing.Point(3, 3);
			this.btnRooms.Name = "btnRooms";
			this.btnRooms.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
			this.btnRooms.Size = new System.Drawing.Size(205, 56);
			this.btnRooms.TabIndex = 4;
			this.btnRooms.Text = "Rooms";
			this.btnRooms.UseVisualStyleBackColor = true;
			this.btnRooms.Click += new System.EventHandler(this.btnRooms_Click);
			// 
			// btnCustomers
			// 
			this.btnCustomers.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnCustomers.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCustomers.Image = ((System.Drawing.Image)(resources.GetObject("btnCustomers.Image")));
			this.btnCustomers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCustomers.Location = new System.Drawing.Point(3, 3);
			this.btnCustomers.Name = "btnCustomers";
			this.btnCustomers.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
			this.btnCustomers.Size = new System.Drawing.Size(205, 56);
			this.btnCustomers.TabIndex = 5;
			this.btnCustomers.Text = "Customers";
			this.btnCustomers.UseVisualStyleBackColor = true;
			this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
			// 
			// btnLogout
			// 
			this.btnLogout.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnLogout.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLogout.Location = new System.Drawing.Point(415, 549);
			this.btnLogout.Name = "btnLogout";
			this.btnLogout.Size = new System.Drawing.Size(181, 53);
			this.btnLogout.TabIndex = 6;
			this.btnLogout.Text = "Logout";
			this.btnLogout.UseVisualStyleBackColor = false;
			this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(3, 3);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(53, 43);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pictureBox1.TabIndex = 8;
			this.pictureBox1.TabStop = false;
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
			this.flowLayoutPanel1.Controls.Add(this.panel5);
			this.flowLayoutPanel1.Controls.Add(this.panel1);
			this.flowLayoutPanel1.Controls.Add(this.panel2);
			this.flowLayoutPanel1.Controls.Add(this.panel3);
			this.flowLayoutPanel1.Controls.Add(this.panel4);
			this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(274, 796);
			this.flowLayoutPanel1.TabIndex = 9;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.btnDashboard);
			this.panel1.Location = new System.Drawing.Point(3, 124);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(211, 84);
			this.panel1.TabIndex = 10;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.btnAddUser);
			this.panel2.Location = new System.Drawing.Point(3, 214);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(211, 84);
			this.panel2.TabIndex = 11;
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.btnRooms);
			this.panel3.Location = new System.Drawing.Point(3, 304);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(211, 84);
			this.panel3.TabIndex = 12;
			// 
			// panel4
			// 
			this.panel4.Controls.Add(this.btnCustomers);
			this.panel4.Controls.Add(this.admin_dashboard1);
			this.panel4.Location = new System.Drawing.Point(3, 394);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(211, 84);
			this.panel4.TabIndex = 12;
			// 
			// panel5
			// 
			this.panel5.Controls.Add(this.pictureBox1);
			this.panel5.Location = new System.Drawing.Point(3, 3);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(61, 115);
			this.panel5.TabIndex = 10;
			// 
			// AdminMainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(1339, 796);
			this.Controls.Add(this.flowLayoutPanel1);
			this.Controls.Add(this.btnLogout);
			this.Controls.Add(this.admin_addUser1);
			this.Controls.Add(this.admin_room1);
			this.Controls.Add(this.admin_customer1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.pictureBox2);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "AdminMainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Hotel Management System";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.flowLayoutPanel1.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			this.panel5.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private admin_customer admin_customer1;
		private admin_room admin_room1;
		private admin_addUser admin_addUser1;
		private admin_dashboard admin_dashboard1;
		private System.DirectoryServices.DirectoryEntry directoryEntry1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnDashboard;
		private System.Windows.Forms.Button btnAddUser;
		private System.Windows.Forms.Button btnRooms;
		private System.Windows.Forms.Button btnCustomers;
		private System.Windows.Forms.Button btnLogout;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Panel panel5;
	}
}