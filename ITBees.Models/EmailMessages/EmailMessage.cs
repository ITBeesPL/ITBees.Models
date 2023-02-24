using System;
using ITBees.Models.Companies;
using ITBees.Models.EmailAccounts;
using ITBees.Models.Users;

namespace ITBees.Models.EmailMessages
{
    public class EmailMessage
    {
        public Guid Guid { get; set; }
        public DateTime Created { get; set; }
        public string Recipients { get; set; }
        public string RecipientsNames { get; set; }
        public string RecipientsCc { get; set; }
        public string RecipientsCcNames { get; set; }
        public string RecipientsBcc { get; set; }
        public string RecipientsBccNames { get; set; }
        public DateTime? SendDate { get; set; }
        public string? SenderEmailAddress { get; set; }
        public string Subject { get; set; }
        public string? BodyHtml { get; set; }
        public string? BodyText { get; set; }
        public Guid EmailCampaignGuid { get; set; }
        public EmailAccount EmailAccount { get; set; }
        public Guid EmailAccountGuid { get; set; }
        public Company Company { get; set; }
        public Guid CompanyGuid { get; set; }
        public int OpenCount { get; set; }
        public DateTime? LastOpenDate { get; set; }
        public Guid MessageOnServerGuid { get; set; }
        public Guid? CreatedByGuid { get; set; }
        public UserAccount CreatedBy { get; set; }
        public string ReplyToEmail { get; set; }
    }
}