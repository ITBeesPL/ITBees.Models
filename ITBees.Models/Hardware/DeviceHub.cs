using System;
using System.ComponentModel.DataAnnotations;
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
}