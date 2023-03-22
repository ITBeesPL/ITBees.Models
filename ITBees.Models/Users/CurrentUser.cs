using System;
using ITBees.Models.Languages;

namespace ITBees.Models.Users
{
    public class CurrentUser
    {
        public Guid Guid { get; set; }
        public Guid LastUsedCompanyGuid { get; set; }
        public Language Language { get; set; }
        public string DisplayName { get; set; }
    }
}