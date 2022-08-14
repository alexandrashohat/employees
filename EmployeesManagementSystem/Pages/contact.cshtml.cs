using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EmployeesManagementSystem.Pages
{
    public class contactModel : PageModel
    {
        public string errorMessage = "";
        public string successMessage = "";
        public Contact contact = new Contact();
        public void OnGet()
        {

        }
        public void OnPost()
        {
            contact.fullName = Request.Form["fullName"];
            contact.officeNumber = Request.Form["officeNumber"];
            contact.email = Request.Form["email"];
            if (contact.fullName == "")
            {
                errorMessage = "Please fill the field";
                return;
            }
            int id = Int32.Parse(Request.Query["id"]);
            Employees e = new Employees();
            e.addContact(id,contact);
          
            successMessage = "added a new contact to customer";
            Response.Redirect("Index");
        }
    }
}