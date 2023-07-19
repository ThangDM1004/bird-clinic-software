using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;

namespace Repositories
{
    public class MedicalRecordRepository : IMedicalRecordReposotory
    {
        public void AddServiceMore(ServiceMore service)
        {
            MedicalRecordDAO.AddServiceMore(service);
        }

        public List<MedicalRecord> GetMedicalRecords()
        {
            return MedicalRecordDAO.GetMedicalRecords();
        }
    }
}
