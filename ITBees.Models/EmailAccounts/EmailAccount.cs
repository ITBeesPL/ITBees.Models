using System.ComponentModel.DataAnnotations;
using System;
using ITBees.Models.Companies;

namespace ITBees.Models.EmailAccounts
{
    public class EmailAccount
    {
        [Key]
        public Guid Guid { get; set; }

        public string Email { get; set; }

        public string EmailFromTitle { get; set; }

        public string Login { get; set; }

        public string Pass { get; set; }

        public bool UseSSL { get; set; }

        public string ImapServer { get; set; }

        public string SmtpServer { get; set; }

        public string ImapPort { get; set; }

        public string SmtpPort { get; set; }

        public bool UseAdditionalAuthWhenSendingEmail { get; set; }

        public DateTime CreatedDate { get; set; }
        public Company Company { get; set; }
        public Guid? CompanyGuid { get; set; }
    }
}