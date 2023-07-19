using DataAccess;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
	public class BookingRepository : IBookingRepository
	{
		public List<Booking> getAllBooking() => BookingDAO.getAllBooking();
		public void UpdateBooking(Booking booking) => BookingDAO.UpdateBooking(booking);
		public List<StatusBooking> getStatusBooking() => BookingDAO.getStatusBooking();
		public List<StatusBooking> GetStatusBooking(int id) => BookingDAO.GetStatusBooking(id);
		public int getStatusByBookingID(int id) => BookingDAO.getStatusByBookingID(id);
		public Booking GetBookingbyID(int id) => BookingDAO.GetBookingbyID(id);

        public List<Booking> getBookingByDoctor(string doctor)
        {
            return BookingDAO.getBookingByDoctor(doctor);
        }
        public List<Booking> getBookingUser(string user) => BookingDAO.getBookingUser(user);
        public void CreateBooking(Booking booking) => BookingDAO.CreateBooking(booking);
    }
		
	
}
