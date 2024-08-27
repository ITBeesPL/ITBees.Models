using System;
using System.ComponentModel.DataAnnotations;

namespace ITBees.Models.Hardware;

public class AccessCardCardGroup
{
    [Key]
    public Guid Guid { get; set; }
    public AccessCard AccessCard { get; set; }
    public Guid AccessCardGuid { get; set; }
    public AccessCardGroup AccessCardGroup { get; set; }
    public Guid AccessCardGroupGuid { get; set; }
}