using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EmployeesManagementSystem.Pages
{
    public class IndexModel : PageModel
    {
        public List<Customer> Customers = new List<Customer>();
        public void OnGet()
        {
            Employees e = new Employees();
            Customers = e.getList();
        }
        
    }
    public class Customer
    {
        public int id { get; set; }
        public string name { get; set; }
        public int customerNumber { get; set; }

    }

}
