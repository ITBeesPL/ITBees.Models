using System;
using ITBees.Models.Companies;

namespace ITBees.Models.Users
{
    public class UsersInCompany
    {
        public Guid Guid { get; set; }
        public UserAccount UserAccount { get; set; }
        public Guid UserAccountGuid { get; set; }
        public Company Company { get; set; }
        public Guid CompanyGuid { get; set; }
        public UserAccount AddedBy { get; set; }
        public Guid AddedByGuid { get; set; }
        public DateTime AddedDate { get; set; }
        public FasIdentityRole IdentityRole { get; set; }
        public  Guid? IdentityRoleId { get; set; }
        public bool InvitationAccepted { get; set; }
        public DateTime? InvitationAcceptedDateTime { get; set; }
    }
}