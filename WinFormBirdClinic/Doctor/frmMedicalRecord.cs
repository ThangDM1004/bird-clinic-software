using DataAccess;
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

namespace WinFormBirdClinic.Doctor
{
    public partial class frmMedicalRecord : Form
    {
        string username;
        BindingSource source;
        BookingRepository repo = new BookingRepository();
        IServiceRepository serviceRepository = new ServiceRepository();
        MedicalRecordRepository recordRepository = new MedicalRecordRepository();

        public frmMedicalRecord(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            frmScheduleView frmSchedule = new frmScheduleView(username);
            frmSchedule.StartPosition = FormStartPosition.CenterScreen;
            frmSchedule.ShowDialog();
            this.Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            frmSchedule schedule = new frmSchedule(username);
            schedule.StartPosition = FormStartPosition.CenterScreen;
            schedule.ShowDialog();
            this.Close();
        }

        private void frmMedicalRecord_Load(object sender, EventArgs e)
        {
            LoadMedicalRecordCheckInByDoctor();
            LoadService();
        }

        public void LoadMedicalRecordCheckInByDoctor()
        {
            btnSave.Enabled = false;
            btnCreate.Enabled = false;

            source = new BindingSource();
            source.DataSource = recordRepository.GetMedicalRecords().OrderBy(r => r.RecordId);

            txtRecordId.DataBindings.Clear();
            txtBookingId.DataBindings.Clear();
            txtPatientId.DataBindings.Clear();
            txtFee.DataBindings.Clear();

            txtBookingId.DataBindings.Add("Text", source, "BookingId");
            txtPatientId.DataBindings.Add("Text", source, "PatientId");
            txtRecordId.DataBindings.Add("Text", source, "RecordId");
            txtFee.DataBindings.Add("Text", source, "TotalFee");
            if (repo.getStatusByBookingID(int.Parse(txtBookingId.Text)) == 3)
            {
                btnCreate.Enabled = true;
                btnSave.Enabled = true;
            }

            dgvMedical.DataSource = null;
            dgvMedical.DataSource = source;
        }

        public void LoadService()
        {
            try
            {
                var list = serviceRepository.getAllServiceCus().Where(s => s.ServiceName != "Vip" && s.ServiceName != "Normal").ToList();
                cboService.DataSource = list;
                cboService.DisplayMember = "ServiceName";
                cboService.ValueMember = "ServiceId";
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            var list = MedicalRecordDAO.GetServiceMoresByRecordId(int.Parse(txtRecordId.Text));
            bool a = true;
            foreach (var item in list)
            {
                if (item.ServiceId == serviceRepository.getServicebyID(int.Parse(cboService.SelectedValue.ToString())).ServiceId) a = false;
            }
            if (a)
            {
                ServiceMore serviceMore = new ServiceMore
                {
                    Fee = serviceRepository.getServicebyID(int.Parse(cboService.SelectedValue.ToString())).Fee,
                    RecordId = int.Parse(txtRecordId.Text),
                    ServiceId = serviceRepository.getServicebyID(int.Parse(cboService.SelectedValue.ToString())).ServiceId
                };
                recordRepository.AddServiceMore(serviceMore);
                double totalfee = 0;
                var list1 = MedicalRecordDAO.GetServiceMoresByRecordId(int.Parse(txtRecordId.Text));
                foreach (var item in list1)
                {
                    totalfee += item.Fee;
                }
                MedicalRecord medical = new MedicalRecord
                {
                    BookingId = int.Parse(txtBookingId.Text),
                    PatientId = int.Parse(txtPatientId.Text),
                    RecordId = int.Parse(txtRecordId.Text),
                    TotalFee = totalfee
                };
                MedicalRecordDAO.UpdateMedicalRecord(medical);
                MessageBox.Show("This service add successful.");
                LoadMedicalRecordCheckInByDoctor();
                LoadService();
            }
            else
            {
                MessageBox.Show("This service has already been added.");
            }

        }

        private void btnView_Click(object sender, EventArgs e)
        {
            MedicalRecord medical = new MedicalRecord
            {
                BookingId = int.Parse(txtBookingId.Text),
                PatientId = int.Parse(txtPatientId.Text),
                RecordId = int.Parse(txtRecordId.Text),
                TotalFee = int.Parse(txtFee.Text)
            };
            frmCreateMedical frmCreate = new frmCreateMedical(medical);
            frmCreate.ShowDialog();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadMedicalRecordCheckInByDoctor();   
            LoadService();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn tiếp tục?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                Booking booking = repo.GetBookingbyID(int.Parse(txtBookingId.Text));
                booking.StatusId = 4;
                repo.UpdateBooking(booking);
                MessageBox.Show("Save successful.");
            }
        }
    }
}
