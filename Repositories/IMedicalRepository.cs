using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
	public interface IMedicalRepository
	{
		List<MedicalRecord> getMedicalbyUser(string username);
		List<ServiceMore> serviceMores(int id);
		void CreateMedical(MedicalRecord record);
	}
}
