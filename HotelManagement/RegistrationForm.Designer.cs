namespace HotelManagement
{
	partial class RegistrationForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrationForm));
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnSignIn = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.btnSignup = new System.Windows.Forms.Button();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtUsername = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.close = new System.Windows.Forms.Label();
			this.cboxShowPass = new System.Windows.Forms.CheckBox();
			this.txtConfirmPassword = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.DarkSeaGreen;
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.pictureBox2);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(419, 526);
			this.panel1.TabIndex = 9;
			// 
			// btnSignIn
			// 
			this.btnSignIn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSignIn.Location = new System.Drawing.Point(644, 465);
			this.btnSignIn.Name = "btnSignIn";
			this.btnSignIn.Size = new System.Drawing.Size(99, 30);
			this.btnSignIn.TabIndex = 8;
			this.btnSignIn.Text = "Sign In";
			this.btnSignIn.UseVisualStyleBackColor = true;
			this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Cursor = System.Windows.Forms.Cursors.Hand;
			this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.White;
			this.label5.Location = new System.Drawing.Point(53, 435);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(309, 27);
			this.label5.TabIndex = 8;
			this.label5.Text = "Hotel Management System";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btnSignup
			// 
			this.btnSignup.BackColor = System.Drawing.Color.MediumSeaGreen;
			this.btnSignup.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
			this.btnSignup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
			this.btnSignup.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSignup.Location = new System.Drawing.Point(510, 388);
			this.btnSignup.Name = "btnSignup";
			this.btnSignup.Size = new System.Drawing.Size(188, 49);
			this.btnSignup.TabIndex = 16;
			this.btnSignup.Text = "Signup";
			this.btnSignup.UseVisualStyleBackColor = false;
			this.btnSignup.Click += new System.EventHandler(this.btnSignup_Click);
			// 
			// txtPassword
			// 
			this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPassword.Location = new System.Drawing.Point(450, 220);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.PasswordChar = '*';
			this.txtPassword.Size = new System.Drawing.Size(309, 30);
			this.txtPassword.TabIndex = 15;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
			this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(446, 197);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(90, 20);
			this.label4.TabIndex = 14;
			this.label4.Text = "Password";
			// 
			// txtUsername
			// 
			this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtUsername.Location = new System.Drawing.Point(450, 146);
			this.txtUsername.Name = "txtUsername";
			this.txtUsername.Size = new System.Drawing.Size(309, 30);
			this.txtUsername.TabIndex = 13;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
			this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(446, 114);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(93, 20);
			this.label3.TabIndex = 12;
			this.label3.Text = "Username";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
			this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(445, 56);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(149, 27);
			this.label2.TabIndex = 11;
			this.label2.Text = "Registration";
			// 
			// close
			// 
			this.close.AutoSize = true;
			this.close.Cursor = System.Windows.Forms.Cursors.Hand;
			this.close.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.close.Location = new System.Drawing.Point(838, 20);
			this.close.Name = "close";
			this.close.Size = new System.Drawing.Size(19, 20);
			this.close.TabIndex = 10;
			this.close.Text = "X";
			this.close.Click += new System.EventHandler(this.close_Click);
			// 
			// cboxShowPass
			// 
			this.cboxShowPass.AutoSize = true;
			this.cboxShowPass.Location = new System.Drawing.Point(450, 362);
			this.cboxShowPass.Name = "cboxShowPass";
			this.cboxShowPass.Size = new System.Drawing.Size(125, 20);
			this.cboxShowPass.TabIndex = 17;
			this.cboxShowPass.Text = "Show Password";
			this.cboxShowPass.UseVisualStyleBackColor = true;
			this.cboxShowPass.CheckedChanged += new System.EventHandler(this.cboxShowPass_CheckedChanged);
			// 
			// txtConfirmPassword
			// 
			this.txtConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtConfirmPassword.Location = new System.Drawing.Point(450, 308);
			this.txtConfirmPassword.Name = "txtConfirmPassword";
			this.txtConfirmPassword.PasswordChar = '*';
			this.txtConfirmPassword.Size = new System.Drawing.Size(309, 30);
			this.txtConfirmPassword.TabIndex = 19;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Cursor = System.Windows.Forms.Cursors.Hand;
			this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(446, 272);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(160, 20);
			this.label7.TabIndex = 18;
			this.label7.Text = "Confirm Password";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(491, 472);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(127, 16);
			this.label1.TabIndex = 20;
			this.label1.Text = "Sign In your Account";
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(86, 56);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(264, 306);
			this.pictureBox2.TabIndex = 1;
			this.pictureBox2.TabStop = false;
			// 
			// RegistrationForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(885, 526);
			this.Controls.Add(this.btnSignIn);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtConfirmPassword);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.btnSignup);
			this.Controls.Add(this.txtPassword);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtUsername);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.close);
			this.Controls.Add(this.cboxShowPass);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "RegistrationForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "RegistrationForm";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnSignIn;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button btnSignup;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtUsername;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label close;
		private System.Windows.Forms.CheckBox cboxShowPass;
		private System.Windows.Forms.TextBox txtConfirmPassword;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pictureBox2;
	}
}