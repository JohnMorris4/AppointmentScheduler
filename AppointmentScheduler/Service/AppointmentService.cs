

using System.Collections.Generic;
using System.Linq;
using AppointmentScheduler.Data;
using AppointmentScheduler.HelperMethods;
using AppointmentScheduler.Models.ViewModels;

namespace AppointmentScheduler.Service
{
    public class AppointmentService : IAppointmentService
    {
        private readonly ApplicationDbContext _db;

        public AppointmentService(ApplicationDbContext db)
        {
            _db = db;
        }
        public List<ManagerViewModel> GetManagerList()
        {
            var managers = (from user in _db.Users
                join userRoles in _db.UserRoles on user.Id equals userRoles.RoleId 
                join roles in _db.Roles.Where(x => x.Name == Helper.Manager) on  userRoles.RoleId equals roles.Id
                    select new ManagerViewModel
                    {
                        Id = user.Id,
                        Name = user.Name
                    }
                ).ToList();
            return managers;
        }

        public List<MechanicViewModel> GetMechanicList()
        {
            var mechanic = (from user in _db.Users
                    join userRoles in _db.UserRoles on user.Id equals userRoles.RoleId 
                    join roles in _db.Roles.Where(x => x.Name == Helper.Mechanic) on  userRoles.RoleId equals roles.Id
                    select new MechanicViewModel
                    {
                        Id = user.Id,
                        Name = user.Name
                    }
                ).ToList();
            return mechanic;
        }

        public List<CustomerViewModel> GetCustomerList()
        {
            var customer = (from user in _db.Users
                    join userRoles in _db.UserRoles on user.Id equals userRoles.RoleId 
                    join roles in _db.Roles.Where(x => x.Name == Helper.Customer) on  userRoles.RoleId equals roles.Id
                    select new CustomerViewModel
                    {
                        Id = user.Id,
                        Name = user.Name
                    }
                ).ToList();
            return customer;
        }
    }
}