namespace HotelManagement
{
	partial class admin_room
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.dgvRoomsData = new System.Windows.Forms.DataGridView();
			this.label5 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtRoomID = new System.Windows.Forms.TextBox();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.label2 = new System.Windows.Forms.Label();
			this.cboxType = new System.Windows.Forms.ComboBox();
			this.txtRoomName = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtPrice = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.cboxStatus = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.btnImport = new System.Windows.Forms.Button();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnClear = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvRoomsData)).BeginInit();
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.White;
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.dgvRoomsData);
			this.panel1.Location = new System.Drawing.Point(24, 24);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1062, 398);
			this.panel1.TabIndex = 0;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.White;
			this.panel2.Controls.Add(this.btnClear);
			this.panel2.Controls.Add(this.btnDelete);
			this.panel2.Controls.Add(this.btnUpdate);
			this.panel2.Controls.Add(this.btnAdd);
			this.panel2.Controls.Add(this.btnImport);
			this.panel2.Controls.Add(this.panel3);
			this.panel2.Controls.Add(this.cboxStatus);
			this.panel2.Controls.Add(this.label6);
			this.panel2.Controls.Add(this.txtPrice);
			this.panel2.Controls.Add(this.label4);
			this.panel2.Controls.Add(this.txtRoomName);
			this.panel2.Controls.Add(this.label3);
			this.panel2.Controls.Add(this.cboxType);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Controls.Add(this.txtRoomID);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Location = new System.Drawing.Point(24, 465);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1062, 239);
			this.panel2.TabIndex = 1;
			// 
			// dgvRoomsData
			// 
			this.dgvRoomsData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ActiveCaption;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvRoomsData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.dgvRoomsData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvRoomsData.EnableHeadersVisualStyles = false;
			this.dgvRoomsData.Location = new System.Drawing.Point(23, 70);
			this.dgvRoomsData.Name = "dgvRoomsData";
			this.dgvRoomsData.RowHeadersVisible = false;
			this.dgvRoomsData.RowHeadersWidth = 51;
			this.dgvRoomsData.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.dgvRoomsData.RowTemplate.Height = 24;
			this.dgvRoomsData.Size = new System.Drawing.Size(1010, 305);
			this.dgvRoomsData.TabIndex = 16;
			this.dgvRoomsData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRoomsData_CellClick);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(29, 25);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 17);
			this.label5.TabIndex = 17;
			this.label5.Text = "Room\'s Data";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(29, 28);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(75, 17);
			this.label1.TabIndex = 18;
			this.label1.Text = "Room ID:";
			// 
			// txtRoomID
			// 
			this.txtRoomID.Location = new System.Drawing.Point(110, 23);
			this.txtRoomID.Name = "txtRoomID";
			this.txtRoomID.Size = new System.Drawing.Size(123, 22);
			this.txtRoomID.TabIndex = 19;
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(39, 74);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(48, 17);
			this.label2.TabIndex = 20;
			this.label2.Text = "Type:";
			// 
			// cboxType
			// 
			this.cboxType.FormattingEnabled = true;
			this.cboxType.Items.AddRange(new object[] {
            "Single Room",
            "Double Room"});
			this.cboxType.Location = new System.Drawing.Point(110, 74);
			this.cboxType.Name = "cboxType";
			this.cboxType.Size = new System.Drawing.Size(164, 24);
			this.cboxType.TabIndex = 21;
			// 
			// txtRoomName
			// 
			this.txtRoomName.Location = new System.Drawing.Point(136, 123);
			this.txtRoomName.Name = "txtRoomName";
			this.txtRoomName.Size = new System.Drawing.Size(123, 22);
			this.txtRoomName.TabIndex = 23;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(29, 125);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(101, 17);
			this.label3.TabIndex = 22;
			this.label3.Text = "Room Name:";
			// 
			// txtPrice
			// 
			this.txtPrice.Location = new System.Drawing.Point(489, 23);
			this.txtPrice.Name = "txtPrice";
			this.txtPrice.Size = new System.Drawing.Size(123, 22);
			this.txtPrice.TabIndex = 25;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(408, 28);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(75, 17);
			this.label4.TabIndex = 24;
			this.label4.Text = "Price ($):";
			// 
			// cboxStatus
			// 
			this.cboxStatus.FormattingEnabled = true;
			this.cboxStatus.Items.AddRange(new object[] {
            "Active",
            "Inactive",
            "Occupied"});
			this.cboxStatus.Location = new System.Drawing.Point(489, 74);
			this.cboxStatus.Name = "cboxStatus";
			this.cboxStatus.Size = new System.Drawing.Size(164, 24);
			this.cboxStatus.TabIndex = 27;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(418, 74);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(59, 17);
			this.label6.TabIndex = 26;
			this.label6.Text = "Status:";
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.Silver;
			this.panel3.Controls.Add(this.pictureBox1);
			this.panel3.Location = new System.Drawing.Point(902, 23);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(131, 119);
			this.panel3.TabIndex = 28;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(0, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(131, 119);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// btnImport
			// 
			this.btnImport.BackColor = System.Drawing.Color.IndianRed;
			this.btnImport.Location = new System.Drawing.Point(902, 162);
			this.btnImport.Name = "btnImport";
			this.btnImport.Size = new System.Drawing.Size(131, 40);
			this.btnImport.TabIndex = 29;
			this.btnImport.Text = "Import";
			this.btnImport.UseVisualStyleBackColor = false;
			this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
			// 
			// btnAdd
			// 
			this.btnAdd.BackColor = System.Drawing.Color.IndianRed;
			this.btnAdd.Location = new System.Drawing.Point(65, 182);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(131, 40);
			this.btnAdd.TabIndex = 30;
			this.btnAdd.Text = "Add";
			this.btnAdd.UseVisualStyleBackColor = false;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnUpdate
			// 
			this.btnUpdate.BackColor = System.Drawing.Color.IndianRed;
			this.btnUpdate.Location = new System.Drawing.Point(259, 182);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(131, 40);
			this.btnUpdate.TabIndex = 31;
			this.btnUpdate.Text = "Update";
			this.btnUpdate.UseVisualStyleBackColor = false;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.BackColor = System.Drawing.Color.IndianRed;
			this.btnDelete.Location = new System.Drawing.Point(454, 182);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(131, 40);
			this.btnDelete.TabIndex = 32;
			this.btnDelete.Text = "Delete";
			this.btnDelete.UseVisualStyleBackColor = false;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnClear
			// 
			this.btnClear.BackColor = System.Drawing.Color.IndianRed;
			this.btnClear.Location = new System.Drawing.Point(642, 182);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(131, 40);
			this.btnClear.TabIndex = 33;
			this.btnClear.Text = "Clear";
			this.btnClear.UseVisualStyleBackColor = false;
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
			// 
			// admin_room
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Name = "admin_room";
			this.Size = new System.Drawing.Size(1112, 732);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvRoomsData)).EndInit();
			this.panel3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.DataGridView dgvRoomsData;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox cboxType;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtRoomID;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.ComboBox cboxStatus;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtPrice;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtRoomName;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button btnImport;
		private System.Windows.Forms.Button btnClear;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.Button btnAdd;
	}
}
