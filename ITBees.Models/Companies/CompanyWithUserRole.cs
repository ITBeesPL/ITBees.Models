using System;

namespace ITBees.Models.Companies;

public class CompanyWithUserRole : Company
{
    public CompanyWithUserRole()
    {
    }

    public CompanyWithUserRole(Company x, string identityRoleName, Guid? identityRoleGuid)
    {
        this.Guid = x.Guid;
        this.CompanyName = x.CompanyName;
        this.CompanyShortName = x.CompanyShortName;
        this.Created = x.Created;
        this.CreatedBy = x.CreatedBy;
        this.CreatedByGuid = x.CreatedByGuid;
        this.Owner = x.Owner;
        this.OwnerGuid = x.OwnerGuid;
        this.IsActive = x.IsActive;
        this.CompanyPlatformSubscription = x.CompanyPlatformSubscription;
        this.PostCode = x.PostCode;
        this.City = x.City;
        this.Street = x.Street;
        this.IdentityRoleName = identityRoleName;
        this.IdentityRoleGuid = identityRoleGuid;
    }

    public string? IdentityRoleName { get; set; }
    public Guid? IdentityRoleGuid { get; set; }
}