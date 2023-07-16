using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
	public class BookingDAO
	{
		public static List<Booking> getAllBooking()
		{
			var bookingList = new List<Booking>();
			try
			{
				using (var context = new BirdClinicContext())
				{
					bookingList = context.Bookings.Include(s => s.Status)
												  .Include(v => v.Service)
												  .Include(p => p.Patiend).ToList();
				}
			}
			catch (Exception ex)
			{

			}
			return bookingList;
		}
		public static void UpdateBooking(Booking booking)
		{
			try
			{
				using(var context = new BirdClinicContext())
				{
					context.Entry<Booking>(booking).State = EntityState.Modified;
					context.SaveChanges();
				}
			}catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}
		public static List<StatusBooking> getStatusBooking()
		{
			var statusBooking = new List<StatusBooking>(); ;
			try
			{
				using( var context = new BirdClinicContext())
				{
					statusBooking = context.StatusBookings.Where(f=> f.StatusId == 2 || f.StatusId == 6 || f.StatusId == 1).ToList();
				}
			}catch (Exception e)
			{

			}
			return statusBooking;
		}
		public static List<StatusBooking> GetStatusBooking(int id)
		{
			var statusBooking = new List<StatusBooking>();
			try
			{
				using(var context = new BirdClinicContext())
				{
					statusBooking = context.StatusBookings.Where(f => f.StatusId == (id + 1) || f.StatusId == id).ToList();
				}
			}catch(Exception e)
			{

			}
			return statusBooking;
		}
		public static int getStatusByBookingID(int id)
		{
			int status = 0;
			try
			{
				using (var context = new BirdClinicContext())
				{
					status = context.Bookings.SingleOrDefault(f => f.StatusId == id).StatusId;
				}
			}
			catch (Exception e)
			{

			}
			return status;
		}
		public static Booking GetBookingbyID(int id)
		{
			Booking booking = new Booking();
			try
			{
				using (var context = new BirdClinicContext())
				{
					booking = context.Bookings.SingleOrDefault(f => f.BookingId == id);
				}
			}
			catch (Exception e)
			{

			}
			return booking;
		}
	}
}
