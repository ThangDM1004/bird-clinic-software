using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface IMedicalRecordReposotory
    {
        public List<MedicalRecord> GetMedicalRecords();
        public void AddServiceMore(ServiceMore service);
    }
}
