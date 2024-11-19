using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Endpoints;
using API.Entities;

namespace Frontend.Services
{
    public class CustomerServices
    {
        public static async Task<List<Customer>> SetCustomers()
        {
            var result = CustomerEndpoints.SetCustomers();
            return result;
        }
        public static async Task<List<Customer>> GetCustomers()
        {
            var result = await CustomerEndpoints.GetCustomers();
            return result;
        }

        public static async Task<Customer> GetCustomer(Guid id)
        {
            var result = await CustomerEndpoints.GetCustomer(id);
            var customer = result.FirstOrDefault();
            return customer;
        }
        
        public static async Task<string> AddCustomer(Customer customer)
        {
            var result = await CustomerEndpoints.AddCustomer(customer);
            return result;
        }
        
        public static async Task<string> EditCustomer(Customer customer)
        {
            var result = await CustomerEndpoints.EditCustomer(customer);
            return result;
        }

        public static async Task<string> DeleteCustomer(Guid id)
        {
            var result = await CustomerEndpoints.DeleteCustomer(id);
            return result;
        }
        
        public static async Task<string> HardDeleteCustomer(Guid id)
        {
            var result = await CustomerEndpoints.HardDeleteCustomer(id);
            return result;
        }
    }
}