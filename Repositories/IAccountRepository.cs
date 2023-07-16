using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
	public interface IAccountRepository
	{
		List<Account> GetAccountsByRole(int roleId);
		void UpdateAccount(Account account);
		void CreateAccount(Account account);
	}
}
