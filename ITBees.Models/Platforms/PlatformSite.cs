using System;

namespace ITBees.Models.Platforms
{
    public class PlatformSite
    {
        public Guid Guid { get; set; }
        public string Url { get; set; }
        public string DefaultLanguage { get; set; }
        public string CompanyName { get; set; }
        public string CompanyEmail { get; set; }
        public string CompanyEmailDisplayName { get; set; }
        public string CompanyEmailPassword { get; set; }
        public string SmtpHost { get; set; }
        public string SmtpPort { get; set; }
        public bool SmtpUseSSL { get; set; }
        public bool IsActive { get; set; }
    }
}