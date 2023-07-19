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
using WinFormBirdClinic.Doctor;
using WinFormBirdClinic.User;

namespace WinFormBirdClinic
{
	public partial class frmLogin : Form
	{
		IAccountRepository repo = new AccountRepository();
		public frmLogin()
		{
			InitializeComponent();
		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			var account = repo.Login(txtUsername.Text);
			if (account != null)
			{
				if (account.Password.Trim() == txtPassword.Text)
				{
					switch (account.RoleId)
					{
						case 1:
							frmUserPage user = new frmUserPage
							{
								UserName = txtUsername.Text,
							};
							user.ShowDialog();
							break;
						case 2:
							frmHome staff = new frmHome();
							staff.ShowDialog();
							break;
						case 3: 
							frmSchedule schedule = new frmSchedule(account.Username);
                            schedule.StartPosition = FormStartPosition.CenterScreen;
                            schedule.ShowDialog();
							break;
						default:
							break;

                    }
				}
			}
			else
			{
				MessageBox.Show("Username or Password incorrect !!!","Login",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}

		}
	}
}
