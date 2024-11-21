using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using ITBees.Models.Buildings;
using ITBees.Models.Companies;
using ITBees.Models.Users;

namespace ITBees.Models.Hardware;

public abstract class DeviceHub
{
    [Key]
    public Guid Guid { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public UserAccount CreatedBy { get; set; }
    public Guid CreatedByGuid { get; set; }
    public DateTime Created { get; set; }
    public bool IsActive { get; set; }
    public Company Company { get; set; }
    public Guid? CompanyGuid { get; set; }
    public Building Building { get; set; }
    public Guid? BuildingGuid { get; set; }
    public DeviceType DeviceType { get; set; }
    public int DeviceTypeId { get; set; }
    public List<DeviceHubDevice> Devices { get; set; }
}