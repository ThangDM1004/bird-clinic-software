using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
	public class ServiceDAO
	{
		public static List<Service> getAllService()
		{
			var list = new List<Service>();
			try
			{
				using (var context = new BirdClinicContext())
				{
					list = context.Services.ToList();
				}
			}
			catch (Exception ex)
			{

			}
			return list;
		}
		public static void UpdateService(Service service)
		{
			try
			{
				using (var context = new BirdClinicContext())
				{
					context.Entry<Service>(service).State = EntityState.Modified;
					context.SaveChanges();
				}
			}
			catch (Exception ex)
			{

			}
		}
		public static void CreateService(Service service)
		{
			try
			{
				using (var context = new BirdClinicContext())
				{
					context.Services.Add(service);
					context.SaveChanges();
				}
			}
			catch (Exception e)
			{
				throw new Exception(e.Message);
			}
		}
	}
}
