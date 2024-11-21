﻿using System;
using System.ComponentModel.DataAnnotations;
using ITBees.Models.Users;

namespace ITBees.Models.Hardware;

public class Device
{
    [Key]
    public Guid Guid { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public bool IsAvailable { get; set; }
    public UserAccount CreatedBy { get; set; }
    public Guid CreatedByGuid { get; set; }
    public DateTime CreatedDate { get; set; }
    public DeviceType DeviceType { get; set; }
    public int DeviceTypeId { get; set; }
}