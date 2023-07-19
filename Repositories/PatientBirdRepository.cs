using DataAccess;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
	public class PatientBirdRepository : IPatientBirdRepository
	{
		public List<PatientBird> GetListBirdByUser(string username) => PatientBirdDAO.GetListBirdByUser(username);
		public List<Gender> Gender() => PatientBirdDAO.Gender();
		public List<Species> getSpecies() => PatientBirdDAO.getSpecies();
		public void UpdateBird(PatientBird patientBird) => PatientBirdDAO.UpdateBird(patientBird);
		public void Create(PatientBird patientBird) => PatientBirdDAO.Create(patientBird);
		public PatientBird getPatientByID(int id) => PatientBirdDAO.getPatientByID(id);
		public PatientBird getPatientByName(string name) => PatientBirdDAO.getPatientByName(name);
	}
}
