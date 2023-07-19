using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
	public interface IPatientBirdRepository
	{
		List<PatientBird> GetListBirdByUser(string username);
		List<Gender> Gender();
		List<Species> getSpecies();
		void UpdateBird(PatientBird patientBird);
		void Create(PatientBird patientBird);
		PatientBird getPatientByID(int id);
		PatientBird getPatientByName(string name);
	}
}
