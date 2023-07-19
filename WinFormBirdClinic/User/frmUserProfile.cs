using Models;
using Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WinFormBirdClinic.User
{
	public partial class frmUserProfile : Form
	{
		public string Username { get; set; }
		public frmUserProfile()
		{
			InitializeComponent();
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void pictureBox4_Click(object sender, EventArgs e)
		{
			frmUserBooking frmBooking = new frmUserBooking
			{
				Username = Username,
			};
			frmBooking.StartPosition = FormStartPosition.CenterScreen;
			frmBooking.ShowDialog();
			this.Close();
		}

		private void pictureBox5_Click(object sender, EventArgs e)
		{
			frmUserService frmUserService = new frmUserService
			{
				Username = Username,
			};
			frmUserService.ShowDialog();
			frmUserService.StartPosition = FormStartPosition.CenterScreen;
			this.Close();
		}

		private void pictureBox7_Click(object sender, EventArgs e)
		{
			frmUserProfile frmUserProfile = new frmUserProfile
			{
				Username = Username,
			};
			frmUserProfile.StartPosition = FormStartPosition.CenterScreen;
			frmUserProfile.ShowDialog();
			this.Close();
		}

		private void pictureBox6_Click(object sender, EventArgs e)
		{
			frmUserBill frmUserBill = new frmUserBill
			{
				Username = Username,
			};
			frmUserBill.StartPosition = FormStartPosition.CenterScreen;
			frmUserBill.ShowDialog();
			this.Close();
		}

		private void pictureBox3_Click(object sender, EventArgs e)
		{
			frmUserBird frmUserBird = new frmUserBird
			{
				Username = Username,
			};
			frmUserBird.StartPosition = FormStartPosition.CenterScreen;
			frmUserBird.ShowDialog();
			this.Close();
		}
		IAccountRepository repo = new AccountRepository();
		BindingSource source;
		private void frmUserProfile_Load(object sender, EventArgs e)
		{
			LoadGender();
			LoadInfo(repo.Login(Username));
		}
		public void LoadInfo(Account account)
		{
			try
			{
				source = new BindingSource();
				source.DataSource = account;

				dtpBirth.DataBindings.Clear();
				txtFullName.DataBindings.Clear();
				txtPassword.DataBindings.Clear();
				txtUserName.DataBindings.Clear();
				txtPhone.DataBindings.Clear();
				cbGender.DataBindings.Clear();

				dtpBirth.DataBindings.Add("Text", source, "DateOfBirth");
				txtFullName.DataBindings.Add("Text", source, "Name");
				txtPassword.DataBindings.Add("Text", source, "Password");
				txtUserName.DataBindings.Add("Text", source, "Username");
				txtPhone.DataBindings.Add("Text", source, "Phone");
				cbGender.DataBindings.Add("Text", source, "GenderNavigation.GenderName");


			}
			catch (Exception ex) { }
		}
		private void LoadGender()
		{
			var gender = repo.Gender();
			cbGender.DataSource = gender;
			cbGender.DisplayMember = "GenderName";
			cbGender.ValueMember = "Gender1";
		}

		private void btnUpdate_Click(object sender, EventArgs e)
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
					RoleId = 1,
					Status = true,
					Username = txtUserName.Text.Trim(),
					DateOfBirth = DateTime.Parse(Date),
					Password = txtPassword.Text.Trim(),
					Gender = int.Parse(cbGender.SelectedValue.ToString()),
					Phone = txtPhone.Text,
				};
				repo.UpdateAccount(p);
				LoadInfo(repo.Login(Username));
			}
		}
	}
}
