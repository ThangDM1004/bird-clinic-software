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

namespace WinFormBirdClinic.Doctor
{
    public partial class frmScheduleView : Form
    {
        string username;
        BindingSource source;
        BookingRepository repo = new BookingRepository();
        public frmScheduleView(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmScheduleView_Load(object sender, EventArgs e)
        {
            LoadBookingTodayByDoctor();
        }

        public void LoadBookingTodayByDoctor()
        {
            source = new BindingSource();
            source.DataSource = repo.getBookingByDoctor(username).Where(b => b.BookingDate == DateTime.Today && b.StatusId == 2);

            dgvSchedule.DataSource = null;
            dgvSchedule.DataSource = source;
        }
        public void LoadBookingUpComingByDoctor()
        {
            source = new BindingSource();
            source.DataSource = repo.getBookingByDoctor(username).Where(b => b.BookingDate.Date > DateTime.Today.Date && b.StatusId == 2);

            dgvSchedule.DataSource = null;
            dgvSchedule.DataSource = source;
        }

        private void btnToday_Click(object sender, EventArgs e)
        {
            LoadBookingTodayByDoctor();
        }

        private void btnUpcoming_Click(object sender, EventArgs e)
        {
            LoadBookingUpComingByDoctor();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            frmSchedule schedule = new frmSchedule(username);
            schedule.StartPosition = FormStartPosition.CenterScreen;
            schedule.ShowDialog();
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
