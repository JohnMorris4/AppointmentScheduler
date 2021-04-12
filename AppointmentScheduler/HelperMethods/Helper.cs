using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AppointmentScheduler.HelperMethods
{
    public static class Helper
    {
        public static string Admin = "Admin";
        public static string Manager = "Manager";
        public static string Mechanic = "Mechanic";
        public static string Customer = "Customer";


        public static List<SelectListItem> GetRolesForDropDown()
        {
            return new List<SelectListItem>
            {
                new SelectListItem {Value = Helper.Admin, Text = Helper.Admin},
                new SelectListItem {Value = Helper.Manager, Text = Helper.Manager},
                new SelectListItem {Value = Helper.Mechanic, Text = Helper.Mechanic},
                new SelectListItem {Value = Helper.Customer, Text = Helper.Customer}
            };  
        }
    }
}