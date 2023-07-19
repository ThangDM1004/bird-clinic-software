using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using Models;

namespace Repositories
{
    public interface IRegistrationScheduleRepository
    {
        public List<RegistrationSchedule> getScheduleByUsername(string username);
        public void addScheduleByUsername(RegistrationSchedule registrationSchedule);
        public Boolean checkExist(RegistrationSchedule registrationSchedule);
        public void updateScheduleByUsername(RegistrationSchedule registrationSchedule);
        public void deleteScheduleByUsername(RegistrationSchedule registrationSchedule);
        public bool checkRegister(string doctor, DateTime date);
    }
}
