namespace ITBees.Models.Hardware.Infrastructure;

public class IpAddress
{
    public int Id { get; set; }
    public string Ip { get; set; }
    public IpNetworkAddress IpNetworkAddress { get; set; }
    public int IpNetworkAddressId { get; set; }
    public IpVersionType IpVersion { get; set; }
}

public enum IpVersionType
{
    IPv4,
    IPv6
}