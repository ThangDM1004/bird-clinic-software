namespace WinFormBirdClinic
{
	partial class frmBooking
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBooking));
			label1 = new System.Windows.Forms.Label();
			label3 = new System.Windows.Forms.Label();
			label8 = new System.Windows.Forms.Label();
			label11 = new System.Windows.Forms.Label();
			label12 = new System.Windows.Forms.Label();
			label13 = new System.Windows.Forms.Label();
			txtBookingId = new System.Windows.Forms.TextBox();
			txtDoctor = new System.Windows.Forms.TextBox();
			txtCustomer = new System.Windows.Forms.TextBox();
			dgvBooking = new System.Windows.Forms.DataGridView();
			btnUpdate = new System.Windows.Forms.Button();
			panel1 = new System.Windows.Forms.Panel();
			label2 = new System.Windows.Forms.Label();
			label9 = new System.Windows.Forms.Label();
			label7 = new System.Windows.Forms.Label();
			label5 = new System.Windows.Forms.Label();
			pictureBox2 = new System.Windows.Forms.PictureBox();
			pictureBox9 = new System.Windows.Forms.PictureBox();
			pictureBox7 = new System.Windows.Forms.PictureBox();
			pictureBox5 = new System.Windows.Forms.PictureBox();
			label4 = new System.Windows.Forms.Label();
			pictureBox4 = new System.Windows.Forms.PictureBox();
			label6 = new System.Windows.Forms.Label();
			label10 = new System.Windows.Forms.Label();
			txtFee = new System.Windows.Forms.TextBox();
			txtService = new System.Windows.Forms.TextBox();
			pictureBox1 = new System.Windows.Forms.PictureBox();
			dtpBooking = new System.Windows.Forms.DateTimePicker();
			txtPatientName = new System.Windows.Forms.TextBox();
			label14 = new System.Windows.Forms.Label();
			cbStatus = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)dgvBooking).BeginInit();
			panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new System.Drawing.Font("Segoe UI", 19.8000011F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			label1.Location = new System.Drawing.Point(549, 9);
			label1.Name = "label1";
			label1.Size = new System.Drawing.Size(301, 46);
			label1.TabIndex = 2;
			label1.Text = "Manage Schedule";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			label3.Location = new System.Drawing.Point(300, 58);
			label3.Name = "label3";
			label3.Size = new System.Drawing.Size(105, 25);
			label3.TabIndex = 3;
			label3.Text = "Booking Id";
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			label8.Location = new System.Drawing.Point(300, 120);
			label8.Name = "label8";
			label8.Size = new System.Drawing.Size(70, 25);
			label8.TabIndex = 3;
			label8.Text = "Doctor";
			// 
			// label11
			// 
			label11.AutoSize = true;
			label11.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			label11.Location = new System.Drawing.Point(300, 180);
			label11.Name = "label11";
			label11.Size = new System.Drawing.Size(93, 25);
			label11.TabIndex = 3;
			label11.Text = "Customer";
			// 
			// label12
			// 
			label12.AutoSize = true;
			label12.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			label12.Location = new System.Drawing.Point(780, 62);
			label12.Name = "label12";
			label12.Size = new System.Drawing.Size(128, 25);
			label12.TabIndex = 3;
			label12.Text = "Booking Date";
			// 
			// label13
			// 
			label13.AutoSize = true;
			label13.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			label13.Location = new System.Drawing.Point(785, 120);
			label13.Name = "label13";
			label13.Size = new System.Drawing.Size(65, 25);
			label13.TabIndex = 3;
			label13.Text = "Status";
			// 
			// txtBookingId
			// 
			txtBookingId.Enabled = false;
			txtBookingId.Location = new System.Drawing.Point(300, 86);
			txtBookingId.Name = "txtBookingId";
			txtBookingId.Size = new System.Drawing.Size(280, 27);
			txtBookingId.TabIndex = 4;
			// 
			// txtDoctor
			// 
			txtDoctor.Enabled = false;
			txtDoctor.Location = new System.Drawing.Point(300, 151);
			txtDoctor.Name = "txtDoctor";
			txtDoctor.Size = new System.Drawing.Size(280, 27);
			txtDoctor.TabIndex = 4;
			// 
			// txtCustomer
			// 
			txtCustomer.Enabled = false;
			txtCustomer.Location = new System.Drawing.Point(300, 208);
			txtCustomer.Name = "txtCustomer";
			txtCustomer.Size = new System.Drawing.Size(280, 27);
			txtCustomer.TabIndex = 4;
			// 
			// dgvBooking
			// 
			dgvBooking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvBooking.Location = new System.Drawing.Point(291, 364);
			dgvBooking.Name = "dgvBooking";
			dgvBooking.RowHeadersWidth = 51;
			dgvBooking.RowTemplate.Height = 29;
			dgvBooking.Size = new System.Drawing.Size(887, 244);
			dgvBooking.TabIndex = 7;
			dgvBooking.CellMouseClick += dgvBooking_CellMouseClick;
			// 
			// btnUpdate
			// 
			btnUpdate.Location = new System.Drawing.Point(966, 312);
			btnUpdate.Name = "btnUpdate";
			btnUpdate.Size = new System.Drawing.Size(94, 29);
			btnUpdate.TabIndex = 8;
			btnUpdate.Text = "Update";
			btnUpdate.UseVisualStyleBackColor = true;
			btnUpdate.Click += btnUpdate_Click;
			// 
			// panel1
			// 
			panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
			panel1.Controls.Add(label2);
			panel1.Controls.Add(label9);
			panel1.Controls.Add(label7);
			panel1.Controls.Add(label5);
			panel1.Controls.Add(pictureBox2);
			panel1.Controls.Add(pictureBox9);
			panel1.Controls.Add(pictureBox7);
			panel1.Controls.Add(pictureBox5);
			panel1.Controls.Add(label4);
			panel1.Controls.Add(pictureBox4);
			panel1.Location = new System.Drawing.Point(0, 0);
			panel1.Name = "panel1";
			panel1.Size = new System.Drawing.Size(261, 622);
			panel1.TabIndex = 12;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
			label2.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			label2.ForeColor = System.Drawing.Color.Black;
			label2.Location = new System.Drawing.Point(114, 553);
			label2.Name = "label2";
			label2.Size = new System.Drawing.Size(109, 33);
			label2.TabIndex = 3;
			label2.Text = "Logout";
			// 
			// label9
			// 
			label9.AutoSize = true;
			label9.BackColor = System.Drawing.SystemColors.ActiveCaption;
			label9.Font = new System.Drawing.Font("Arial", 17.9999981F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			label9.ForeColor = System.Drawing.Color.Black;
			label9.Location = new System.Drawing.Point(114, 353);
			label9.Name = "label9";
			label9.Size = new System.Drawing.Size(133, 35);
			label9.TabIndex = 3;
			label9.Text = "Booking";
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.BackColor = System.Drawing.SystemColors.ActiveCaption;
			label7.Font = new System.Drawing.Font("Arial", 17.9999981F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			label7.ForeColor = System.Drawing.Color.Black;
			label7.Location = new System.Drawing.Point(107, 253);
			label7.Name = "label7";
			label7.Size = new System.Drawing.Size(155, 35);
			label7.TabIndex = 3;
			label7.Text = "Customer";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.BackColor = System.Drawing.SystemColors.ActiveCaption;
			label5.Font = new System.Drawing.Font("Arial", 19.7999973F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			label5.ForeColor = System.Drawing.Color.Black;
			label5.Location = new System.Drawing.Point(114, 151);
			label5.Name = "label5";
			label5.Size = new System.Drawing.Size(134, 38);
			label5.TabIndex = 2;
			label5.Text = "Service";
			// 
			// pictureBox2
			// 
			pictureBox2.Image = (System.Drawing.Image)resources.GetObject("pictureBox2.Image");
			pictureBox2.Location = new System.Drawing.Point(55, 542);
			pictureBox2.Name = "pictureBox2";
			pictureBox2.Size = new System.Drawing.Size(46, 47);
			pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			pictureBox2.TabIndex = 2;
			pictureBox2.TabStop = false;
			// 
			// pictureBox9
			// 
			pictureBox9.Image = (System.Drawing.Image)resources.GetObject("pictureBox9.Image");
			pictureBox9.Location = new System.Drawing.Point(12, 312);
			pictureBox9.Name = "pictureBox9";
			pictureBox9.Size = new System.Drawing.Size(89, 77);
			pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			pictureBox9.TabIndex = 2;
			pictureBox9.TabStop = false;
			pictureBox9.Click += pictureBox9_Click;
			// 
			// pictureBox7
			// 
			pictureBox7.Image = (System.Drawing.Image)resources.GetObject("pictureBox7.Image");
			pictureBox7.Location = new System.Drawing.Point(12, 212);
			pictureBox7.Name = "pictureBox7";
			pictureBox7.Size = new System.Drawing.Size(89, 77);
			pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			pictureBox7.TabIndex = 2;
			pictureBox7.TabStop = false;
			pictureBox7.Click += pictureBox7_Click;
			// 
			// pictureBox5
			// 
			pictureBox5.Image = (System.Drawing.Image)resources.GetObject("pictureBox5.Image");
			pictureBox5.Location = new System.Drawing.Point(12, 112);
			pictureBox5.Name = "pictureBox5";
			pictureBox5.Size = new System.Drawing.Size(89, 77);
			pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			pictureBox5.TabIndex = 2;
			pictureBox5.TabStop = false;
			pictureBox5.Click += pictureBox5_Click;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new System.Drawing.Font("Arial", 19.7999973F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			label4.ForeColor = System.Drawing.Color.Black;
			label4.Location = new System.Drawing.Point(114, 51);
			label4.Name = "label4";
			label4.Size = new System.Drawing.Size(122, 38);
			label4.TabIndex = 2;
			label4.Text = "Doctor";
			// 
			// pictureBox4
			// 
			pictureBox4.Image = (System.Drawing.Image)resources.GetObject("pictureBox4.Image");
			pictureBox4.Location = new System.Drawing.Point(12, 12);
			pictureBox4.Name = "pictureBox4";
			pictureBox4.Size = new System.Drawing.Size(89, 77);
			pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			pictureBox4.TabIndex = 1;
			pictureBox4.TabStop = false;
			pictureBox4.Click += pictureBox4_Click;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			label6.Location = new System.Drawing.Point(785, 181);
			label6.Name = "label6";
			label6.Size = new System.Drawing.Size(74, 25);
			label6.TabIndex = 14;
			label6.Text = "Service";
			// 
			// label10
			// 
			label10.AutoSize = true;
			label10.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			label10.Location = new System.Drawing.Point(785, 251);
			label10.Name = "label10";
			label10.Size = new System.Drawing.Size(41, 25);
			label10.TabIndex = 16;
			label10.Text = "Fee";
			// 
			// txtFee
			// 
			txtFee.Enabled = false;
			txtFee.Location = new System.Drawing.Point(780, 279);
			txtFee.Name = "txtFee";
			txtFee.Size = new System.Drawing.Size(280, 27);
			txtFee.TabIndex = 17;
			// 
			// txtService
			// 
			txtService.Enabled = false;
			txtService.Location = new System.Drawing.Point(780, 212);
			txtService.Name = "txtService";
			txtService.Size = new System.Drawing.Size(280, 27);
			txtService.TabIndex = 18;
			// 
			// pictureBox1
			// 
			pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
			pictureBox1.Location = new System.Drawing.Point(1160, 0);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new System.Drawing.Size(31, 34);
			pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			pictureBox1.TabIndex = 19;
			pictureBox1.TabStop = false;
			pictureBox1.Click += pictureBox1_Click;
			// 
			// dtpBooking
			// 
			dtpBooking.Enabled = false;
			dtpBooking.Location = new System.Drawing.Point(780, 90);
			dtpBooking.Name = "dtpBooking";
			dtpBooking.Size = new System.Drawing.Size(280, 27);
			dtpBooking.TabIndex = 20;
			// 
			// txtPatientName
			// 
			txtPatientName.Enabled = false;
			txtPatientName.Location = new System.Drawing.Point(300, 279);
			txtPatientName.Name = "txtPatientName";
			txtPatientName.Size = new System.Drawing.Size(280, 27);
			txtPatientName.TabIndex = 23;
			// 
			// label14
			// 
			label14.AutoSize = true;
			label14.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			label14.Location = new System.Drawing.Point(305, 251);
			label14.Name = "label14";
			label14.Size = new System.Drawing.Size(128, 25);
			label14.TabIndex = 22;
			label14.Text = "Patient Name";
			// 
			// cbStatus
			// 
			cbStatus.FormattingEnabled = true;
			cbStatus.Location = new System.Drawing.Point(780, 151);
			cbStatus.Name = "cbStatus";
			cbStatus.Size = new System.Drawing.Size(280, 28);
			cbStatus.TabIndex = 24;
			// 
			// frmBooking
			// 
			AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			BackColor = System.Drawing.SystemColors.ControlLight;
			ClientSize = new System.Drawing.Size(1190, 620);
			Controls.Add(cbStatus);
			Controls.Add(txtPatientName);
			Controls.Add(label14);
			Controls.Add(dtpBooking);
			Controls.Add(pictureBox1);
			Controls.Add(txtService);
			Controls.Add(txtFee);
			Controls.Add(label10);
			Controls.Add(label6);
			Controls.Add(panel1);
			Controls.Add(btnUpdate);
			Controls.Add(dgvBooking);
			Controls.Add(txtCustomer);
			Controls.Add(txtDoctor);
			Controls.Add(txtBookingId);
			Controls.Add(label11);
			Controls.Add(label13);
			Controls.Add(label12);
			Controls.Add(label8);
			Controls.Add(label3);
			Controls.Add(label1);
			FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			Name = "frmBooking";
			Text = "frmDoctor";
			Load += frmBooking_Load;
			((System.ComponentModel.ISupportInitialize)dgvBooking).EndInit();
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.TextBox txtBookingId;
		private System.Windows.Forms.TextBox txtDoctor;
		private System.Windows.Forms.TextBox txtCustomer;
		private System.Windows.Forms.DataGridView dgvBooking;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox pictureBox9;
		private System.Windows.Forms.PictureBox pictureBox7;
		private System.Windows.Forms.PictureBox pictureBox5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.PictureBox pictureBox4;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox txtFee;
		private System.Windows.Forms.TextBox txtService;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.DateTimePicker dtpBooking;
		private System.Windows.Forms.TextBox txtPatientName;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.ComboBox cbStatus;
	}
}