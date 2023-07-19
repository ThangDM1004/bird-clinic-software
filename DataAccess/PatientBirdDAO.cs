using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
	public class PatientBirdDAO
	{
		public static List<PatientBird> GetListBirdByUser(string username)
		{
			var list = new List<PatientBird>();
			try
			{
				using(var context = new BirdClinicContext())
				{
					list = context.PatientBirds.Where(p => p.Username == username)
											   .Include(g => g.GenderNavigation)
											   .Include(s => s.Species)
											   .ToList();
				}
			}catch (Exception ex)
			{

			}
			return list;
		}
		public static List<Gender> Gender()
		{
			var list = new List<Gender>();
			try
			{
				using (var context = new BirdClinicContext())
				{
					list = context.Genders.ToList();
				}
			}
			catch (Exception e)
			{

			}
			return list;
		}
		public static List<Species> getSpecies()
		{
			var list = new List<Species>();
			try
			{
				using(var context = new BirdClinicContext())
				{
					list = context.Species.ToList();
				}
			}catch (Exception e)
			{

			}
			return list;
		}
		public static void UpdateBird(PatientBird patientBird)
		{
			try
			{
				using(var context = new BirdClinicContext())
				{
					context.Entry<PatientBird>(patientBird).State = EntityState.Modified;
					context.SaveChanges();
				}
			}catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}
		public static void Create(PatientBird patientBird)
		{
			try
			{
				using(var context = new BirdClinicContext())
				{
					context.PatientBirds.Add(patientBird);
					context.SaveChanges();
				}
			}catch(Exception ex) { }
		}
		public static PatientBird getPatientByID(int id)
		{
			var p = new PatientBird();
			try
			{
				using(var context = new BirdClinicContext())
				{
					p = context.PatientBirds.SingleOrDefault(f => f.PatientId == id);
				}
			}catch(Exception e) { }
			return p;
		}
		public static PatientBird getPatientByName(string name)
		{
			var p = new PatientBird();
			try
			{
				using (var context = new BirdClinicContext())
				{
					p = context.PatientBirds.SingleOrDefault(f => f.BirdName == name);
				}
			}
			catch (Exception e) { }
			return p;
		}
	}
}
