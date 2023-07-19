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
	public partial class frmUserBird : Form
	{
		public string Username { get; set; }
		public frmUserBird()
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
		IPatientBirdRepository repo = new PatientBirdRepository();
		BindingSource source;
		private void frmUserBird_Load(object sender, EventArgs e)
		{
			LoadGender();
			LoadSpecies();
			LoadBird(repo.GetListBirdByUser(Username));
		}
		private void LoadGender()
		{
			var gender = repo.Gender();
			cbGender.DataSource = gender;
			cbGender.DisplayMember = "GenderName";
			cbGender.ValueMember = "Gender1";
		}
		private void LoadSpecies()
		{
			var species = repo.getSpecies();
			cbSpecies.DataSource = species;
			cbSpecies.DisplayMember = "Name";
			cbSpecies.ValueMember = "SpeciesId";
		}
		public void LoadBird(List<PatientBird> list)
		{
			try
			{
				source = new BindingSource();
				source.DataSource = list;

				txtPatientID.DataBindings.Clear();
				txtBirdName.DataBindings.Clear();
				txtAge.DataBindings.Clear();
				txtHeight.DataBindings.Clear();
				txtWeight.DataBindings.Clear();
				cbGender.DataBindings.Clear();
				cbSpecies.DataBindings.Clear();

				txtPatientID.DataBindings.Add("Text", source, "PatientId");
				txtBirdName.DataBindings.Add("Text", source, "BirdName");
				txtAge.DataBindings.Add("Text", source, "Age");
				txtHeight.DataBindings.Add("Text", source, "Height");
				txtWeight.DataBindings.Add("Text", source, "Weight");
				cbGender.DataBindings.Add("Text", source, "GenderNavigation.GenderName");
				cbSpecies.DataBindings.Add("Text", source, "Species.Name");

				dgvBird.DataSource = null;
				dgvBird.DataSource = source;
			}
			catch (Exception ex) { }
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{

			if (txtBirdName.Text == "" || txtHeight.Text == "" || txtAge.Text == "" || txtWeight.Text == "")
			{
				MessageBox.Show("All fields are required!");
			}
			else
			{
				var p = repo.getPatientByID(int.Parse(txtPatientID.Text));

				p.Age = int.Parse(txtAge.Text);
					p.BirdName = txtBirdName.Text;
					p.Height = double.Parse(txtHeight.Text);
					p.Gender = int.Parse(cbGender.SelectedValue.ToString());
					p.SpeciesId = int.Parse(cbSpecies.SelectedValue.ToString());
					p.Username = Username;
					p.Weight = double.Parse(txtWeight.Text);
					p.Status = true;
				
				repo.UpdateBird(p);
				LoadBird(repo.GetListBirdByUser(Username));
			}
		}

		private void btnCreate_Click(object sender, EventArgs e)
		{
			txtPatientID.DataBindings.Clear();
			txtBirdName.DataBindings.Clear();
			txtHeight.DataBindings.Clear();
			txtAge.DataBindings.Clear();
			cbSpecies.DataBindings.Clear();
			cbGender.DataBindings.Clear();
			txtWeight.DataBindings.Clear();
			ClearText();
			btnCreate.Enabled = false;
			btnCancel.Enabled = true;
			btnSave.Enabled = true;
		}

		public void ClearText()
		{
			txtPatientID.Text = string.Empty;
			txtBirdName.Text = string.Empty;
			txtHeight.Text = string.Empty;
			txtAge.Text = string.Empty;
			txtWeight.Text = string.Empty;
		}
		private void btnSave_Click(object sender, EventArgs e)
		{


			if (txtBirdName.Text == "" || txtHeight.Text == "" || txtAge.Text == "" || txtWeight.Text == "")
			{
				MessageBox.Show("All fields are required!");
			}
			else
			{
				var p = new PatientBird
				{
					Age = int.Parse(txtAge.Text),
					BirdName = txtBirdName.Text,
					Height = double.Parse(txtHeight.Text),
					Gender = int.Parse(cbGender.SelectedValue.ToString()),
					SpeciesId = int.Parse(cbSpecies.SelectedValue.ToString()),
					Status = true,
					Username = Username,
					Weight = double.Parse(txtWeight.Text),
				};
				repo.Create(p);
				
				LoadBird(repo.GetListBirdByUser(Username));
			}

		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			btnCreate.Enabled = true;
			btnSave.Enabled = false;
			btnUpdate.Enabled = true;
			btnCancel.Enabled = false;
			
			LoadBird(repo.GetListBirdByUser(Username));
		}
	}
}
