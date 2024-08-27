using System;
using System.ComponentModel.DataAnnotations;
using ITBees.Models.Companies;

namespace ITBees.Models.Hardware;

public class AccessCardGroup
{
    [Key]
    public Guid Guid { get; set; }
    public string GroupName { get; set; }
    public string GroupDescirption { get; set; }
    public Guid CreatedByGuid { get; set; }
    public DateTime Created { get; set; }
    public int ExpireDays { get; set; }
    public Company Company { get; set; }
    public Guid CompanyGuid { get; set; }
    public bool IsActive { get; set; }
}