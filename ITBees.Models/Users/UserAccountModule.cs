using System;
using System.ComponentModel.DataAnnotations;
using ITBees.Models.Companies;
using ITBees.Models.MyAccount;

namespace ITBees.Models.Users
{
    public class UserAccountModule
    {
        [Key]
        public Guid Guid { get; set; }
        public string ModuleName { get; set; }
        public string ModuleType { get; set; }
        public string MethodName { get; set; }
        public TypeOfOperation AllowedTypeOfOperation { get; set; }
        public Guid? CompanyGuid { get; set; }
        public Company Company { get; set; }
        public Guid UserAccountGuid { get; set; }

        public UserAccount UserAccount { get; set; }
    }
}