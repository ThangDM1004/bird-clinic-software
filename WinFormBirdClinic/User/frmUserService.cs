using Microsoft.VisualBasic.Devices;
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

namespace WinFormBirdClinic.User
{
	public partial class frmUserService : Form
	{
		public string Username { get; set; }
		public frmUserService()
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
			frmUserBill frmUserBill = new frmUserBill{ Username = Username };
			frmUserBill.StartPosition = FormStartPosition.CenterScreen;
			frmUserBill.ShowDialog();
			this.Close();
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			frmUserBird frmUserBird = new frmUserBird{ Username = Username };
			frmUserBird.StartPosition = FormStartPosition.CenterScreen;
			frmUserBird.ShowDialog();
			this.Close();
		}
		IServiceRepository ser_repo = new ServiceRepository();
		BindingSource source;
		private void frmUserService_Load(object sender, EventArgs e)
		{
			LoadService(ser_repo.getAllServiceCus());
		}
		public void LoadService(List<Service> services)
		{
			try
			{
				source = new BindingSource();
				source.DataSource = services;

				dgvService.DataSource = null;
				dgvService.DataSource = source;
			}
			catch (Exception ex) { }
		}

	}
}
