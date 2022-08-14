using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeesManagementSystem.Pages
{

    public class Employees
    {
        public String connectionStr = "Data Source=.;Initial Catalog=EmployeesManagement;Integrated Security=True";
        public List<Customer> getList()
        {
             List<Customer> Customers = new List<Customer>();
            try
            {
               
                using (SqlConnection conn = new SqlConnection(connectionStr))
                {
                    conn.Open();
                    using (SqlCommand command = new SqlCommand("SELECT [Id],[Name] ,[CustomerNumber] FROM [EmployeesManagement].[dbo].[Customers] where IsDeleted = 0", conn))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Customers.Add(new Customer()
                                {

                                    id = Convert.ToInt32(reader["Id"].ToString()),
                                    name = reader["Name"].ToString(),
                                    customerNumber = Convert.ToInt32(reader["CustomerNumber"].ToString())

                                });
                            }
                        }
                    }

                }



            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
            return Customers;
        }
        public void editCustomer(SelectedCustomer selectedCustomer)
        {
            using (SqlConnection conn = new SqlConnection(connectionStr))
            {
                conn.Open();

                using (SqlCommand command = new SqlCommand("update [EmployeesManagement].[dbo].[Customers] set Name = @name, CustomerNumber = @customerNumber where Id = @id ", conn))
                {
                    command.Parameters.AddWithValue("@name", selectedCustomer.name);
                    command.Parameters.AddWithValue("@customerNumber", selectedCustomer.customerNumber);
                    command.Parameters.AddWithValue("@id", selectedCustomer.id);
                    command.ExecuteNonQuery();
                }

            }
        }
        public SelectedCustomer showSelectedCustomer(int id)
        {
            SelectedCustomer selectedCustomer = new SelectedCustomer();            
            try
            {                
                using (SqlConnection conn = new SqlConnection(connectionStr))
                {
                    conn.Open();

                    using (SqlCommand command = new SqlCommand("select cu.Id Id, Name, CustomerNumber, count(a.id) addressCount, count(c.id) contactCount from [EmployeesManagement].[dbo].[Customers] cu " +
                        " left join [EmployeesManagement].[dbo].[Addresses] a on a.CustomerId = cu.Id and  a.IsDeleted = 0 " +
                        " left join [EmployeesManagement].[dbo].[Contacts] c on c.CustomerId = cu.Id and c.IsDeleted = 0 where cu.Id = @id group by cu.id, Name, CustomerNumber", conn))
                    {
                        command.Parameters.AddWithValue("@id", id);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                selectedCustomer.id = Convert.ToInt32(reader["Id"].ToString());
                                selectedCustomer.name = reader["Name"].ToString();
                                selectedCustomer.customerNumber = Convert.ToInt32(reader["CustomerNumber"].ToString());
                                selectedCustomer.addressCount = Convert.ToInt32(reader["addressCount"].ToString());
                                selectedCustomer.contactCount = Convert.ToInt32(reader["contactCount"].ToString());
                            }
                        }
                    }
                    using (SqlCommand command = new SqlCommand("select City,Street from [EmployeesManagement].[dbo].[Addresses] where CustomerId = @id and IsDeleted = 0", conn))
                    {
                        command.Parameters.AddWithValue("@id", id);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                selectedCustomer.addresses.Add(new Address()
                                {
                                    city = reader["City"].ToString(),
                                    street = reader["Street"].ToString()
                                });
                            }
                        }
                    }
                    using (SqlCommand command = new SqlCommand("select  FullName,OfficeNumber,Email from [EmployeesManagement].[dbo].[Contacts] where CustomerId = @id and IsDeleted = 0", conn))
                    {
                        command.Parameters.AddWithValue("@id", id);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                selectedCustomer.contacts.Add(new Contact()
                                {
                                    fullName = reader["FullName"].ToString(),
                                    officeNumber = reader["OfficeNumber"].ToString(),
                                    email = reader["Email"].ToString(),
                                });
                            }
                        }
                    }

                }




            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
            return selectedCustomer;
        }
        public void addAddress(int id,Address address)
        {
            try
            {

                using (SqlConnection conn = new SqlConnection(connectionStr))
                {
                    conn.Open();

                    using (SqlCommand command = new SqlCommand("insert into [EmployeesManagement].[dbo].[Addresses] (City, Street,CustomerId, IsDeleted, Created) values (@city, @street,@id,0,@date)", conn))
                    {
                        command.Parameters.AddWithValue("@city", address.city);
                        command.Parameters.AddWithValue("@street", address.street);
                        command.Parameters.AddWithValue("@id", id);
                        command.Parameters.AddWithValue("@date", DateTime.Now);
                        command.ExecuteNonQuery();
                    }

                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }
        public void addContact (int id, Contact contact)
        {
            try
            {
               
                using (SqlConnection conn = new SqlConnection(connectionStr))
                {
                    conn.Open();

                    using (SqlCommand command = new SqlCommand("insert into [EmployeesManagement].[dbo].[Contacts] (FullName, OfficeNumber,Email,CustomerId, IsDeleted, Created) values (@fullName, @officeNumber,@email,@id,0,@date)", conn))
                    {
                        command.Parameters.AddWithValue("@fullName", contact.fullName);
                        command.Parameters.AddWithValue("@officeNumber", contact.officeNumber);
                        command.Parameters.AddWithValue("@email", contact.email);
                        command.Parameters.AddWithValue("@id", id);
                        command.Parameters.AddWithValue("@date", DateTime.Now);
                        command.ExecuteNonQuery();
                    }

                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }
        public int checkIfNameExists(string name)
        {
            int id = 0;
            try
            {

                using (SqlConnection conn = new SqlConnection(connectionStr))
                {
                    conn.Open();

                    using (SqlCommand command = new SqlCommand("select Id from [EmployeesManagement].[dbo].[Customers] where Name = @name", conn))
                    {
                        command.Parameters.AddWithValue("@name", name);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                id = Convert.ToInt32(reader["Id"].ToString());
                            }
                        }
                    }

                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
            return id;
        }
        public void addCustomer(SelectedCustomer selectedCustomer)
        {
           

            using (SqlConnection conn = new SqlConnection(connectionStr))
            {
                conn.Open();
                using (SqlCommand command = new SqlCommand("insert into [EmployeesManagement].[dbo].[Customers] (Name, CustomerNumber, IsDeleted, Created) values (@name,@customerNumber,0,@date) ", conn))
                {
                    command.Parameters.AddWithValue("@name", selectedCustomer.name);
                    command.Parameters.AddWithValue("@customerNumber", selectedCustomer.customerNumber);

                    command.Parameters.AddWithValue("@date", DateTime.Now);
                    command.ExecuteNonQuery();
                }

            }
        }
        public void deleteCustomer(int id)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionStr))
                {
                    conn.Open();

                    using (SqlCommand command = new SqlCommand("update [EmployeesManagement].[dbo].[Customers] set IsDeleted = 1 where Id = @id ", conn))
                    {
                        command.Parameters.AddWithValue("@id", id);
                        command.ExecuteNonQuery();
                    }



                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }
        public SelectedCustomer showSelectedCustomerForEdit(int id)
        {
            SelectedCustomer selectedCustomer = new SelectedCustomer();
            try
            {                
                using (SqlConnection conn = new SqlConnection(connectionStr))
                {
                    conn.Open();

                    using (SqlCommand command = new SqlCommand("select cu.Id Id, Name, CustomerNumber from [EmployeesManagement].[dbo].[Customers] cu  where Id = @id", conn))
                    {
                        command.Parameters.AddWithValue("@id", id);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                selectedCustomer.id = Convert.ToInt32(reader["Id"].ToString());
                                selectedCustomer.name = reader["Name"].ToString();
                                selectedCustomer.customerNumber = Convert.ToInt32(reader["CustomerNumber"].ToString());
                            }
                        }
                    }

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
            return selectedCustomer;
        }
    }
}
