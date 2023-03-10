using System;

namespace ITBees.Models.Users
{
    public class CurrentUser
    {
        public Guid Guid { get; set; }
        public Guid LastUsedCompanyGuid { get; set; }
    }
}