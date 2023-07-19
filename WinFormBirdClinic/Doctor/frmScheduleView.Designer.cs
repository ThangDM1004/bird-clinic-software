namespace WinFormBirdClinic.Doctor
{
    partial class frmScheduleView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmScheduleView));
            label1 = new System.Windows.Forms.Label();
            dgvSchedule = new System.Windows.Forms.DataGridView();
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
            btnUpcoming = new System.Windows.Forms.Button();
            btnToday = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dgvSchedule).BeginInit();
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
            label1.Size = new System.Drawing.Size(163, 46);
            label1.TabIndex = 2;
            label1.Text = "Schedule";
            // 
            // dgvSchedule
            // 
            dgvSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSchedule.Location = new System.Drawing.Point(267, 249);
            dgvSchedule.Name = "dgvSchedule";
            dgvSchedule.RowHeadersWidth = 51;
            dgvSchedule.RowTemplate.Height = 29;
            dgvSchedule.Size = new System.Drawing.Size(911, 349);
            dgvSchedule.TabIndex = 7;
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
            pictureBox3.Click += pictureBox3_Click;
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
            // btnUpcoming
            // 
            btnUpcoming.Location = new System.Drawing.Point(299, 119);
            btnUpcoming.Name = "btnUpcoming";
            btnUpcoming.Size = new System.Drawing.Size(94, 29);
            btnUpcoming.TabIndex = 23;
            btnUpcoming.Text = "Upcoming";
            btnUpcoming.UseVisualStyleBackColor = true;
            btnUpcoming.Click += btnUpcoming_Click;
            // 
            // btnToday
            // 
            btnToday.Location = new System.Drawing.Point(299, 84);
            btnToday.Name = "btnToday";
            btnToday.Size = new System.Drawing.Size(94, 29);
            btnToday.TabIndex = 25;
            btnToday.Text = "Today";
            btnToday.UseVisualStyleBackColor = true;
            btnToday.Click += btnToday_Click;
            // 
            // frmScheduleView
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.ControlLight;
            ClientSize = new System.Drawing.Size(1190, 620);
            Controls.Add(btnToday);
            Controls.Add(btnUpcoming);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(dgvSchedule);
            Controls.Add(label1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "frmScheduleView";
            Text = "frmDoctor";
            Load += frmScheduleView_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSchedule).EndInit();
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
        private System.Windows.Forms.DataGridView dgvSchedule;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button btnUpcoming;
        private System.Windows.Forms.Button btnToday;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}