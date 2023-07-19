using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormBirdClinic.User
{
	public partial class frmUserPage : Form
	{
		public string UserName {  get; set; }
		public frmUserPage()
		{
			InitializeComponent();
		}

		private void pictureBox3_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void pictureBox4_Click(object sender, EventArgs e)
		{
			frmUserBooking frmBooking = new frmUserBooking
			{
				Username = UserName,
			};
			frmBooking.StartPosition = FormStartPosition.CenterScreen;
			frmBooking.ShowDialog();
			this.Close();
		}

		private void pictureBox5_Click(object sender, EventArgs e)
		{
			frmUserService frmUserService = new frmUserService
			{
				Username = UserName,
			};
			frmUserService.ShowDialog();
			frmUserService.StartPosition = FormStartPosition.CenterScreen;
			this.Close();
		}

		private void pictureBox7_Click(object sender, EventArgs e)
		{
			frmUserProfile frmUserProfile = new frmUserProfile
			{
				Username = UserName,
			};
			frmUserProfile.StartPosition = FormStartPosition.CenterScreen;
			frmUserProfile.ShowDialog();
			this.Close();
		}

		private void pictureBox6_Click(object sender, EventArgs e)
		{
			frmUserBill frmUserBill = new frmUserBill{ Username = UserName };
			frmUserBill.StartPosition = FormStartPosition.CenterScreen;
			frmUserBill.ShowDialog();
			this.Close();
		}

		private void pictureBox8_Click(object sender, EventArgs e)
		{
			frmUserBird frmUserBird = new frmUserBird{ Username = UserName };
			frmUserBird.StartPosition = FormStartPosition.CenterScreen;
			frmUserBird.ShowDialog();
			this.Close();
		}

		private void frmUserPage_Load(object sender, EventArgs e)
		{

		}
	}
}
