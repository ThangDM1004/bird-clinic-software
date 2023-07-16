using DataAccess;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
	public class ServiceRepository : IServiceRepository
	{
		public List<Service> getAllService() => ServiceDAO.getAllService();
		public void UpdateService(Service service) => ServiceDAO.UpdateService(service);
		public void CreateService(Service service)=> ServiceDAO.CreateService(service);
	}
}
