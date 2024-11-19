using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Entities;
using Microsoft.VisualBasic;

namespace API.Persistence
{
    public class DummyData
    {
        public static List<Customer> SetCustomers()
        {
            var customers = new List<Customer>();
            customers.Add(new Customer
            {
                Id = Guid.Parse("428814c1-b5ea-4086-a1b1-f01daedc51ba"),
                FirstName = "Joe",
                MiddleName = null,
                Surname = "Bloggs",
                CreatedDateTime = DateTime.Now,
                EditedDateTime = null,
                IsDeleted = false,
                DeletedDateTime = null
            });
            customers.Add(new Customer
            {
                Id = Guid.Parse("e26a4df1-39de-4627-b1f2-ef0f976d7f6f"),
                FirstName = "Laura",
                MiddleName = "Sophie",
                Surname = "Harris",
                CreatedDateTime = DateTime.Now,
                EditedDateTime = null,
                IsDeleted = false,
                DeletedDateTime = null
            });
            customers.Add(new Customer
            {
                Id = Guid.Parse("386a62e5-5178-47ed-82a0-ed5e81854c8b"),
                FirstName = "Ronald",
                MiddleName = "Michael",
                Surname = "Tibbs",
                CreatedDateTime = DateTime.Now,
                EditedDateTime = null,
                IsDeleted = false,
                DeletedDateTime = null
            });
            customers.Add(new Customer
            {
                Id = Guid.Parse("23a849a3-68ec-48aa-a4a5-85e072b2b5de"),
                FirstName = "Trevor",
                MiddleName = null,
                Surname = "Francis",
                CreatedDateTime = DateTime.Now,
                EditedDateTime = null,
                IsDeleted = false,
                DeletedDateTime = null
            });

            return customers;
        }
    }
}