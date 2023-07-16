using DataAccess;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
	public class AccountRepository : IAccountRepository
	{
		public List<Account> GetAccountsByRole(int roleId) => AccountDAO.GetAccountsByRole(roleId);
		public void UpdateAccount(Account account) => AccountDAO.UpdateAccount(account) ;
		public void CreateAccount(Account account) => AccountDAO.CreateAccount(account);
	}
}
