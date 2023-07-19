using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
	public interface IBookingRepository
	{
		List<Booking> getAllBooking();
		void UpdateBooking(Booking booking);
		List<StatusBooking> getStatusBooking();
		List<StatusBooking> GetStatusBooking(int id);
		int getStatusByBookingID(int id);
		Booking GetBookingbyID(int id);
		public List<Booking> getBookingByDoctor(string doctor);
        List<Booking> getBookingUser(string username);
        void CreateBooking(Booking booking);
    }
		
	
}
