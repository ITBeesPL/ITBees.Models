using System;
using System.ComponentModel.DataAnnotations;
using ITBees.Models.Companies;
using ITBees.Models.Users;

namespace ITBees.Models.Hardware;

public class AccessCard
{
    [Key]
    public Guid Guid { get; set; }
    public string CardId { get; set; }
    public AccessCardType AccessCardType { get; set; }
    public int AccessCardTypeId { get; set; }
    public DateTime ValidDate { get; set; }
    public string OwnerName { get; set; }
    public string OwnerEmail { get; set; }
    public DateTime? LastUsedDateTime { get; set; }
    public UserAccount CreatedBy { get; set; }
    public Guid CreatedByGuid { get; set; }
    public DateTime Created { get; set; }
    public UserAccount DeactivatedBy { get; set; }
    public Guid? DeactivatedByGuid { get; set; }
    public DateTime Deactivated { get; set; }
    public bool IsActive { get; set; }
    public bool InvitationSend { get; set; }
    public DateTime? InvitationSendDateTime { get; set; }
    public Company Company { get; set; }
    public Guid CompanyGuid { get; set; }
}