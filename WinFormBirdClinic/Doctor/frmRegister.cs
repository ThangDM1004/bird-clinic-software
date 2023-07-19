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
using Models;

namespace WinFormBirdClinic.Doctor
{
    public partial class frmRegister : Form
    {
        RegistrationScheduleRepository repo = new RegistrationScheduleRepository();
        string username;
        public frmRegister(string username)
        {
            InitializeComponent();
            this.username = username;
            dtpBookingDate.MinDate = DateTime.Today.AddDays(1);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            RegistrationSchedule schedule = new RegistrationSchedule();
            schedule.Username = username;
            schedule.Date = DateTime.Parse(dtpBookingDate.Text);
            DialogResult result = MessageBox.Show("Are you sure you want to register?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                var check = repo.checkExist(schedule);
                if(check == false)
                {
                    repo.addScheduleByUsername(schedule);
                    DialogResult result2 = MessageBox.Show("Registration successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (result2 == DialogResult.OK) { this.Close(); }
                }
                else
                {
                    DialogResult result2 = MessageBox.Show("You have already registered for this date!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (result2 == DialogResult.OK) { this.Close(); }
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
