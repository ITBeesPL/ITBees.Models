using System;

namespace ITBees.Models.Hardware.Ac;

public class AcGroupIm
{
    public String GroupName { get; set; }
    public String GroupDescription { get; set; }
    public Guid CompanyGuid { get; set; }
    public bool IsActive { get; set; }
}