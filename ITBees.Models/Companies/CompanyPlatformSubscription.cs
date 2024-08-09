using System;
using Microsoft.EntityFrameworkCore;

namespace ITBees.Models.Companies;

[Owned]
public class CompanyPlatformSubscription
{
    public Guid? SubscriptionPlanGuid { get; set; }
    public string? SubscriptionPlanName { get; set; }
    public DateTime? SubscriptionActiveTo { get; set; }
    public bool TrialNotAvailable { get; set; } = false;
}