using DataAccess;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
	public class MedicalRepository : IMedicalRepository
	{
		public List<MedicalRecord> getMedicalbyUser(string username) => MedicalDAO.getMedicalbyUser(username);
		public List<ServiceMore> serviceMores(int id) => MedicalDAO.serviceMores(id);
		public void CreateMedical(MedicalRecord record) => MedicalDAO.CreateMedical(record);
	}
}
