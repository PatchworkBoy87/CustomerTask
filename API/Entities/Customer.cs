using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Entities
{
    public class Customer
    {
        public Guid Id { get; set; }
        public string? FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string? Surname { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public DateTime? EditedDateTime { get; set; }
        public bool IsDeleted { get; set; } = false;
        public DateTime? DeletedDateTime { get; set; }
    }
}