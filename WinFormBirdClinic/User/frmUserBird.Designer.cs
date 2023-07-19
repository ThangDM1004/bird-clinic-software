namespace WinFormBirdClinic.User
{
	partial class frmUserBird
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUserBird));
			label1 = new System.Windows.Forms.Label();
			label3 = new System.Windows.Forms.Label();
			label8 = new System.Windows.Forms.Label();
			label11 = new System.Windows.Forms.Label();
			label12 = new System.Windows.Forms.Label();
			txtPatientID = new System.Windows.Forms.TextBox();
			txtHeight = new System.Windows.Forms.TextBox();
			txtWeight = new System.Windows.Forms.TextBox();
			dgvBird = new System.Windows.Forms.DataGridView();
			btnUpdate = new System.Windows.Forms.Button();
			btnSave = new System.Windows.Forms.Button();
			btnCancel = new System.Windows.Forms.Button();
			pictureBox1 = new System.Windows.Forms.PictureBox();
			pictureBox4 = new System.Windows.Forms.PictureBox();
			pictureBox5 = new System.Windows.Forms.PictureBox();
			pictureBox7 = new System.Windows.Forms.PictureBox();
			pictureBox2 = new System.Windows.Forms.PictureBox();
			label5 = new System.Windows.Forms.Label();
			label7 = new System.Windows.Forms.Label();
			label9 = new System.Windows.Forms.Label();
			label4 = new System.Windows.Forms.Label();
			pictureBox6 = new System.Windows.Forms.PictureBox();
			label2 = new System.Windows.Forms.Label();
			panel1 = new System.Windows.Forms.Panel();
			label6 = new System.Windows.Forms.Label();
			pictureBox3 = new System.Windows.Forms.PictureBox();
			btnCreate = new System.Windows.Forms.Button();
			txtAge = new System.Windows.Forms.TextBox();
			txtBirdName = new System.Windows.Forms.TextBox();
			label10 = new System.Windows.Forms.Label();
			label13 = new System.Windows.Forms.Label();
			label14 = new System.Windows.Forms.Label();
			cbGender = new System.Windows.Forms.ComboBox();
			cbSpecies = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)dgvBird).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
			panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new System.Drawing.Font("Segoe UI", 19.8000011F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			label1.Location = new System.Drawing.Point(656, 0);
			label1.Name = "label1";
			label1.Size = new System.Drawing.Size(87, 46);
			label1.TabIndex = 2;
			label1.Text = "Bird";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			label3.Location = new System.Drawing.Point(312, 46);
			label3.Name = "label3";
			label3.Size = new System.Drawing.Size(120, 31);
			label3.TabIndex = 3;
			label3.Text = "Patient ID";
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			label8.Location = new System.Drawing.Point(312, 238);
			label8.Name = "label8";
			label8.Size = new System.Drawing.Size(88, 31);
			label8.TabIndex = 3;
			label8.Text = "Height";
			// 
			// label11
			// 
			label11.AutoSize = true;
			label11.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			label11.Location = new System.Drawing.Point(812, 238);
			label11.Name = "label11";
			label11.Size = new System.Drawing.Size(92, 31);
			label11.TabIndex = 3;
			label11.Text = "Weight";
			// 
			// label12
			// 
			label12.AutoSize = true;
			label12.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			label12.Location = new System.Drawing.Point(812, 46);
			label12.Name = "label12";
			label12.Size = new System.Drawing.Size(93, 31);
			label12.TabIndex = 3;
			label12.Text = "Species";
			// 
			// txtPatientID
			// 
			txtPatientID.Enabled = false;
			txtPatientID.Location = new System.Drawing.Point(312, 91);
			txtPatientID.Name = "txtPatientID";
			txtPatientID.Size = new System.Drawing.Size(280, 27);
			txtPatientID.TabIndex = 4;
			// 
			// txtHeight
			// 
			txtHeight.Location = new System.Drawing.Point(312, 283);
			txtHeight.Name = "txtHeight";
			txtHeight.Size = new System.Drawing.Size(280, 27);
			txtHeight.TabIndex = 4;
			// 
			// txtWeight
			// 
			txtWeight.Location = new System.Drawing.Point(812, 283);
			txtWeight.Name = "txtWeight";
			txtWeight.Size = new System.Drawing.Size(280, 27);
			txtWeight.TabIndex = 4;
			// 
			// dgvBird
			// 
			dgvBird.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvBird.Location = new System.Drawing.Point(291, 434);
			dgvBird.Name = "dgvBird";
			dgvBird.RowHeadersWidth = 51;
			dgvBird.RowTemplate.Height = 29;
			dgvBird.Size = new System.Drawing.Size(887, 174);
			dgvBird.TabIndex = 7;
			// 
			// btnUpdate
			// 
			btnUpdate.Location = new System.Drawing.Point(555, 399);
			btnUpdate.Name = "btnUpdate";
			btnUpdate.Size = new System.Drawing.Size(94, 29);
			btnUpdate.TabIndex = 8;
			btnUpdate.Text = "Update";
			btnUpdate.UseVisualStyleBackColor = true;
			btnUpdate.Click += btnUpdate_Click;
			// 
			// btnSave
			// 
			btnSave.Enabled = false;
			btnSave.Location = new System.Drawing.Point(869, 399);
			btnSave.Name = "btnSave";
			btnSave.Size = new System.Drawing.Size(94, 29);
			btnSave.TabIndex = 8;
			btnSave.Text = "Save";
			btnSave.UseVisualStyleBackColor = true;
			btnSave.Click += btnSave_Click;
			// 
			// btnCancel
			// 
			btnCancel.Enabled = false;
			btnCancel.Location = new System.Drawing.Point(1032, 399);
			btnCancel.Name = "btnCancel";
			btnCancel.Size = new System.Drawing.Size(94, 29);
			btnCancel.TabIndex = 8;
			btnCancel.Text = "Cancel";
			btnCancel.UseVisualStyleBackColor = true;
			btnCancel.Click += btnCancel_Click;
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
			// panel1
			// 
			panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
			panel1.Controls.Add(label6);
			panel1.Controls.Add(pictureBox3);
			panel1.Controls.Add(label2);
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
			panel1.TabIndex = 13;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.BackColor = System.Drawing.SystemColors.ActiveCaption;
			label6.Font = new System.Drawing.Font("Arial", 17.9999981F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			label6.ForeColor = System.Drawing.Color.Black;
			label6.Location = new System.Drawing.Point(114, 453);
			label6.Name = "label6";
			label6.Size = new System.Drawing.Size(74, 35);
			label6.TabIndex = 7;
			label6.Text = "Bird";
			// 
			// pictureBox3
			// 
			pictureBox3.Image = (System.Drawing.Image)resources.GetObject("pictureBox3.Image");
			pictureBox3.Location = new System.Drawing.Point(12, 412);
			pictureBox3.Name = "pictureBox3";
			pictureBox3.Size = new System.Drawing.Size(89, 77);
			pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			pictureBox3.TabIndex = 6;
			pictureBox3.TabStop = false;
			pictureBox3.Click += pictureBox3_Click;
			// 
			// btnCreate
			// 
			btnCreate.Location = new System.Drawing.Point(708, 399);
			btnCreate.Name = "btnCreate";
			btnCreate.Size = new System.Drawing.Size(94, 29);
			btnCreate.TabIndex = 14;
			btnCreate.Text = "Create";
			btnCreate.UseVisualStyleBackColor = true;
			btnCreate.Click += btnCreate_Click;
			// 
			// txtAge
			// 
			txtAge.Location = new System.Drawing.Point(812, 183);
			txtAge.Name = "txtAge";
			txtAge.Size = new System.Drawing.Size(280, 27);
			txtAge.TabIndex = 18;
			// 
			// txtBirdName
			// 
			txtBirdName.Location = new System.Drawing.Point(312, 183);
			txtBirdName.Name = "txtBirdName";
			txtBirdName.Size = new System.Drawing.Size(280, 27);
			txtBirdName.TabIndex = 19;
			// 
			// label10
			// 
			label10.AutoSize = true;
			label10.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			label10.Location = new System.Drawing.Point(812, 138);
			label10.Name = "label10";
			label10.Size = new System.Drawing.Size(56, 31);
			label10.TabIndex = 16;
			label10.Text = "Age";
			// 
			// label13
			// 
			label13.AutoSize = true;
			label13.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			label13.Location = new System.Drawing.Point(312, 138);
			label13.Name = "label13";
			label13.Size = new System.Drawing.Size(128, 31);
			label13.TabIndex = 17;
			label13.Text = "Bird Name";
			// 
			// label14
			// 
			label14.AutoSize = true;
			label14.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			label14.Location = new System.Drawing.Point(312, 323);
			label14.Name = "label14";
			label14.Size = new System.Drawing.Size(91, 31);
			label14.TabIndex = 20;
			label14.Text = "Gender";
			// 
			// cbGender
			// 
			cbGender.FormattingEnabled = true;
			cbGender.Location = new System.Drawing.Point(312, 366);
			cbGender.Name = "cbGender";
			cbGender.Size = new System.Drawing.Size(169, 28);
			cbGender.TabIndex = 21;
			// 
			// cbSpecies
			// 
			cbSpecies.FormattingEnabled = true;
			cbSpecies.Location = new System.Drawing.Point(812, 90);
			cbSpecies.Name = "cbSpecies";
			cbSpecies.Size = new System.Drawing.Size(280, 28);
			cbSpecies.TabIndex = 22;
			// 
			// frmUserBird
			// 
			AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			BackColor = System.Drawing.SystemColors.ControlLight;
			ClientSize = new System.Drawing.Size(1190, 620);
			Controls.Add(cbSpecies);
			Controls.Add(cbGender);
			Controls.Add(label14);
			Controls.Add(txtAge);
			Controls.Add(txtBirdName);
			Controls.Add(label10);
			Controls.Add(label13);
			Controls.Add(btnCreate);
			Controls.Add(panel1);
			Controls.Add(pictureBox1);
			Controls.Add(btnCancel);
			Controls.Add(btnSave);
			Controls.Add(btnUpdate);
			Controls.Add(dgvBird);
			Controls.Add(txtWeight);
			Controls.Add(txtHeight);
			Controls.Add(txtPatientID);
			Controls.Add(label11);
			Controls.Add(label12);
			Controls.Add(label8);
			Controls.Add(label3);
			Controls.Add(label1);
			FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			Name = "frmUserBird";
			Text = "frmDoctor";
			Load += frmUserBird_Load;
			((System.ComponentModel.ISupportInitialize)dgvBird).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.TextBox txtPatientID;
		private System.Windows.Forms.TextBox txtHeight;
		private System.Windows.Forms.TextBox txtWeight;
		private System.Windows.Forms.DataGridView dgvBird;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox4;
		private System.Windows.Forms.PictureBox pictureBox5;
		private System.Windows.Forms.PictureBox pictureBox7;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.PictureBox pictureBox6;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.Button btnCreate;
		private System.Windows.Forms.TextBox txtAge;
		private System.Windows.Forms.TextBox txtBirdName;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.ComboBox cbGender;
		private System.Windows.Forms.ComboBox cbSpecies;
	}
}