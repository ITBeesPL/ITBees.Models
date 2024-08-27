using System;
using System.ComponentModel.DataAnnotations;
using ITBees.Models.Hardware;

namespace ITBees.Models.Buildings;

public class BuildingDeviceHub
{
    [Key]
    public Guid Guid { get; set; }
    public Building Building { get; set; }
    public Guid BuildingGuid { get; set; }
    public DeviceHub DeviceHub { get; set; }
    public Guid DeviceHubGuid { get; set; }
}