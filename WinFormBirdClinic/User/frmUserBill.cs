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
	public partial class frmUserBill : Form
	{
		public string Username { get; set; }
		public frmUserBill()
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
		IMedicalRepository repo = new MedicalRepository();
		BindingSource source;
		IServiceRepository service = new ServiceRepository();
		private void frmUserBill_Load(object sender, EventArgs e)
		{
			LoadBooking(repo.getMedicalbyUser(Username));
		}
		public void LoadBooking(List<MedicalRecord> records)
		{
			try
			{
				source = new BindingSource();
				source.DataSource = records;

				dgvMedical.DataSource = null;
				dgvMedical.DataSource = source;
				dgvMedical.Columns[3].Visible = false;
				dgvMedical.Columns[4].Visible = false;
			}
			catch (Exception ex) { }
		}

		private void dgvMedical_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			DataGridViewCell selectedCell = dgvMedical.Rows[e.RowIndex].Cells[0];
			string cellValue = selectedCell.Value.ToString();
			int id = int.Parse(cellValue);
			LoadSerMore(repo.serviceMores(id));
		}
		public void LoadSerMore(List<ServiceMore> list)
		{
			try
			{
				source = new BindingSource();
				source.DataSource = list;

				dgvServiceMore.DataSource = null;
				dgvServiceMore.DataSource = source;
				dgvServiceMore.Columns[1].Visible = false;
				dgvServiceMore.Columns[3].Visible = false;
				dgvServiceMore.Columns[4].Visible = false;
				DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
				column.HeaderText = "ServiceName";
				dgvServiceMore.Columns.Add(column);
				int columnIndex = 5; // Chỉ mục cột

				for (int rowIndex = 0; rowIndex < list.Count; rowIndex++)
				{
					dgvServiceMore.Rows[rowIndex].Cells[columnIndex].Value = service.getServicebyID(list[rowIndex].ServiceId).ServiceName;
				}
			}
			catch (Exception ex) { }
		}
	}
}
