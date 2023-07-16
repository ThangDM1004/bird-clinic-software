using Models;
using Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormBirdClinic
{
	public partial class frmDoctor : Form
	{
		public frmDoctor()
		{
			InitializeComponent();
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void pictureBox4_Click(object sender, EventArgs e)
		{
			frmDoctor doctor = new frmDoctor();
			doctor.StartPosition = FormStartPosition.CenterScreen;
			doctor.ShowDialog();
			this.Close();
		}

		private void pictureBox5_Click(object sender, EventArgs e)
		{
			frmService service = new frmService();
			service.StartPosition = FormStartPosition.CenterScreen;
			service.ShowDialog();
			this.Close();
		}

		private void pictureBox7_Click(object sender, EventArgs e)
		{
			frmCustomer customer = new frmCustomer();
			customer.StartPosition = FormStartPosition.CenterScreen;
			customer.ShowDialog();
			this.Close();
		}

		private void pictureBox9_Click(object sender, EventArgs e)
		{
			frmBooking frmBookinig = new frmBooking();
			frmBookinig.StartPosition = FormStartPosition.CenterScreen;
			frmBookinig.ShowDialog();
			this.Close();
		}

		private void frmDoctor_Load(object sender, EventArgs e)
		{
			LoadDoctorList(repo.GetAccountsByRole(3));
		}
		IAccountRepository repo = new AccountRepository();
		BindingSource source;
		public void LoadDoctorList(List<Account> list)
		{
			try
			{
				source = new BindingSource();
				source.DataSource = list;

				dtpBirth.DataBindings.Clear();
				txtFullName.DataBindings.Clear();
				txtPassword.DataBindings.Clear();
				txtUserName.DataBindings.Clear();
				txtStatus.DataBindings.Clear();

				dtpBirth.DataBindings.Add("Text", source, "DateOfBirth");
				txtFullName.DataBindings.Add("Text", source, "Name");
				txtPassword.DataBindings.Add("Text", source, "Password");
				txtUserName.DataBindings.Add("Text", source, "Username");
				txtStatus.DataBindings.Add("Text", source, "Status");
				dgvDoctor.DataSource = null;
				dgvDoctor.DataSource = source;

			}
			catch (Exception ex) { }
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			btnSave.Enabled = false;

			DateTime selectDate = dtpBirth.Value;
			string Date = selectDate.ToString("yyyy/MM/dd HH:mm:ss");
			if (txtFullName.Text == "" || txtPassword.Text == "" || txtUserName.Text == "")
			{
				MessageBox.Show("All fields are required!");
			}
			else
			{
				var p = new Account
				{
					Name = txtFullName.Text.Trim(),
					RoleId = 1,
					Status = true,
					Username = txtUserName.Text.Trim(),
					DateOfBirth = DateTime.Parse(Date),
					Password = txtPassword.Text.Trim(),
				};
				repo.UpdateAccount(p);
				LoadDoctorList(repo.GetAccountsByRole(3));
			}

		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			btnCreate.Enabled = true;
			btnSave.Enabled = false;
			btnUpdate.Enabled = true;
			btnCancel.Enabled = false;

			txtUserName.Enabled = false;
			LoadDoctorList(repo.GetAccountsByRole(3));
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			DateTime selectDate = dtpBirth.Value;
			string Date = selectDate.ToString("yyyy/MM/dd HH:mm:ss");

			if (txtFullName.Text == "" || txtPassword.Text == "" || txtUserName.Text == "")
			{
				MessageBox.Show("All fields are required!");
			}
			else
			{
				var p = new Account
				{
					Name = txtFullName.Text.Trim(),
					DateOfBirth = DateTime.Parse(Date),
					Password = txtPassword.Text.Trim(),
					Username = txtUserName.Text.Trim(),
					RoleId = 3,
					Status = true

				};
				repo.CreateAccount(p);
				LoadDoctorList(repo.GetAccountsByRole(3));
			}


		}

		private void btnCreate_Click(object sender, EventArgs e)
		{
			txtFullName.DataBindings.Clear();
			txtPassword.DataBindings.Clear();
			txtUserName.DataBindings.Clear();
			dtpBirth.DataBindings.Clear();
			ClearText();
			btnCreate.Enabled = false;
			btnCancel.Enabled = true;
			btnSave.Enabled = true;
			txtStatus.Enabled = false;

			txtUserName.Enabled = true;
		}
		public void ClearText()
		{
			txtFullName.Text = string.Empty;
			txtPassword.Text = string.Empty;
			txtStatus.Text = string.Empty;
			txtUserName.Text = string.Empty;

		}
	}
}
