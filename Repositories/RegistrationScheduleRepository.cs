using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;

namespace Repositories
{
    public class RegistrationScheduleRepository : IRegistrationScheduleRepository
    {
        public void addScheduleByUsername(RegistrationSchedule registrationSchedule)
        {
            RegistrationScheduleDAO.addScheduleByUsername(registrationSchedule);
        }

        public bool checkExist(RegistrationSchedule registrationSchedule)
        {
            return RegistrationScheduleDAO.checkExist(registrationSchedule);
        }

        public bool checkRegister(string doctor, DateTime date)
        {
            return RegistrationScheduleDAO.checkRegister(doctor, date);
        }

        public void deleteScheduleByUsername(RegistrationSchedule registrationSchedule)
        {
            RegistrationScheduleDAO.deleteScheduleByUsername(registrationSchedule);
        }

        public List<RegistrationSchedule> getScheduleByUsername(string username)
        {
            return RegistrationScheduleDAO.getScheduleByUsername(username);
        }

        public void updateScheduleByUsername(RegistrationSchedule registrationSchedule)
        {
            RegistrationScheduleDAO.updateScheduleByUsername(registrationSchedule);
        }
    }
}
