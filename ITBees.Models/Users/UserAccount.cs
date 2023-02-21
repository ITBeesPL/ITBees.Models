using System.Runtime.Serialization;
using System;

namespace ITBees.Models.Users
{
    public class UserAccount
    {
        public Guid Guid { get; set; }

        public string Email { get; set; }

        public string AspNetUserId { get; set; }

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
    }
}