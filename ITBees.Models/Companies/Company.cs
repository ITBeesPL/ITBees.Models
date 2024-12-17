using System;
using ITBees.Models.Users;

namespace ITBees.Models.Companies
{
    public class Company
    {
        public Guid Guid { get; set; }
        public string CompanyName { get; set; }
        public string CompanyShortName { get; set; }
        public DateTime Created { get; set; }
        public UserAccount CreatedBy { get; set; }
        public Guid? CreatedByGuid { get; set; }
        public UserAccount Owner { get; set; }
        public Guid? OwnerGuid { get; set; }
        public bool IsActive { get; set; }
        public string Street { get; set; }
        public string PostCode { get; set; }
        public string City { get; set; }
        public string Nip { get; set; }
        public string? Email { get; set; }
        public string? Phones { get; set; }
        public string? CompanyInvoiceHeader { get; set; }
        public CompanyPlatformSubscription CompanyPlatformSubscription { get; set; }
        
    }
}