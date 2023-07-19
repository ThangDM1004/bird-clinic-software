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
					list = context.Accounts.Include(f => f.GenderNavigation).Where(r => r.RoleId == roleId).ToList();
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
			}
			catch (Exception ex)
			{

			}
		}
		public static void CreateAccount(Account account)
		{
			try
			{
				using (var context = new BirdClinicContext())
				{
					context.Accounts.Add(account);
					context.SaveChanges();
				}
			}
			catch (Exception ex) { }
		}
		public static Account Login(string username)
		{
			var account = new Account();
			try
			{
				using (var context = new BirdClinicContext())
				{
					account = context.Accounts.SingleOrDefault(r => r.Username == username);
				}
			}
			catch (Exception e)
			{
				throw new Exception(e.Message);
			}
			return account;
		}
		public static List<Gender> Gender()
		{
			var list = new List<Gender>();
			try
			{
				using (var context = new BirdClinicContext())
				{
					list = context.Genders.ToList();
				}
			}
			catch (Exception e)
			{

			}
			return list;
		}

		public static List<RegistrationSchedule> getSchedules(DateTime date)
		{
			var list = new List<RegistrationSchedule>();
			try
			{
				using (var context = new BirdClinicContext())
				{
					list = context.RegistrationSchedules.Where(t => t.Date == date).ToList();
				}
			}
			catch (Exception e) { }
			return list;
		}
	}
}
