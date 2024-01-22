using System;
using System.ComponentModel.DataAnnotations;
using ITBees.Models.Users;

namespace ITBees.Models.Customers
{
    public abstract class Customer
    {
        [Key]
        public Guid Guid { get; set; }

        public UserAccount CreatedBy { get; set; }
        public Guid? CreatedByGuid { get; set; }
        public DateTime Created { get; set; }
        public bool IsActive { get; set; }
        public string Email { get; set; }
    }
}