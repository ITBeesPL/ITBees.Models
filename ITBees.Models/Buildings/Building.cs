using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using ITBees.Models.Common;
using ITBees.Models.Companies;
using ITBees.Models.Users;

namespace ITBees.Models.Buildings;

public class Building
{
    [Key] public Guid Guid { get; set; }
    public string Name { get; set; }
    public string? City { get; set; }
    public string? PostCode { get; set; }
    public string? Street { get; set; }
    public GpsLocation GpsLocation { get; set; }
    public List<BuildingDeviceHub> BuildingDeviceHubs { get; set; }
    public UserAccount CreatedBy { get; set; }
    public Guid CreatedByGuid { get; set; }
    public DateTime Created { get; set; }
    public bool IsActive { get; set; }
    public Guid? CompanyGuid { get; set; }
    public Company Company { get; set; }
}