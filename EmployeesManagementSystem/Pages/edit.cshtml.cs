using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EmployeesManagementSystem.Pages
{
    public class editModel : PageModel
    {       
        public string errorMessage = "";
        public string successMessage = "";
        public SelectedCustomer selectedCustomer = new SelectedCustomer();
        public Employees e = new Employees();
        public void OnGet()
        {
            int id = Int32.Parse(Request.Query["id"]);
            selectedCustomer = e.showSelectedCustomerForEdit(id);         

        }
        public void OnPost()
        {
            selectedCustomer.name = Request.Form["customerName"];
            selectedCustomer.customerNumber = Int32.Parse(Request.Form["customerNumber"]);

            selectedCustomer.id = Int32.Parse(Request.Query["id"]);
            if (selectedCustomer.name == "" )
            {
                errorMessage = "Please fill the fields";
                return;
            }
            if ( selectedCustomer.customerNumber.ToString().Length != 9)
            {
                errorMessage = "customer number must be 9 chars long";
                return;
            }
            e.editCustomer(selectedCustomer);

            successMessage = "edited the customer";
            Response.Redirect("Index");
        }
    }
}