using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Repositories;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WinFormBirdClinic.Doctor
{
    public partial class frmSchedule : Form
    {
        BindingSource source;
        RegistrationScheduleRepository repo = new RegistrationScheduleRepository();
        string username;

        public frmSchedule(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void LoadBooking(List<RegistrationSchedule> list)
        {
            try
            {
                source = new BindingSource();
                source.DataSource = list;

                txtUsename.DataBindings.Clear();
                dtpBookingDate.DataBindings.Clear();

                txtUsename.DataBindings.Add("Text", source, "Username");
                dtpBookingDate.DataBindings.Add("Text", source, "Date");

                dgvSchedule.DataSource = null;
                dgvSchedule.DataSource = source;
            }
            catch (Exception ex) { }
        }

        private void frmSchedule_Load(object sender, EventArgs e)
        {
            txtUsename.Enabled = false;
            LoadBooking(repo.getScheduleByUsername(username));
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            frmRegister frmRegister = new frmRegister(username);
            frmRegister.StartPosition = FormStartPosition.CenterScreen;
            frmRegister.ShowDialog();
            LoadBooking(repo.getScheduleByUsername(username));
        }

        //private void btnUpdate_Click(object sender, EventArgs e)
        //{
        //    RegistrationSchedule schedule = new RegistrationSchedule();
        //    schedule.Username = username;
        //    schedule.Date = DateTime.Parse(dtpBookingDate.Text);
        //    var check = repo.checkExist(schedule);
        //    if (check == false)
        //    {
        //        repo.updateScheduleByUsername(schedule);
        //        MessageBox.Show("Update successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        LoadBooking(repo.getScheduleByUsername(username));
        //    }
        //    else
        //    {
        //        MessageBox.Show("You have already registered for this date!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        LoadBooking(repo.getScheduleByUsername(username));
        //    }
        //}

        private void btnDelete_Click(object sender, EventArgs e)
        {
            RegistrationSchedule schedule = new RegistrationSchedule();
            schedule.Username = username;
            schedule.Date = DateTime.Parse(dtpBookingDate.Text);
            DialogResult result = MessageBox.Show("Are you sure you want to delete?!", "Success", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                if (repo.checkRegister(username, DateTime.Parse(dtpBookingDate.Text)))
                {
                    MessageBox.Show("Your schedule has been booked by another user and cannot be deleted!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    repo.deleteScheduleByUsername(schedule);
                }
                LoadBooking(repo.getScheduleByUsername(username));
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            frmScheduleView frmSchedule = new frmScheduleView(username);
            frmSchedule.StartPosition = FormStartPosition.CenterScreen;
            frmSchedule.ShowDialog();
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            frmMedicalRecord medicalRecord = new frmMedicalRecord(username);
            medicalRecord.StartPosition = FormStartPosition.CenterScreen;
            medicalRecord.ShowDialog();
            this.Close();
        }
    }
}
