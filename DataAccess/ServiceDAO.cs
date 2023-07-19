using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

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
		public static List<Service> getAllServiceWhenBooking()
		{
			var list = new List<Service>();
			try
			{
				using (var context = new BirdClinicContext())
				{
					list = context.Services.Where(s => s.ServiceName == "Vip" || s.ServiceName == "Normal").ToList();
				}
			}
			catch (Exception ex)
			{

			}
			return list;
		}
		public static List<Service> getAllServiceCus()
		{
			var list = new List<Service>();
			try
			{
				using (var context = new BirdClinicContext())
				{
					list = context.Services.Where(f => f.Status == true).ToList();
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

		public static Service GetServiceById(int id)
		{
			Service service = null;
            try
            {
                using (var context = new BirdClinicContext())
                {
					service = context.Services.SingleOrDefault(s => s.ServiceId == id);
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
			return service;
        }
		public static Service getServicebyName(string name)
		{
			var ser = new Service();
			try
			{
				using (var context = new BirdClinicContext())
				{
					ser = context.Services.SingleOrDefault(s => s.ServiceName == name);
				}
			}
			catch (Exception ex)
			{

			}
			return ser;
		}
		public static Service getServicebyID(int id)
		{
			var ser = new Service();
			try
			{
				using (var context = new BirdClinicContext())
				{
					ser = context.Services.SingleOrDefault(s => s.ServiceId == id);
				}
			}
			catch (Exception ex)
			{

			}
			return ser;
		}
	}
}
