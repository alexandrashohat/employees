using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EmployeesManagementSystem.Pages
{
    public class ShowProfileModel : PageModel
    {
        public SelectedCustomer selectedCustomer = new SelectedCustomer();
        public void OnGet()
        {
            int id = Int32.Parse(Request.Query["id"]);

            Employees e = new Employees();
            selectedCustomer = e.showSelectedCustomer(id);                     
        }
    }
    public class SelectedCustomer
    {
        public int id { get; set; }
        public string name { get; set; }
        public int customerNumber { get; set; }
        public int addressCount { get; set; }
        public int contactCount { get; set; }
        public List<Address> addresses = new List<Address>();
        public List<Contact> contacts = new List<Contact>();


    }
    public class Address
    {
        public string city { get; set; }
        public string street { get; set; }
    }
    public class Contact
    {
        public string fullName { get; set; }
        public string officeNumber { get; set; }
        public string email { get; set; }
    }
}