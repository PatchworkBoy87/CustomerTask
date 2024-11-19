using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Entities;
using API.Persistence;

namespace API.Endpoints
{
    public static class CustomerEndpoints
    {
        public static void MapCustomerEndpoints (this WebApplication app)
        {
            app.MapGet("setcustomers", SetCustomers)
                .WithName("SetCustomers")
                .WithOpenApi();
            app.MapGet("customers", GetCustomers)
                .WithName("GetCustomers")
                .WithOpenApi();
            app.MapGet("customers/{id}", GetCustomer)
                .WithName("GetCustomer")
                .WithOpenApi();
            app.MapPost("customers/add", AddCustomer)
                .WithName("AddCustomer")
                .WithOpenApi();
            app.MapPost("customers/edit/{id}", EditCustomer)
                .WithName("EditCustomer")
                .WithOpenApi();
            app.MapPost("customers/delete/{id}", DeleteCustomer)
                .WithName("DeleteCustomer")
                .WithOpenApi();
            app.MapDelete("customers/harddelete/{id}", HardDeleteCustomer)
                .WithName("HardDeleteCustomer")
                .WithOpenApi();
        }

        public static List<Customer> customers { get; set; } 

        public static List<Customer> SetCustomers()
        {
            customers = Persistence.DummyData.SetCustomers(); 
            return customers;
        }

        public static async Task<List<Customer>> GetCustomers()
        {  
            return customers.Where(x => x.IsDeleted == false).ToList();
        }

        public static async Task<List<Customer>> GetCustomer(Guid id)
        {
            var customer = customers.Where(x => x.Id == id).ToList();

            return customer;
        }

        public static async Task<string> AddCustomer(Customer customer)
        {
            // add to the customer list
            customers.Add(customer);
            
            return $@"Customer {customer.FirstName} {customer.Surname} was added";
        }

        public static async Task<string> EditCustomer(Customer customer)
        {
            // edit customer in the list
            try
            {
                int index = customers.FindIndex(x => x.Id == customer.Id);
                if (index > -1)
                {
                    customers[index] = customer;
                }

                return $@"Customer {customer.FirstName} {customer.Surname} was updated";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
        }

        public static async Task<string> DeleteCustomer(Guid id)
        {
            // NOTE: This changes the status of the customer to "Deleted" rather than removes it from database
            customers.Where(x => x.Id == id).FirstOrDefault().DeletedDateTime = DateTime.Now;
            customers.Where(x => x.Id == id).FirstOrDefault().IsDeleted = true;
            return "Customer was deleted";
        }

        public static async Task<string> HardDeleteCustomer(Guid id)
        {
            // NOTE: This removes the custoemr from the database
            customers.Remove(customers.Where(x => x.Id == id).FirstOrDefault());
            return "Customer was deleted";
        }
    }
}