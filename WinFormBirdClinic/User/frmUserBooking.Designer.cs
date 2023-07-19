namespace WinFormBirdClinic.User
{
	partial class frmUserBooking
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUserBooking));
			label1 = new System.Windows.Forms.Label();
			label3 = new System.Windows.Forms.Label();
			label8 = new System.Windows.Forms.Label();
			label11 = new System.Windows.Forms.Label();
			label12 = new System.Windows.Forms.Label();
			dtpBooking = new System.Windows.Forms.DateTimePicker();
			dgvBooking = new System.Windows.Forms.DataGridView();
			pictureBox1 = new System.Windows.Forms.PictureBox();
			txtFee = new System.Windows.Forms.TextBox();
			label6 = new System.Windows.Forms.Label();
			button2 = new System.Windows.Forms.Button();
			cbDoctor = new System.Windows.Forms.ComboBox();
			cbBird = new System.Windows.Forms.ComboBox();
			cbService = new System.Windows.Forms.ComboBox();
			panel1 = new System.Windows.Forms.Panel();
			label10 = new System.Windows.Forms.Label();
			label2 = new System.Windows.Forms.Label();
			pictureBox3 = new System.Windows.Forms.PictureBox();
			pictureBox6 = new System.Windows.Forms.PictureBox();
			label4 = new System.Windows.Forms.Label();
			label9 = new System.Windows.Forms.Label();
			label7 = new System.Windows.Forms.Label();
			label5 = new System.Windows.Forms.Label();
			pictureBox2 = new System.Windows.Forms.PictureBox();
			pictureBox7 = new System.Windows.Forms.PictureBox();
			pictureBox5 = new System.Windows.Forms.PictureBox();
			pictureBox4 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)dgvBooking).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new System.Drawing.Font("Segoe UI", 19.8000011F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			label1.Location = new System.Drawing.Point(549, 9);
			label1.Name = "label1";
			label1.Size = new System.Drawing.Size(155, 46);
			label1.TabIndex = 2;
			label1.Text = "Booking";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			label3.Location = new System.Drawing.Point(798, 75);
			label3.Name = "label3";
			label3.Size = new System.Drawing.Size(153, 31);
			label3.TabIndex = 3;
			label3.Text = "Doctor name";
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			label8.Location = new System.Drawing.Point(300, 175);
			label8.Name = "label8";
			label8.Size = new System.Drawing.Size(91, 31);
			label8.TabIndex = 3;
			label8.Text = "Service";
			// 
			// label11
			// 
			label11.AutoSize = true;
			label11.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			label11.Location = new System.Drawing.Point(800, 175);
			label11.Name = "label11";
			label11.Size = new System.Drawing.Size(124, 31);
			label11.TabIndex = 3;
			label11.Text = "Bird name";
			// 
			// label12
			// 
			label12.AutoSize = true;
			label12.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			label12.Location = new System.Drawing.Point(302, 78);
			label12.Name = "label12";
			label12.Size = new System.Drawing.Size(161, 31);
			label12.TabIndex = 3;
			label12.Text = "Booking Date";
			// 
			// dtpBooking
			// 
			dtpBooking.Location = new System.Drawing.Point(302, 123);
			dtpBooking.Name = "dtpBooking";
			dtpBooking.Size = new System.Drawing.Size(280, 27);
			dtpBooking.TabIndex = 5;
			dtpBooking.ValueChanged += dtpBooking_ValueChanged;
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
			// 
			// pictureBox1
			// 
			pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
			pictureBox1.Location = new System.Drawing.Point(1158, 0);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new System.Drawing.Size(31, 34);
			pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			pictureBox1.TabIndex = 12;
			pictureBox1.TabStop = false;
			pictureBox1.Click += pictureBox1_Click;
			// 
			// txtFee
			// 
			txtFee.Enabled = false;
			txtFee.Location = new System.Drawing.Point(300, 312);
			txtFee.Name = "txtFee";
			txtFee.Size = new System.Drawing.Size(280, 27);
			txtFee.TabIndex = 16;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			label6.Location = new System.Drawing.Point(300, 267);
			label6.Name = "label6";
			label6.Size = new System.Drawing.Size(50, 31);
			label6.TabIndex = 15;
			label6.Text = "Fee";
			// 
			// button2
			// 
			button2.Location = new System.Drawing.Point(800, 311);
			button2.Name = "button2";
			button2.Size = new System.Drawing.Size(94, 29);
			button2.TabIndex = 18;
			button2.Text = "Booking";
			button2.UseVisualStyleBackColor = true;
			button2.Click += button2_Click;
			// 
			// cbDoctor
			// 
			cbDoctor.FormattingEnabled = true;
			cbDoctor.Location = new System.Drawing.Point(800, 122);
			cbDoctor.Name = "cbDoctor";
			cbDoctor.Size = new System.Drawing.Size(278, 28);
			cbDoctor.TabIndex = 19;
			// 
			// cbBird
			// 
			cbBird.FormattingEnabled = true;
			cbBird.Location = new System.Drawing.Point(800, 220);
			cbBird.Name = "cbBird";
			cbBird.Size = new System.Drawing.Size(278, 28);
			cbBird.TabIndex = 20;
			// 
			// cbService
			// 
			cbService.FormattingEnabled = true;
			cbService.Location = new System.Drawing.Point(302, 220);
			cbService.Name = "cbService";
			cbService.Size = new System.Drawing.Size(278, 28);
			cbService.TabIndex = 21;
			cbService.SelectedIndexChanged += cbService_SelectedIndexChanged;
			// 
			// panel1
			// 
			panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
			panel1.Controls.Add(label10);
			panel1.Controls.Add(label2);
			panel1.Controls.Add(pictureBox3);
			panel1.Controls.Add(pictureBox6);
			panel1.Controls.Add(label4);
			panel1.Controls.Add(label9);
			panel1.Controls.Add(label7);
			panel1.Controls.Add(label5);
			panel1.Controls.Add(pictureBox2);
			panel1.Controls.Add(pictureBox7);
			panel1.Controls.Add(pictureBox5);
			panel1.Controls.Add(pictureBox4);
			panel1.Location = new System.Drawing.Point(0, 0);
			panel1.Name = "panel1";
			panel1.Size = new System.Drawing.Size(261, 622);
			panel1.TabIndex = 22;
			// 
			// label10
			// 
			label10.AutoSize = true;
			label10.BackColor = System.Drawing.SystemColors.ActiveCaption;
			label10.Font = new System.Drawing.Font("Arial", 17.9999981F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			label10.ForeColor = System.Drawing.Color.Black;
			label10.Location = new System.Drawing.Point(114, 455);
			label10.Name = "label10";
			label10.Size = new System.Drawing.Size(74, 35);
			label10.TabIndex = 24;
			label10.Text = "Bird";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
			label2.Font = new System.Drawing.Font("Arial", 17.9999981F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			label2.ForeColor = System.Drawing.Color.Black;
			label2.Location = new System.Drawing.Point(114, 353);
			label2.Name = "label2";
			label2.Size = new System.Drawing.Size(60, 35);
			label2.TabIndex = 5;
			label2.Text = "Bill";
			// 
			// pictureBox3
			// 
			pictureBox3.Image = (System.Drawing.Image)resources.GetObject("pictureBox3.Image");
			pictureBox3.Location = new System.Drawing.Point(12, 412);
			pictureBox3.Name = "pictureBox3";
			pictureBox3.Size = new System.Drawing.Size(89, 77);
			pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			pictureBox3.TabIndex = 23;
			pictureBox3.TabStop = false;
			pictureBox3.Click += pictureBox3_Click;
			// 
			// pictureBox6
			// 
			pictureBox6.Image = (System.Drawing.Image)resources.GetObject("pictureBox6.Image");
			pictureBox6.Location = new System.Drawing.Point(12, 312);
			pictureBox6.Name = "pictureBox6";
			pictureBox6.Size = new System.Drawing.Size(89, 77);
			pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			pictureBox6.TabIndex = 4;
			pictureBox6.TabStop = false;
			pictureBox6.Click += pictureBox6_Click;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
			label4.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			label4.ForeColor = System.Drawing.Color.Black;
			label4.Location = new System.Drawing.Point(114, 553);
			label4.Name = "label4";
			label4.Size = new System.Drawing.Size(109, 33);
			label4.TabIndex = 3;
			label4.Text = "Logout";
			// 
			// label9
			// 
			label9.AutoSize = true;
			label9.BackColor = System.Drawing.SystemColors.ActiveCaption;
			label9.Font = new System.Drawing.Font("Arial", 17.9999981F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			label9.ForeColor = System.Drawing.Color.Black;
			label9.Location = new System.Drawing.Point(114, 53);
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
			label7.Size = new System.Drawing.Size(108, 35);
			label7.TabIndex = 3;
			label7.Text = "Profile";
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
			// frmUserBooking
			// 
			AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			BackColor = System.Drawing.SystemColors.ControlLight;
			ClientSize = new System.Drawing.Size(1190, 620);
			Controls.Add(panel1);
			Controls.Add(cbService);
			Controls.Add(cbBird);
			Controls.Add(cbDoctor);
			Controls.Add(button2);
			Controls.Add(txtFee);
			Controls.Add(label6);
			Controls.Add(pictureBox1);
			Controls.Add(dgvBooking);
			Controls.Add(dtpBooking);
			Controls.Add(label11);
			Controls.Add(label12);
			Controls.Add(label8);
			Controls.Add(label3);
			Controls.Add(label1);
			FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			Name = "frmUserBooking";
			Text = "frmDoctor";
			Load += frmUserBooking_Load;
			((System.ComponentModel.ISupportInitialize)dgvBooking).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.DateTimePicker dtpBooking;
		private System.Windows.Forms.DataGridView dgvBooking;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.TextBox txtFee;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.ComboBox cbDoctor;
		private System.Windows.Forms.ComboBox cbBird;
		private System.Windows.Forms.ComboBox cbService;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.PictureBox pictureBox6;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox pictureBox7;
		private System.Windows.Forms.PictureBox pictureBox5;
		private System.Windows.Forms.PictureBox pictureBox4;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.PictureBox pictureBox3;
	}
}