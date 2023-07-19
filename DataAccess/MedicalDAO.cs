using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
	public class MedicalDAO
	{
		public static List<MedicalRecord> getMedicalbyUser(string username)
		{
			var list = new List<MedicalRecord>();
			try
			{
				using (var context = new BirdClinicContext())
				{
					var query = from MedicalRecord in context.MedicalRecords
								join Booking in context.Bookings on MedicalRecord.BookingId equals Booking.BookingId
								where Booking.UsernameCustomer == username
								select new MedicalRecord
								{
									RecordId = MedicalRecord.RecordId,
									BookingId = MedicalRecord.BookingId,
									PatientId = MedicalRecord.PatientId,
									TotalFee = MedicalRecord.TotalFee,
								};
					list = query.ToList();
				}
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
			return list;
		}
		public static List<ServiceMore> serviceMores(int id)
		{
			var ser = new List<ServiceMore>();
			try
			{
				using(var context = new BirdClinicContext())
				{
					ser = context.ServiceMores.Where(f=> f.RecordId == id).ToList();
				}
			}catch (Exception ex) { }
			return ser;
		}
		public static void CreateMedical(MedicalRecord record)
		{
			try
			{
				using(var context = new BirdClinicContext())
				{
					context.MedicalRecords.Add(record);
					context.SaveChanges();
				}
			}catch (Exception ex)
			{

			}
		}
	}
}
