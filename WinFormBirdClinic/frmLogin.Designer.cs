namespace WinFormBirdClinic
{
	partial class frmLogin
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			lbEmail = new System.Windows.Forms.Label();
			lbPassword = new System.Windows.Forms.Label();
			txtUsername = new System.Windows.Forms.TextBox();
			txtPassword = new System.Windows.Forms.TextBox();
			btnLogin = new System.Windows.Forms.Button();
			btnExit = new System.Windows.Forms.Button();
			SuspendLayout();
			// 
			// lbEmail
			// 
			lbEmail.AutoSize = true;
			lbEmail.Location = new System.Drawing.Point(211, 129);
			lbEmail.Name = "lbEmail";
			lbEmail.Size = new System.Drawing.Size(75, 20);
			lbEmail.TabIndex = 0;
			lbEmail.Text = "Username";
			// 
			// lbPassword
			// 
			lbPassword.AutoSize = true;
			lbPassword.Location = new System.Drawing.Point(211, 202);
			lbPassword.Name = "lbPassword";
			lbPassword.Size = new System.Drawing.Size(70, 20);
			lbPassword.TabIndex = 1;
			lbPassword.Text = "Password";
			// 
			// txtUsername
			// 
			txtUsername.Location = new System.Drawing.Point(389, 126);
			txtUsername.Name = "txtUsername";
			txtUsername.Size = new System.Drawing.Size(250, 27);
			txtUsername.TabIndex = 2;
			// 
			// txtPassword
			// 
			txtPassword.Location = new System.Drawing.Point(389, 199);
			txtPassword.Name = "txtPassword";
			txtPassword.Size = new System.Drawing.Size(250, 27);
			txtPassword.TabIndex = 3;
			txtPassword.UseSystemPasswordChar = true;
			// 
			// btnLogin
			// 
			btnLogin.Location = new System.Drawing.Point(300, 284);
			btnLogin.Name = "btnLogin";
			btnLogin.Size = new System.Drawing.Size(94, 29);
			btnLogin.TabIndex = 4;
			btnLogin.Text = "Login";
			btnLogin.UseVisualStyleBackColor = true;
			btnLogin.Click += btnLogin_Click;
			// 
			// btnExit
			// 
			btnExit.Location = new System.Drawing.Point(467, 284);
			btnExit.Name = "btnExit";
			btnExit.Size = new System.Drawing.Size(94, 29);
			btnExit.TabIndex = 5;
			btnExit.Text = "Exit";
			btnExit.UseVisualStyleBackColor = true;
			// 
			// frmLogin
			// 
			AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			ClientSize = new System.Drawing.Size(800, 450);
			Controls.Add(btnExit);
			Controls.Add(btnLogin);
			Controls.Add(txtPassword);
			Controls.Add(txtUsername);
			Controls.Add(lbPassword);
			Controls.Add(lbEmail);
			Name = "frmLogin";
			Text = "Login Form";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private System.Windows.Forms.Label lbEmail;
		private System.Windows.Forms.Label lbPassword;
		private System.Windows.Forms.TextBox txtUsername;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.Button btnLogin;
		private System.Windows.Forms.Button btnExit;
	}
}