using DataAccess;
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

namespace WinFormBirdClinic.Doctor
{
    public partial class frmCreateMedical : Form
    {
        MedicalRecord record;
        BindingSource source;
        public frmCreateMedical(MedicalRecord record)
        {
            InitializeComponent();
            this.record = record;
        }

        private void frmCreateMedical_Load(object sender, EventArgs e)
        {
            LoadServiceMore();
        }
        public void LoadServiceMore()
        {
            btnDelete.Enabled = false;
            source = new BindingSource();
            source.DataSource = MedicalRecordDAO.GetServiceMoresByRecordId(record.RecordId);

            txtFee.DataBindings.Clear();
            txtRecordId.DataBindings.Clear();
            txtServiceId.DataBindings.Clear();

            txtFee.DataBindings.Add("Text", source, "Fee");
            txtRecordId.DataBindings.Add("Text", source, "RecordId");
            txtServiceId.DataBindings.Add("Text", source, "ServiceId");

            if (BookingDAO.getStatusByBookingID(MedicalRecordDAO.GetMedicalRecordById(record.RecordId).BookingId) == 3)
            {
                btnDelete.Enabled = true;
            }

            dgvServiceMore.DataSource = null;
            dgvServiceMore.DataSource = source;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            ServiceMore service = new ServiceMore
            {
                RecordId = int.Parse(txtRecordId.Text),
                Fee = double.Parse(txtFee.Text),
                ServiceId = int.Parse(txtServiceId.Text)
            };
            MedicalRecordDAO.DeleteServiceMore(service);
            double totalfee = 0;
            var list1 = MedicalRecordDAO.GetServiceMoresByRecordId(int.Parse(txtRecordId.Text));
            foreach (var item in list1)
            {
                totalfee += item.Fee;
            }
            record.TotalFee = totalfee;
            MedicalRecordDAO.UpdateMedicalRecord(record);
            LoadServiceMore();
        }
    }
}
