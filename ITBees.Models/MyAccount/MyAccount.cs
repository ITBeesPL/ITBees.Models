using System;
using System.Collections.Generic;
using ITBees.Models.Companies;
using ITBees.Models.Languages;

namespace ITBees.Models.MyAccount
{
    public class MyAccount
    {
        public string Email { get; set; }
        public string Phone { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Guid Guid { get; set; }
        public List<CompanyWithUserRole> Companies { get; set; }
        public CompanyWithUserRole LastUsedCompany { get; set; }
        public Guid LastUsedCompanyGuid { get; set; }
        public Language Language { get; set; }
        public string DisplayName { get; set; }
    }
}