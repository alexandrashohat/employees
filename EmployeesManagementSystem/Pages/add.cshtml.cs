using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EmployeesManagementSystem.Pages
{
    public class addModel : PageModel
    {
         public string errorMessage = "";
        public string successMessage = "";
        public SelectedCustomer selectedCustomer = new SelectedCustomer();
        public void OnGet()
        {
           

        }
        public void OnPost()
        {
            selectedCustomer.name = Request.Form["customerName"];
            selectedCustomer.customerNumber = Int32.Parse(Request.Form["customerNumber"]);
            Employees e = new Employees();
            var id = e.checkIfNameExists(selectedCustomer.name);
           
            if (selectedCustomer.name == "")
            {
                errorMessage = "Please fill the fields";
                return;
            }
            if (id > 0)
            {
                errorMessage = "name already exists";
                return;
            }
            if (selectedCustomer.customerNumber.ToString().Length != 9)
            {
                errorMessage = "customer number must be 9 chars long";
                return;
            }
            e.addCustomer(selectedCustomer);                                

            successMessage = "added a new customer";
            Response.Redirect("Index");
        }
    }
}