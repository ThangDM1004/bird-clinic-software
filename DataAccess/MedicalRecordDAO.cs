using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace DataAccess
{
    public class MedicalRecordDAO
    {
        public static List<MedicalRecord> GetMedicalRecords()
        {
            List<MedicalRecord> records = new List<MedicalRecord>();
            try
			{
                using (var context = new BirdClinicContext())
				{
					records = context.MedicalRecords.ToList();
				}
			}
			catch (Exception)
			{

				throw;
			}
			return records;
        }

		public static void AddServiceMore(ServiceMore service)
		{
            try
            {
                using (var context = new BirdClinicContext())
                {
                    context.ServiceMores.Add(service);
                    context.SaveChanges();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static void UpdateMedicalRecord(MedicalRecord medical)
        {
            try
            {
                using (var context = new BirdClinicContext())
                {
                    context.MedicalRecords.Update(medical);
                    context.SaveChanges();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static List<ServiceMore> GetServiceMoresByRecordId(int recordId)
        {
            List < ServiceMore > serviceMores = new List<ServiceMore >();
            try
            {
                using (var context = new BirdClinicContext())
                {
                    serviceMores = context.ServiceMores.Where(s => s.RecordId == recordId).ToList();
                }
            }
            catch (Exception)
            {

                throw;
            }
            return serviceMores;
        }

        public static MedicalRecord GetMedicalRecordById(int recordId)
        {
            MedicalRecord medicalRecord = null;
            try
            {
                using (var context = new BirdClinicContext())
                {
                    medicalRecord = context.MedicalRecords.SingleOrDefault(m => m.RecordId == recordId);
                }
            }
            catch (Exception)
            {

                throw;
            }
            return medicalRecord;
        }

        public static void DeleteServiceMore(ServiceMore service)
        {
            try
            {
                using (var context = new BirdClinicContext())
                {
                    context.ServiceMores.Remove(service);
                    context.SaveChanges();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
