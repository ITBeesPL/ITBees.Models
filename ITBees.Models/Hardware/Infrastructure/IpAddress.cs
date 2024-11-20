using ITBees.Models.Users;
using System;

namespace ITBees.Models.Hardware.Infrastructure;

public class IpAddress
{
    public int Id { get; set; }
    public string Ip { get; set; }
    public IpNetworkAddress IpNetworkAddress { get; set; }
    public int IpNetworkAddressId { get; set; }
    public IpVersionType IpVersion { get; set; }
    public bool IsActive { get; set; }
    public UserAccount CreatedBy { get; set; }
    public Guid CreatedByGuid { get; set; }
    public UserAccount UpdatedBy { get; set; }
    public Guid? UpdatedByGuid { get; set; }
}

public enum IpVersionType
{
    IPv4,
    IPv6
}