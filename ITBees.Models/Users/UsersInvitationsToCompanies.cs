using System;
using System.ComponentModel.DataAnnotations;
using ITBees.Models.Companies;
using Microsoft.AspNetCore.Identity;

namespace ITBees.Models.Users
{
    public class UsersInvitationsToCompanies
    {
        [Key]
        public Guid Guid { get; set; }
        public UserAccount UserAccount { get; set; }
        public Guid UserAccountGuid { get; set; }
        public Company Company { get; set; }
        public Guid CompanyGuid { get; set; }
        public string Acls { get; set; }
        public DateTime CreatedDate { get; set; }
        public UserAccount CreatedBy { get; set; }
        public Guid CreatedByGuid { get; set; }
        public bool Applied { get; set; }
        public FasIdentityRole IdentityRole { get; set; }
        public Guid? IdentityRoleId { get; set; }
    }
}