using System;
using ITBees.Models.Users;

namespace ITBees.Models.Zones;

public class Zone
{
    public Guid Guid { get; set; }
    public string ZoneName { get; set; }
    public UserAccount CreatedBy { get; set; }
    public DateTime Created { get; set; }
    public Guid CreatedByGuid { get; set; }
}