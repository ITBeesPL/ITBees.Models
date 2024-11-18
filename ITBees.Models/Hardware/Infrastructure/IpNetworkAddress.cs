using System;
using ITBees.Models.Companies;
using ITBees.Models.Users;

namespace ITBees.Models.Hardware.Infrastructure;

public class IpNetworkAddress
{
    public int Id { get; set; }
    public string NetworkIp { get; set; }
    public string Netmask { get; set; }
    public string Gateway { get; set; }
    public string Dns { get; set; }
    public Company Company { get; set; }
    public Guid CompanyGuid { get; set; }
    public UserAccount CreatedBy { get; set; }
    public Guid CreatedByGuid { get; set; }
    public UserAccount UpdatedBy { get; set; }
    public Guid UpdatedByGuid { get; set; }
    public bool IsActive { get; set; }
}