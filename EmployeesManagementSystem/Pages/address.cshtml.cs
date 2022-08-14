using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EmployeesManagementSystem.Pages
{
    public class addressModel : PageModel
    {
        public string errorMessage = "";
        public string successMessage = "";
        public Address address = new Address();
        public void OnGet()
        {

        }
        public void OnPost()
        {
            address.city = Request.Form["city"];
            address.street = Request.Form["street"];
            if (address.city == "" || address.street == "")
            {
                errorMessage = "Please fill the fields";
                return;
            }
            int id = Int32.Parse(Request.Query["id"]);
            Employees e = new Employees();
            e.addAddress(id, address);

            successMessage = "added a new address to customer";
            Response.Redirect("Index");
        }
    }   
}