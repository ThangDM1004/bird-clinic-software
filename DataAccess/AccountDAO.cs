using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
	public class AccountDAO
	{
		public static List<Account> GetAccountsByRole(int roleId)
		{
			var list = new List<Account>();
			try
			{
				using (var context = new BirdClinicContext())
				{
					list = context.Accounts.Where(r => r.RoleId == roleId).ToList();
				}
			}
			catch (Exception ex)
			{

			}
			return list;
		}
		public static void UpdateAccount(Account account)
		{
			try
			{
				using (var context = new BirdClinicContext())
				{
					context.Entry<Account>(account).State = EntityState.Modified;
					context.SaveChanges();
				}
			}catch (Exception ex)
			{

			}
		}
		public static void CreateAccount(Account account)
		{
			try
			{
				using(var context = new BirdClinicContext())
				{
					context.Accounts.Add(account);
					context.SaveChanges();
				}
			}catch(Exception ex) { }
		}
	}
}
