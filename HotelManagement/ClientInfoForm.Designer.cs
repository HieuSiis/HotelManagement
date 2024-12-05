namespace HotelManagement
{
	partial class ClientInfoForm
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.labelBI = new System.Windows.Forms.Label();
			this.lblBookID = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtFullName = new System.Windows.Forms.TextBox();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtPhoneNumber = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.cboxGender = new System.Windows.Forms.ComboBox();
			this.txtAddress = new System.Windows.Forms.TextBox();
			this.lblAddress = new System.Windows.Forms.Label();
			this.btnDone = new System.Windows.Forms.Button();
			this.btnClear = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.White;
			this.panel1.Controls.Add(this.btnClear);
			this.panel1.Controls.Add(this.btnDone);
			this.panel1.Controls.Add(this.txtAddress);
			this.panel1.Controls.Add(this.lblAddress);
			this.panel1.Controls.Add(this.cboxGender);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.txtPhoneNumber);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.txtEmail);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.txtFullName);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.lblBookID);
			this.panel1.Controls.Add(this.labelBI);
			this.panel1.Location = new System.Drawing.Point(12, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(925, 547);
			this.panel1.TabIndex = 0;
			// 
			// labelBI
			// 
			this.labelBI.AutoSize = true;
			this.labelBI.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelBI.Location = new System.Drawing.Point(153, 78);
			this.labelBI.Name = "labelBI";
			this.labelBI.Size = new System.Drawing.Size(66, 16);
			this.labelBI.TabIndex = 0;
			this.labelBI.Text = "Book ID:";
			// 
			// lblBookID
			// 
			this.lblBookID.AutoSize = true;
			this.lblBookID.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblBookID.Location = new System.Drawing.Point(225, 78);
			this.lblBookID.Name = "lblBookID";
			this.lblBookID.Size = new System.Drawing.Size(66, 16);
			this.lblBookID.TabIndex = 1;
			this.lblBookID.Text = "Book ID:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(138, 120);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(81, 16);
			this.label2.TabIndex = 2;
			this.label2.Text = "Full Name:";
			// 
			// txtFullName
			// 
			this.txtFullName.Location = new System.Drawing.Point(228, 120);
			this.txtFullName.Name = "txtFullName";
			this.txtFullName.Size = new System.Drawing.Size(158, 22);
			this.txtFullName.TabIndex = 3;
			// 
			// txtEmail
			// 
			this.txtEmail.Location = new System.Drawing.Point(228, 171);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(158, 22);
			this.txtEmail.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(169, 171);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(50, 16);
			this.label3.TabIndex = 4;
			this.label3.Text = "Email:";
			// 
			// txtPhoneNumber
			// 
			this.txtPhoneNumber.Location = new System.Drawing.Point(228, 222);
			this.txtPhoneNumber.Name = "txtPhoneNumber";
			this.txtPhoneNumber.Size = new System.Drawing.Size(158, 22);
			this.txtPhoneNumber.TabIndex = 7;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(106, 222);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(113, 16);
			this.label4.TabIndex = 6;
			this.label4.Text = "Phone Number:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(514, 123);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(62, 16);
			this.label5.TabIndex = 8;
			this.label5.Text = "Gender:";
			// 
			// cboxGender
			// 
			this.cboxGender.FormattingEnabled = true;
			this.cboxGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
			this.cboxGender.Location = new System.Drawing.Point(591, 120);
			this.cboxGender.Name = "cboxGender";
			this.cboxGender.Size = new System.Drawing.Size(150, 24);
			this.cboxGender.TabIndex = 9;
			// 
			// txtAddress
			// 
			this.txtAddress.Location = new System.Drawing.Point(591, 183);
			this.txtAddress.Multiline = true;
			this.txtAddress.Name = "txtAddress";
			this.txtAddress.Size = new System.Drawing.Size(163, 69);
			this.txtAddress.TabIndex = 11;
			this.txtAddress.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
			// 
			// lblAddress
			// 
			this.lblAddress.AutoSize = true;
			this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblAddress.Location = new System.Drawing.Point(516, 186);
			this.lblAddress.Name = "lblAddress";
			this.lblAddress.Size = new System.Drawing.Size(69, 16);
			this.lblAddress.TabIndex = 10;
			this.lblAddress.Text = "Address:";
			// 
			// btnDone
			// 
			this.btnDone.BackColor = System.Drawing.Color.IndianRed;
			this.btnDone.Location = new System.Drawing.Point(106, 385);
			this.btnDone.Name = "btnDone";
			this.btnDone.Size = new System.Drawing.Size(185, 40);
			this.btnDone.TabIndex = 33;
			this.btnDone.Text = "Done";
			this.btnDone.UseVisualStyleBackColor = false;
			this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
			// 
			// btnClear
			// 
			this.btnClear.BackColor = System.Drawing.Color.IndianRed;
			this.btnClear.Location = new System.Drawing.Point(517, 385);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(185, 40);
			this.btnClear.TabIndex = 34;
			this.btnClear.Text = "Clear";
			this.btnClear.UseVisualStyleBackColor = false;
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
			// 
			// ClientInfoForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(949, 571);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "ClientInfoForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ClientInfoForm";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TextBox txtEmail;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtFullName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lblBookID;
		private System.Windows.Forms.Label labelBI;
		private System.Windows.Forms.TextBox txtAddress;
		private System.Windows.Forms.Label lblAddress;
		private System.Windows.Forms.ComboBox cboxGender;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtPhoneNumber;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btnClear;
		private System.Windows.Forms.Button btnDone;
	}
}