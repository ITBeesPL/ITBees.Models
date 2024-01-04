using System;
using System.ComponentModel.DataAnnotations;

namespace ITBees.Models.Users
{
    public class UsersInvitationsToCompaniesWithModules
    {
        [Key]
        public Guid Guid { get; set; }
        public UsersInvitationsToCompanies UsersInvitationsToCompanies { get; set; }
        public Guid UsersInvitationsToCompaniesGuid { get; set; }
        public UserAccountModule UserAccountModule { get; set; }
        public Guid UserAccountModuleGuid { get; set; }
    }
}