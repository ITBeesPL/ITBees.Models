using System.Runtime.Serialization;
using System;
using System.Collections.Generic;
using ITBees.Models.Companies;
using ITBees.Models.Languages;

namespace ITBees.Models.Users
{
    public class UserAccount
    {
        public Guid Guid { get; set; }

        public string Email { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Phone { get; set; }

        [IgnoreDataMember]
        public string DisplayName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }

        public Guid? LastUsedCompanyGuid { get; set; }
        public Company LastUsedCompany { get; set; }

        public DateTime? LastLoginDateTime { get; set; }

        public int LoginsCount { get; set; }

        public DateTime SetupTime { get; set; }

        public Language Language { get; set; }

        public int LanguageId { get; set; }
        public List<UserAccountModule> UserAccountModules { get; set; }
        public List<UsersInCompany> UsersInCompanies{ get; set; }
    }
}