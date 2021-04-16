using System.Collections.Generic;
using AppointmentScheduler.Models.ViewModels;

namespace AppointmentScheduler.Service
{
    public interface IAppointmentService
    {
        public List<ManagerViewModel> GetManagerList();
        public List<MechanicViewModel> GetMechanicList();
        public List<CustomerViewModel> GetCustomerList();
    }
}