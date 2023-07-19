namespace WinFormBirdClinic.Doctor
{
    partial class frmRegister
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
            btnSave = new System.Windows.Forms.Button();
            btnCancel = new System.Windows.Forms.Button();
            dtpBookingDate = new System.Windows.Forms.DateTimePicker();
            label12 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Location = new System.Drawing.Point(51, 171);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(94, 29);
            btnSave.TabIndex = 28;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new System.Drawing.Point(237, 171);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(94, 29);
            btnCancel.TabIndex = 27;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // dtpBookingDate
            // 
            dtpBookingDate.Location = new System.Drawing.Point(51, 98);
            dtpBookingDate.Name = "dtpBookingDate";
            dtpBookingDate.Size = new System.Drawing.Size(280, 27);
            dtpBookingDate.TabIndex = 26;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label12.Location = new System.Drawing.Point(51, 53);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(161, 31);
            label12.TabIndex = 25;
            label12.Text = "Booking Date";
            // 
            // frmRegister
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(407, 273);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            Controls.Add(dtpBookingDate);
            Controls.Add(label12);
            Name = "frmRegister";
            Text = "frmRegister";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DateTimePicker dtpBookingDate;
        private System.Windows.Forms.Label label12;
    }
}