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
        public void CreateService(Service service) => ServiceDAO.CreateService(service);
        public List<Service> getAllServiceCus() => ServiceDAO.getAllServiceCus();
        public List<Service> getAllServiceWhenBooking() => ServiceDAO.getAllServiceWhenBooking();
        public Service getServicebyName(string name) => ServiceDAO.getServicebyName(name);
        public Service getServicebyID(int id) => ServiceDAO.getServicebyID(id);
        public Service GetServiceById(int id)
        {
            return ServiceDAO.GetServiceById(id);
        }
    }



}
