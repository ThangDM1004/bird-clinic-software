using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormBirdClinic
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            frmDoctor doctor = new frmDoctor();
            doctor.StartPosition = FormStartPosition.CenterScreen;
            doctor.ShowDialog();
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            frmService service = new frmService();
            service.StartPosition = FormStartPosition.CenterScreen;
            service.ShowDialog();
            this.Close();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            frmCustomer customer = new frmCustomer();
            customer.ShowDialog();
            this.Close();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            frmBooking frmBookinig = new frmBooking();
            frmBookinig.StartPosition = FormStartPosition.CenterScreen;
            frmBookinig.ShowDialog();
            this.Close();
        }
    }
}
