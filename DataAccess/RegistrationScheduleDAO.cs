using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class RegistrationScheduleDAO
    {
        public static List<RegistrationSchedule> getScheduleByUsername(string username)
        {
            List<RegistrationSchedule> registrationSchedules = new List<RegistrationSchedule>();
            using (var context = new BirdClinicContext())
            {
                registrationSchedules = context.RegistrationSchedules.Where(d => d.Username == username).ToList();
            }
            return registrationSchedules;
        }

        public static void addScheduleByUsername(RegistrationSchedule registrationSchedule)
        {
            try
            {
                using (var context = new BirdClinicContext())
                {
                    context.RegistrationSchedules.Add(registrationSchedule);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }

        public static bool checkExist(RegistrationSchedule registrationSchedule)
        {
            try
            {
                using (var context = new BirdClinicContext())
                {
                    return context.RegistrationSchedules.Any(r => r.Username == registrationSchedule.Username && r.Date == registrationSchedule.Date);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return false;
        }

        public static void updateScheduleByUsername(RegistrationSchedule registrationSchedule)
        {
            try
            {
                using (var context = new BirdClinicContext())
                {
                    context.Entry(registrationSchedule).State = EntityState.Modified;
                    context.SaveChanges();
                }

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }

        public static void deleteScheduleByUsername(RegistrationSchedule registrationSchedule)
        {
            try
            {
                using (var context = new BirdClinicContext())
                {
                    context.RegistrationSchedules.Remove(registrationSchedule);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }

        public static bool checkRegister(string doctor, DateTime date)
        {
            try
            {
                using (var context = new BirdClinicContext())
                {
                    return context.Bookings.Any(r => r.UsernameDoctor == doctor && r.BookingDate == date);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return false;
        }
    }
}
