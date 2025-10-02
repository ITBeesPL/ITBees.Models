using System;

namespace ITBees.Models.Hardware.Ac;

public class AcGroupUm
{
    public Guid Guid { get; set; }
    public String GroupName { get; set; }
    public String GroupDescription { get; set; }
    public bool IsActive { get; set; }
}