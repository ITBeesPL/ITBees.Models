using System;
using System.ComponentModel.DataAnnotations;

namespace ITBees.Models.Hardware;

public class DeviceHubDevice
{
    [Key]
    public Guid Guid { get; set; }
    public DeviceHub DeviceHub { get; set; }
    public Guid DeviceHubGuid { get; set; }
    public Device Device { get; set; }
    public Guid DeviceGuid { get; set; }
}