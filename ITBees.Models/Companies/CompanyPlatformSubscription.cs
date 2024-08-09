using System;

namespace ITBees.Models.Companies;

public class CompanyPlatformSubscription
{
    public Guid? SubscriptionPlanGuid { get; set; }
    public string? SubscriptionPlanName { get; set; }
    public DateTime? SubscriptionActiveTo { get; set; }
    public bool TrialExpired { get; set; }
}