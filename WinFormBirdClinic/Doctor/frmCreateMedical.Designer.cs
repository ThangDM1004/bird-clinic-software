namespace WinFormBirdClinic.Doctor
{
    partial class frmCreateMedical
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
            dgvServiceMore = new System.Windows.Forms.DataGridView();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            txtFee = new System.Windows.Forms.TextBox();
            btnDelete = new System.Windows.Forms.Button();
            txtServiceId = new System.Windows.Forms.TextBox();
            txtRecordId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvServiceMore).BeginInit();
            SuspendLayout();
            // 
            // dgvServiceMore
            // 
            dgvServiceMore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvServiceMore.Location = new System.Drawing.Point(457, 12);
            dgvServiceMore.Name = "dgvServiceMore";
            dgvServiceMore.RowHeadersWidth = 51;
            dgvServiceMore.RowTemplate.Height = 29;
            dgvServiceMore.Size = new System.Drawing.Size(439, 268);
            dgvServiceMore.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(12, 23);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(73, 20);
            label1.TabIndex = 2;
            label1.Text = "Record Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(12, 86);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(73, 20);
            label2.TabIndex = 3;
            label2.Text = "Service Id";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(12, 142);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(32, 20);
            label3.TabIndex = 4;
            label3.Text = "Fee";
            // 
            // txtFee
            // 
            txtFee.Location = new System.Drawing.Point(127, 139);
            txtFee.Name = "txtFee";
            txtFee.Size = new System.Drawing.Size(206, 27);
            txtFee.TabIndex = 8;
            // 
            // btnDelete
            // 
            btnDelete.Location = new System.Drawing.Point(239, 212);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(94, 29);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // txtServiceId
            // 
            txtServiceId.Location = new System.Drawing.Point(127, 83);
            txtServiceId.Name = "txtServiceId";
            txtServiceId.Size = new System.Drawing.Size(206, 27);
            txtServiceId.TabIndex = 10;
            // 
            // txtRecordId
            // 
            txtRecordId.Location = new System.Drawing.Point(127, 20);
            txtRecordId.Name = "txtRecordId";
            txtRecordId.Size = new System.Drawing.Size(206, 27);
            txtRecordId.TabIndex = 11;
            // 
            // frmCreateMedical
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(908, 299);
            Controls.Add(txtRecordId);
            Controls.Add(txtServiceId);
            Controls.Add(btnDelete);
            Controls.Add(txtFee);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvServiceMore);
            Name = "frmCreateMedical";
            Text = "frmCreateMedical";
            Load += frmCreateMedical_Load;
            ((System.ComponentModel.ISupportInitialize)dgvServiceMore).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMedicalRecord;
        private System.Windows.Forms.DataGridView dgvServiceMore;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txtFee;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox txtServiceId;
        private System.Windows.Forms.TextBox txtRecordId;
    }
}