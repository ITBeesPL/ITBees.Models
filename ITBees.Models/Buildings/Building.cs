using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using ITBees.Models.Common;
using ITBees.Models.Users;

namespace ITBees.Models.Buildings;

public class Building
{
    [Key] public Guid Guid { get; set; }
    public string Name { get; set; }
    public GpsLocation GpsLocation { get; set; }
    public List<BuildingDeviceHub> BuildingDeviceHubs { get; set; }
    public UserAccount CreatedBy { get; set; }
    public Guid CreatedByGuid { get; set; }
    public DateTime Created { get; set; }
    public bool IsActive { get; set; }
}