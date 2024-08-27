using System;

namespace ITBees.Models.Hardware;

public class AccessCardCardGroup
{
    public AccessCard AccessCard { get; set; }
    public Guid AccessCardGuid { get; set; }
    public AccessCardGroup AccessCardGroup { get; set; }
    public Guid AccessCardGroupGuid { get; set; }
}