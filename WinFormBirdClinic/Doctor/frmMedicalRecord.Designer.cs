namespace WinFormBirdClinic.Doctor
{
    partial class frmMedicalRecord
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMedicalRecord));
            label1 = new System.Windows.Forms.Label();
            dgvMedical = new System.Windows.Forms.DataGridView();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            panel1 = new System.Windows.Forms.Panel();
            label2 = new System.Windows.Forms.Label();
            pictureBox3 = new System.Windows.Forms.PictureBox();
            label4 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            pictureBox5 = new System.Windows.Forms.PictureBox();
            pictureBox4 = new System.Windows.Forms.PictureBox();
            btnCreate = new System.Windows.Forms.Button();
            txtBookingId = new System.Windows.Forms.TextBox();
            txtPatientId = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            cboService = new System.Windows.Forms.ComboBox();
            label6 = new System.Windows.Forms.Label();
            btnView = new System.Windows.Forms.Button();
            label7 = new System.Windows.Forms.Label();
            txtRecordId = new System.Windows.Forms.TextBox();
            label8 = new System.Windows.Forms.Label();
            txtFee = new System.Windows.Forms.TextBox();
            btnLoad = new System.Windows.Forms.Button();
            btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dgvMedical).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 19.8000011F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(541, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(266, 46);
            label1.TabIndex = 2;
            label1.Text = "Medical Record";
            // 
            // dgvMedical
            // 
            dgvMedical.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMedical.Location = new System.Drawing.Point(267, 345);
            dgvMedical.Name = "dgvMedical";
            dgvMedical.RowHeadersWidth = 51;
            dgvMedical.RowTemplate.Height = 29;
            dgvMedical.Size = new System.Drawing.Size(922, 253);
            dgvMedical.TabIndex = 7;
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
            // panel1
            // 
            panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox5);
            panel1.Controls.Add(pictureBox4);
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(261, 622);
            panel1.TabIndex = 22;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            label2.Font = new System.Drawing.Font("HP Simplified", 11.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.ForeColor = System.Drawing.Color.Black;
            label2.Location = new System.Drawing.Point(114, 249);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(140, 24);
            label2.TabIndex = 4;
            label2.Text = "Medical Record";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (System.Drawing.Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new System.Drawing.Point(12, 210);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new System.Drawing.Size(89, 77);
            pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            label4.Font = new System.Drawing.Font("HP Simplified", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label4.ForeColor = System.Drawing.Color.Black;
            label4.Location = new System.Drawing.Point(114, 553);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(99, 32);
            label4.TabIndex = 3;
            label4.Text = "Logout";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = System.Drawing.SystemColors.ActiveCaption;
            label9.Font = new System.Drawing.Font("HP Simplified", 17.9999981F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label9.ForeColor = System.Drawing.Color.Black;
            label9.Location = new System.Drawing.Point(114, 53);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(123, 36);
            label9.TabIndex = 3;
            label9.Text = "Register";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            label5.Font = new System.Drawing.Font("HP Simplified", 19.7999973F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label5.ForeColor = System.Drawing.Color.Black;
            label5.Location = new System.Drawing.Point(114, 151);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(145, 38);
            label5.TabIndex = 2;
            label5.Text = "Schedule";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (System.Drawing.Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new System.Drawing.Point(55, 538);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(46, 47);
            pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
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
            // btnCreate
            // 
            btnCreate.Location = new System.Drawing.Point(629, 206);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new System.Drawing.Size(94, 29);
            btnCreate.TabIndex = 25;
            btnCreate.Text = "Add";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // txtBookingId
            // 
            txtBookingId.Location = new System.Drawing.Point(379, 162);
            txtBookingId.Name = "txtBookingId";
            txtBookingId.Size = new System.Drawing.Size(244, 27);
            txtBookingId.TabIndex = 26;
            // 
            // txtPatientId
            // 
            txtPatientId.Location = new System.Drawing.Point(911, 163);
            txtPatientId.Name = "txtPatientId";
            txtPatientId.Size = new System.Drawing.Size(227, 27);
            txtPatientId.TabIndex = 27;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(300, 169);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(81, 20);
            label3.TabIndex = 30;
            label3.Text = "Booking id";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new System.Drawing.Point(812, 169);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(71, 20);
            label10.TabIndex = 34;
            label10.Text = "Patient Id";
            // 
            // cboService
            // 
            cboService.FormattingEnabled = true;
            cboService.Location = new System.Drawing.Point(379, 207);
            cboService.Name = "cboService";
            cboService.Size = new System.Drawing.Size(244, 28);
            cboService.TabIndex = 35;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(300, 215);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(56, 20);
            label6.TabIndex = 36;
            label6.Text = "Service";
            // 
            // btnView
            // 
            btnView.Location = new System.Drawing.Point(1044, 211);
            btnView.Name = "btnView";
            btnView.Size = new System.Drawing.Size(94, 29);
            btnView.TabIndex = 37;
            btnView.Text = "View Detail";
            btnView.UseVisualStyleBackColor = true;
            btnView.Click += btnView_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(300, 119);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(73, 20);
            label7.TabIndex = 39;
            label7.Text = "Record id";
            // 
            // txtRecordId
            // 
            txtRecordId.Location = new System.Drawing.Point(379, 112);
            txtRecordId.Name = "txtRecordId";
            txtRecordId.Size = new System.Drawing.Size(244, 27);
            txtRecordId.TabIndex = 38;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(812, 119);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(67, 20);
            label8.TabIndex = 41;
            label8.Text = "Total fee";
            // 
            // txtFee
            // 
            txtFee.Location = new System.Drawing.Point(911, 112);
            txtFee.Name = "txtFee";
            txtFee.Size = new System.Drawing.Size(227, 27);
            txtFee.TabIndex = 40;
            // 
            // btnLoad
            // 
            btnLoad.Location = new System.Drawing.Point(529, 295);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new System.Drawing.Size(94, 29);
            btnLoad.TabIndex = 42;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new System.Drawing.Point(1044, 295);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(94, 29);
            btnSave.TabIndex = 43;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // frmMedicalRecord
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.ControlLight;
            ClientSize = new System.Drawing.Size(1190, 620);
            Controls.Add(btnSave);
            Controls.Add(btnLoad);
            Controls.Add(label8);
            Controls.Add(txtFee);
            Controls.Add(label7);
            Controls.Add(txtRecordId);
            Controls.Add(btnView);
            Controls.Add(label6);
            Controls.Add(cboService);
            Controls.Add(label10);
            Controls.Add(label3);
            Controls.Add(txtPatientId);
            Controls.Add(txtBookingId);
            Controls.Add(btnCreate);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(dgvMedical);
            Controls.Add(label1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "frmMedicalRecord";
            Text = "frmDoctor";
            Load += frmMedicalRecord_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMedical).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvMedical;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox txtBookingId;
        private System.Windows.Forms.TextBox txtPatientId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cboService;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtRecordId;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtFee;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnSave;
    }
}